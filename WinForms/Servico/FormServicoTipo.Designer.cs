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
            this.comboBoxLinha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonoK = new System.Windows.Forms.Button();
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
            this.buttonNotebook.Location = new System.Drawing.Point(215, 58);
            this.buttonNotebook.Name = "buttonNotebook";
            this.buttonNotebook.Size = new System.Drawing.Size(129, 60);
            this.buttonNotebook.TabIndex = 3;
            this.buttonNotebook.Text = "Computadores (F2)";
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
            this.buttonCelular.Location = new System.Drawing.Point(14, 58);
            this.buttonCelular.Name = "buttonCelular";
            this.buttonCelular.Size = new System.Drawing.Size(129, 60);
            this.buttonCelular.TabIndex = 2;
            this.buttonCelular.Text = "Celulares (F1)";
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
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Qual dispositivo?";
            // 
            // comboBoxLinha
            // 
            this.comboBoxLinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLinha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxLinha.FormattingEnabled = true;
            this.comboBoxLinha.Location = new System.Drawing.Point(12, 147);
            this.comboBoxLinha.Name = "comboBoxLinha";
            this.comboBoxLinha.Size = new System.Drawing.Size(40, 21);
            this.comboBoxLinha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Qual Linha?";
            // 
            // buttonoK
            // 
            this.buttonoK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonoK.Location = new System.Drawing.Point(269, 183);
            this.buttonoK.Name = "buttonoK";
            this.buttonoK.Size = new System.Drawing.Size(75, 23);
            this.buttonoK.TabIndex = 7;
            this.buttonoK.Text = "OK";
            this.buttonoK.UseVisualStyleBackColor = true;
            this.buttonoK.Visible = false;
            this.buttonoK.Click += new System.EventHandler(this.ButtonoK_Click);
            // 
            // FormServicoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(363, 218);
            this.Controls.Add(this.buttonoK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLinha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNotebook);
            this.Controls.Add(this.buttonCelular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormServicoTipo";
            this.Text = "FormServicoTipo";
            this.Load += new System.EventHandler(this.FormServicoTipo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormServicoTipo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNotebook;
        private System.Windows.Forms.Button buttonCelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLinha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonoK;
    }
}