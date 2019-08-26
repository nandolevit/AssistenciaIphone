using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Iphone
{
    public partial class FormIphoneListar : Form
    {
        public FormIphoneListar()
        {
            InitializeComponent();
            DefinirDataGrid();
        }

        private void DefinirDataGrid()
        {
            dataGridViewListar.Columns["colIphone"].DataPropertyName = "Descricao";
            dataGridViewListar.Columns["colDataCompra"].DataPropertyName = "iphcompradatacompra";
            dataGridViewListar.Columns["colGarantia"].DataPropertyName = "iphcompragarantiaapple";
            dataGridViewListar.Columns["colEstado"].DataPropertyName = "iphcompranovo";
            dataGridViewListar.Columns["colDataGarantia"].DataPropertyName = "iphcompradatagarantia";
            dataGridViewListar.Columns["colFornecedor"].DataPropertyName = "iphcomprafornecedor";
            dataGridViewListar.Columns["colValorCompra"].DataPropertyName = "iphcompravalorcompra";
            dataGridViewListar.Columns["colValorVenda"].DataPropertyName = "iphcompravalorvenda";
        }
    }
}
