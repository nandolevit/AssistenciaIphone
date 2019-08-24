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
using ObjTransfer.Pessoas;
using Negocios;

namespace WinForms
{
    public partial class FormUserEsqueciSenha : Form
    {
        UserNegocio negocioUser;
        EmailNegocio negocioEmail;
        PessoaInfo pessoa;
        UserInfo user;

        public FormUserEsqueciSenha()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonEmail;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCpf.Text;

            if (!string.IsNullOrEmpty(cpf))
            {
                negocioUser = new UserNegocio(Form1.Empresa.empconexao);
                negocioEmail = new EmailNegocio(Form1.EmpresaEmail, Form1.Empresa.empfantasia);
                pessoa = negocioUser.ConsultarPessoaCpf(cpf);

                if (pessoa != null)
                {
                    labelNome.Text = "Nome: " + pessoa.Nome;
                    labelEmail.Text = "E-mail: " + pessoa.Email;

                    user = negocioUser.ConsultarUsuarioFuncId(pessoa.Id);

                    buttonBuscar.Enabled = false;
                    buttonEmail.Enabled = true;
                }
                else
                {
                    buttonBuscar.Enabled = true;
                    buttonEmail.Enabled = false;
                    FormMessage.ShowMessegeWarning("Ninguém foi encontrado!");
                }
            }

        }

        private void ButtonEmail_Click(object sender, EventArgs e)
        {
            if (pessoa.Email == "sem@email.com")
            {
                FormMessage.ShowMessegeWarning("O email não é válido,  não será possível enviar o email!");
                return;
            }

            string mensagem = string.Empty;
            mensagem += "Segue abaixo o seu login e senha," + Environment.NewLine;
            mensagem += Environment.NewLine;
            mensagem += "Login: " + user.uselogin + Environment.NewLine;
            mensagem += "Senha: " + user.usesenha + Environment.NewLine;
            mensagem += Environment.NewLine;
            mensagem += Environment.NewLine;
            mensagem += "Att," + Environment.NewLine;
            mensagem += "LevitSoft Soluções.";

            if (negocioEmail.EnviarEmailBasico(pessoa.Email, "Esqueci minha senha!", mensagem))
                this.DialogResult = DialogResult.Yes;
            else
                this.DialogResult = DialogResult.Abort;
        }

        private void MaskedTextBoxCpf_TextChanged(object sender, EventArgs e)
        {
            labelNome.Text = string.Empty;
            labelEmail.Text = string.Empty;

            buttonBuscar.Enabled = true;
            buttonEmail.Enabled = false;
        }
    }
}
