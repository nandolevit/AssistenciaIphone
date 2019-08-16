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
        AparelhoMarcaColecao colecaoMarcaPc;
        AparelhoMarcaColecao colecaoMarcaCelular;
        SistemaOperacionalColecao colecaoSistema;
        SistemaOperacionalVersaoColecao colecaoVersao;
        SistemaOperacionalModeloColecao colecaoModelo;

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
            var colecao = colecaoSistema.Where(p => p.Soidlinha == 4);
            AbrirForm(linha, colecaoMarcaCelular, SistemaColecao(colecao as SistemaOperacionalColecao));
        }

        private void ButtonWin_Click(object sender, EventArgs e)
        {
            panelSeta.Top = buttonWin.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 2).FirstOrDefault();
            colecaoSistema.Where(p => p.Soidlinha == 2).ToList();
            AbrirForm(linha, colecaoMarcaPc, SistemaColecao(colecaoSistema));
        }

        private void ButtonMac_Click(object sender, EventArgs e)
        {
            panelSeta.Top = buttonMac.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 1).FirstOrDefault();
            colecaoSistema.Where(p => p.Soidlinha == 1);
            AbrirForm(linha, colecaoMarcaPc, colecaoSistema);
        }

        private void FormAparelhoMenu_Load(object sender, EventArgs e)
        {
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            colecaoLinha = negocioAparelho.ConsultarAparelhoLinha();
            colecaoSistema = negocioAparelho.ConsultarSistemaPorLinha();
            colecaoVersao = negocioAparelho.ConsultarSistemaVersao();
            colecaoMarcaPc = negocioAparelho.ConsultarAparelhoMarca(2);
            colecaoMarcaCelular = negocioAparelho.ConsultarAparelhoMarca(4);
            colecaoModelo = negocioAparelho.ConsultarSistemaModelo();
            AbrirFormIphone();
        }

        private void AbrirForm(AparelhoLinha linha, AparelhoMarcaColecao marca, SistemaOperacionalColecao sistema)
        {
            if (Application.OpenForms["FormIphoneModelo"] != null)
                Application.OpenForms["FormIphoneModelo"].Close();

            if (Application.OpenForms["FormAparelhoCadastrar"] != null)
                Application.OpenForms["FormAparelhoCadastrar"].Close();


            this.Width = 950;
            this.CenterToScreen();

            FormAparelhoCadastrar formAparelhoCadastrar = new FormAparelhoCadastrar(linha, infoPessoa, marca, sistema, colecaoVersao, colecaoModelo);
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

        private SistemaOperacionalColecao SistemaColecao(SistemaOperacionalColecao colecao)
        {
            SistemaOperacionalColecao sistemas = new SistemaOperacionalColecao();
            foreach (SistemaOperacional item in colecao)
                sistemas.Add(item);

            return sistemas;

        }
    }
}
