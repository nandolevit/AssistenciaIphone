using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjTransfer;
using ObjTransfer.Pessoas;
using Negocios;

namespace WinForms.Pessoa
{
    public partial class FormPessoaCad : Form
    {
        string cpf;
        bool fisica;
        EnumPessoaTipo enumPessoa = new EnumPessoaTipo();
        EnumAssistencia Assistencia = new EnumAssistencia();
        PessoaInfo infoPessoa;
        public PessoaInfo SelecionadoPessoa { get; set; }
        PessoaNegocio negocioPessoa;

        public FormPessoaCad(EnumPessoaTipo tipo, EnumAssistencia assist, bool pfisica = true)
        {
            Inicializar();
            enumPessoa = tipo;
            TipoPessoa(pfisica);
            Assistencia = assist;
        }

        public FormPessoaCad(PessoaInfo pessoa)
        {
            Inicializar();
            infoPessoa = pessoa;
            PreencherFormPessoa();
        }

        public FormPessoaCad(EnumPessoaTipo tipo, bool pfisica)
        {
            Inicializar();
            enumPessoa = tipo;
            TipoPessoa(pfisica);
        }

        public void TipoPessoa(bool pfisica)
        {
            fisica = pfisica;

            if (pfisica)
            {
                maskedTextBoxCpf.Mask = "000,000,000-00";
            }
            else
            {
                labelCpf.Text = "CNPJ:";
                labelNome.Text = "Nome Fantasia:";
                labelNiver.Text = "Fundada em:";

                labelRazao.Visible = true;
                textBoxRazao.Visible = true;

                labelSite.Visible = true;
                textBoxSite.Visible = true;

                labelPontoReferencia.Visible = true;
                textBoxPontoReferencia.Visible = true;

                maskedTextBoxCpf.Mask = "00,000,000/0000-00";
            }

            if (enumPessoa == EnumPessoaTipo.Unidade)
            {
                labelIdent.Visible = true;
                textBoxIdent.Visible = true;
            }
        }

        private void Inicializar()
        {
            InitializeComponent();
            this.AcceptButton = buttonSalvar;
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            if (Form1.Unidade == null)
                Assistencia = EnumAssistencia.Assistencia;
            else
                Assistencia = Form1.Unidade.uniassistencia;

            negocioPessoa = new PessoaNegocio(Form1.Empresa.empconexao, Assistencia);
        }

        private void ButtonEnd_Click(object sender, EventArgs e)
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

        private void ButtonAddNiver_Click(object sender, EventArgs e)
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

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposObrigatorios())
            {
                PreencherPessoaInfo();

                if (infoPessoa.Id == 0)
                {
                    if (FormMessage.ShowMessegeQuestion("Deseja salvar este registro?") == DialogResult.Yes)
                    {
                        infoPessoa.Id = negocioPessoa.InsertPessoa(infoPessoa);
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

            infoPessoa.Endereco = new EnderecoInfo
            {
                Bairro = textBoxBairro.Text,
                Cep = maskedTextBoxCep.Text,
                Cidade = textBoxCidade.Text,
                Complemento = textBoxComplemento.Text,
                Logradouro = textBoxLogradouro.Text,
                Uf = textBoxUF.Text,
            };

            infoPessoa.Ident = maskedTextBoxCpf.Text;
            infoPessoa.Email = textBoxEmail.Text;
            infoPessoa.Nome = textBoxNome.Text;
            infoPessoa.Telefone = maskedTextBoxTel1.Text + (string.IsNullOrEmpty(maskedTextBoxTel2.Text) ? "" : "/" + maskedTextBoxTel2.Text);

            infoPessoa.User = Form1.User == null ? new UserInfo() : Form1.User;
            infoPessoa.Tipo = enumPessoa;
            infoPessoa.Nascimento = string.IsNullOrEmpty(textBoxNiver.Text) ? DateTime.Now.Date : Convert.ToDateTime(textBoxNiver.Text).Date;
            infoPessoa.booPF = fisica;
            SelecionadoPessoa = infoPessoa;
        }

        private void MaskedTextBoxCpf_Leave(object sender, EventArgs e)
        {

            if (infoPessoa == null || string.IsNullOrEmpty(infoPessoa.Ident))
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
                            if (!infoPessoa.booPF)
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
        }
        private void ConsultarCpf()
        {
            if (infoPessoa == null)
            {
                infoPessoa = negocioPessoa.ConsultarPessoaCpf(cpf);

                if (infoPessoa != null)
                {
                    if (FormMessage.ShowMessegeQuestion("Cliente: " + infoPessoa.Nome + " já está cadastrada com este CPF/CNPJ. Deseja abrir este registro?") == DialogResult.Yes)
                        PreencherFormPessoa();
                    else
                    {
                        infoPessoa = null;
                        LimparForm();
                    }
                }
            }
        }

        private void PreencherFormPessoa()
        {
            TipoPessoa(infoPessoa.booPF);

            textBoxId.Text = string.Format("{0:00000}", infoPessoa.Id);
            maskedTextBoxCpf.Text = infoPessoa.Ident;

            if (!string.IsNullOrEmpty(infoPessoa.Ident))
                maskedTextBoxCpf.ReadOnly = true;

            textBoxEmail.Text = infoPessoa.Email;
            textBoxNome.Text = infoPessoa.Nome;
            textBoxNiver.Text = infoPessoa.Nascimento.Date.ToShortDateString();

            string[] tel = infoPessoa.Telefone.Split('/');

            if (tel.Length > 1)
            {
                maskedTextBoxTel1.Text = tel[0];
                maskedTextBoxTel2.Text = tel[1];
            }
            else
                maskedTextBoxTel1.Text = tel[0];

            textBoxBairro.Text = infoPessoa.Endereco.Bairro;
            maskedTextBoxCep.Text = infoPessoa.Endereco.Cep;
            textBoxCidade.Text = infoPessoa.Endereco.Cidade;
            textBoxComplemento.Text = infoPessoa.Endereco.Complemento;
            textBoxLogradouro.Text = infoPessoa.Endereco.Logradouro;
            textBoxUF.Text = infoPessoa.Endereco.Uf;
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            if (this.Modal)
                this.DialogResult = DialogResult.Cancel;
            else
                this.Close();
        }
    }
}
