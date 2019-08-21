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
using ObjTransfer.Aparelho.Computadores;
//using System.Linq;
using Negocios;
using ObjTransfer;
using ObjTransfer.Aparelho.Enum;

namespace WinForms.Aparelho
{
    public partial class FormAparelhoMenu : Form
    {
        EnumAparelhoLinha enumAparelho;
        AparelhoLinhaColecao colecaoLinha;
        AparelhoNegocio negocioAparelho;
        PessoaInfo infoPessoa;
        AparelhoMarcaColecao colecaoMarcaPc;
        AparelhoMarcaColecao colecaoMarcaCelular;
        SistemaOperacionalColecao colecaoSistema;
        SistemaOperacionalVersaoColecao colecaoVersao;
        SistemaOperacionalModeloColecao colecaoModelo;
        ProcessadorModeloColecao colecaoModeloProc;
        ProcessadorLinhaColecao colecaoLinhaProc;

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
            enumAparelho = EnumAparelhoLinha.Iphone;
            panelSeta.Top = buttonIphone.Top;
            AbrirFormIphone();

            //AbrirForm(linha);
        }

        private void ButtonSmart_Click(object sender, EventArgs e)
        {
            enumAparelho = EnumAparelhoLinha.SmartPhone;
            panelSeta.Top = buttonSmart.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 4).FirstOrDefault();
            var colecao = colecaoSistema.Where(p => p.Soidlinha == 4).ToList();
            AbrirForm(linha, colecaoMarcaCelular, colecao);
        }

        private void ButtonWin_Click(object sender, EventArgs e)
        {
            enumAparelho = EnumAparelhoLinha.Pc;
            panelSeta.Top = buttonWin.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 2).FirstOrDefault();
            var colecao = colecaoSistema.Where(p => p.Soidlinha == 2).ToList();
            AbrirForm(linha, colecaoMarcaPc, colecao);
        }

        private void ButtonMac_Click(object sender, EventArgs e)
        {
            enumAparelho = EnumAparelhoLinha.Mac;
            panelSeta.Top = buttonMac.Top;
            AparelhoLinha linha = colecaoLinha.Where(p => p.linhaid == 1).FirstOrDefault();
            var colecao = colecaoSistema.Where(p => p.Soidlinha == 1).ToList();
            AbrirForm(linha, colecaoMarcaPc, colecao);
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
            colecaoModeloProc = negocioAparelho.ConsultarProcessadorModelo();
            colecaoLinhaProc = negocioAparelho.ConsultarProcessadorLinha();
            AbrirFormIphone();
        }

        private void AbrirForm(AparelhoLinha linha, AparelhoMarcaColecao marca, List<SistemaOperacional> sistema)
        {
            if (Application.OpenForms["FormIphoneModelo"] != null)
                Application.OpenForms["FormIphoneModelo"].Close();

            if (Application.OpenForms["FormAparelhoCadastrar"] != null)
                Application.OpenForms["FormAparelhoCadastrar"].Close();


            this.Width = 950;
            this.CenterToScreen();

            FormAparelhoCadastrar formAparelhoCadastrar = new FormAparelhoCadastrar(linha, infoPessoa, marca, sistema, colecaoVersao, colecaoModelo, colecaoModeloProc, colecaoLinhaProc);
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
            if (this.DialogResult != DialogResult.Yes)
                if (FormMessage.ShowMessegeQuestion("Deseja encerrar este forrmulário?") == DialogResult.No)
                    e.Cancel = true;
        }
    }
}
