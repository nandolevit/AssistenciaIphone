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


namespace WinForms
{
    public partial class FormServicoTipo : Form
    {
        public FormServicoTipo()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
            //this.KeyPreview = true;
        }

        private void ButtonCelular_Click(object sender, EventArgs e)
        {
            Celular();
        }

        private void ButtonNotebook_Click(object sender, EventArgs e)
        {
            Notebook();
        }

        private void Celular()
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void Notebook()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FormServicoTipo_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.F1:
                    Celular();
                    break;
                case Keys.F2:
                    Notebook();
                    break;
                default:
                    break;
            }
        }
    }
}
