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
            dataGridViewListar.Columns["colFornecedor"].DataPropertyName = "UserInfo.usenome";
            dataGridViewListar.Columns["colValorCompra"].DataPropertyName = "iphcompravalorcompra";
            dataGridViewListar.Columns["colValorVenda"].DataPropertyName = "iphcompravalorvenda";
        }

        private void FormIphoneListar_Load(object sender, EventArgs e)
        {
            AparelhoNegocio negocio = new AparelhoNegocio(Form1.Empresa.empconexao);
            dataGridViewListar.DataSource = negocio.ConsultarIphoneCompra();
        }
    }
}
