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
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonLoja = new System.Windows.Forms.RadioButton();
            this.radioButtonApple = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCompra = new System.Windows.Forms.TextBox();
            this.labelCompra = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerGarantia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerCompra = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonSemi = new System.Windows.Forms.RadioButton();
            this.radioButtonNovo = new System.Windows.Forms.RadioButton();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxPrincipal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.buttonSalvar);
            this.groupBoxPrincipal.Controls.Add(this.groupBox2);
            this.groupBoxPrincipal.Controls.Add(this.buttonFechar);
            this.groupBoxPrincipal.Controls.Add(this.groupBox1);
            this.groupBoxPrincipal.Controls.Add(this.groupBoxTipo);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(608, 344);
            this.groupBoxPrincipal.TabIndex = 0;
            this.groupBoxPrincipal.TabStop = false;
            this.groupBoxPrincipal.Text = "Cadastro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonLoja);
            this.groupBox2.Controls.Add(this.radioButtonApple);
            this.groupBox2.Location = new System.Drawing.Point(163, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 50);
            this.groupBox2.TabIndex = 3;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxVenda);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCompra);
            this.groupBox1.Controls.Add(this.labelCompra);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerGarantia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerCompra);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do aparelho:";
            // 
            // textBoxVenda
            // 
            this.textBoxVenda.Location = new System.Drawing.Point(131, 188);
            this.textBoxVenda.Name = "textBoxVenda";
            this.textBoxVenda.Size = new System.Drawing.Size(115, 20);
            this.textBoxVenda.TabIndex = 15;
            this.textBoxVenda.Text = "0";
            this.textBoxVenda.TextChanged += new System.EventHandler(this.TextBoxVenda_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor Venda:";
            // 
            // textBoxCompra
            // 
            this.textBoxCompra.Location = new System.Drawing.Point(6, 188);
            this.textBoxCompra.Name = "textBoxCompra";
            this.textBoxCompra.Size = new System.Drawing.Size(115, 20);
            this.textBoxCompra.TabIndex = 13;
            this.textBoxCompra.Text = "0";
            this.textBoxCompra.TextChanged += new System.EventHandler(this.TextBoxCompra_TextChanged);
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Location = new System.Drawing.Point(6, 172);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(73, 13);
            this.labelCompra.TabIndex = 12;
            this.labelCompra.Text = "Valor Compra:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(252, 110);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(336, 98);
            this.textBox3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data da Garantia:";
            // 
            // dateTimePickerGarantia
            // 
            this.dateTimePickerGarantia.Location = new System.Drawing.Point(6, 149);
            this.dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            this.dateTimePickerGarantia.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerGarantia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data da Compra:";
            // 
            // dateTimePickerCompra
            // 
            this.dateTimePickerCompra.Location = new System.Drawing.Point(6, 110);
            this.dateTimePickerCompra.Name = "dateTimePickerCompra";
            this.dateTimePickerCompra.Size = new System.Drawing.Size(240, 20);
            this.dateTimePickerCompra.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(554, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fornecedor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(554, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonSemi);
            this.groupBoxTipo.Controls.Add(this.radioButtonNovo);
            this.groupBoxTipo.Location = new System.Drawing.Point(6, 19);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(151, 50);
            this.groupBoxTipo.TabIndex = 2;
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
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(425, 296);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 20;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(517, 296);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 21;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms.Properties.Resources.SP727_iphone6s_plus_gold_select_2015;
            this.pictureBox1.Location = new System.Drawing.Point(626, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormIphoneCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxPrincipal);
            this.Name = "FormIphoneCadastrar";
            this.Text = "FormIphoneCadastrar";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonSemi;
        private System.Windows.Forms.RadioButton radioButtonNovo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCompra;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerGarantia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonLoja;
        private System.Windows.Forms.RadioButton radioButtonApple;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}