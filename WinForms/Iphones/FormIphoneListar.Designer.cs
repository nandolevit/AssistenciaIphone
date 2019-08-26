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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewListar = new System.Windows.Forms.DataGridView();
            this.labelItens = new System.Windows.Forms.Label();
            this.labelVenda = new System.Windows.Forms.Label();
            this.labelCompra = new System.Windows.Forms.Label();
            this.labelMargem = new System.Windows.Forms.Label();
            this.colIphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMargem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.comboBoxGarantia = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIphone = new System.Windows.Forms.ComboBox();
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
            this.colValorCompra,
            this.colValorVenda,
            this.colMargem});
            this.dataGridViewListar.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.RowHeadersVisible = false;
            this.dataGridViewListar.Size = new System.Drawing.Size(1320, 454);
            this.dataGridViewListar.TabIndex = 0;
            // 
            // labelItens
            // 
            this.labelItens.AutoSize = true;
            this.labelItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItens.Location = new System.Drawing.Point(558, 523);
            this.labelItens.Name = "labelItens";
            this.labelItens.Size = new System.Drawing.Size(107, 13);
            this.labelItens.TabIndex = 1;
            this.labelItens.Text = "Total de Iphones:";
            // 
            // labelVenda
            // 
            this.labelVenda.AutoSize = true;
            this.labelVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenda.Location = new System.Drawing.Point(926, 523);
            this.labelVenda.Name = "labelVenda";
            this.labelVenda.Size = new System.Drawing.Size(106, 13);
            this.labelVenda.TabIndex = 2;
            this.labelVenda.Text = "Total em Vendas:";
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompra.Location = new System.Drawing.Point(704, 523);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(111, 13);
            this.labelCompra.TabIndex = 3;
            this.labelCompra.Text = "Total em compras:";
            // 
            // labelMargem
            // 
            this.labelMargem.AutoSize = true;
            this.labelMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMargem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelMargem.Location = new System.Drawing.Point(1141, 523);
            this.labelMargem.Name = "labelMargem";
            this.labelMargem.Size = new System.Drawing.Size(55, 13);
            this.labelMargem.TabIndex = 4;
            this.labelMargem.Text = "Margem:";
            // 
            // colIphone
            // 
            this.colIphone.HeaderText = "Iphone";
            this.colIphone.Name = "colIphone";
            this.colIphone.Width = 625;
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
            this.colGarantia.Width = 175;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado:";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 75;
            // 
            // colDataGarantia
            // 
            this.colDataGarantia.HeaderText = "Data Garantia:";
            this.colDataGarantia.Name = "colDataGarantia";
            this.colDataGarantia.Visible = false;
            // 
            // colValorCompra
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.colValorCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValorCompra.HeaderText = "Valor Compra:";
            this.colValorCompra.Name = "colValorCompra";
            // 
            // colValorVenda
            // 
            dataGridViewCellStyle4.Format = "C2";
            this.colValorVenda.DefaultCellStyle = dataGridViewCellStyle4;
            this.colValorVenda.HeaderText = "Valor Venda:";
            this.colValorVenda.Name = "colValorVenda";
            // 
            // colMargem
            // 
            this.colMargem.HeaderText = "Margem:";
            this.colMargem.Name = "colMargem";
            this.colMargem.Width = 125;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Image = global::WinForms.Properties.Resources.add_32;
            this.buttonAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdicionar.Location = new System.Drawing.Point(1183, 20);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(149, 40);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.Text = "&Adicionar Iphone";
            this.buttonAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar por IMEI:";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Location = new System.Drawing.Point(634, 29);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(20, 20);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.TabStop = false;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // comboBoxGarantia
            // 
            this.comboBoxGarantia.FormattingEnabled = true;
            this.comboBoxGarantia.Items.AddRange(new object[] {
            "*Todos*",
            "Apple",
            "Loja"});
            this.comboBoxGarantia.Location = new System.Drawing.Point(475, 30);
            this.comboBoxGarantia.Name = "comboBoxGarantia";
            this.comboBoxGarantia.Size = new System.Drawing.Size(69, 21);
            this.comboBoxGarantia.TabIndex = 11;
            this.comboBoxGarantia.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGarantia_SelectedIndexChanged);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "*Todos*",
            "Novo",
            "Semi"});
            this.comboBoxEstado.Location = new System.Drawing.Point(550, 30);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(69, 21);
            this.comboBoxEstado.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Garantia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Iphone";
            // 
            // comboBoxIphone
            // 
            this.comboBoxIphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIphone.FormattingEnabled = true;
            this.comboBoxIphone.Items.AddRange(new object[] {
            "*Todos*"});
            this.comboBoxIphone.Location = new System.Drawing.Point(264, 31);
            this.comboBoxIphone.Name = "comboBoxIphone";
            this.comboBoxIphone.Size = new System.Drawing.Size(205, 21);
            this.comboBoxIphone.TabIndex = 15;
            // 
            // FormIphoneListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 587);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxIphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxGarantia);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelMargem);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.labelVenda);
            this.Controls.Add(this.labelItens);
            this.Controls.Add(this.dataGridViewListar);
            this.Name = "FormIphoneListar";
            this.Load += new System.EventHandler(this.FormIphoneListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForncedor;
        private System.Windows.Forms.Label labelItens;
        private System.Windows.Forms.Label labelVenda;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.Label labelMargem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMargem;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ComboBox comboBoxGarantia;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxIphone;
    }
}