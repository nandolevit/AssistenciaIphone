namespace WinForms.Iphone
{
    partial class FormIphoneListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewListar = new System.Windows.Forms.DataGridView();
            this.colIphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListar
            // 
            this.dataGridViewListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIphone,
            this.colDataCompra,
            this.colGarantia,
            this.colEstado,
            this.colDataGarantia,
            this.colFornecedor,
            this.colValorCompra,
            this.colValorVenda});
            this.dataGridViewListar.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.RowHeadersVisible = false;
            this.dataGridViewListar.Size = new System.Drawing.Size(1320, 413);
            this.dataGridViewListar.TabIndex = 0;
            // 
            // colIphone
            // 
            this.colIphone.HeaderText = "Iphone";
            this.colIphone.Name = "colIphone";
            this.colIphone.Width = 600;
            // 
            // colDataCompra
            // 
            this.colDataCompra.HeaderText = "Data Compra:";
            this.colDataCompra.Name = "colDataCompra";
            // 
            // colGarantia
            // 
            this.colGarantia.HeaderText = "Garantia:";
            this.colGarantia.Name = "colGarantia";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado:";
            this.colEstado.Name = "colEstado";
            // 
            // colDataGarantia
            // 
            this.colDataGarantia.HeaderText = "Data Garantia:";
            this.colDataGarantia.Name = "colDataGarantia";
            // 
            // colFornecedor
            // 
            this.colFornecedor.HeaderText = "Fornecedor:";
            this.colFornecedor.Name = "colFornecedor";
            // 
            // colValorCompra
            // 
            this.colValorCompra.HeaderText = "Valor Compra:";
            this.colValorCompra.Name = "colValorCompra";
            // 
            // colValorVenda
            // 
            this.colValorVenda.HeaderText = "Valor Venda:";
            this.colValorVenda.Name = "colValorVenda";
            // 
            // FormIphoneListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 532);
            this.Controls.Add(this.dataGridViewListar);
            this.Name = "FormIphoneListar";
            this.Text = "FormIphoneListar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForncedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorVenda;
    }
}