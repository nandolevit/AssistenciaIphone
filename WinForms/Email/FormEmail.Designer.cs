namespace WinForms
{
    partial class FormEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmail));
            this.textBoxPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCCo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAnexo = new System.Windows.Forms.Button();
            this.buttonCCo = new System.Windows.Forms.Button();
            this.buttonCC = new System.Windows.Forms.Button();
            this.buttonTo = new System.Windows.Forms.Button();
            this.listBoxAnexo = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPara
            // 
            this.textBoxPara.Location = new System.Drawing.Point(110, 31);
            this.textBoxPara.Name = "textBoxPara";
            this.textBoxPara.Size = new System.Drawing.Size(681, 20);
            this.textBoxPara.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para:";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonEnviar.FlatAppearance.BorderSize = 0;
            this.buttonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviar.ForeColor = System.Drawing.Color.White;
            this.buttonEnviar.Location = new System.Drawing.Point(13, 12);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(91, 123);
            this.buttonEnviar.TabIndex = 0;
            this.buttonEnviar.Text = "ENVIAR";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.ButtonEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CCo:";
            // 
            // textBoxCCo
            // 
            this.textBoxCCo.Location = new System.Drawing.Point(110, 115);
            this.textBoxCCo.Name = "textBoxCCo";
            this.textBoxCCo.Size = new System.Drawing.Size(681, 20);
            this.textBoxCCo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CC:";
            // 
            // textBoxCC
            // 
            this.textBoxCC.Location = new System.Drawing.Point(110, 73);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(681, 20);
            this.textBoxCC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Assunto:";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(12, 157);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(805, 20);
            this.textBoxAssunto.TabIndex = 11;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 196);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(805, 283);
            this.textBoxMessage.TabIndex = 12;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.TextBoxMessage_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(169, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(622, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Caso deseje enviar para mais de 1 e-mail, separar os e-mails por ponto e vírgula " +
    "\';\' = (exemplo: email@email.com;novo@email.com)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mensagem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Anexos:";
            // 
            // buttonAnexo
            // 
            this.buttonAnexo.BackgroundImage = global::WinForms.Properties.Resources.icons8_Attach_32;
            this.buttonAnexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnexo.Location = new System.Drawing.Point(778, 498);
            this.buttonAnexo.Name = "buttonAnexo";
            this.buttonAnexo.Size = new System.Drawing.Size(39, 69);
            this.buttonAnexo.TabIndex = 17;
            this.buttonAnexo.UseVisualStyleBackColor = true;
            this.buttonAnexo.Click += new System.EventHandler(this.ButtonAnexo_Click);
            // 
            // buttonCCo
            // 
            this.buttonCCo.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonCCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCCo.FlatAppearance.BorderSize = 0;
            this.buttonCCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCCo.Location = new System.Drawing.Point(797, 115);
            this.buttonCCo.Name = "buttonCCo";
            this.buttonCCo.Size = new System.Drawing.Size(20, 20);
            this.buttonCCo.TabIndex = 9;
            this.buttonCCo.UseVisualStyleBackColor = true;
            this.buttonCCo.Click += new System.EventHandler(this.ButtonCCo_Click);
            // 
            // buttonCC
            // 
            this.buttonCC.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCC.FlatAppearance.BorderSize = 0;
            this.buttonCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCC.Location = new System.Drawing.Point(797, 73);
            this.buttonCC.Name = "buttonCC";
            this.buttonCC.Size = new System.Drawing.Size(20, 20);
            this.buttonCC.TabIndex = 6;
            this.buttonCC.UseVisualStyleBackColor = true;
            this.buttonCC.Click += new System.EventHandler(this.ButtonCC_Click);
            // 
            // buttonTo
            // 
            this.buttonTo.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTo.FlatAppearance.BorderSize = 0;
            this.buttonTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTo.Location = new System.Drawing.Point(797, 31);
            this.buttonTo.Name = "buttonTo";
            this.buttonTo.Size = new System.Drawing.Size(20, 20);
            this.buttonTo.TabIndex = 3;
            this.buttonTo.UseVisualStyleBackColor = true;
            this.buttonTo.Click += new System.EventHandler(this.ButtonTo_Click);
            // 
            // listBoxAnexo
            // 
            this.listBoxAnexo.FormattingEnabled = true;
            this.listBoxAnexo.Location = new System.Drawing.Point(12, 498);
            this.listBoxAnexo.Name = "listBoxAnexo";
            this.listBoxAnexo.Size = new System.Drawing.Size(760, 69);
            this.listBoxAnexo.TabIndex = 18;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = global::WinForms.Properties.Resources.icons8_Trash_Can_32;
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(12, 573);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(20, 20);
            this.buttonRemove.TabIndex = 19;
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 609);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxAnexo);
            this.Controls.Add(this.buttonAnexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCCo);
            this.Controls.Add(this.buttonCC);
            this.Controls.Add(this.buttonTo);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCCo);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEmail_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCCo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonTo;
        private System.Windows.Forms.Button buttonCC;
        private System.Windows.Forms.Button buttonCCo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAnexo;
        private System.Windows.Forms.ListBox listBoxAnexo;
        private System.Windows.Forms.Button buttonRemove;
    }
}