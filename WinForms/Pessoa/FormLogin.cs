using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;
using System.IO;

namespace WinForms
{
    public partial class FormLogin : Form
    {
        EmpresaNegocios empresaNegocios = new EmpresaNegocios(Form1.Empresa.empconexao);
        UserNegocio userNegocio = new UserNegocio(Form1.Empresa.empconexao);
        SerializarNegocios serializarNegocios = new SerializarNegocios(Form1.Caminho);
        AccessLogin accessLogin = new AccessLogin(Form1.Empresa.empconexao);

        private string FileNameLogin { get { return "log.lvt"; } }
        string[] login = new string[3];
        string senha = string.Empty;

        public FormLogin()
        {
            InitializeComponent();

            if (serializarNegocios.ArquivoExiste(FileNameLogin))
            {
                UserInfo user = (serializarNegocios.DesserializarObjeto(FileNameLogin) as UserInfo);

                if (user != null)
                {
                    textBoxLogin.Text = user.uselogin;
                    maskedTextBoxSenha.Text = user.usesenha;
                    checkBoxSalvarLogin.Checked = true;
                }

            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logar()
        {
            Iniciar:
            if (!(string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(maskedTextBoxSenha.Text)))
            {
                if (!string.IsNullOrEmpty(labelUnidadeDescricao.Text))
                {
                    login[0] = textBoxLogin.Text;
                    login[1] = maskedTextBoxSenha.Text;
                    Login();
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Selecione uma unidade!");
                    ConsultarUnidade();
                    goto Iniciar;
                }
            }
            else
                FormMessage.ShowMessegeWarning("Digite o seu LOGIN E SENHA!");
        }

        private void Login()
        {
            int log = accessLogin.LoginAutentic(login);

            switch (log)
            {
                case 0:
                    FormMessage.ShowMessegeWarning("Senha ou login incorreto!");
                    break;
                case 1:
                    if (checkBoxSalvarLogin.Checked)
                        serializarNegocios.SerializarObjeto(Form1.User, FileNameLogin);
                    else
                        serializarNegocios.ExcluirArquivo(FileNameLogin);

                    this.DialogResult = DialogResult.Yes;
                    break;
                case 2:
                    FormMessage.ShowMessegeWarning("Senha ou login incorreto!");
                    break;
                case 3:
                    FormMessage.ShowMessegeWarning("Você está bloqueado!");
                    break;
                default:
                    break;
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Form1.EmpresaEmail == null)
                buttonEsqueci.Enabled = false;

            textBoxLogin.Select();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            Logar();

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            checkBoxSalvarLogin.Checked = false;
        }

        private void maskedTextBoxSenha_TextChanged(object sender, EventArgs e)
        {
            checkBoxSalvarLogin.Checked = false;
        }

        private void ButtonUnid_Click(object sender, EventArgs e)
        {
            ConsultarUnidade();
        }

        private void ConsultarUnidade()
        {
            UnidadeColecao colecao = Form1.colecaoUnidade;
            Form_ConsultarColecao formColecao = new Form_ConsultarColecao();
            foreach (UnidadeInfo unid in colecao)
            {
                Form_Consultar form_Consultar = new Form_Consultar
                {
                    Cod = string.Format("{0:000}", unid.uniid),
                    Descricao = unid.uniunidade
                };

                formColecao.Add(form_Consultar);
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(formColecao, "SELECIONAR UNIDADE");
            if (formConsultar_Cod_Descricao.ShowDialog(this) == DialogResult.Yes)
            {
                Form_Consultar form_Consultar = formConsultar_Cod_Descricao.Selecionado;

                foreach (UnidadeInfo unid in colecao)
                    if (unid.uniid == Convert.ToInt32(form_Consultar.Cod))
                    {
                        login[2] = form_Consultar.Cod;
                        labelUnidadeDescricao.Text = unid.uniunidade;
                        textBoxLogin.Select();
                        break;
                    }
            }
            formConsultar_Cod_Descricao.Dispose();
        }

        private void ButtonEsqueci_Click(object sender, EventArgs e)
        {
            FormUserEsqueciSenha formUserEsqueciSenha = new FormUserEsqueciSenha();
            if (formUserEsqueciSenha.ShowDialog(this) == DialogResult.Yes)
                FormMessage.ShowMessegeInfo("Seu Login e senha foi enviado para o seu email com sucesso!");
            else if (formUserEsqueciSenha.DialogResult == DialogResult.Abort)
                FormMessage.ShowMessegeInfo("Falha, não foi possível recuperar a sua senha!");
        }
    }
}
