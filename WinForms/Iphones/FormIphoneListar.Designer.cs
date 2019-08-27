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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewListar = new System.Windows.Forms.DataGridView();
            this.colIphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMargem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelItens = new System.Windows.Forms.Label();
            this.labelVenda = new System.Windows.Forms.Label();
            this.labelCompra = new System.Windows.Forms.Label();
            this.labelMargem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGarantia = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIphone = new System.Windows.Forms.ComboBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxPesquisar = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxFiltrar = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxImei = new System.Windows.Forms.MaskedTextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonVender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).BeginInit();
            this.groupBoxPesquisar.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dataGridViewListar.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.RowHeadersVisible = false;
            this.dataGridViewListar.Size = new System.Drawing.Size(1320, 438);
            this.dataGridViewListar.TabIndex = 0;
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
            dataGridViewCellStyle5.Format = "C2";
            this.colValorCompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.colValorCompra.HeaderText = "Valor Compra:";
            this.colValorCompra.Name = "colValorCompra";
            // 
            // colValorVenda
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.colValorVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.colValorVenda.HeaderText = "Valor Venda:";
            this.colValorVenda.Name = "colValorVenda";
            // 
            // colMargem
            // 
            this.colMargem.HeaderText = "Margem:";
            this.colMargem.Name = "colMargem";
            this.colMargem.Width = 125;
            // 
            // labelItens
            // 
            this.labelItens.AutoSize = true;
            this.labelItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItens.ForeColor = System.Drawing.Color.Maroon;
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
            this.labelVenda.ForeColor = System.Drawing.Color.Maroon;
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
            this.labelCompra.ForeColor = System.Drawing.Color.Maroon;
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
            this.labelMargem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelMargem.Location = new System.Drawing.Point(1141, 523);
            this.labelMargem.Name = "labelMargem";
            this.labelMargem.Size = new System.Drawing.Size(55, 13);
            this.labelMargem.TabIndex = 4;
            this.labelMargem.Text = "Margem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar por IMEI:";
            // 
            // comboBoxGarantia
            // 
            this.comboBoxGarantia.Enabled = false;
            this.comboBoxGarantia.FormattingEnabled = true;
            this.comboBoxGarantia.Items.AddRange(new object[] {
            "Apple",
            "Loja"});
            this.comboBoxGarantia.Location = new System.Drawing.Point(272, 18);
            this.comboBoxGarantia.Name = "comboBoxGarantia";
            this.comboBoxGarantia.Size = new System.Drawing.Size(69, 21);
            this.comboBoxGarantia.TabIndex = 11;
            this.comboBoxGarantia.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGarantia_SelectedIndexChanged);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Enabled = false;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Novo",
            "Semi"});
            this.comboBoxEstado.Location = new System.Drawing.Point(347, 18);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(69, 21);
            this.comboBoxEstado.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Garantia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Iphone:";
            // 
            // comboBoxIphone
            // 
            this.comboBoxIphone.Enabled = false;
            this.comboBoxIphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIphone.FormattingEnabled = true;
            this.comboBoxIphone.Location = new System.Drawing.Point(61, 18);
            this.comboBoxIphone.Name = "comboBoxIphone";
            this.comboBoxIphone.Size = new System.Drawing.Size(205, 21);
            this.comboBoxIphone.TabIndex = 15;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Image = global::WinForms.Properties.Resources.icons8_Filter_16;
            this.buttonPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPesquisar.Location = new System.Drawing.Point(431, 17);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(84, 21);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.TabStop = false;
            this.buttonPesquisar.Text = "Pesquisar:";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.ButtonPesquisar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Image = global::WinForms.Properties.Resources.add_32;
            this.buttonAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdicionar.Location = new System.Drawing.Point(1183, 36);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(149, 40);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.Text = "&Adicionar Iphone";
            this.buttonAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBoxPesquisar
            // 
            this.groupBoxPesquisar.Controls.Add(this.panel1);
            this.groupBoxPesquisar.Controls.Add(this.maskedTextBoxImei);
            this.groupBoxPesquisar.Controls.Add(this.label1);
            this.groupBoxPesquisar.Enabled = false;
            this.groupBoxPesquisar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPesquisar.Name = "groupBoxPesquisar";
            this.groupBoxPesquisar.Size = new System.Drawing.Size(682, 64);
            this.groupBoxPesquisar.TabIndex = 17;
            this.groupBoxPesquisar.TabStop = false;
            this.groupBoxPesquisar.Text = "Pesquisar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxFiltrar);
            this.panel1.Controls.Add(this.comboBoxEstado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxGarantia);
            this.panel1.Controls.Add(this.comboBoxIphone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonPesquisar);
            this.panel1.Location = new System.Drawing.Point(139, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 44);
            this.panel1.TabIndex = 18;
            // 
            // checkBoxFiltrar
            // 
            this.checkBoxFiltrar.AutoSize = true;
            this.checkBoxFiltrar.Location = new System.Drawing.Point(3, 20);
            this.checkBoxFiltrar.Name = "checkBoxFiltrar";
            this.checkBoxFiltrar.Size = new System.Drawing.Size(51, 17);
            this.checkBoxFiltrar.TabIndex = 18;
            this.checkBoxFiltrar.Text = "Filtrar";
            this.checkBoxFiltrar.UseVisualStyleBackColor = true;
            this.checkBoxFiltrar.CheckedChanged += new System.EventHandler(this.CheckBoxFiltrar_CheckedChanged);
            // 
            // maskedTextBoxImei
            // 
            this.maskedTextBoxImei.Location = new System.Drawing.Point(9, 32);
            this.maskedTextBoxImei.Mask = "000000000000000";
            this.maskedTextBoxImei.Name = "maskedTextBoxImei";
            this.maskedTextBoxImei.Size = new System.Drawing.Size(124, 20);
            this.maskedTextBoxImei.TabIndex = 17;
            this.maskedTextBoxImei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxImei.TextChanged += new System.EventHandler(this.MaskedTextBoxImei_TextChanged);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(1133, 544);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(108, 40);
            this.buttonSelecionar.TabIndex = 19;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.ButtonSelecionar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(1247, 543);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 20;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // buttonVender
            // 
            this.buttonVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVender.Image = global::WinForms.Properties.Resources.icons8_Low_Price_32;
            this.buttonVender.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonVender.Location = new System.Drawing.Point(12, 526);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(90, 40);
            this.buttonVender.TabIndex = 21;
            this.buttonVender.Text = "&Vender";
            this.buttonVender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVender.UseVisualStyleBackColor = true;
            // 
            // FormIphoneListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 595);
            this.Controls.Add(this.buttonVender);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.groupBoxPesquisar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelMargem);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.labelVenda);
            this.Controls.Add(this.labelItens);
            this.Controls.Add(this.dataGridViewListar);
            this.Name = "FormIphoneListar";
            this.Load += new System.EventHandler(this.FormIphoneListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            this.groupBoxPesquisar.ResumeLayout(false);
            this.groupBoxPesquisar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ComboBox comboBoxGarantia;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxIphone;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxPesquisar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxImei;
        private System.Windows.Forms.CheckBox checkBoxFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonVender;
    }
}