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

namespace WinForms
{
    public partial class FormIphoneCadastrar : Form
    {
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
            formIphoneModelo.ShowDialog(this);
            formIphoneModelo.Dispose();
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
    }
}
