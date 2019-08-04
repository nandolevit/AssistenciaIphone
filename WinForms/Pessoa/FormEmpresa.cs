using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormEmpresa : Form
    {
        Thread thread;
        Form1 form1 = new Form1();
        EmpresaNegocios empresaNegocios = new EmpresaNegocios();
        public EmpresaInfo infoEmpresa;
        ComputerColecao colecaoComp;
        ComputerInfo infoComp;
        UnidadeInfo infoUnid;
        UnidadeColecao colecaoUnid;
        PessoaNegocio negocioPessoa;
        SerializarNegocios serializarNegocios = new SerializarNegocios(Form1.Caminho);
        bool Ativo;


        string diretorio = @"C:\Users\Public\LevitSoft\";

        public FormEmpresa(EmpresaInfo empresa)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            infoEmpresa = empresa;
            Ativo = true;
            textBoxId.ReadOnly = true;
            textBoxId.TabStop = false;
            buttonBuscar.Visible = false;
            buttonInserir.Visible = false;
            buttonSair.Text = "&Fechar";
            this.Text = "Sobre a Empresa";
            PreencherForm();
        }

        public FormEmpresa()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            textBoxId.Select();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            PreencherForm();
        }

        private void PreencherForm()
        {
            
            if (Ativo)
            {
                textBoxId.Text = infoEmpresa.empcod;
                buttonUnid.Enabled = false;
                buttonUnid.ForeColor = Color.Gray;
            }
            else
                infoEmpresa = empresaNegocios.ConsultarEmpresaSysId(textBoxId.Text);

            if (infoEmpresa != null)
            {
                textBoxCnpj.Text = infoEmpresa.empcnpj;
                textBoxCep.Text = infoEmpresa.empcep;
                textBoxEmail.Text = infoEmpresa.empemail;
                textBoxComplemento.Text = infoEmpresa.empcomplemento;
                textBoxRef.Text = infoEmpresa.empreferencia;
                textBoxEnd.Text = infoEmpresa.empcomplemento;
                textBoxFantasia.Text = infoEmpresa.empfantasia;
                textBoxEnd.Text = infoEmpresa.emplogradouro + "/" + infoEmpresa.empbairro +" ("+ infoEmpresa.empcidade + "-" + infoEmpresa.empuf + ")";
                textBoxRazao.Text = infoEmpresa.emprazaosocial;
                textBoxTel.Text = infoEmpresa.emptelefone;

                empresaNegocios = new EmpresaNegocios(infoEmpresa.empconexao);
                colecaoUnid = empresaNegocios.ConsultarAssistencia();

                Form1.Computer = new ComputerInfo();
                Form1.ConfiguracaoRede();
                textBoxComputer.Text = Form1.Computer.comphostname;
                textBoxIp.Text = Form1.Computer.compip;
                textBoxAdapter.Text = Form1.Computer.compadaptador;
                maskedTextBoxMac.Text = Form1.Computer.compmac;

                if (colecaoUnid != null)
                {
                    infoUnid = colecaoUnid[0];

                    colecaoComp = empresaNegocios.ConsultarComputadorIdUnid(infoUnid.uniid);

                    if (colecaoComp != null)
                        foreach (ComputerInfo comp in colecaoComp)
                        {
                            if (comp.compserver)
                            {
                                Form1.Server = comp;
                                groupBoxServer.Enabled = false;
                                radioButtonNao.Checked = true;
                            }

                            if (Form1.Computer.compmac == comp.compmac)
                                infoComp = comp;
                        }

                    textBoxUnidNome.Text = colecaoUnid[0].uniunidade;
                    textBoxServer.Text = (Form1.Server == null) ? "" : Form1.Server.comphostname;
                }

                dataGridViewUnid.DataSource = colecaoUnid;

                buttonInserir.Enabled = true;
            }
            else
                FormMessage.ShowMessegeInfo("Registro não encontrado!");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (this.Modal)
                Application.Exit();
            else
                Close();
        }

        private void PreencherComputador()
        {
            infoComp = new ComputerInfo
            {
                comphostname = textBoxComputer.Text,
                compadaptador = textBoxAdapter.Text,
                compidunid = infoUnid.uniid,
                compmac = maskedTextBoxMac.Text,
                compserver = radioButtonSim.Checked,
            };
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

        }

        private void Inserir()
        {
            if (FormMessage.ShowMessegeQuestion("Deseja inserir a nova empresa?") == DialogResult.Yes)
            {
                pictureBoxLoad.Visible = true;
                panelUnidade.Enabled = false;

                if (serializarNegocios.SerializarObjeto(infoEmpresa, Form1.FileNameEmp))
                {
                    Form1.Empresa = (serializarNegocios.DesserializarObjeto(Form1.FileNameEmp) as EmpresaInfo);
                    empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);
                    UnidadeInfo uni = empresaNegocios.ConsultarUnidadeSede();

                    if (uni == null)
                    {
                        infoUnid = new UnidadeInfo
                        {
                            unibairro = infoEmpresa.empbairro,
                            unicep = infoEmpresa.empcep,
                            unicidade = infoEmpresa.empcidade,
                            unicnpj = infoEmpresa.empcnpj,
                            unicomplemento = infoEmpresa.empcomplemento,
                            uniemail = infoEmpresa.empemail,
                            unifantasia = infoEmpresa.empfantasia,
                            uniidEmpresa = infoEmpresa.empcod,
                            unilogradouro = infoEmpresa.emplogradouro,
                            unirazaoSocial = infoEmpresa.emprazaosocial,
                            unireferencia = infoEmpresa.empreferencia,
                            unisite = infoEmpresa.empsite,
                            unitelefone = infoEmpresa.emptelefone,
                            uniuf = infoEmpresa.empuf,
                            uniunidade = "ASSISTÊNCIA",
                            unifundada = infoEmpresa.empfundada,
                            uniassistencia = EnumAssistencia.Assistencia,
                            unisede = true
                        };

                        int cod = empresaNegocios.InsertUnidade(infoUnid);
                        if (cod > 0)
                        {
                            Form1.Unidade = infoUnid;
                            infoUnid.uniativa = 1;
                            infoUnid.uniunidade = "LOJA IPHONE";
                            infoUnid.unisede = false;
                            infoUnid.uniassistencia = EnumAssistencia.Loja;
                            empresaNegocios.InsertUnidade(infoUnid);
                            infoUnid.uniassistencia = EnumAssistencia.Assistencia;

                            negocioPessoa = new PessoaNegocio(infoEmpresa.empconexao, Form1.Unidade.uniassistencia);
                            PessoaInfo pessoa = new PessoaInfo
                            {
                                pssassistencia = EnumAssistencia.Assistencia,
                                psscpf = infoUnid.unicnpj,
                                pssdataregistro = DateTime.Now,
                                pssemail = infoUnid.uniemail,
                                pssendbairro = infoUnid.unibairro,
                                pssendcep = infoUnid.unicep,
                                pssendcidade = infoUnid.unicidade,
                                pssendcomplemento = infoUnid.unicomplemento,
                                pssendlogradouro = infoUnid.unilogradouro,
                                pssenduf = infoUnid.uniuf,
                                pssidtipo = EnumPessoaTipo.Funcionario,
                                pssniver = DateTime.Now,
                                pssnome = "FUNCIONARIO PADRAO",
                                psstelefone = infoUnid.unitelefone,
                                pssiduser = 0,
                                psspadrao = true
                            };
                            int id = negocioPessoa.InsertPessoa(pessoa);
                            UserNegocio negocio = new UserNegocio(Form1.Empresa.empconexao);
                            negocio.UpdateUserAdmin(id);

                            pessoa.pssidtipo = EnumPessoaTipo.Fornecedor;
                            pessoa.pssnome = "FORNECEDOR PADRAO";
                            negocioPessoa.InsertPessoa(pessoa);

                            pessoa.pssidtipo = EnumPessoaTipo.Cliente;
                            pessoa.pssnome = "CLIENTE AVULSO";
                            negocioPessoa.InsertPessoa(pessoa);

                            textBoxUnidNome.Text = infoUnid.uniunidade;
                            infoUnid.uniid = cod;
                        }
                    }

                    if (!VerificaComputador())
                    {
                        PreencherComputador();
                        infoComp.compid = empresaNegocios.InsertComputador(infoComp);
                    }

                    thread = new Thread(ExecutarConsulta);
                    form1.ExecutarThread(thread);
                    pictureBoxLoad.Visible = false;
                }
                else
                    FormMessage.ShowMessegeWarning("Falha, tente novamente!");
            }
        }

        private bool VerificaComputador()
        {
            ComputerColecao colecao = empresaNegocios.ConsultarComputadorIdUnid(infoUnid.uniid);

            if (colecao != null)
            {
                PreencherComputador();
                List<string> mac = new List<string>();

                foreach (ComputerInfo comp in colecao)
                {
                    mac.Add(comp.compmac);

                    if (mac.Contains(infoComp.compmac))
                    {
                        infoComp = comp;
                        return true;
                    }
                }

                return false;
            }
            else
                return false;
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Delete o registro desta empresa?") == DialogResult.Yes)
            {
                EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);

                FormMessage.ShowMessegeInfo("O sistema será encerrado...");
                Application.Exit();
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar.Enabled = true;
        }

        private void buttonDeleteDB_Click(object sender, EventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja apagar a pasta \"LevitSoft\"?") == DialogResult.Yes)
            {
                if (Directory.Exists(diretorio))
                {
                    Directory.Delete(diretorio, true);
                    FormMessage.ShowMessegeWarning("Pasta deletada com sucesso! Agora o sistema será encerrado...");
                    Application.Exit();
                }
            }
        }

        private void ButtonUnid_Click(object sender, EventArgs e)
        {
            if (infoUnid != null)
            {
                if (colecaoComp.Count < infoUnid.unicomputador)
                    Inserir();
                else
                {
                    if (VerificaComputador())
                    {
                        Inserir();
                    }
                    else
                        FormMessage.ShowMessegeWarning("Esta unidade possui a lincença para " + infoUnid.unicomputador + "e todas já estão ativas!");
                }
            }
            else
                Inserir();
        }


        private void ExecutarConsulta()
        {
            serializarNegocios.SerializarObjeto(infoComp, Form1.FileNameComp);

            //o código abaixo eu utilizo para baixar um novo arquivo phone.lvt
            //negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
            //IphoneModeloColecao colecao = negocioServ.ConsultarIphoneColecao();
            //serializarNegocios.SerializarObjeto(colecao, "Novo" + Form1.FileIphone);
            //FormMessage.ShowMessegeWarning("Download concluído!");

            string path = Directory.GetCurrentDirectory();
            string path1 = path;

            if (!serializarNegocios.ArquivoExiste(Form1.FileIphoneCores))
            {
                path += @"\" + Form1.FileIphoneCores;
                File.Copy(path, Path.Combine(Path.GetDirectoryName(Form1.Caminho), Form1.FileIphoneCores));
            }

            if (!serializarNegocios.ArquivoExiste(Form1.FileIphone))
            {
                path1 += @"\" + Form1.FileIphone;
                File.Copy(path1, Path.Combine(Path.GetDirectoryName(Form1.Caminho), Form1.FileIphone));
            }

            Form1.encerrarThread = true;
            this.DialogResult = DialogResult.Yes;
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                serializarNegocios.ExcluirArquivo(Form1.FileNameEmp);
                serializarNegocios.ExcluirArquivo(Form1.FileNameComp);

            }
            else
                buttonUnid.Enabled = false;

        }

        private void FormEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)
                if (thread.ThreadState == ThreadState.Running)
                    thread.Abort();
        }

    }
}
