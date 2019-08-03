namespace WinForms
{
    partial class FormPessoa
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxEnd = new System.Windows.Forms.GroupBox();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.linkLabelCep = new System.Windows.Forms.LinkLabel();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.labelUf = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.radioButtonCnpj = new System.Windows.Forms.RadioButton();
            this.radioButtonCpf = new System.Windows.Forms.RadioButton();
            this.buttonAddNiver = new System.Windows.Forms.Button();
            this.textBoxNiver = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelNiver = new System.Windows.Forms.Label();
            this.maskedTextBoxTel2 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTel1 = new System.Windows.Forms.MaskedTextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLoad = new System.Windows.Forms.PictureBox();
            this.groupBoxEnd.SuspendLayout();
            this.groupBoxDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEnd
            // 
            this.groupBoxEnd.Controls.Add(this.buttonEnd);
            this.groupBoxEnd.Controls.Add(this.linkLabelCep);
            this.groupBoxEnd.Controls.Add(this.textBoxUF);
            this.groupBoxEnd.Controls.Add(this.labelUf);
            this.groupBoxEnd.Controls.Add(this.textBoxCidade);
            this.groupBoxEnd.Controls.Add(this.labelCidade);
            this.groupBoxEnd.Controls.Add(this.textBoxBairro);
            this.groupBoxEnd.Controls.Add(this.labelBairro);
            this.groupBoxEnd.Controls.Add(this.textBoxLogradouro);
            this.groupBoxEnd.Controls.Add(this.labelLogradouro);
            this.groupBoxEnd.Controls.Add(this.maskedTextBoxCep);
            this.groupBoxEnd.Controls.Add(this.labelCep);
            this.groupBoxEnd.Controls.Add(this.textBoxComplemento);
            this.groupBoxEnd.Controls.Add(this.labelComplemento);
            this.groupBoxEnd.Location = new System.Drawing.Point(12, 196);
            this.groupBoxEnd.Name = "groupBoxEnd";
            this.groupBoxEnd.Size = new System.Drawing.Size(524, 229);
            this.groupBoxEnd.TabIndex = 2;
            this.groupBoxEnd.TabStop = false;
            this.groupBoxEnd.Text = "Endereço:";
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackgroundImage = global::WinForms.Properties.Resources.consultar_cep;
            this.buttonEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEnd.FlatAppearance.BorderSize = 0;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(103, 21);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(93, 37);
            this.buttonEnd.TabIndex = 2;
            this.buttonEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonEnd, "Consultar o cep.");
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // linkLabelCep
            // 
            this.linkLabelCep.AutoSize = true;
            this.linkLabelCep.Location = new System.Drawing.Point(453, 37);
            this.linkLabelCep.Name = "linkLabelCep";
            this.linkLabelCep.Size = new System.Drawing.Size(62, 13);
            this.linkLabelCep.TabIndex = 3;
            this.linkLabelCep.TabStop = true;
            this.linkLabelCep.Text = "Buscar Cep";
            this.toolTip1.SetToolTip(this.linkLabelCep, "Encontrar o cep para um endereço.");
            this.linkLabelCep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCep_LinkClicked);
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(422, 195);
            this.textBoxUF.MaxLength = 2;
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(93, 20);
            this.textBoxUF.TabIndex = 12;
            this.textBoxUF.TabStop = false;
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Location = new System.Drawing.Point(422, 182);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(24, 13);
            this.labelUf.TabIndex = 13;
            this.labelUf.Text = "UF:";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(14, 195);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(402, 20);
            this.textBoxCidade.TabIndex = 11;
            this.textBoxCidade.TabStop = false;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(14, 182);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 10;
            this.labelCidade.Text = "Cidade:";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(14, 162);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(501, 20);
            this.textBoxBairro.TabIndex = 9;
            this.textBoxBairro.TabStop = false;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(14, 149);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(37, 13);
            this.labelBairro.TabIndex = 8;
            this.labelBairro.Text = "Bairro:";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(14, 129);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(501, 20);
            this.textBoxLogradouro.TabIndex = 7;
            this.textBoxLogradouro.TabStop = false;
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(14, 116);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(64, 13);
            this.labelLogradouro.TabIndex = 6;
            this.labelLogradouro.Text = "Logradouro:";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(14, 30);
            this.maskedTextBoxCep.Mask = "00,000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(83, 20);
            this.maskedTextBoxCep.TabIndex = 1;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(14, 17);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(31, 13);
            this.labelCep.TabIndex = 0;
            this.labelCep.Text = "CEP:";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(14, 63);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(501, 20);
            this.textBoxComplemento.TabIndex = 5;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(14, 50);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(74, 13);
            this.labelComplemento.TabIndex = 4;
            this.labelComplemento.Text = "Complemento:";
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.Controls.Add(this.radioButtonCnpj);
            this.groupBoxDadosPessoais.Controls.Add(this.radioButtonCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.buttonAddNiver);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNiver);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.labelNiver);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxTel2);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxId);
            this.groupBoxDadosPessoais.Controls.Add(this.maskedTextBoxTel1);
            this.groupBoxDadosPessoais.Controls.Add(this.labelCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.labelTel);
            this.groupBoxDadosPessoais.Controls.Add(this.labelNome);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxNome);
            this.groupBoxDadosPessoais.Controls.Add(this.labelId);
            this.groupBoxDadosPessoais.Controls.Add(this.labelEmail);
            this.groupBoxDadosPessoais.Controls.Add(this.textBoxEmail);
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(12, 48);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(524, 142);
            this.groupBoxDadosPessoais.TabIndex = 1;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados Pessoais";
            // 
            // radioButtonCnpj
            // 
            this.radioButtonCnpj.AutoSize = true;
            this.radioButtonCnpj.Location = new System.Drawing.Point(165, 34);
            this.radioButtonCnpj.Name = "radioButtonCnpj";
            this.radioButtonCnpj.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCnpj.TabIndex = 3;
            this.radioButtonCnpj.Text = "CNPJ";
            this.radioButtonCnpj.UseVisualStyleBackColor = true;
            // 
            // radioButtonCpf
            // 
            this.radioButtonCpf.AutoSize = true;
            this.radioButtonCpf.Checked = true;
            this.radioButtonCpf.Location = new System.Drawing.Point(114, 33);
            this.radioButtonCpf.Name = "radioButtonCpf";
            this.radioButtonCpf.Size = new System.Drawing.Size(45, 17);
            this.radioButtonCpf.TabIndex = 2;
            this.radioButtonCpf.TabStop = true;
            this.radioButtonCpf.Text = "CPF";
            this.radioButtonCpf.UseVisualStyleBackColor = true;
            this.radioButtonCpf.CheckedChanged += new System.EventHandler(this.RadioButtonCpf_CheckedChanged);
            // 
            // buttonAddNiver
            // 
            this.buttonAddNiver.BackgroundImage = global::WinForms.Properties.Resources.icons8_Add_New_32;
            this.buttonAddNiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddNiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNiver.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddNiver.Location = new System.Drawing.Point(494, 72);
            this.buttonAddNiver.Name = "buttonAddNiver";
            this.buttonAddNiver.Size = new System.Drawing.Size(24, 23);
            this.buttonAddNiver.TabIndex = 10;
            this.toolTip1.SetToolTip(this.buttonAddNiver, "Adicionar data de nascimento.");
            this.buttonAddNiver.UseVisualStyleBackColor = true;
            this.buttonAddNiver.Click += new System.EventHandler(this.buttonAddNiver_Click);
            // 
            // textBoxNiver
            // 
            this.textBoxNiver.Location = new System.Drawing.Point(381, 72);
            this.textBoxNiver.Name = "textBoxNiver";
            this.textBoxNiver.ReadOnly = true;
            this.textBoxNiver.Size = new System.Drawing.Size(107, 20);
            this.textBoxNiver.TabIndex = 9;
            this.textBoxNiver.TabStop = false;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(223, 32);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBoxCpf.TabIndex = 5;
            this.maskedTextBoxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxCpf.Leave += new System.EventHandler(this.maskedTextBoxCpf_Leave);
            // 
            // labelNiver
            // 
            this.labelNiver.AutoSize = true;
            this.labelNiver.Location = new System.Drawing.Point(381, 56);
            this.labelNiver.Name = "labelNiver";
            this.labelNiver.Size = new System.Drawing.Size(107, 13);
            this.labelNiver.TabIndex = 8;
            this.labelNiver.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxTel2
            // 
            this.maskedTextBoxTel2.Location = new System.Drawing.Point(114, 112);
            this.maskedTextBoxTel2.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxTel2.Name = "maskedTextBoxTel2";
            this.maskedTextBoxTel2.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBoxTel2.TabIndex = 13;
            this.maskedTextBoxTel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(13, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(95, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TabStop = false;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxTel1
            // 
            this.maskedTextBoxTel1.Location = new System.Drawing.Point(13, 112);
            this.maskedTextBoxTel1.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxTel1.Name = "maskedTextBoxTel1";
            this.maskedTextBoxTel1.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBoxTel1.TabIndex = 12;
            this.maskedTextBoxTel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(224, 16);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 13);
            this.labelCpf.TabIndex = 4;
            this.labelCpf.Text = "CPF:";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(13, 96);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(57, 13);
            this.labelTel.TabIndex = 11;
            this.labelTel.Text = "Telefones:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(14, 56);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(13, 72);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(362, 20);
            this.textBoxNome.TabIndex = 7;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(214, 96);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(214, 112);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(301, 20);
            this.textBoxEmail.TabIndex = 15;
            this.textBoxEmail.Text = "sem@email.com";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Image = global::WinForms.Properties.Resources.conf_green;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(359, 431);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(85, 40);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonSalvar, "Salvar novo registro.");
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Image = global::WinForms.Properties.Resources.exit_red;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFechar.Location = new System.Drawing.Point(451, 431);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(85, 40);
            this.buttonFechar.TabIndex = 4;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonFechar, "Fechar formulário.");
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Maroon;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(524, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLoad
            // 
            this.pictureBoxLoad.Image = global::WinForms.Properties.Resources.load;
            this.pictureBoxLoad.Location = new System.Drawing.Point(10, 431);
            this.pictureBoxLoad.Name = "pictureBoxLoad";
            this.pictureBoxLoad.Size = new System.Drawing.Size(53, 40);
            this.pictureBoxLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoad.TabIndex = 7;
            this.pictureBoxLoad.TabStop = false;
            this.pictureBoxLoad.Visible = false;
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 482);
            this.Controls.Add(this.pictureBoxLoad);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.groupBoxEnd);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Name = "FormPessoa";
            this.Text = "FormCadastroPessoa";
            this.Load += new System.EventHandler(this.FormCadastroPessoa_Load);
            this.groupBoxEnd.ResumeLayout(false);
            this.groupBoxEnd.PerformLayout();
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEnd;
        private System.Windows.Forms.LinkLabel linkLabelCep;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label labelUf;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label labelNiver;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel1;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonAddNiver;
        private System.Windows.Forms.TextBox textBoxNiver;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLoad;
        private System.Windows.Forms.RadioButton radioButtonCnpj;
        private System.Windows.Forms.RadioButton radioButtonCpf;
    }
}