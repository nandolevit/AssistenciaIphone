using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormProdutosConsultar : Form
    {
        ProdutoNegocios produtoNegocios = new ProdutoNegocios(Form1.Empresa.empconexao, Form1.Unidade.uniassistencia);
        ProdutoColecao produtosColecao;

        public int CodProd { get; set; }
        public ProdutoInfo SelecionadoProduto { get; set; }

        public FormProdutosConsultar()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonPesquisar;
            textBoxPesquisar.Select();

        }

        private void PreencherGrid()
        {

            int pesquisa = 0;
            produtosColecao = new ProdutoColecao();

            if (radioButtonProd.Checked)
                pesquisa = 0;

            if (radioButtonId.Checked)
                pesquisa = 1;

            if (radioButtonBarras.Checked)
                pesquisa = 2;

            switch (pesquisa)
            {
                case 0:
                    produtosColecao = produtoNegocios.ConsultarProdutosDescricao(textBoxPesquisar.Text);
                    break;
                case 1:
                    if (int.TryParse(textBoxPesquisar.Text, out int id))
                        produtosColecao.Add(produtoNegocios.ConsultarProdutosId(id));
                    else
                        FormMessage.ShowMessegeWarning("Digite um código válido!");
                    break;
                case 2:
                    produtosColecao.Add(produtoNegocios.ConsultarProdutoCodBarras(textBoxPesquisar.Text));
                    break;
                default:
                    break;
            }
            
            dataGridViewProd.DataSource = null;

            if (produtosColecao != null)
            {
                dataGridViewProd.DataSource = produtosColecao;
                dataGridViewProd.Select();
            }
            else
            {
                dataGridViewProd.Rows.Clear();
                dataGridViewProd.Rows.Add(null, null, "Nenhum produto foi encontrado!");
                textBoxPesquisar.Select();
            }

            //dataGridViewProd.ClearSelection();
            textBoxPesquisar.Clear();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void radioButtonProd_CheckedChanged(object sender, EventArgs e)
        {
            TipoPesquisaChange();
        }

        private void radioButtonId_CheckedChanged(object sender, EventArgs e)
        {
            TipoPesquisaChange();
        }

        private void radioButtonBarras_CheckedChanged(object sender, EventArgs e)
        {
            TipoPesquisaChange();
        }

        private void TipoPesquisaChange()
        {
            textBoxPesquisar.Clear();
            textBoxPesquisar.Select();
            dataGridViewProd.DataSource = null;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProdutosConsultar_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void DataGridViewProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemSelecionado();
        }

        private void ItemSelecionado()
        {
            if (dataGridViewProd.SelectedRows.Count > 0)
                SelecionadoProduto = dataGridViewProd.SelectedRows[0].DataBoundItem as ProdutoInfo;

            if (this.Modal)
                this.DialogResult = DialogResult.Yes;
            else
            {
                FormProdutos produto = new FormProdutos(SelecionadoProduto.proId);
                produto.ShowDialog(this);
                produto.Dispose();
            }
        }

        private void FormProdutosConsultar_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ActiveControl.Equals(dataGridViewProd))
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        ItemSelecionado();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
