namespace WinForms.Aparelho
{
    partial class FormAparelhoMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAparelhoMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSeta = new System.Windows.Forms.Panel();
            this.buttonMac = new System.Windows.Forms.Button();
            this.buttonWin = new System.Windows.Forms.Button();
            this.buttonSmart = new System.Windows.Forms.Button();
            this.buttonIphone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.panelSeta);
            this.panelMenu.Controls.Add(this.buttonMac);
            this.panelMenu.Controls.Add(this.buttonWin);
            this.panelMenu.Controls.Add(this.buttonSmart);
            this.panelMenu.Controls.Add(this.buttonIphone);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(185, 575);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSeta
            // 
            this.panelSeta.BackColor = System.Drawing.Color.Maroon;
            this.panelSeta.Location = new System.Drawing.Point(172, 81);
            this.panelSeta.Name = "panelSeta";
            this.panelSeta.Size = new System.Drawing.Size(10, 51);
            this.panelSeta.TabIndex = 2;
            // 
            // buttonMac
            // 
            this.buttonMac.FlatAppearance.BorderSize = 0;
            this.buttonMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMac.ForeColor = System.Drawing.Color.White;
            this.buttonMac.Image = ((System.Drawing.Image)(resources.GetObject("buttonMac.Image")));
            this.buttonMac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMac.Location = new System.Drawing.Point(4, 252);
            this.buttonMac.Name = "buttonMac";
            this.buttonMac.Size = new System.Drawing.Size(175, 51);
            this.buttonMac.TabIndex = 4;
            this.buttonMac.Text = "    Mac PCs";
            this.buttonMac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMac.UseVisualStyleBackColor = true;
            this.buttonMac.Click += new System.EventHandler(this.ButtonMac_Click);
            // 
            // buttonWin
            // 
            this.buttonWin.FlatAppearance.BorderSize = 0;
            this.buttonWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWin.ForeColor = System.Drawing.Color.White;
            this.buttonWin.Image = ((System.Drawing.Image)(resources.GetObject("buttonWin.Image")));
            this.buttonWin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWin.Location = new System.Drawing.Point(4, 195);
            this.buttonWin.Name = "buttonWin";
            this.buttonWin.Size = new System.Drawing.Size(175, 51);
            this.buttonWin.TabIndex = 3;
            this.buttonWin.Text = "    Windows PCs";
            this.buttonWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWin.UseVisualStyleBackColor = true;
            this.buttonWin.Click += new System.EventHandler(this.ButtonWin_Click);
            // 
            // buttonSmart
            // 
            this.buttonSmart.FlatAppearance.BorderSize = 0;
            this.buttonSmart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSmart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSmart.ForeColor = System.Drawing.Color.White;
            this.buttonSmart.Image = ((System.Drawing.Image)(resources.GetObject("buttonSmart.Image")));
            this.buttonSmart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSmart.Location = new System.Drawing.Point(4, 138);
            this.buttonSmart.Name = "buttonSmart";
            this.buttonSmart.Size = new System.Drawing.Size(175, 51);
            this.buttonSmart.TabIndex = 2;
            this.buttonSmart.Text = "          SmartPhone/Tablet";
            this.buttonSmart.UseVisualStyleBackColor = true;
            this.buttonSmart.Click += new System.EventHandler(this.ButtonSmart_Click);
            // 
            // buttonIphone
            // 
            this.buttonIphone.FlatAppearance.BorderSize = 0;
            this.buttonIphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIphone.ForeColor = System.Drawing.Color.White;
            this.buttonIphone.Image = ((System.Drawing.Image)(resources.GetObject("buttonIphone.Image")));
            this.buttonIphone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIphone.Location = new System.Drawing.Point(4, 81);
            this.buttonIphone.Name = "buttonIphone";
            this.buttonIphone.Size = new System.Drawing.Size(175, 51);
            this.buttonIphone.TabIndex = 1;
            this.buttonIphone.Text = "iPhone/iPad";
            this.buttonIphone.UseVisualStyleBackColor = true;
            this.buttonIphone.Click += new System.EventHandler(this.ButtonIphone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE APARELHOS";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Maroon;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(185, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(765, 33);
            this.panelTitle.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Gray;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(185, 33);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(765, 542);
            this.panelPrincipal.TabIndex = 2;
            // 
            // FormAparelhoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 575);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormAparelhoMenu";
            this.Text = "FormAparelhoMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAparelhoMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormAparelhoMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonIphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonSmart;
        private System.Windows.Forms.Panel panelSeta;
        private System.Windows.Forms.Button buttonMac;
        private System.Windows.Forms.Button buttonWin;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}