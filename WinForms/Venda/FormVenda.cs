using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public enum EnumVenda { Taxa, Orcamento, Servico}
    public partial class FormVenda : Form
    {
        Form1 form1 = new Form1();
        FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao, Form1.Unidade.uniassistencia);
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao);
        ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao, Form1.Unidade.uniassistencia);
        VendaNegocios vendaNegocios = new VendaNegocios(Form1.Empresa.empconexao);

        Thread thread;
        Caixa caixa;
        VendaInfo vendaInfo;
        VendaInfo vendaFinal;
        PessoaInfo responsavel;
        PessoaInfo infoPessoa;
        ProdutoInfo produtoInfo;
        ItemVendaColecao colecaoVendNova;
        ItemVendaInfo itemSelecionando;
        ItemVendaColecao colecaoItemVenda = new ItemVendaColecao();
        VendaDetalhesColecao colecaoDetalhes;
        VendaCanceladaInfo vendaCanceladaInfo;


        public ServicoOrcamentoInfo ServicoTaxa { get; set; }
        private bool VendaVip { get; set; }
        private bool VendaEncerrada { get; set; }
        private bool VendaAtiva { get; set; }
        private string OsTexto { get; set; }

        EnumVenda vendaEnum = new EnumVenda();

        decimal qtTotal = 0;
        decimal dcTotal = 0;

        public FormVenda()
        {
            Inicializar();
        }

        public FormVenda(VendaInfo venda, VendaDetalhesColecao colecao, string servicoTexto, EnumVenda enumVenda)
        {
            Inicializar();
            OsTexto = servicoTexto;
            vendaInfo = venda;
            colecaoDetalhes = colecao;
            PreencherCliente();
            vendaEnum = enumVenda;
            AtivarForm(false);
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        public FormVenda(VendaInfo venda)
        {
            Inicializar();
            vendaInfo = venda;
            //VendaThread();
            PreencherForm();
            BloquearVenda();
        }

        private void PreencherCliente()
        {
            infoPessoa = clienteNegocios.ConsultarPessoaId(vendaInfo.venidcliente);
            labelCliente.Text = "Cliente: " + infoPessoa.pssnome;
            labelValorVolume.Text = string.Format("{0:000}", vendaInfo.venquant);
            labelValorTotal.Text = vendaInfo.venvalor.ToString("C");

            PreencherFormProduto();
        }
        private void VendaThread()
        {
            pictureBoxLoad.Visible = true;
            thread = new Thread(PreencherFormThread);
            form1.ExecutarThread(thread);
            this.Activate();
        }

        private void PreencherFormThread()
        {
            responsavel = funcNegocios.ConsultarPessoaId(vendaInfo.venidfunc);
            infoPessoa = clienteNegocios.ConsultarPessoaId(vendaInfo.venidcliente);

            if (colecaoDetalhes == null)
                colecaoDetalhes = vendaNegocios.ConsultarVendaDetalhesIdVenda(vendaInfo.venid);

            if (vendaInfo.venidstatus == 3)
                vendaCanceladaInfo = vendaNegocios.ConsultarVendaCanceladaIdVenda(vendaInfo.venid);

            Form1.encerrarThread = true;
            pictureBoxLoad.Visible = false;
        }

        private void PreencherForm()
        {
            colecaoItemVenda = new ItemVendaColecao();

            VendaThread();
            if (vendaInfo.venidstatus == 2)
            {
                this.Text = "Venda Concluída!";
                pictureBoxConcluido.Visible = true;
            }
            else if (vendaInfo.venidstatus == 3)
            {

                string texto = "Cancelado por: ";
                texto += responsavel == null ? "" : responsavel.pssnome + Environment.NewLine + Environment.NewLine;
                texto += "Motivo do cancelamento: " + vendaCanceladaInfo.vendacanceladadescricao;
                textBoxObs.Text = texto;
                this.Text = "Venda Cancelada!";
                pictureBoxCancel.Visible = true;
                textBoxObs.Visible = true;
            }

            labelOperacao.Text += " " + string.Format("{0:00000000}", vendaInfo.venid);
            labelVendedor.Text += " " + Form1.User.usenome;
            
            labelCliente.Text = "Cliente: " + infoPessoa.pssnome;
            labelValorVolume.Text = string.Format("{0:000}", vendaInfo.venquant);
            labelValorTotal.Text = vendaInfo.venvalor.ToString("C");

            PreencherFormProduto();
        }

        private void InserirVenda()
        {
            caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                vendaFinal = new VendaInfo();
                CaixaTurnoInfo caixaTurnoInfo = caixa.ConsultarTurnoAberto();

                if (vendaInfo == null)
                {
                    VendaInfo vendaNova = new VendaInfo
                    {
                        vendata = DateTime.Now.Date,
                        venidcliente = infoPessoa.pssid,
                        venidfunc = Form1.User.useidfuncionario,
                        venidunidade = Form1.Unidade.uniid,
                        venquant = qtTotal,
                        venvalor = dcTotal,
                        venvip = VendaVip ? 1 : 0,
                        venmodo = 1,
                        venidturno = caixaTurnoInfo.caixaturnoid,
                        venidstatus = 1,
                        venidtipoentrada = 4
                    };

                    vendaFinal = vendaNova;
                }
                else
                {
                    vendaInfo.venidturno = caixaTurnoInfo.caixaturnoid;
                    vendaInfo.venquant = qtTotal;
                    vendaInfo.venvalor = dcTotal;
                    vendaFinal = vendaInfo;
                }

                colecaoDetalhes = new VendaDetalhesColecao();
                foreach (ItemVendaInfo item in colecaoItemVenda)
                {
                    VendaDetalhesInfo vendaDetalhesInfo = new VendaDetalhesInfo
                    {
                        vendetalhesid = 0,
                        vendetalhesidprod = item.Id,
                        vendetalhesidvenda = 0,
                        vendetalhesquant = item.Quant,
                        vendetalhesvalordesc = item.ValorDesc,
                        vendetalhesvalorunit = item.ValorUnit,
                        vendetalhesidfunc = item.funid
                    };

                    colecaoDetalhes.Add(vendaDetalhesInfo);
                }

            }
            else
            {
                FormMessage.ShowMessegeWarning("Verificar se há algum caixa aberto!");
            }
        }

        private void AbrirFormPagamento()
        {
            FormPagamento formPagamento = new FormPagamento(vendaFinal, colecaoDetalhes);
            formPagamento.ShowDialog(this);
            if (formPagamento.DialogResult == DialogResult.Yes)
            {
                vendaFinal = formPagamento.VendaConcluida;
                ConcluirVenda(vendaFinal);
                labelOperacao.Text = "Controle: " + string.Format("{0:000000}", vendaFinal.venid);
                FormCupom formCupom = new FormCupom(vendaFinal.venid, EnumCupom.Rodape, OsTexto);
                formCupom.ShowDialog(this);
                formCupom.Dispose();

                this.DialogResult = DialogResult.Yes;

                if (vendaInfo == null)
                {
                    LimparVenda();
                    FormMessage.ShowMessegeWarning("CAIXA LIVRE!");
                    
                }
            }
        }

        private void ExecutarContagem()
        {
            decimal dc = 0;
            decimal dcQuant = 0;

            foreach (ItemVendaInfo vend in colecaoItemVenda)
            {
                dc += vend.Total;
                dcQuant += vend.Quant;
            }

            dcTotal = dc;
            qtTotal = dcQuant;
            labelValorTotal.Text = dc.ToString("C");
            labelValorVolume.Text = dcQuant.ToString("000");

            if (dc > 0)
                buttonConcluir.Enabled = true;
            else
                buttonConcluir.Enabled = false;
        }

        private void FormVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (!VendaEncerrada)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ConsultarProduto();
                }

                CriarFuncoes(e);
            }
            else
            {
                if (e.KeyCode == Keys.F11)
                    this.Close();
            }
        }

        private void PreencherFormProduto()
        {
            ItemVendaInfo itemVendaInfo;

            if (vendaInfo != null)
            {
                foreach (VendaDetalhesInfo detalhes in colecaoDetalhes)
                {
                    produtoInfo = produtoNegocios.ConsultarProdutosId(detalhes.vendetalhesidprod);
                    responsavel = funcNegocios.ConsultarPessoaId(detalhes.vendetalhesidfunc);

                    itemVendaInfo = new ItemVendaInfo
                    {
                        Id = produtoInfo.proId,
                        ValorDesc = detalhes.vendetalhesvalordesc,
                        Barras = produtoInfo.proCodBarras,
                        Descricao = produtoInfo.proDescricao,
                        Quant = detalhes.vendetalhesquant,
                        Total = detalhes.vendetalhesquant * detalhes.vendetalhesvalordesc,
                        ValorUnit = detalhes.vendetalhesvalorunit,
                        funid = responsavel.pssid,
                        funnome = responsavel.pssnome
                    };

                    colecaoItemVenda.Add(itemVendaInfo);
                }
            }
            else
            {
                bool estoqueZerado = false;
                decimal dbQuant = Convert.ToDecimal(textBoxQuant.Text);
                decimal dbTotal = produtoInfo.proValorVarejo * dbQuant;

                itemVendaInfo = new ItemVendaInfo
                {
                    Id = produtoInfo.proId,
                    ValorDesc = produtoInfo.proValorVarejo,
                    Barras = produtoInfo.proCodBarras,
                    Descricao = string.Format("{0:00000}", produtoInfo.proId) + " - " +  produtoInfo.proDescricao,
                    Quant = dbQuant,
                    Total = dbTotal,
                    ValorUnit = produtoInfo.proValorVarejo,
                    funid = responsavel.pssid,
                    funnome = responsavel.pssnome
                };
                
                if (colecaoItemVenda.Count > 0)
                {
                    for (int i = 0; i < colecaoItemVenda.Count; i++)
                    {
                        if (colecaoItemVenda[i].Id == produtoInfo.proId)
                        {
                            itemVendaInfo.ValorDesc = colecaoItemVenda[i].ValorDesc;
                            itemVendaInfo.Quant += colecaoItemVenda[i].Quant;
                            itemVendaInfo.Total = colecaoItemVenda[i].ValorDesc * itemVendaInfo.Quant;
                            itemVendaInfo.funid = colecaoItemVenda[i].funid;
                            itemVendaInfo.funnome = colecaoItemVenda[i].funnome;
                            colecaoItemVenda.RemoveAt(i);
                            break;
                        }
                    }
                }

                colecaoItemVenda.Add(itemVendaInfo);

                if (produtoInfo.proControleEstoque == true)
                {
                    int cod = produtoInfo.proId;
                    produtoInfo = new ProdutoInfo();
                    produtoInfo = produtoNegocios.ConsultarEstoqueIdProdutoUnid(cod, Form1.Unidade.uniid);
                    
                    if (produtoInfo.prodestoquequant < 1)
                    {
                        estoqueZerado = true;
                        FormMessage.ShowMessegeWarning("Verificar o estoque, consta que não tem mais desse produto!");
                    }
                }

                if (produtoInfo.proControleEstoque == true && !estoqueZerado)
                    if (itemVendaInfo.Quant > produtoInfo.prodestoquequant)
                        FormMessage.ShowMessegeWarning("A quantidade de produto lançada é maior que a " +
                            "quantidade que há no estoque!");

                labelDescricao.Text = produtoInfo.proDescricao.Length > 99 ? produtoInfo.proDescricao.Substring(0, 95) + "..." : produtoInfo.proDescricao;
                labelValorTotalProd.Text = dbTotal.ToString("C");

                labelValorProdCod.Text = string.Format("{0:000000}", produtoInfo.proId);
                labelValorProdBarras.Text = produtoInfo.proCodBarras;
                labelValorProdQuant.Text = dbQuant.ToString("000");
                labelValorProdPreco.Text = produtoInfo.proValorVarejo.ToString("C");
                labelValorEstoque.Text = string.Format("{0:000}", produtoInfo.prodestoquequant);

                textBoxQuant.Text = "1,000";
                textBoxBarras.Clear();
                textBoxBarras.Select();
                buttonRemover.Enabled = true;
            }

            //AdicionarItemGrid();
            AdicionarItem();
        }

        private void MudarResponsavel()
        {
            ItemVendaInfo item = (ItemVendaInfo)dataGridViewItens.SelectedRows[0].DataBoundItem;
            
            for (int i = 0; i < colecaoItemVenda.Count; i++)
            {
                if (colecaoItemVenda[i].Id == item.Id)
                {
                    item.funid = responsavel.pssid;
                    item.funnome = responsavel.pssnome;
                    colecaoItemVenda.RemoveAt(i);
                    break;
                }
            }

            colecaoItemVenda.Add(item);
            AdicionarItem();
        }

        private void AdicionarItem()
        {
            colecaoVendNova = new ItemVendaColecao();

            for (int i = 0; i < colecaoItemVenda.Count; i++)
                colecaoVendNova.Add(colecaoItemVenda[i]);

            colecaoItemVenda = colecaoVendNova;
            AdicionarItemGrid();
        }

        private void AdicionarItemGrid()
        {
            dataGridViewItens.DataSource = null;
            dataGridViewItens.DataSource = colecaoItemVenda;
            dataGridViewItens.ClearSelection();
            dataGridViewItens.Select();

            ExecutarContagem();
        }

        private void TipoVenda()
        {
            FormVendaVip formVendaVip = new FormVendaVip();
            formVendaVip.ShowDialog(this);

            if (formVendaVip.DialogResult == DialogResult.Yes)
            {
                VendaVip = true;
                BuscarCliente();
            }
            else if (formVendaVip.DialogResult == DialogResult.OK)
            {
                ClienteNegocios clienteNegocios = new ClienteNegocios(Form1.Empresa.empconexao, Form1.Unidade.uniassistencia);
                infoPessoa = clienteNegocios.ConsultarPessoaPadrao(EnumPessoaTipo.Cliente); //seleciona cliente avulso

                labelCliente.Text = "Cliente: " + infoPessoa.pssnome;
                AtivarForm(true);
                VendaVip = false;
            }

            formVendaVip.Dispose();
            
        }

        private void ConsultarProduto()
        {
            string barras = textBoxBarras.Text;

            if (!string.IsNullOrEmpty(barras))
            {
                string codBarras = textBoxBarras.Text.Substring(0, 1);

                switch (codBarras)
                {
                    case "*":
                        decimal db = Convert.ToDecimal(barras.Substring(1, barras.Length - 1));
                        textBoxQuant.Text = string.Format("{0:0.000}", db);
                        textBoxBarras.Clear();
                        return;

                    case "-":
                        barras = barras.Replace("-", "");
                        break;
                    case "+":
                        barras = barras.Replace("+", "");
                        break;

                    default:
                        break;
                }

                produtoInfo = produtoNegocios.ConsultarProdutoCodBarras(barras);

                if (produtoInfo != null)
                {
                    PreencherFormProduto();
                }
                else
                    FormMessage.ShowMessegeWarning("Produto não encontrado!");
            }
            else
                FormMessage.ShowMessegeWarning("Insira um código de barras!");
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            buttonCliente.Select();
            dataGridViewItens.ClearSelection();
        }

        private void buttonDesconto_Click(object sender, EventArgs e)
        {
            AddDesconto();
        }

        private void AddDesconto()
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                ProdutoInfo produto = produtoNegocios.ConsultarProdutosId(itemSelecionando.Id);
                produto.proValorVarejo = itemSelecionando.ValorUnit;
                FormProdDesconto formProdDesconto = new FormProdDesconto(produto.proValorVarejo, produto.proDescricao);
                formProdDesconto.ShowDialog(this);

                if (formProdDesconto.DialogResult == DialogResult.Yes)
                {

                    for (int i = 0; i < colecaoItemVenda.Count; i++)
                    {
                        if (itemSelecionando.Id == colecaoItemVenda[i].Id)
                        {
                            itemSelecionando.ValorDesc = Convert.ToDecimal(formProdDesconto.valorFinal[1]);
                            itemSelecionando.Total = itemSelecionando.ValorDesc * itemSelecionando.Quant;
                            colecaoItemVenda.RemoveAt(i);
                        }
                    }

                    ItemVendaColecao vendColecao = new ItemVendaColecao
                    {
                        itemSelecionando
                    };

                    for (int i = 0; i < colecaoItemVenda.Count; i++)
                        vendColecao.Add(colecaoItemVenda[i]);

                    colecaoItemVenda = vendColecao;
                    AdicionarItemGrid();
                }

                formProdDesconto.Dispose();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o produto que deseja aplicar o desconto!");
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            TipoVenda();
        }

        private void AtivarForm(bool ativar)
        {
            buttonCliente.Enabled = ativar;
            buttonResponsavel.Enabled = true;
            buttonDesconto.Enabled = true;
            buttonProd.Enabled = ativar;

            textBoxQuant.Enabled = ativar;
            textBoxBarras.Enabled = ativar;
            textBoxBarras.Select();

            VendaAtiva = ativar;
            responsavel = funcNegocios.ConsultarPessoaId(Form1.User.useidfuncionario);
            labelVendedor.Text = "Vendedor: " + responsavel.pssnome;

            if (ativar)
                buttonProd.Select();
        }

        private void CriarFuncoes(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                default:
                    if (VendaAtiva)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.F6:
                                textBoxQuant.Select();
                                break;
                            case Keys.F7:
                                textBoxBarras.Select();
                                break;
                            case Keys.F12:

                                if (!(dataGridViewItens.Rows.Count > 0))
                                {
                                    FormMessage.ShowMessegeWarning("Nenhum item foi lançado!");
                                    return;
                                }

                                ConcluirVenda();
                                break;
                            default:
                                break;
                        }
                    }
                    break;
            }
        }

        private void ConcluirVenda(VendaInfo final)
        {
            foreach (ItemVendaInfo item in colecaoItemVenda)
            {
                //dar baixa no estoque
                ProdutoInfo produtoInfo = produtoNegocios.ConsultarProdutosId(item.Id);

                if (vendaEnum == EnumVenda.Taxa) //inserir taxa na tabela
                {
                    ServicoTaxa = new ServicoOrcamentoInfo();
                    ServicoTaxa.servicoorcamentoidprod = item.Id;
                    ServicoTaxa.servicoorcamentoquant = item.Quant;
                    ServicoTaxa.servicoorcamentovalordesc = item.ValorDesc;
                    ServicoTaxa.servicoorcamentovalorunit = item.ValorUnit;
                    ServicoTaxa.servicoorcamentotaxaativo = true;
                }

                if (produtoInfo.proControleEstoque == true)
                {
                    produtoInfo = new ProdutoInfo();
                    produtoInfo = produtoNegocios.ConsultarEstoqueIdProdutoUnid(item.Id, Form1.Unidade.uniid);
                    produtoInfo.prodestoquequant -=item.Quant;

                    if (produtoNegocios.UpdateEstoqueId(produtoInfo) == 0)
                    {
                        FormMessage.ShowMessegeWarning("Falha ao salvar os itens!");
                        return;
                    }

                    MovEstoqueInfo movEstoqueInfo = new MovEstoqueInfo
                    {
                        movestoqueidproduto = item.Id,
                        movestoqueidtipomovimento = final.venidtipoentrada,
                        movestoquequant = item.Quant,
                        movestoquevalor = item.ValorDesc
                    };

                    if (!produtoNegocios.InsertMovEstoque(movEstoqueInfo))
                    {
                        FormMessage.ShowMessegeWarning("Falha ao salvar os itens!");
                        return;
                    }
                }

            }

            BloquearVenda();
        }

        private void BloquearVenda()
        {
            AtivarForm(false);
            buttonConcluir.Enabled = false;
            buttonCliente.Enabled = false;
            buttonRemover.Enabled = false;
            dataGridViewItens.Enabled = false;
            VendaEncerrada = true;
            buttonImprimir.Visible = true;
        }

        private void LimparVenda()
        {
            thread = null;
            vendaInfo = null;
            responsavel = null;
            vendaFinal = null;
            produtoInfo = null;
            infoPessoa = null;
            colecaoVendNova = null;
            itemSelecionando = null;
            colecaoItemVenda = null;
            colecaoDetalhes = null;
            vendaCanceladaInfo = null;

            dataGridViewItens.DataSource = null;

            ServicoTaxa = null;
            VendaVip = false;
            VendaEncerrada = false;
            VendaAtiva = false;
            OsTexto = string.Empty;

            qtTotal = 0;
            dcTotal = 0;
            buttonCliente.Enabled = true;
            buttonResponsavel.Enabled = false;
            buttonDesconto.Enabled = false;
            buttonCliente.Select();
            buttonImprimir.Enabled = false;

            labelCliente.Text = "Cliente: ";
            labelDescricao.Text = string.Empty;
            labelVendedor.Text = "Vendedor: ";
            labelOperacao.Text = "Operação: ";
            labelValorVolume.Text = string.Empty;
            labelValorTotal.Text = string.Empty;
            labelValorTotalProd.Text = string.Empty;
            labelValorProdCod.Text = string.Empty;
            labelValorProdBarras.Text = string.Empty;
            labelValorProdQuant.Text = string.Empty;
            labelValorProdPreco.Text = string.Empty;
            labelValorEstoque.Text = string.Empty;
            textBoxQuant.Text = "1.000";
        }

        private void BuscarCliente()
        {
            if (VendaVip)
            {
                FormPessoaConsultar formClienteConsultar = new FormPessoaConsultar(EnumPessoaTipo.Cliente);
                formClienteConsultar.ShowDialog(this);
                infoPessoa =  new PessoaInfo();

                if (formClienteConsultar.DialogResult == DialogResult.Yes)
                {
                    infoPessoa = formClienteConsultar.SelecionadoCliente;
                    labelCliente.Text = "Cliente: " + infoPessoa.pssnome;
                    AtivarForm(true);
                }

                formClienteConsultar.Dispose();
            }
        }

        private void buttonConcluir_Click(object sender, EventArgs e)
        {
            ConcluirVenda();
        }

        private void ConcluirVenda()
        {
            InserirVenda();
            AbrirFormPagamento();
        }
        
        private void buttonProd_Click(object sender, EventArgs e)
        {

            FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar();
            formProdutosConsultar.ShowDialog(this);
            formProdutosConsultar.Dispose();

            if (formProdutosConsultar.DialogResult == DialogResult.Yes)
            {
                produtoInfo = formProdutosConsultar.SelecionadoProduto;
                PreencherFormProduto();
            }

        }

        private void labelOperacao_Click(object sender, EventArgs e)
        {

        }

        private void buttonVendedor_Click(object sender, EventArgs e)
        {
            BuscarVendedor();
        }

        private void BuscarVendedor()
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                Form_ConsultarColecao form_ConsultarColecao = new Form_ConsultarColecao();
                PessoaColecao funcColecao = new PessoaColecao();
                funcColecao = funcNegocios.ConsultarPessoaPorTipo(EnumPessoaTipo.Funcionario);

                foreach (PessoaInfo func in funcColecao)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:000}", func.pssid),
                        Descricao = func.pssnome
                    };

                    form_ConsultarColecao.Add(form_Consultar);
                }

                FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(form_ConsultarColecao, "Funcionário");
                formConsultar_Cod_Descricao.ShowDialog(this);

                if (formConsultar_Cod_Descricao.DialogResult == DialogResult.Yes)
                    responsavel = funcNegocios.ConsultarPessoaId(Convert.ToInt32(formConsultar_Cod_Descricao.Selecionado.Cod));

                MudarResponsavel();

                formConsultar_Cod_Descricao.Dispose();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o item que deseja alterar o responsável!");
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            //if (VendaEncerrada)
            //    this.Close();
            //else
            //{
            //    if (FormMessage.ShowMessegeQuestion("Deseja cancelar está venda?") == DialogResult.Yes)
            //        this.Close();
            //}
            this.Close();
        }

        private void dataGridViewItens_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
                itemSelecionando = (ItemVendaInfo)dataGridViewItens.SelectedRows[0].DataBoundItem;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewItens.SelectedRows.Count > 0)
            {
                for (int i = 0; i < colecaoItemVenda.Count; i++)
                {
                    if (itemSelecionando.Id == colecaoItemVenda[i].Id)
                    {
                        colecaoItemVenda.RemoveAt(i);
                        AdicionarItemGrid();
                    }
                }

                textBoxBarras.Select();
            }
            else
                FormMessage.ShowMessegeWarning("Selecione o produto que deseja excluir!");
        }

        private void textBoxQuant_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.Format3casasdecimais((TextBox)sender);
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            FormCupom formCupom = new FormCupom(vendaInfo.venid, EnumCupom.Rodape, OsTexto);
            formCupom.ShowDialog(this);
            formCupom.Dispose();
        }

        private void FormVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja fechar esta venda?") == DialogResult.No)
                e.Cancel = true;
        }

        private void DataGridViewItens_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewItens.Rows[e.RowIndex].Cells[0].Value = string.Format("{0:00}", e.RowIndex + 1);
        }
    }
}
