using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjTransfer.Aparelho;
using System.Linq;
using Negocios;
using ObjTransfer;

namespace WinForms.Aparelho
{
    public partial class FormAparelhoMenu : Form
    {
        AparelhoLinhaColecao colecaoLinha;
        AparelhoNegocio negocioAparelho;
        PessoaInfo infoPessoa;

        public FormAparelhoMenu(PessoaInfo pessoa)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
            infoPessoa = pessoa;
        }

        private void ButtonIphone_Click(object sender, EventArgs e)
        {
            panelSeta.Top = buttonIphone.Top;
            AbrirFormIphone();

            //AbrirForm(linha);
        }

        private void ButtonSmart_Click(object sender, EventArgs e)
        {
            panelSeta.Top = buttonSmart.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 4).FirstOrDefault();
            AbrirForm(linha);
        }

        private void ButtonWin_Click(object sender, EventArgs e)
        {
            panelSeta.Top = buttonWin.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 2).FirstOrDefault();
            AbrirForm(linha);
        }

        private void ButtonMac_Click(object sender, EventArgs e)
        {
            panelSeta.Top = buttonMac.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 1).FirstOrDefault();
            AbrirForm(linha);
        }

        private void FormAparelhoMenu_Load(object sender, EventArgs e)
        {
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            colecaoLinha = negocioAparelho.ConsultarAparelhoLinha();
            AbrirFormIphone();
        }

        private void AbrirForm(AparelhoLinha linha)
        {
            if (Application.OpenForms["FormIphoneModelo"] != null)
                Application.OpenForms["FormIphoneModelo"].Close();

            if (Application.OpenForms["FormAparelhoCadastrar"] != null)
                Application.OpenForms["FormAparelhoCadastrar"].Close();


            this.Width = 950;
            this.CenterToScreen();

            FormAparelhoCadastrar formAparelhoCadastrar = new FormAparelhoCadastrar(linha, infoPessoa);
            formAparelhoCadastrar.WindowState = FormWindowState.Maximized;
            formAparelhoCadastrar.FormBorderStyle = FormBorderStyle.None;
            formAparelhoCadastrar.MdiParent = this;
            this.panelPrincipal.Controls.Add(formAparelhoCadastrar);
            formAparelhoCadastrar.Show();
        }

        private void AbrirFormIphone()
        {
            if (Application.OpenForms["FormAparelhoCadastrar"] != null)
                Application.OpenForms["FormAparelhoCadastrar"].Close();

            this.Width = 1280;
            this.CenterToScreen();

            FormIphoneModelo formIphoneModelo = new FormIphoneModelo();
            formIphoneModelo.WindowState = FormWindowState.Maximized;
            formIphoneModelo.MdiParent = this;
            this.panelPrincipal.Controls.Add(formIphoneModelo);
            formIphoneModelo.Show();
        }

        private void FormAparelhoMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormMessage.ShowMessegeQuestion("Deseja encerrar este forrmulário?") == DialogResult.No)
                e.Cancel = true;
        }
    }
}
