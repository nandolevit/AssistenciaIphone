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
    public partial class FormCadTexto : Form
    {
        public string Descricao { get; set; }
        public FormCadTexto()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonSalvar;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            Descricao = textBoxNome.Text.Trim();

            if (string.IsNullOrEmpty(Descricao))
                DialogResult = DialogResult.Cancel;
            else
                DialogResult = DialogResult.Yes;
        }
    }
}
