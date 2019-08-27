using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ObjTransfer;
using ObjTransfer.Aparelho;
using ObjTransfer.Aparelho.Celulares;
using Negocios;

namespace WinForms.Iphone
{
    public partial class FormIphoneListar : Form
    {
        Thread thread;
        IphoneCompraColecao colecaoComprar;
        public FormIphoneListar()
        {
            InitializeComponent();
            DefinirDataGrid();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();

            this.AcceptButton = buttonPesquisar;
        }

        private void DefinirDataGrid()
        {
            dataGridViewListar.Columns["colIphone"].DataPropertyName = "Descricao";
            dataGridViewListar.Columns["colDataCompra"].DataPropertyName = "iphcompradatacompra";
            dataGridViewListar.Columns["colGarantia"].DataPropertyName = "DescricaoGarantia";
            dataGridViewListar.Columns["colEstado"].DataPropertyName = "DescricaoEstado";
            dataGridViewListar.Columns["colDataGarantia"].DataPropertyName = "iphcompradatagarantia";
            dataGridViewListar.Columns["colValorCompra"].DataPropertyName = "iphcompravalorcompra";
            dataGridViewListar.Columns["colValorVenda"].DataPropertyName = "iphcompravalorvenda";
            dataGridViewListar.Columns["colMargem"].DataPropertyName = "DescricaoMargem";
        }

        private void FormIphoneListar_Load(object sender, EventArgs e)
        {
            if (this.Modal)
            {
                buttonAdicionar.Visible = false;
                buttonVender.Visible = false;
                dataGridViewListar.MultiSelect = true;
            }

            comboBoxEstado.SelectedIndex = 0;
            comboBoxGarantia.SelectedIndex = 0;

            thread = new Thread(new ThreadStart(ConsultarIphone));
            thread.Start();
        }

        private void ConsultarIphone()
        {
            AparelhoNegocio negocio = new AparelhoNegocio(Form1.Empresa.empconexao);
            colecaoComprar = negocio.ConsultarIphoneCompra();

            if (thread != null)
                thread.Abort();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            FormIphoneCadastrar formIphoneCadastrar = new FormIphoneCadastrar();
            if (formIphoneCadastrar.ShowDialog(this) == DialogResult.Yes)
            {
                ConsultarIphone();
                PreencherGrid();
            }

            formIphoneCadastrar.Dispose();
        }

        private void ComboBoxGarantia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxGarantia.SelectedIndex == 2)
            //{
            //    comboBoxEstado.SelectedIndex = 2;
            //    comboBoxEstado.Enabled = false;
            //}
            //else
            //    comboBoxEstado.Enabled = true;
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            IphoneCompraColecao colecao = new IphoneCompraColecao();
            maskedTextBoxImei.Clear();
            if (checkBoxFiltrar.Checked)
            {
                bool garantia = comboBoxGarantia.Text == "Apple" ? true : false;
                bool novo = comboBoxEstado.Text == "Novo" ? true : false;
                var grid = colecaoComprar.Where(g => g.iphcompraaparelho.Descricao == comboBoxIphone.Text && g.iphcompragarantiaapple == garantia && g.iphcompranovo == novo).ToList();

                foreach (IphoneCompraInfo compra in grid)
                    colecao.Add(compra);
            }
            else
                colecao = colecaoComprar;

            dataGridViewListar.DataSource = colecao;
            GridCalc(colecao);
        }

        private void PreencherGrid()
        {
            dataGridViewListar.DataSource = colecaoComprar;

            if (colecaoComprar != null)
            {
                GridCalc(colecaoComprar);

                foreach (IphoneCompraInfo item in colecaoComprar)
                    if (!comboBoxIphone.Items.Contains(item.iphcompraaparelho.Descricao))
                        comboBoxIphone.Items.Add(item.iphcompraaparelho.Descricao);

                comboBoxIphone.SelectedIndex = 0;
            }
        }

        private void GridCalc(IphoneCompraColecao colecao)
        {
            var compra = from phone in colecao
                         let total = phone.iphcompravalorcompra
                         select total;

            var venda = from phone in colecao
                        let total = phone.iphcompravalorvenda
                        select total;

            decimal comp = compra.Sum();
            decimal vend = venda.Sum();
            decimal lucro = vend - comp;

            labelItens.Text = "Total de Iphones: " + string.Format("{0:000}", colecao.Count());
            labelCompra.Text = "Total em compras: " + comp.ToString("C2");
            labelVenda.Text = "Total em Vendas: " + vend.ToString("C2");

            decimal valor = venda.Sum() - compra.Sum();

            if (colecao.Count > 0)
                labelMargem.Text = "Margem: " + lucro.ToString("C2") + " (" + ((lucro * 100) / comp).ToString("F1") + "%)";
            else
                labelMargem.Text = "Margem: 0,00";

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (colecaoComprar != null)
            {
                PreencherGrid();
                groupBoxPesquisar.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void CheckBoxFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFiltrar.Checked)
            {
                comboBoxIphone.Enabled = true;
                comboBoxEstado.Enabled = true;
                comboBoxGarantia.Enabled = true;
            }
            else
            {
                comboBoxIphone.Enabled = false;
                comboBoxEstado.Enabled = false;
                comboBoxGarantia.Enabled = false;
            }
        }

        private void MaskedTextBoxImei_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxImei.Text.Length >= 15)
            {
                IphoneCompraColecao colecao = new IphoneCompraColecao();
                var grid = colecaoComprar.Where(g => g.iphcompraaparelho.IMEI == maskedTextBoxImei.Text).ToList();

                foreach (IphoneCompraInfo compra in grid)
                    colecao.Add(compra);

                dataGridViewListar.DataSource = colecao;
                GridCalc(colecao);
            }
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSelecionar_Click(object sender, EventArgs e)
        {
            if (this.Modal)
            {

            }
            else
            {

            }
        }
    }
}
