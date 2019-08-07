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
    public partial class FormIphoneCadastrar : Form
    {
        IphoneCelularInfo infoModelo;

        public FormIphoneCadastrar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void TextBoxCompra_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(textBoxCompra);
        }

        private void TextBoxVenda_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(textBoxVenda);
        }

        private void RadioButtonApple_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonApple.Checked)
            {
                comboBoxPrazo.Enabled = false;

            }
            else
            {
                comboBoxPrazo.Enabled = true;
            }
        }

        private void ButtonModelo_Click(object sender, EventArgs e)
        {
            FormIphoneModelo formIphoneModelo = new FormIphoneModelo();
            if(formIphoneModelo.ShowDialog(this) == DialogResult.Yes)
            {
                infoModelo = formIphoneModelo.SelecionadoIphone;
                textBoxModelo.Text = infoModelo.ToString();
                textBoxObs.Text = infoModelo.celobs;

                foreach (IphoneModeloCorInfo cor in Form1.IphoneCorColecao)
                {
                    if (infoModelo.celcor == cor.iphcordescricao)
                    {
                        ConvertImagem(cor.modcorfoto);
                        break;
                    }
                }
            }
            formIphoneModelo.Dispose();
        }

        private void ConvertImagem(byte[] foto)
        {
            if (foto != null)
            {
                MemoryStream memoryStream = new MemoryStream(foto);
                pictureBoxFoto.Image = Image.FromStream(memoryStream);
            }
            else
                pictureBoxFoto.Image = null;
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFornecedor_Click(object sender, EventArgs e)
        {
            FormPessoaConsultar formPessoaConsultar = new FormPessoaConsultar(EnumPessoaTipo.Fornecedor);
            formPessoaConsultar.ShowDialog(this);
            formPessoaConsultar.Dispose();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormPessoa formPessoa = new FormPessoa(EnumPessoaTipo.Fornecedor);
            if (formPessoa.ShowDialog(this) == DialogResult.Yes)
            {

            }
        }
    }
}
