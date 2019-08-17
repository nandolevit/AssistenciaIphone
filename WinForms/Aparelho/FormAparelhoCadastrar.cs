using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;
using ObjTransfer.Aparelho;

namespace WinForms.Aparelho
{
    public partial class FormAparelhoCadastrar : Form
    {
        AparelhoNegocio negocioAparelho;
        AparelhoLinha linhaAparelho;
        PessoaInfo infoPessoa;
        AparelhoMarcaColecao colecaoMarca;
        List<SistemaOperacional> colecaoSistema;
        SistemaOperacionalVersaoColecao colecaoVersao;
        SistemaOperacionalModeloColecao colecaoModelo;

        public FormAparelhoCadastrar(AparelhoLinha linha, PessoaInfo pessoa, AparelhoMarcaColecao marca, List<SistemaOperacional> sistema, SistemaOperacionalVersaoColecao versao, SistemaOperacionalModeloColecao modelo)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.KeyPreview = false;
            linhaAparelho = linha;
            textBoxLinha.Text = linha.linhadescricao;
            infoPessoa = pessoa;
            textBoxNome.Text = pessoa.pssnome;
            colecaoMarca = marca;
            colecaoSistema = sistema;
            colecaoVersao = versao;
            colecaoModelo = modelo;
        }

        private void FormAparelhoCadastrar_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < tabControlEspecificacoes.TabCount; i++)
                tabControlEspecificacoes.TabPages.RemoveAt(i);

            comboBoxVersao.ValueMember = "Id";
            comboBoxVersao.DisplayMember = "Descricao";

            comboBoxSistema.ValueMember = "Id";
            comboBoxSistema.DisplayMember = "Descricao";
            comboBoxSistema.DataSource = colecaoSistema;

            switch (linhaAparelho.linhaid)
            {
                case 1:
                case 3:
                    tabControlEspecificacoes.TabPages.RemoveAt(0);
                    comboBoxMarca.DisplayMember = "Descricao";
                    comboBoxMarca.ValueMember = "Id";

                    AparelhoMarca marca = new AparelhoMarca
                    {
                        Descricao = "Apple",
                        Id = 1
                    };

                    comboBoxMarca.Items.Add(marca);
                    comboBoxMarca.SelectedIndex = 0;
                    comboBoxMarca.Enabled = false;
                    comboBoxVersao.Width = 343;
                    colecaoMarca = null;
                    break;
                case 2:
                    tabControlEspecificacoes.TabPages.RemoveAt(0);
                    comboBoxSistema.Text = "Windows";
                    comboBoxVersao.Text = "Windows 10";
                    buttonCpuz.Visible = true;
                    tabControlEspecificacoes.TabPages.Add(tabPagePc);
                    break;
                case 4:
                    tabControlEspecificacoes.TabPages.RemoveAt(0);
                    comboBoxVersao.Width = 343;
                    comboBoxCategoria.Text = "SmartPhone";
                    tabControlEspecificacoes.TabPages.Add(tabPageCelular);
                    break;
                default:
                    break;
            }


            //tabControlEspecificacoes.TabPages.RemoveAt(0);

            if (colecaoMarca != null)
            {
                comboBoxMarca.DisplayMember = "Descricao";
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DataSource = colecaoMarca;
                comboBoxMarca.SelectedIndex = -1;
                comboBoxVersao.Width = 200;
            }

            PreencherComboBoxCategoria();
        }

        private void ComboBoxSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            int id = Convert.ToInt32(comboBoxSistema.SelectedValue);
            var colecao = colecaoVersao.Where(p => p.IdSo == id).ToList();

            if (colecao.Count == 0)
            {
                comboBoxVersao.DropDownStyle = ComboBoxStyle.Simple;
                comboBoxVersao.Width = 343;
                comboBoxVersao.DataSource = null;
            }
            else
            {
                comboBoxVersao.Width = 200;
                comboBoxVersao.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxVersao.ValueMember = "Id";
                comboBoxVersao.DisplayMember = "Descricao";
                comboBoxVersao.DataSource = colecao;
            }

            comboBoxVersao.Select();
        }

        private void ComboBoxVersao_SelectedIndexChanged(object sender, EventArgs e)
        {
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            int id = Convert.ToInt32(comboBoxVersao.SelectedValue);
            var colecao = colecaoModelo.Where(p => p.IdSo == id).ToList();

            if (colecao.Count > 0)
            {
                labelModelo.Visible = true;
                comboBoxModelo.Visible = true;
                comboBoxModelo.ValueMember = "Id";
                comboBoxModelo.DisplayMember = "Descricao";
                comboBoxModelo.DataSource = colecao;
                comboBoxModelo.Select();
            }
            else
            {
                labelModelo.Visible = false;
                comboBoxModelo.Visible = false;
            }
        }

        private void PreencherComboBoxCategoria()
        {
            //linha 1
            string[] catApple = new string[] { "MacBook", "iMac", "Mac Pro", "Mac Mini", "Outros" };

            //linha 2
            string[] catPc = new string[]{ "Laptop", "Desktop", "All in One (AIO)",  "Servidor", "Outros" };

            //linha 4
            string[] catSmart = new string[] { "SmartPhone", "Tablet"};


            switch (linhaAparelho.linhaid)
            {
                case 1:
                    comboBoxCategoria.Items.AddRange(catApple);
                    comboBoxCategoria.SelectedIndex = 0;
                    comboBoxSub.SelectedIndex = 0;
                    break;
                case 2:
                    comboBoxCategoria.Items.AddRange(catPc);
                    comboBoxCategoria.Text = "Laptop";
                    comboBoxSub.Text = "Notebook";
                    break;
                case 3:
                    break;
                case 4:
                    comboBoxCategoria.Items.AddRange(catSmart);
                    comboBoxCategoria.SelectedIndex = 0;
                    comboBoxVersao.Width = 343;
                    break;
                default:
                    break;
            }
        }

        private void ComboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //linha mac
            string[] subiMac = new string[] { "iMac", "iMac Pro", "Outros" };
            string[] subMacBook = new string[] { "MacBook Pro", "MacBook Air", "MacBook Retina", "Outros" };

            string[] subNotebook = new string[] { "Notebook", "Netbook", "Notebook 2 em 1", "Ultrabook", "Gamer", "Outros" };

            comboBoxSub.Items.Clear();
            comboBoxSub.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (comboBoxCategoria.Text)
            {
                case "SmartPhone":
                    pictureBoxFoto.Image = Properties.Resources.smartphone;
                    ComboBoxSub_Visible(false);
                    break;
                case "Tablet":
                    pictureBoxFoto.Image = Properties.Resources.tablets;
                    ComboBoxSub_Visible(false);
                    break;
                case "All in One (AIO)":
                    pictureBoxFoto.Image = Properties.Resources.aiopc;
                    ComboBoxSub_Visible(false);
                    break;
                case "Desktop":
                    pictureBoxFoto.Image = Properties.Resources.computer;
                    ComboBoxSub_Visible(false);
                    break;
                case "Servidor":
                    pictureBoxFoto.Image = Properties.Resources.servidores;
                    ComboBoxSub_Visible(false);
                    break;
                case "Mac Pro":
                    pictureBoxFoto.Image = Properties.Resources.macpro;
                    ComboBoxSub_Visible(false);
                    break;
                case "Mac Mini":
                    pictureBoxFoto.Image = Properties.Resources.macmini;
                    ComboBoxSub_Visible(false);
                    break;
                case "iMac":
                    comboBoxSub.Items.AddRange(subiMac);
                    ComboBoxSub_Visible();
                    pictureBoxFoto.Image = Properties.Resources.imac;
                    break;
                case "MacBook":
                    comboBoxSub.Items.AddRange(subMacBook);
                    ComboBoxSub_Visible();
                    pictureBoxFoto.Image = Properties.Resources.notebook;
                    break;
                case "Laptop":
                    comboBoxSub.Items.AddRange(subNotebook);
                    ComboBoxSub_Visible();
                    pictureBoxFoto.Image = Properties.Resources.notebooks;
                    break;
                case "Outros":
                    comboBoxSub.Items.AddRange(subNotebook);
                    ComboBoxSub_Visible();
                    comboBoxSub.DropDownStyle = ComboBoxStyle.Simple;
                    comboBoxSub.Select();
                    pictureBoxFoto.Image = Properties.Resources.outrospc;
                    break;
                default:
                    ComboBoxSub_Visible(false);
                    break;
            }
        }

        private void ComboBoxSub_Visible(bool ativar = true)
        {
            comboBoxSub.Visible = ativar;
            labelSub.Visible = ativar;
        }

        private void ComboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarca.Text == "Outras")
            {
                labelOutra.Visible = true;
                textBoxOutra.Visible = true;
                textBoxOutra.Select();
            }
            else
            {
                labelOutra.Visible = false;
                textBoxOutra.Visible = false;
            }
        }

        private void ComboBoxSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSub.Text == "Outros")
            {
                labelOutraSub.Visible = true;
                textBoxOutraSub.Visible = true;
                textBoxOutraSub.Select();
            }
            else
            {
                labelOutraSub.Visible = false;
                textBoxOutraSub.Visible = false;
            }
        }

        private void ButtonCpuz_Click(object sender, EventArgs e)
        {
            using (FormLerText formLerText = new FormLerText())
            {
                formLerText.ShowDialog(this);
            }
        }

        private void ComboBoxConector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxConector.Text)
            {
                case "Mini USB":
                    pictureBoxConector.Image = Properties.Resources.microusb;
                    break;
                case "Tipo C":
                    pictureBoxConector.Image = Properties.Resources.tipo_c;
                    break;
                case "Lightning":
                    pictureBoxConector.Image = Properties.Resources.lightning;
                    break;
                case "Outros":
                    pictureBoxConector.Image = null;
                    break;
                default:
                    break;
            }
        }
    }
}
