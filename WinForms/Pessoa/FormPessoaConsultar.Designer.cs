namespace WinForms
{
    partial class FormPessoaConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPesquisarCliente = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPesquisar = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.pictureBoxLoad = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPesquisarCliente
            // 
            this.dataGridViewPesquisarCliente.AllowUserToAddRows = false;
            this.dataGridViewPesquisarCliente.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.ColNome,
            this.ColEmail,
            this.ColTel});
            this.dataGridViewPesquisarCliente.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewPesquisarCliente.Name = "dataGridViewPesquisarCliente";
            this.dataGridViewPesquisarCliente.ReadOnly = true;
            this.dataGridViewPesquisarCliente.RowHeadersWidth = 10;
            this.dataGridViewPesquisarCliente.Size = new System.Drawing.Size(1090, 461);
            this.dataGridViewPesquisarCliente.TabIndex = 3;
            this.dataGridViewPesquisarCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisarCliente_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "pssid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "000000";
            this.colId.DefaultCellStyle = dataGridViewCellStyle4;
            this.colId.HeaderText = "Id:";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 75;
            // 
            // ColNome
            // 
            this.ColNome.DataPropertyName = "pssnome";
            this.ColNome.HeaderText = "Nome:";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 475;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "pssemail";
            this.ColEmail.HeaderText = "Email:";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 300;
            // 
            // ColTel
            // 
            this.ColTel.DataPropertyName = "psstelefone";
            this.ColTel.HeaderText = "Telefone:";
            this.ColTel.Name = "ColTel";
            this.ColTel.ReadOnly = true;
            this.ColTel.Width = 200;
            // 
            // labelPesquisar
            // 
            this.labelPesquisar.AutoSize = true;
            this.labelPesquisar.Location = new System.Drawing.Point(12, 38);
            this.labelPesquisar.Name = "labelPesquisar";
            this.labelPesquisar.Size = new System.Drawing.Size(218, 13);
            this.labelPesquisar.TabIndex = 0;
            this.labelPesquisar.Text = "Pesquisar por: id, nome, cpf, e-mail, telefone,";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(12, 54);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(1034, 20);
            this.textBoxPesquisar.TabIndex = 1;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(1017, 547);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelecionar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSelecionar.Location = new System.Drawing.Point(903, 547);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(108, 40);
            this.buttonSelecionar.TabIndex = 4;
            this.buttonSelecionar.Text = "&Selecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::WinForms.Properties.Resources.icons8_Filter_32;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Location = new System.Drawing.Point(1052, 53);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(28, 20);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // pictureBoxLoad
            // 
            this.pictureBoxLoad.Image = global::WinForms.Properties.Resources.load;
            this.pictureBoxLoad.Location = new System.Drawing.Point(12, 547);
            this.pictureBoxLoad.Name = "pictureBoxLoad";
            this.pictureBoxLoad.Size = new System.Drawing.Size(53, 40);
            this.pictureBoxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoad.TabIndex = 7;
            this.pictureBoxLoad.TabStop = false;
            this.pictureBoxLoad.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1090, 29);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Consultar ";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPessoaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 599);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLoad);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.labelPesquisar);
            this.Controls.Add(this.dataGridViewPesquisarCliente);
            this.KeyPreview = true;
            this.Name = "FormPessoaConsultar";
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.FormClienteConsultar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClienteConsultar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPesquisarCliente;
        private System.Windows.Forms.Label labelPesquisar;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.PictureBox pictureBoxLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.Label labelTitle;
    }
}