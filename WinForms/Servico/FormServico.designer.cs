namespace WinForms
{
    partial class FormServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDefeito = new System.Windows.Forms.Label();
            this.textBoxDefeito = new System.Windows.Forms.TextBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxCodTec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResponsavel = new System.Windows.Forms.TextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxServico = new System.Windows.Forms.GroupBox();
            this.pictureBoxLoad = new System.Windows.Forms.PictureBox();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.textBoxCaracteristica = new System.Windows.Forms.TextBox();
            this.buttonAddTec = new System.Windows.Forms.Button();
            this.buttonBuscarTec = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewServico = new System.Windows.Forms.DataGridView();
            this.colOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.groupBoxServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServico)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(9, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(493, 20);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.TabStop = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(6, 16);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(6, 56);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(52, 13);
            this.labelDescricao.TabIndex = 5;
            this.labelDescricao.Text = "Aparelho:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(9, 69);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.ReadOnly = true;
            this.textBoxDescricao.Size = new System.Drawing.Size(720, 39);
            this.textBoxDescricao.TabIndex = 6;
            this.textBoxDescricao.TabStop = false;
            // 
            // labelDefeito
            // 
            this.labelDefeito.AutoSize = true;
            this.labelDefeito.Location = new System.Drawing.Point(6, 111);
            this.labelDefeito.Name = "labelDefeito";
            this.labelDefeito.Size = new System.Drawing.Size(44, 13);
            this.labelDefeito.TabIndex = 8;
            this.labelDefeito.Text = "Defeito:";
            // 
            // textBoxDefeito
            // 
            this.textBoxDefeito.Location = new System.Drawing.Point(9, 124);
            this.textBoxDefeito.Name = "textBoxDefeito";
            this.textBoxDefeito.ReadOnly = true;
            this.textBoxDefeito.Size = new System.Drawing.Size(768, 20);
            this.textBoxDefeito.TabIndex = 9;
            this.textBoxDefeito.TabStop = false;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(540, 33);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerData.TabIndex = 4;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(537, 17);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "&Data:";
            // 
            // textBoxCodTec
            // 
            this.textBoxCodTec.Location = new System.Drawing.Point(9, 410);
            this.textBoxCodTec.Name = "textBoxCodTec";
            this.textBoxCodTec.Size = new System.Drawing.Size(30, 20);
            this.textBoxCodTec.TabIndex = 14;
            this.textBoxCodTec.TextChanged += new System.EventHandler(this.textBoxCodTec_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Técnico Responsável:";
            // 
            // textBoxResponsavel
            // 
            this.textBoxResponsavel.Location = new System.Drawing.Point(86, 411);
            this.textBoxResponsavel.Name = "textBoxResponsavel";
            this.textBoxResponsavel.ReadOnly = true;
            this.textBoxResponsavel.Size = new System.Drawing.Size(438, 20);
            this.textBoxResponsavel.TabIndex = 18;
            this.textBoxResponsavel.TabStop = false;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(6, 183);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(140, 13);
            this.labelObs.TabIndex = 12;
            this.labelObs.Text = "Características do aparelho:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOVA ORDEM DE SERVIÇO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxServico
            // 
            this.groupBoxServico.Controls.Add(this.pictureBoxLoad);
            this.groupBoxServico.Controls.Add(this.textBoxObs);
            this.groupBoxServico.Controls.Add(this.labelEnd);
            this.groupBoxServico.Controls.Add(this.labelNome);
            this.groupBoxServico.Controls.Add(this.textBoxNome);
            this.groupBoxServico.Controls.Add(this.buttonSalvar);
            this.groupBoxServico.Controls.Add(this.buttonCliente);
            this.groupBoxServico.Controls.Add(this.textBoxDescricao);
            this.groupBoxServico.Controls.Add(this.labelDescricao);
            this.groupBoxServico.Controls.Add(this.labelObs);
            this.groupBoxServico.Controls.Add(this.textBoxDefeito);
            this.groupBoxServico.Controls.Add(this.textBoxCaracteristica);
            this.groupBoxServico.Controls.Add(this.labelDefeito);
            this.groupBoxServico.Controls.Add(this.buttonAddTec);
            this.groupBoxServico.Controls.Add(this.dateTimePickerData);
            this.groupBoxServico.Controls.Add(this.buttonBuscarTec);
            this.groupBoxServico.Controls.Add(this.buttonAdd);
            this.groupBoxServico.Controls.Add(this.textBoxCodTec);
            this.groupBoxServico.Controls.Add(this.label2);
            this.groupBoxServico.Controls.Add(this.labelData);
            this.groupBoxServico.Controls.Add(this.textBoxResponsavel);
            this.groupBoxServico.Location = new System.Drawing.Point(12, 50);
            this.groupBoxServico.Name = "groupBoxServico";
            this.groupBoxServico.Size = new System.Drawing.Size(783, 438);
            this.groupBoxServico.TabIndex = 0;
            this.groupBoxServico.TabStop = false;
            this.groupBoxServico.Text = "Serviço:";
            // 
            // pictureBoxLoad
            // 
            this.pictureBoxLoad.Image = global::WinForms.Properties.Resources.load;
            this.pictureBoxLoad.Location = new System.Drawing.Point(633, 392);
            this.pictureBoxLoad.Name = "pictureBoxLoad";
            this.pictureBoxLoad.Size = new System.Drawing.Size(53, 40);
            this.pictureBoxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoad.TabIndex = 6;
            this.pictureBoxLoad.TabStop = false;
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(9, 160);
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.ReadOnly = true;
            this.textBoxObs.Size = new System.Drawing.Size(768, 20);
            this.textBoxObs.TabIndex = 11;
            this.textBoxObs.TabStop = false;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(6, 147);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(73, 13);
            this.labelEnd.TabIndex = 10;
            this.labelEnd.Text = "Observações:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(692, 392);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCliente.BackgroundImage")));
            this.buttonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCliente.Location = new System.Drawing.Point(508, 31);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(26, 23);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.ButtonCliente_Click);
            // 
            // textBoxCaracteristica
            // 
            this.textBoxCaracteristica.Location = new System.Drawing.Point(9, 196);
            this.textBoxCaracteristica.Multiline = true;
            this.textBoxCaracteristica.Name = "textBoxCaracteristica";
            this.textBoxCaracteristica.ReadOnly = true;
            this.textBoxCaracteristica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCaracteristica.Size = new System.Drawing.Size(768, 190);
            this.textBoxCaracteristica.TabIndex = 13;
            this.textBoxCaracteristica.Leave += new System.EventHandler(this.TextBoxObs_Leave);
            // 
            // buttonAddTec
            // 
            this.buttonAddTec.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddTec.Enabled = false;
            this.buttonAddTec.FlatAppearance.BorderSize = 0;
            this.buttonAddTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTec.Location = new System.Drawing.Point(63, 410);
            this.buttonAddTec.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddTec.Name = "buttonAddTec";
            this.buttonAddTec.Size = new System.Drawing.Size(20, 20);
            this.buttonAddTec.TabIndex = 16;
            this.buttonAddTec.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarTec
            // 
            this.buttonBuscarTec.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscarTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscarTec.FlatAppearance.BorderSize = 0;
            this.buttonBuscarTec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarTec.Location = new System.Drawing.Point(43, 410);
            this.buttonBuscarTec.Name = "buttonBuscarTec";
            this.buttonBuscarTec.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarTec.TabIndex = 15;
            this.buttonBuscarTec.UseVisualStyleBackColor = true;
            this.buttonBuscarTec.Click += new System.EventHandler(this.buttonBuscarTec_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_64;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(735, 69);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 39);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewServico
            // 
            this.dataGridViewServico.AllowUserToAddRows = false;
            this.dataGridViewServico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOs,
            this.colDescricao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServico.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServico.Location = new System.Drawing.Point(12, 494);
            this.dataGridViewServico.Name = "dataGridViewServico";
            this.dataGridViewServico.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServico.RowHeadersVisible = false;
            this.dataGridViewServico.Size = new System.Drawing.Size(783, 99);
            this.dataGridViewServico.TabIndex = 1;
            // 
            // colOs
            // 
            this.colOs.DataPropertyName = "serid";
            dataGridViewCellStyle2.Format = "00000";
            this.colOs.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOs.HeaderText = "OS:";
            this.colOs.Name = "colOs";
            this.colOs.ReadOnly = true;
            this.colOs.Width = 75;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "serdescricao";
            this.colDescricao.HeaderText = "Descrição:";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 675;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(710, 599);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click_1);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackgroundImage = global::WinForms.Properties.Resources.icons8_Print_32;
            this.buttonImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.Location = new System.Drawing.Point(651, 600);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(53, 40);
            this.buttonImprimir.TabIndex = 4;
            this.buttonImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Visible = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 660);
            this.Controls.Add(this.groupBoxServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.dataGridViewServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServico_FormClosed);
            this.Load += new System.EventHandler(this.FrmServico_Load);
            this.groupBoxServico.ResumeLayout(false);
            this.groupBoxServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDefeito;
        private System.Windows.Forms.TextBox textBoxDefeito;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAddTec;
        private System.Windows.Forms.Button buttonBuscarTec;
        private System.Windows.Forms.TextBox textBoxCodTec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResponsavel;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxServico;
        private System.Windows.Forms.DataGridView dataGridViewServico;
        private System.Windows.Forms.TextBox textBoxCaracteristica;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.PictureBox pictureBoxLoad;
    }
}