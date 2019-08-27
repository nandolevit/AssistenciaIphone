using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Venda
{
    public partial class FormVendaProdutoTipo : Form
    {
        public FormVendaProdutoTipo()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ButtonJuridica_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    this.DialogResult = DialogResult.Yes;
                    break;
                case Keys.F2:
                    this.DialogResult = DialogResult.OK;
                    break;
                default:
                    break;
            }
        }

        private void ButtonApple_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void ButtonProduto_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
