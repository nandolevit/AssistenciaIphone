namespace WinForms
{
    partial class FormIphoneSalvarFoto
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
            this.buttonFoto = new System.Windows.Forms.Button();
            this.textBoxCaminho = new System.Windows.Forms.TextBox();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboBoxCor = new System.Windows.Forms.ComboBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(107, 412);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(75, 23);
            this.buttonFoto.TabIndex = 0;
            this.buttonFoto.Text = "Foto";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.ButtonFoto_Click);
            // 
            // textBoxCaminho
            // 
            this.textBoxCaminho.Location = new System.Drawing.Point(9, 386);
            this.textBoxCaminho.Name = "textBoxCaminho";
            this.textBoxCaminho.Size = new System.Drawing.Size(275, 20);
            this.textBoxCaminho.TabIndex = 2;
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.FormattingEnabled = true;
            this.comboBoxModelo.Location = new System.Drawing.Point(10, 441);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(274, 21);
            this.comboBoxModelo.TabIndex = 3;
            this.comboBoxModelo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModelo_SelectedIndexChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(107, 495);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // comboBoxCor
            // 
            this.comboBoxCor.FormattingEnabled = true;
            this.comboBoxCor.Location = new System.Drawing.Point(9, 468);
            this.comboBoxCor.Name = "comboBoxCor";
            this.comboBoxCor.Size = new System.Drawing.Size(274, 21);
            this.comboBoxCor.TabIndex = 5;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(275, 368);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 1;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonPrincipal
            // 
            this.buttonPrincipal.Location = new System.Drawing.Point(107, 524);
            this.buttonPrincipal.Name = "buttonPrincipal";
            this.buttonPrincipal.Size = new System.Drawing.Size(75, 23);
            this.buttonPrincipal.TabIndex = 6;
            this.buttonPrincipal.Text = "Principal";
            this.buttonPrincipal.UseVisualStyleBackColor = true;
            this.buttonPrincipal.Click += new System.EventHandler(this.ButtonPrincipal_Click);
            // 
            // FormSalvarFotoIphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 566);
            this.Controls.Add(this.buttonPrincipal);
            this.Controls.Add(this.comboBoxCor);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxModelo);
            this.Controls.Add(this.textBoxCaminho);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.buttonFoto);
            this.Name = "FormSalvarFotoIphone";
            this.Text = "FormSalvarFotoIphone";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.TextBox textBoxCaminho;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private System.Windows.Forms.Button buttonPrincipal;
    }
}