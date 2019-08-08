namespace WinForms
{
    partial class FormIphoneCadastrar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCompra = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPrazo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonLoja = new System.Windows.Forms.RadioButton();
            this.radioButtonApple = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonSemi = new System.Windows.Forms.RadioButton();
            this.radioButtonNovo = new System.Windows.Forms.RadioButton();
            this.textBoxVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCompra = new System.Windows.Forms.TextBox();
            this.labelCompra = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerGarantia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerCompra = new System.Windows.Forms.DateTimePicker();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonModelo = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFornecedor = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxCompra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxCompra);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonFornecedor);
            this.groupBox1.Controls.Add(this.textBoxFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes:";
            // 
            // groupBoxCompra
            // 
            this.groupBoxCompra.Controls.Add(this.label6);
            this.groupBoxCompra.Controls.Add(this.comboBoxPrazo);
            this.groupBoxCompra.Controls.Add(this.groupBox2);
            this.groupBoxCompra.Controls.Add(this.groupBoxTipo);
            this.groupBoxCompra.Controls.Add(this.textBoxVenda);
            this.groupBoxCompra.Controls.Add(this.label7);
            this.groupBoxCompra.Controls.Add(this.textBoxCompra);
            this.groupBoxCompra.Controls.Add(this.labelCompra);
            this.groupBoxCompra.Controls.Add(this.textBoxObs);
            this.groupBoxCompra.Controls.Add(this.label5);
            this.groupBoxCompra.Controls.Add(this.label4);
            this.groupBoxCompra.Controls.Add(this.dateTimePickerGarantia);
            this.groupBoxCompra.Controls.Add(this.label3);
            this.groupBoxCompra.Controls.Add(this.dateTimePickerCompra);
            this.groupBoxCompra.Controls.Add(this.buttonModelo);
            this.groupBoxCompra.Controls.Add(this.textBoxModelo);
            this.groupBoxCompra.Controls.Add(this.label1);
            this.groupBoxCompra.Enabled = false;
            this.groupBoxCompra.Location = new System.Drawing.Point(6, 58);
            this.groupBoxCompra.Name = "groupBoxCompra";
            this.groupBoxCompra.Size = new System.Drawing.Size(584, 233);
            this.groupBoxCompra.TabIndex = 4;
            this.groupBoxCompra.TabStop = false;
            this.groupBoxCompra.Text = "Detalhes da compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prazo:";
            // 
            // comboBoxPrazo
            // 
            this.comboBoxPrazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrazo.Enabled = false;
            this.comboBoxPrazo.FormattingEnabled = true;
            this.comboBoxPrazo.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "180",
            "365"});
            this.comboBoxPrazo.Location = new System.Drawing.Point(291, 37);
            this.comboBoxPrazo.Name = "comboBoxPrazo";
            this.comboBoxPrazo.Size = new System.Drawing.Size(56, 21);
            this.comboBoxPrazo.TabIndex = 3;
            this.comboBoxPrazo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPrazo_SelectedIndexChanged);
            this.comboBoxPrazo.TextChanged += new System.EventHandler(this.ComboBoxPrazo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonLoja);
            this.groupBox2.Controls.Add(this.radioButtonApple);
            this.groupBox2.Location = new System.Drawing.Point(163, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Garantia:";
            // 
            // radioButtonLoja
            // 
            this.radioButtonLoja.AutoSize = true;
            this.radioButtonLoja.Location = new System.Drawing.Point(64, 20);
            this.radioButtonLoja.Name = "radioButtonLoja";
            this.radioButtonLoja.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLoja.TabIndex = 1;
            this.radioButtonLoja.Text = "Loja";
            this.radioButtonLoja.UseVisualStyleBackColor = true;
            // 
            // radioButtonApple
            // 
            this.radioButtonApple.AutoSize = true;
            this.radioButtonApple.Checked = true;
            this.radioButtonApple.Location = new System.Drawing.Point(7, 20);
            this.radioButtonApple.Name = "radioButtonApple";
            this.radioButtonApple.Size = new System.Drawing.Size(52, 17);
            this.radioButtonApple.TabIndex = 0;
            this.radioButtonApple.TabStop = true;
            this.radioButtonApple.Text = "Apple";
            this.radioButtonApple.UseVisualStyleBackColor = true;
            this.radioButtonApple.CheckedChanged += new System.EventHandler(this.RadioButtonApple_CheckedChanged);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonSemi);
            this.groupBoxTipo.Controls.Add(this.radioButtonNovo);
            this.groupBoxTipo.Location = new System.Drawing.Point(6, 21);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(151, 50);
            this.groupBoxTipo.TabIndex = 0;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Aparelho:";
            // 
            // radioButtonSemi
            // 
            this.radioButtonSemi.AutoSize = true;
            this.radioButtonSemi.Location = new System.Drawing.Point(64, 20);
            this.radioButtonSemi.Name = "radioButtonSemi";
            this.radioButtonSemi.Size = new System.Drawing.Size(77, 17);
            this.radioButtonSemi.TabIndex = 1;
            this.radioButtonSemi.Text = "Semi Novo";
            this.radioButtonSemi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNovo
            // 
            this.radioButtonNovo.AutoSize = true;
            this.radioButtonNovo.Checked = true;
            this.radioButtonNovo.Location = new System.Drawing.Point(7, 20);
            this.radioButtonNovo.Name = "radioButtonNovo";
            this.radioButtonNovo.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNovo.TabIndex = 0;
            this.radioButtonNovo.TabStop = true;
            this.radioButtonNovo.Text = "Novo";
            this.radioButtonNovo.UseVisualStyleBackColor = true;
            this.radioButtonNovo.CheckedChanged += new System.EventHandler(this.RadioButtonNovo_CheckedChanged);
            // 
            // textBoxVenda
            // 
            this.textBoxVenda.Location = new System.Drawing.Point(130, 207);
            this.textBoxVenda.Name = "textBoxVenda";
            this.textBoxVenda.Size = new System.Drawing.Size(115, 20);
            this.textBoxVenda.TabIndex = 14;
            this.textBoxVenda.TextChanged += new System.EventHandler(this.TextBoxVenda_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Venda:";
            // 
            // textBoxCompra
            // 
            this.textBoxCompra.Location = new System.Drawing.Point(5, 207);
            this.textBoxCompra.Name = "textBoxCompra";
            this.textBoxCompra.Size = new System.Drawing.Size(115, 20);
            this.textBoxCompra.TabIndex = 12;
            this.textBoxCompra.TextChanged += new System.EventHandler(this.TextBoxCompra_TextChanged);
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Location = new System.Drawing.Point(5, 191);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(73, 13);
            this.labelCompra.TabIndex = 11;
            this.labelCompra.Text = "Valor Compra:";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Enabled = false;
            this.textBoxObs.Location = new System.Drawing.Point(251, 129);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(327, 98);
            this.textBoxObs.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Observações:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data da Garantia:";
            // 
            // dateTimePickerGarantia
            // 
            this.dateTimePickerGarantia.Location = new System.Drawing.Point(5, 168);
            this.dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            this.dateTimePickerGarantia.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerGarantia.TabIndex = 10;
            this.dateTimePickerGarantia.ValueChanged += new System.EventHandler(this.DateTimePickerGarantia_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data da Compra:";
            // 
            // dateTimePickerCompra
            // 
            this.dateTimePickerCompra.Location = new System.Drawing.Point(5, 129);
            this.dateTimePickerCompra.Name = "dateTimePickerCompra";
            this.dateTimePickerCompra.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerCompra.TabIndex = 8;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(6, 90);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.ReadOnly = true;
            this.textBoxModelo.Size = new System.Drawing.Size(546, 20);
            this.textBoxModelo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelo:";
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.Location = new System.Drawing.Point(6, 32);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.ReadOnly = true;
            this.textBoxFornecedor.Size = new System.Drawing.Size(526, 20);
            this.textBoxFornecedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fornecedor:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(431, 315);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(523, 315);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 2;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // buttonModelo
            // 
            this.buttonModelo.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonModelo.FlatAppearance.BorderSize = 0;
            this.buttonModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModelo.Location = new System.Drawing.Point(558, 89);
            this.buttonModelo.Name = "buttonModelo";
            this.buttonModelo.Size = new System.Drawing.Size(20, 20);
            this.buttonModelo.TabIndex = 6;
            this.buttonModelo.UseVisualStyleBackColor = true;
            this.buttonModelo.Click += new System.EventHandler(this.ButtonModelo_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(564, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonFornecedor
            // 
            this.buttonFornecedor.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFornecedor.FlatAppearance.BorderSize = 0;
            this.buttonFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFornecedor.Location = new System.Drawing.Point(538, 32);
            this.buttonFornecedor.Name = "buttonFornecedor";
            this.buttonFornecedor.Size = new System.Drawing.Size(20, 20);
            this.buttonFornecedor.TabIndex = 2;
            this.buttonFornecedor.UseVisualStyleBackColor = true;
            this.buttonFornecedor.Click += new System.EventHandler(this.ButtonFornecedor_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = global::WinForms.Properties.Resources.SteveJob;
            this.pictureBoxFoto.Location = new System.Drawing.Point(614, 12);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(185, 297);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 1;
            this.pictureBoxFoto.TabStop = false;
            // 
            // FormIphoneCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 361);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxFoto);
            this.Name = "FormIphoneCadastrar";
            this.Text = "FormIphoneCadastrar";
            this.Load += new System.EventHandler(this.FormIphoneCadastrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCompra.ResumeLayout(false);
            this.groupBoxCompra.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPrazo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonLoja;
        private System.Windows.Forms.RadioButton radioButtonApple;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonSemi;
        private System.Windows.Forms.RadioButton radioButtonNovo;
        private System.Windows.Forms.TextBox textBoxVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCompra;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerGarantia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompra;
        private System.Windows.Forms.Button buttonModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFornecedor;
        private System.Windows.Forms.TextBox textBoxFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
    }
}