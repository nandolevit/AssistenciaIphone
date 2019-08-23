namespace WinForms.Pessoa
{
    partial class FormPessoaFisicaJuridica
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
            this.buttonJuridica = new System.Windows.Forms.Button();
            this.buttonFisica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonJuridica
            // 
            this.buttonJuridica.BackColor = System.Drawing.Color.Transparent;
            this.buttonJuridica.FlatAppearance.BorderSize = 0;
            this.buttonJuridica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJuridica.ForeColor = System.Drawing.Color.White;
            this.buttonJuridica.Image = global::WinForms.Properties.Resources.icons8_Small_Business_32;
            this.buttonJuridica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonJuridica.Location = new System.Drawing.Point(182, 35);
            this.buttonJuridica.Name = "buttonJuridica";
            this.buttonJuridica.Size = new System.Drawing.Size(134, 60);
            this.buttonJuridica.TabIndex = 3;
            this.buttonJuridica.Text = "Pessoa Juridica (F2)";
            this.buttonJuridica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonJuridica.UseVisualStyleBackColor = false;
            this.buttonJuridica.Click += new System.EventHandler(this.ButtonJuridica_Click);
            // 
            // buttonFisica
            // 
            this.buttonFisica.BackColor = System.Drawing.Color.Transparent;
            this.buttonFisica.FlatAppearance.BorderSize = 0;
            this.buttonFisica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFisica.ForeColor = System.Drawing.Color.White;
            this.buttonFisica.Image = global::WinForms.Properties.Resources.icons8_Customer_32;
            this.buttonFisica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFisica.Location = new System.Drawing.Point(26, 35);
            this.buttonFisica.Name = "buttonFisica";
            this.buttonFisica.Size = new System.Drawing.Size(134, 60);
            this.buttonFisica.TabIndex = 2;
            this.buttonFisica.Text = "Pessoa Fisica (F1)";
            this.buttonFisica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFisica.UseVisualStyleBackColor = false;
            this.buttonFisica.Click += new System.EventHandler(this.ButtonFisica_Click);
            // 
            // FormPessoaFisicaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(345, 135);
            this.Controls.Add(this.buttonJuridica);
            this.Controls.Add(this.buttonFisica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormPessoaFisicaJuridica";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormPessoaFisicaJuridica";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPessoaFisicaJuridica_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonJuridica;
        private System.Windows.Forms.Button buttonFisica;
    }
}