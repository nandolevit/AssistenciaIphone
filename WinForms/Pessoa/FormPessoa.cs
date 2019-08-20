using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ObjTransfer;
using Negocios;
using System.Diagnostics;

namespace WinForms
{
    public partial class FormPessoa : Form
    {
        Form1 form1 = new Form1();
        string cpf;

        EnumPessoaTipo enumPessoa = new EnumPessoaTipo();
        EnumAssistencia Assistencia = new EnumAssistencia();
        PessoaInfo infoPessoa;
        public PessoaInfo SelecionadoPessoa { get; set; }
        PessoaNegocio negocioPessoa;

        public FormPessoa(EnumPessoaTipo pessoa, EnumAssistencia assistencia)
        {
            Inicializar();
            enumPessoa = pessoa;
            labelTitle.Text = pessoa.ToString();
            Assistencia = assistencia;
        }

        public FormPessoa(EnumPessoaTipo pessoa)
        {
            Inicializar();
            enumPessoa = pessoa;
            labelTitle.Text = pessoa.ToString();
        }

        public FormPessoa(PessoaInfo pessoa)
        {
            Inicializar();
            infoPessoa = pessoa;
            PreencherFormPessoa();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonSalvar;
            Assistencia = Form1.Unidade.uniassistencia;
            negocioPessoa = new ClienteNegocios(Form1.Empresa.empconexao, Assistencia);
        }

        private void PreencherFormClienteTeste()
        {
            textBoxId.Text = "0";
            maskedTextBoxCpf.Text = "66440141000133";
            textBoxEmail.Text = "faleconosco@lauraebetinafilmagensltda.com.br";
            textBoxNome.Text = "Laura e Betina Filmagens Ltda";
            textBoxNiver.Text = "06/12/1987";

            maskedTextBoxTel1.Text = "7528634952";
            maskedTextBoxTel2.Text = "75983967082";

            textBoxBairro.Text = "Santo Antônio dos Prazeres";
            maskedTextBoxCep.Text = "44071700";
            textBoxCidade.Text = "Feira de Santana";
            textBoxComplemento.Text = "Santo Antônio dos Prazeres";
            textBoxLogradouro.Text = "2ª Travessa Quito";
            textBoxUF.Text = "ba";
        }

        private void PreencherFormPessoa()
        {
            textBoxId.Text = string.Format("{0:00000}", infoPessoa.pssid);
            maskedTextBoxCpf.Text = infoPessoa.psscpf;
            textBoxEmail.Text = infoPessoa.pssemail;
            textBoxNome.Text = infoPessoa.pssnome;
            textBoxNiver.Text = infoPessoa.pssniver.Date.ToShortDateString();

            string[] tel = infoPessoa.psstelefone.Split('/');

            if (tel.Length > 1)
            {
                maskedTextBoxTel1.Text = tel[0];
                maskedTextBoxTel2.Text = tel[1];
            }
            else
                maskedTextBoxTel1.Text = tel[0];

            textBoxBairro.Text = infoPessoa.pssendbairro;
            maskedTextBoxCep.Text = infoPessoa.pssendcep;
            textBoxCidade.Text = infoPessoa.pssendcidade;
            textBoxComplemento.Text = infoPessoa.pssendcomplemento;
            textBoxLogradouro.Text = infoPessoa.pssendlogradouro;
            textBoxUF.Text = infoPessoa.pssenduf;
        }

        private bool CamposObrigatorios()
        {
            string Nome, Tel, Email, Cpf;
            Nome = textBoxNome.Text.Trim();
            Tel = maskedTextBoxTel1.Text.Trim();
            Email = textBoxEmail.Text.Trim();
            Cpf = maskedTextBoxCpf.Text;

            switch (enumPessoa)
            {
                case EnumPessoaTipo.Cliente:

                    if (String.IsNullOrEmpty(Nome) || String.IsNullOrEmpty(Tel) || String.IsNullOrEmpty(Email))
                    {
                        if (String.IsNullOrEmpty(Nome))
                            labelNome.ForeColor = Color.Red;

                        if (String.IsNullOrEmpty(Tel))
                            labelTel.ForeColor = Color.Red;

                        if (String.IsNullOrEmpty(Email))
                            labelEmail.ForeColor = Color.Red;

                        MessageBox.Show("Todos os campos, em vermelho, devem ser preenchidos!", "ADVERTÊNCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }
                    else
                        return true;

                case EnumPessoaTipo.Funcionario:

                    if (textBoxEmail.Text == "sem@email.com")
                    {
                        FormMessage.ShowMessegeWarning("Insira um email válido!");
                        textBoxEmail.Select();
                        return false;
                    }

                    if (String.IsNullOrEmpty(Nome) || String.IsNullOrEmpty(Cpf))
                    {
                        if (String.IsNullOrEmpty(Nome))
                            labelNome.ForeColor = Color.Red;

                        if (String.IsNullOrEmpty(Cpf))
                            labelCpf.ForeColor = Color.Red;

                        if (String.IsNullOrEmpty(Email))
                            labelEmail.ForeColor = Color.Red;

                        MessageBox.Show("Todos os campos, em vermelho, devem ser preenchidos!", "ADVERTÊNCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }
                    else
                        return true;

                case EnumPessoaTipo.Fornecedor:

                    if (String.IsNullOrEmpty(Nome))
                    {
                        if (String.IsNullOrEmpty(Nome))
                            labelNome.ForeColor = Color.Red;

                        MessageBox.Show("Todos os campos, em vermelho, devem ser preenchidos!", "ADVERTÊNCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }
                    else
                        return true;

                default:
                    return false;
            }
        }

        private void LimparForm()
        {
            textBoxId.Clear();
            maskedTextBoxCpf.Clear();
            textBoxEmail.Clear();
            textBoxNome.Clear();
            textBoxNiver.Clear();

            maskedTextBoxTel1.Clear();
            maskedTextBoxTel2.Clear();

            textBoxBairro.Clear();
            maskedTextBoxCep.Clear();
            textBoxCidade.Clear();
            textBoxComplemento.Clear();
            textBoxLogradouro.Clear();
            textBoxUF.Clear();

            maskedTextBoxCpf.Select();
        }

        private void PreencherPessoaInfo()
        {
            if (infoPessoa == null)
                infoPessoa = new PessoaInfo();

            infoPessoa.pssendbairro = textBoxBairro.Text;
            infoPessoa.pssendcep = maskedTextBoxCep.Text;
            infoPessoa.pssendcidade = textBoxCidade.Text;
            infoPessoa.psscpf = maskedTextBoxCpf.Text;
            infoPessoa.pssendcomplemento = textBoxComplemento.Text;
            infoPessoa.pssemail = textBoxEmail.Text;
            infoPessoa.pssendlogradouro = textBoxLogradouro.Text;
            infoPessoa.pssnome = textBoxNome.Text;
            infoPessoa.psstelefone = maskedTextBoxTel1.Text + (string.IsNullOrEmpty(maskedTextBoxTel2.Text) ? "" : "/" + maskedTextBoxTel2.Text);
            infoPessoa.pssenduf = textBoxUF.Text;
            infoPessoa.pssiduser = Form1.User == null ? 0 : Form1.User.useidfuncionario;
            infoPessoa.pssidtipo = enumPessoa;
            infoPessoa.pssniver = string.IsNullOrEmpty(textBoxNiver.Text) ? DateTime.Now.Date : Convert.ToDateTime(textBoxNiver.Text).Date;

            SelecionadoPessoa = infoPessoa;
        }



        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposObrigatorios())
            {
                PreencherPessoaInfo();

                if (infoPessoa.pssid == 0)
                {
                    if (FormMessage.ShowMessegeQuestion("Deseja salvar este registro?") == DialogResult.Yes)
                    {
                        infoPessoa.pssid = negocioPessoa.InsertPessoa(infoPessoa);
                        SelecionadoPessoa = infoPessoa;
                        FormMessage.ShowMessegeInfo("Registro salvo com sucesso!");

                        if (enumPessoa == EnumPessoaTipo.Funcionario)
                            FormMessage.ShowMessegeInfo("O usuário e senha foram criados, no primeiro acesso deverá ser utilizado o CPF como LOGIN/SENHA!");

                        if (this.Modal)
                            this.DialogResult = DialogResult.Yes;
                        else
                            this.Close();
                    }
                }
                else
                {
                    if (FormMessage.ShowMessegeQuestion("Deseja salvar as alterações para este registro?") == DialogResult.Yes)
                    {
                        negocioPessoa.UpdatePessoa(infoPessoa);
                        FormMessage.ShowMessegeInfo("Alterações realizadas com sucesso!");
                        this.DialogResult = DialogResult.OK;
                    }
                }

            }
        }



        private void linkLabelCep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("http://www.buscacep.correios.com.br/sistemas/buscacep/");
        }

        private void maskedTextBoxCpf_Leave(object sender, EventArgs e)
        {

            cpf = maskedTextBoxCpf.Text;


            //preencher o formulário com os meus dados para testes
            if (cpf == "71992776512")
            {
                PreencherFormClienteTeste();
                return;
            }

            ValidarCpfCnpj validarCpfCnpj = new ValidarCpfCnpj(cpf);

            if (cpf != "00000000000")
            {
                if (maskedTextBoxCpf.Text.Length >= 11)
                {
                    if (validarCpfCnpj.CpfCpnjValido())
                        ConsultarCpf();
                    else
                    {
                        if (radioButtonCnpj.Checked)
                            FormMessage.ShowMessegeWarning("CNPJ inválido! Tente novamente...");
                        else
                            FormMessage.ShowMessegeWarning("CPF inválido! Tente novamente...");

                        maskedTextBoxCpf.Clear();
                        maskedTextBoxCpf.Focus();
                    }
                }
                else
                    maskedTextBoxCpf.Clear();
            }
        }
        private void ConsultarCpf()
        {
            if (infoPessoa == null)
            {
                infoPessoa = negocioPessoa.ConsultarPessoaCpf(cpf);

                if (infoPessoa != null)
                {
                    if (FormMessage.ShowMessegeQuestion("Cliente: " + infoPessoa.pssnome + " já está cadastrada com este CPF/CNPJ. Deseja abrir este registro?") == DialogResult.Yes)
                        PreencherFormPessoa();
                    else
                    {
                        infoPessoa = null;
                        LimparForm();
                    }
                }
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            if (this.Modal)
                this.DialogResult = DialogResult.Cancel;
            else
                this.Close();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            CepInfo cepInfo = new CepInfo();

            cepInfo = negocioPessoa.ConsultarCep(maskedTextBoxCep.Text);

            if (cepInfo != null)
            {
                textBoxLogradouro.Text = cepInfo.Logradouro;
                textBoxBairro.Text = cepInfo.Bairro;
                textBoxCidade.Text = cepInfo.Cidade;
                textBoxUF.Text = cepInfo.Uf;
                textBoxComplemento.Select();
            }
            else
            {
                FormMessage.ShowMessegeWarning("CEP não encontrado, tente outro CEP!");
            }
        }
        private void buttonAddNiver_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            formAddData.ShowDialog(this);
            formAddData.Dispose();

            if (formAddData.DialogResult == DialogResult.Yes)
            {
                DateTime data = Convert.ToDateTime(formAddData.textoData);
                textBoxNiver.Text = data.ToString("ddd, dd 'de' MMMM 'de' yyyy").ToUpper();
                maskedTextBoxCep.Select();
            }

        }

        private void FormCadastroPessoa_Load(object sender, EventArgs e)
        {
            maskedTextBoxCpf.Select();
            maskedTextBoxCpf.Mask = "000.000.000-00";
        }

        private void RadioButtonCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCpf.Checked)
            {
                maskedTextBoxCpf.Mask = "000.000.000-00";
                labelCpf.Text = "CPF:";
            }
            else
            {
                maskedTextBoxCpf.Mask = "00.000.000/0000-00";
                labelCpf.Text = "CNPJ:";
            }

            maskedTextBoxCpf.Select();
        }
    }
}
