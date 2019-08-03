namespace WinForms
{
    partial class FormServicoTipo
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
            this.buttonNotebook = new System.Windows.Forms.Button();
            this.buttonCelular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNotebook
            // 
            this.buttonNotebook.BackColor = System.Drawing.Color.Transparent;
            this.buttonNotebook.FlatAppearance.BorderSize = 0;
            this.buttonNotebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotebook.ForeColor = System.Drawing.Color.White;
            this.buttonNotebook.Image = global::WinForms.Properties.Resources.icons8_iMac_32;
            this.buttonNotebook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNotebook.Location = new System.Drawing.Point(157, 36);
            this.buttonNotebook.Name = "buttonNotebook";
            this.buttonNotebook.Size = new System.Drawing.Size(115, 60);
            this.buttonNotebook.TabIndex = 3;
            this.buttonNotebook.Text = "Notebook (F2)";
            this.buttonNotebook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNotebook.UseVisualStyleBackColor = false;
            this.buttonNotebook.Click += new System.EventHandler(this.ButtonNotebook_Click);
            // 
            // buttonCelular
            // 
            this.buttonCelular.BackColor = System.Drawing.Color.Transparent;
            this.buttonCelular.FlatAppearance.BorderSize = 0;
            this.buttonCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCelular.ForeColor = System.Drawing.Color.White;
            this.buttonCelular.Image = global::WinForms.Properties.Resources.icons8_Smartphone_Tablet_32;
            this.buttonCelular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCelular.Location = new System.Drawing.Point(14, 36);
            this.buttonCelular.Name = "buttonCelular";
            this.buttonCelular.Size = new System.Drawing.Size(115, 60);
            this.buttonCelular.TabIndex = 2;
            this.buttonCelular.Text = "Iphone/Ipad (F1)";
            this.buttonCelular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCelular.UseVisualStyleBackColor = false;
            this.buttonCelular.Click += new System.EventHandler(this.ButtonCelular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para qual dispositivo?";
            // 
            // FormServicoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(307, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNotebook);
            this.Controls.Add(this.buttonCelular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormServicoTipo";
            this.Text = "FormServicoTipo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormServicoTipo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNotebook;
        private System.Windows.Forms.Button buttonCelular;
        private System.Windows.Forms.Label label1;
    }
}