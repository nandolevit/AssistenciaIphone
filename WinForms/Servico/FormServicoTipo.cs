using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;
using ObjTransfer.Aparelho;


namespace WinForms
{
    public partial class FormServicoTipo : Form
    {
        AparelhoNegocio negocioAparelho;
        AparelhoLinhaColecao colecaoLinha;
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
            CrecercomboBoxLinha(2);
            
            //this.DialogResult = DialogResult.Yes;
        }

        private void Notebook()
        {
            CrecercomboBoxLinha(1);
            //this.DialogResult = DialogResult.OK;
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

        private void FormServicoTipo_Load(object sender, EventArgs e)
        {

            comboBoxLinha.DisplayMember = "linhadescricao";
            comboBoxLinha.ValueMember = "linhaid";
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            colecaoLinha = negocioAparelho.ConsultarAparelhoLinha();
        }

        private void CrecercomboBoxLinha(int l)
        {
            comboBoxLinha.Items.Clear();

            foreach (AparelhoLinha linha in colecaoLinha)
                if (linha.linhaidtipo == l)
                    comboBoxLinha.Items.Add(linha);

            comboBoxLinha.Width = 170;
            comboBoxLinha.SelectedIndex = 0;
            comboBoxLinha.Select();
        }
    }
}
