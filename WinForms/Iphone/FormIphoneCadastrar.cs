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
        IphoneCelularInfo infoCelular;
        PessoaInfo infoFornecedor;
        ServicoNegocio negocioServ;


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
                dateTimePickerGarantia.Value = DateTime.Now.AddDays(Convert.ToInt32(comboBoxPrazo.Text));
            }
        }

        private void ButtonModelo_Click(object sender, EventArgs e)
        {
            FormIphoneModelo formIphoneModelo = new FormIphoneModelo();
            if(formIphoneModelo.ShowDialog(this) == DialogResult.Yes)
            {
                infoCelular = formIphoneModelo.SelecionadoIphone;
                ConvertImagem(formIphoneModelo.SelecionadaFoto.modcorfoto);
                textBoxModelo.Text = infoCelular.ToString();
                textBoxObs.Text = infoCelular.celobs;

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
            if(formPessoaConsultar.ShowDialog(this) == DialogResult.Yes)
            {
                infoFornecedor = formPessoaConsultar.SelecionadoCliente;
                Selecionado();
            }
            formPessoaConsultar.Dispose();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormPessoa formPessoa = new FormPessoa(EnumPessoaTipo.Fornecedor);
            if (formPessoa.ShowDialog(this) == DialogResult.Yes)
            {
                infoFornecedor = formPessoa.SelecionadoPessoa;
                Selecionado();
            }
        }

        private void Selecionado()
        {
            textBoxFornecedor.Text = infoFornecedor.pssnome;
            groupBoxCompra.Enabled = true;
        }

        private void RadioButtonNovo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNovo.Checked)
            {
                radioButtonApple.Checked = true;
            }
            else
            {
                radioButtonLoja.Checked = true;
            }
        }

        private void ComboBoxPrazo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerGarantia_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan span = dateTimePickerGarantia.Value.Subtract(DateTime.Now.Date);

            if (span.Days < 0)
            {
                dateTimePickerGarantia.Value = DateTime.Now.Date;
                return;
            }

            if (!comboBoxPrazo.Items.Contains(Convert.ToString(span.Days)))
                comboBoxPrazo.Items.Add(Convert.ToString(span.Days));

            comboBoxPrazo.SelectedItem = Convert.ToString(span.Days);
        }

        private void FormIphoneCadastrar_Load(object sender, EventArgs e)
        {
            comboBoxPrazo.SelectedItem = "90";
            textBoxCompra.Text = "0";
            textBoxVenda.Text = "0";
        }

        private void ComboBoxPrazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePickerGarantia.Value = DateTime.Now.AddDays(Convert.ToInt32(comboBoxPrazo.Text));
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            infoCelular.celid = negocioServ.InsertIphoneCelular(infoCelular);
        }
    }
}
