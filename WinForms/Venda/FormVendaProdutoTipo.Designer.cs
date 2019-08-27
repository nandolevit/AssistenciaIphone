namespace WinForms.Venda
{
    partial class FormVendaProdutoTipo
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
            this.buttonProduto = new System.Windows.Forms.Button();
            this.buttonApple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProduto
            // 
            this.buttonProduto.BackColor = System.Drawing.Color.Transparent;
            this.buttonProduto.FlatAppearance.BorderSize = 0;
            this.buttonProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduto.ForeColor = System.Drawing.Color.White;
            this.buttonProduto.Image = global::WinForms.Properties.Resources.icons8_Ingredients_32;
            this.buttonProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProduto.Location = new System.Drawing.Point(183, 37);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(134, 60);
            this.buttonProduto.TabIndex = 5;
            this.buttonProduto.Text = "Outros Produtos (F2)";
            this.buttonProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProduto.UseVisualStyleBackColor = false;
            this.buttonProduto.Click += new System.EventHandler(this.ButtonProduto_Click);
            this.buttonProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonJuridica_KeyDown);
            // 
            // buttonApple
            // 
            this.buttonApple.BackColor = System.Drawing.Color.Transparent;
            this.buttonApple.FlatAppearance.BorderSize = 0;
            this.buttonApple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApple.ForeColor = System.Drawing.Color.White;
            this.buttonApple.Image = global::WinForms.Properties.Resources.icons8_Apple_32;
            this.buttonApple.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonApple.Location = new System.Drawing.Point(27, 37);
            this.buttonApple.Name = "buttonApple";
            this.buttonApple.Size = new System.Drawing.Size(134, 60);
            this.buttonApple.TabIndex = 4;
            this.buttonApple.Text = "Vender Iphone (F1)";
            this.buttonApple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonApple.UseVisualStyleBackColor = false;
            this.buttonApple.Click += new System.EventHandler(this.ButtonApple_Click);
            // 
            // FormVendaProdutoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(345, 135);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.buttonApple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVendaProdutoTipo";
            this.Text = "FormVendaProdutoTipo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProduto;
        private System.Windows.Forms.Button buttonApple;
    }
}