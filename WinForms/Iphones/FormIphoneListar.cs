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
using ObjTransfer.Aparelho;
using ObjTransfer.Aparelho.Celulares;
using Negocios;

namespace WinForms.Iphone
{
    public partial class FormIphoneListar : Form
    {
        IphoneCompraColecao colecaoComprar;
        public FormIphoneListar()
        {
            InitializeComponent();
            DefinirDataGrid();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
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
            comboBoxIphone.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
            comboBoxGarantia.SelectedIndex = 0;

            AparelhoNegocio negocio = new AparelhoNegocio(Form1.Empresa.empconexao);
            colecaoComprar = negocio.ConsultarIphoneCompra();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            FormIphoneCadastrar formIphoneCadastrar = new FormIphoneCadastrar();
            if (formIphoneCadastrar.ShowDialog(this) == DialogResult.Yes)
                PreencherGrid();

            formIphoneCadastrar.Dispose();
        }

        private void ComboBoxGarantia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGarantia.SelectedIndex == 2)
            {
                comboBoxEstado.SelectedIndex = 2;
                comboBoxEstado.Enabled = false;
            }
            else
                comboBoxEstado.Enabled = true;
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }

        private void PreencherGrid()
        {
            dataGridViewListar.DataSource = colecaoComprar;
            GridCalc(colecaoComprar);

            foreach (IphoneCompraInfo item in colecaoComprar)
                if (!comboBoxIphone.Items.Contains(item.iphcompraaparelho.Descricao))
                    comboBoxIphone.Items.Add(item.iphcompraaparelho.Descricao);
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
            labelMargem.Text += "Margem: " + lucro.ToString("C2") + " (" + ((lucro * 100) / comp).ToString("F1") + "%)";
        }
    }
}
