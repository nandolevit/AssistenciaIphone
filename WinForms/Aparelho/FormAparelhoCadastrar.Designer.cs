namespace WinForms.Aparelho
{
    partial class FormAparelhoCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAparelhoCadastrar));
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxSistema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLinha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVersao = new System.Windows.Forms.ComboBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelSub = new System.Windows.Forms.Label();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.labelOutra = new System.Windows.Forms.Label();
            this.textBoxOutra = new System.Windows.Forms.TextBox();
            this.labelOutraSub = new System.Windows.Forms.Label();
            this.textBoxOutraSub = new System.Windows.Forms.TextBox();
            this.buttonCpuz = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(12, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 35);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(476, 20);
            this.textBoxNome.TabIndex = 4;
            this.textBoxNome.TabStop = false;
            // 
            // comboBoxSistema
            // 
            this.comboBoxSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSistema.FormattingEnabled = true;
            this.comboBoxSistema.Location = new System.Drawing.Point(229, 84);
            this.comboBoxSistema.Name = "comboBoxSistema";
            this.comboBoxSistema.Size = new System.Drawing.Size(165, 21);
            this.comboBoxSistema.TabIndex = 6;
            this.comboBoxSistema.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSistema_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistema Operacional:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(494, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Linha:";
            // 
            // textBoxLinha
            // 
            this.textBoxLinha.Location = new System.Drawing.Point(494, 35);
            this.textBoxLinha.Name = "textBoxLinha";
            this.textBoxLinha.ReadOnly = true;
            this.textBoxLinha.Size = new System.Drawing.Size(249, 20);
            this.textBoxLinha.TabIndex = 9;
            this.textBoxLinha.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "S. O. Versão:";
            // 
            // comboBoxVersao
            // 
            this.comboBoxVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVersao.FormattingEnabled = true;
            this.comboBoxVersao.Location = new System.Drawing.Point(400, 84);
            this.comboBoxVersao.Name = "comboBoxVersao";
            this.comboBoxVersao.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVersao.TabIndex = 10;
            this.comboBoxVersao.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVersao_SelectedIndexChanged);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.ForeColor = System.Drawing.Color.White;
            this.labelModelo.Location = new System.Drawing.Point(606, 68);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(72, 13);
            this.labelModelo.TabIndex = 13;
            this.labelModelo.Text = "S. O. Modelo:";
            this.labelModelo.Visible = false;
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModelo.FormattingEnabled = true;
            this.comboBoxModelo.Location = new System.Drawing.Point(606, 84);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(137, 21);
            this.comboBoxModelo.TabIndex = 12;
            this.comboBoxModelo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(229, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Marca:";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(229, 167);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMarca.TabIndex = 14;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMarca_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(229, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(566, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Série:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(566, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(351, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ano:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(52, 20);
            this.textBox3.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(229, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cor:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(229, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(229, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Categoria:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(229, 124);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCategoria.TabIndex = 24;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategoria_SelectedIndexChanged);
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.ForeColor = System.Drawing.Color.White;
            this.labelSub.Location = new System.Drawing.Point(400, 108);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(73, 13);
            this.labelSub.TabIndex = 27;
            this.labelSub.Text = "Subcategoria:";
            this.labelSub.Visible = false;
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Location = new System.Drawing.Point(400, 124);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSub.TabIndex = 26;
            this.comboBoxSub.Visible = false;
            this.comboBoxSub.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSub_SelectedIndexChanged);
            // 
            // labelOutra
            // 
            this.labelOutra.AutoSize = true;
            this.labelOutra.ForeColor = System.Drawing.Color.White;
            this.labelOutra.Location = new System.Drawing.Point(400, 152);
            this.labelOutra.Name = "labelOutra";
            this.labelOutra.Size = new System.Drawing.Size(68, 13);
            this.labelOutra.TabIndex = 29;
            this.labelOutra.Text = "Outra marca:";
            this.labelOutra.Visible = false;
            // 
            // textBoxOutra
            // 
            this.textBoxOutra.Location = new System.Drawing.Point(400, 167);
            this.textBoxOutra.Name = "textBoxOutra";
            this.textBoxOutra.Size = new System.Drawing.Size(343, 20);
            this.textBoxOutra.TabIndex = 28;
            this.textBoxOutra.Visible = false;
            // 
            // labelOutraSub
            // 
            this.labelOutraSub.AutoSize = true;
            this.labelOutraSub.ForeColor = System.Drawing.Color.White;
            this.labelOutraSub.Location = new System.Drawing.Point(606, 109);
            this.labelOutraSub.Name = "labelOutraSub";
            this.labelOutraSub.Size = new System.Drawing.Size(84, 13);
            this.labelOutraSub.TabIndex = 32;
            this.labelOutraSub.Text = "Outra Categoria:";
            this.labelOutraSub.Visible = false;
            // 
            // textBoxOutraSub
            // 
            this.textBoxOutraSub.Location = new System.Drawing.Point(606, 124);
            this.textBoxOutraSub.Name = "textBoxOutraSub";
            this.textBoxOutraSub.Size = new System.Drawing.Size(137, 20);
            this.textBoxOutraSub.TabIndex = 31;
            this.textBoxOutraSub.Visible = false;
            // 
            // buttonCpuz
            // 
            this.buttonCpuz.BackgroundImage = global::WinForms.Properties.Resources.cpuz;
            this.buttonCpuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCpuz.FlatAppearance.BorderSize = 0;
            this.buttonCpuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCpuz.Location = new System.Drawing.Point(532, 392);
            this.buttonCpuz.Name = "buttonCpuz";
            this.buttonCpuz.Size = new System.Drawing.Size(50, 46);
            this.buttonCpuz.TabIndex = 33;
            this.buttonCpuz.UseVisualStyleBackColor = true;
            this.buttonCpuz.Visible = false;
            this.buttonCpuz.Click += new System.EventHandler(this.ButtonCpuz_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = global::WinForms.Properties.Resources.outrospc;
            this.pictureBoxFoto.Location = new System.Drawing.Point(12, 68);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(211, 196);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 30;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCliente.BackgroundImage")));
            this.buttonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCliente.Location = new System.Drawing.Point(93, 384);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(26, 23);
            this.buttonCliente.TabIndex = 5;
            this.buttonCliente.UseVisualStyleBackColor = true;
            // 
            // FormAparelhoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.buttonCpuz);
            this.Controls.Add(this.labelOutraSub);
            this.Controls.Add(this.textBoxOutraSub);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.labelOutra);
            this.Controls.Add(this.textBoxOutra);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.comboBoxSub);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.comboBoxModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxVersao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLinha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSistema);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAparelhoCadastrar";
            this.Text = "FormAparelhoCadastrar";
            this.Load += new System.EventHandler(this.FormAparelhoCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.ComboBox comboBoxSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLinha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVersao;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.Label labelOutra;
        private System.Windows.Forms.TextBox textBoxOutra;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelOutraSub;
        private System.Windows.Forms.TextBox textBoxOutraSub;
        private System.Windows.Forms.Button buttonCpuz;
    }
}