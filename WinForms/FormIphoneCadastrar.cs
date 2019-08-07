using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
