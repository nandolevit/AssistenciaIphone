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
using ObjTransfer.Aparelho.Celulares;
using ObjTransfer.Pessoas;
using Negocios;
using System.IO;
using WinForms.Pessoa;

namespace WinForms
{
    public partial class FormIphoneCadastrar : Form
    {
        IphoneInfo infoCelular;
        PessoaInfo infoFornecedor;
        AparelhoNegocio negocioAparelho;
        IphoneCompraInfo iphoneCompraInfo;


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

            decimal comp = Convert.ToDecimal(textBoxCompra.Text);
            decimal vend = Convert.ToDecimal(textBoxVenda.Text);
            decimal liq = vend - comp;

            if (liq > 0)
            {
                textBoxMargem.Text = ((liq / comp) * 100).ToString("F1");
                textBoxLiquido.Text = liq.ToString("F2");
            }

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
            if (formIphoneModelo.ShowDialog(this) == DialogResult.Yes)
            {
                infoCelular = formIphoneModelo.SelecionadoIphone;
                ConvertImagem(formIphoneModelo.SelecionadaFoto.modcorfoto);
                textBoxModelo.Text = infoCelular.ToString();
                buttonSalvar.Enabled = true;
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
            if (formPessoaConsultar.ShowDialog(this) == DialogResult.Yes)
            {
                infoFornecedor = formPessoaConsultar.SelecionadoCliente;
                Selecionado();
            }
            formPessoaConsultar.Dispose();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormPessoaCad formPessoa;
            FormPessoaFisicaJuridica formPessoaFisicaJuridica = new FormPessoaFisicaJuridica();
            if (formPessoaFisicaJuridica.ShowDialog(this) == DialogResult.Yes)
                formPessoa = new FormPessoaCad(EnumPessoaTipo.Fornecedor, true);
            else
                formPessoa = new FormPessoaCad(EnumPessoaTipo.Fornecedor, false);

            if (formPessoa.ShowDialog(this) == DialogResult.Yes)
            {
                infoFornecedor = formPessoa.SelecionadoPessoa;
                Selecionado();
            }
        }

        private void Selecionado()
        {
            textBoxFornecedor.Text = infoFornecedor.Nome;
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
            buttonFornecedor.Select();
        }

        private void ComboBoxPrazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePickerGarantia.Value = DateTime.Now.AddDays(Convert.ToInt32(comboBoxPrazo.Text));
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (Campos())
            {
                negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
                infoCelular.Pessoa = infoFornecedor;
                infoCelular.Id = negocioAparelho.InsertIphone(infoCelular);
                PreencherInfo();
                negocioAparelho.InsertIphoneCompra(iphoneCompraInfo);
                FormMessage.ShowMessegeInfo("Registro salva com sucesso!");
            }
            else
                FormMessage.ShowMessegeWarning("Informe os valores de compra de venda e compra!");
        }

        private bool Campos()
        {
            if (infoCelular == null)
                return false;

            if (Convert.ToDecimal(textBoxCompra.Text) <= 0)
                return false;

            if (Convert.ToDecimal(textBoxVenda.Text) <= 0)
                return false;

            return true;
        }

        private void PreencherInfo()
        {
            iphoneCompraInfo = new IphoneCompraInfo
            {
                iphcompradatacompra = dateTimePickerCompra.Value.Date,
                iphcompradatagarantia = dateTimePickerGarantia.Value.Date,
                iphcompragarantiaapple = radioButtonApple.Checked,
                iphcompragarantiadias = Convert.ToInt32(comboBoxPrazo.Text),
                iphcompraid = 0,
                iphcompraaparelho = infoCelular,
                iphcomprafornecedor = infoFornecedor,
                iphcompranovo = radioButtonNovo.Checked,
                iphcompravalorcompra = Convert.ToDecimal(textBoxCompra.Text),
                iphcompravalorvenda = Convert.ToDecimal(textBoxVenda.Text),
                iphcompraidfunc = Form1.User.useidfuncionario
            };
        }
    }
}
