using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormIphoneModelo : Form
    {
        IphoneModeloColecao colecaoIphone;
        IphoneModeloColecao colecaoIpad;
        IphoneModeloInfo infoIphone;
        IphoneModeloCorColecao colecaoCor;
        IphoneModeloCorColecao colecaoCorSelecionada;
        IphoneCelularInfo infoCelular;
        public IphoneCelularInfo SelecionadoIphone { get; set; }
        public IphoneModeloCorInfo SelecionadaFoto { get; set; }
        int cod = 0;

        public FormIphoneModelo()
        {
            Inicializar();
        }

        //public FormIphoneModelo(PessoaInfo cliente)
        //{
        //    Inicializar();
        //    infoCliente = cliente;
        //}

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AcceptButton = buttonSalvar;
            this.textBoxNum.MaxLength = 5;
            comboBoxModelo.ValueMember = "iphmodid";
            comboBoxModelo.DisplayMember = "iphmoddescricao";
            this.KeyPreview = false;
        }

        private void FormIphoneModelo_Load(object sender, EventArgs e)
        {
            colecaoIpad = new IphoneModeloColecao();
            colecaoIphone = new IphoneModeloColecao();

            for (int i = Form1.IphoneColecao.Count - 1; i >= 0; i--)
            {
                if (Form1.IphoneColecao[i].iphmodipad)
                    colecaoIpad.Add(Form1.IphoneColecao[i]);
                else
                    colecaoIphone.Add(Form1.IphoneColecao[i]);
            }


            colecaoCor = Form1.IphoneCorColecao;
            comboBoxTipo.SelectedItem = "Iphone";
            comboBoxModelo.DataSource = colecaoIphone;
            comboBoxModelo.SelectedIndex = -1;
            cod = 1;

            if (colecaoCor == null)
            {
                FormMessage.ShowMessegeWarning("O formulário ainda não está pronto, tente mais tarde!");
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void ComboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemSelecionado();
        }

        private void ItemSelecionado()
        {
            colecaoCorSelecionada = new IphoneModeloCorColecao();

            if (cod > 0)
            {
                int dex = Convert.ToInt32(comboBoxModelo.SelectedValue);
                textBoxModelo.Text = comboBoxModelo.Text;
                textBoxCap.Clear();
                textBoxNumMod.Clear();
                textBoxCor.Clear();

                if (comboBoxTipo.Text == "Iphone")
                {
                    foreach (IphoneModeloInfo phone in colecaoIphone)
                    {
                        if (dex == phone.iphmodid)
                        {
                            infoIphone = phone;
                            break;
                        }
                    }

                    foreach (IphoneModeloCorInfo cor in colecaoCor)
                    {
                        if (cor.modcoridiphone == infoIphone.iphmodid)
                            colecaoCorSelecionada.Add(cor);
                    }
                }
                else
                {
                    foreach (IphoneModeloInfo phone in colecaoIpad)
                    {
                        if (dex == phone.iphmodid)
                        {
                            infoIphone = phone;
                            break;
                        }
                    }
                }

                PreencherForm();

            }
        }
        private void PreencherForm()
        {
            labelTitle.Text = infoIphone.iphmoddescricao;
            textBoxDetalhes.Text = strConver(infoIphone.iphmoddetalhes);
            textBoxAno.Text = infoIphone.iphmodlancamento.ToString();
            textBoxDimensoes.Text = strConver(infoIphone.iphmodpesodimensoes);
            textBoxTela.Text = strConver(infoIphone.iphmodtela);
            textBoxCameraT.Text = strConver(infoIphone.iphmodcameratraseira);
            textBoxCamF.Text = strConver(infoIphone.iphmodcamerafrontal);
            textBoxTv.Text = strConver(infoIphone.iphmodtvvideo);
            textBoxControle.Text = strConver(infoIphone.iphmodbotoescontroles);
            textBoxEnergia.Text = strConver(infoIphone.iphmodenergiabateria);
            textBoxSensores.Text = strConver(infoIphone.iphmodsensores);
            textBoxCaixa.Text = strConver(infoIphone.iphmodconteudocaixa);
            textBoxGravacao.Text = strConver(infoIphone.iphmodgravacao);
            textBoxResistente.Text = strConver(infoIphone.iphmodresistente);

            comboBoxNumMod.Text = string.Empty;
            comboBoxCapacidade.Text = string.Empty;
            comboBoxCor.Text = string.Empty;

            comboBoxNumMod.Items.Clear();
            comboBoxCapacidade.Items.Clear();
            comboBoxCor.Items.Clear();

            comboBoxNumMod.Items.AddRange(infoIphone.iphmodnum);
            comboBoxCapacidade.Items.AddRange(infoIphone.iphmodcapacidade);
            comboBoxCor.Items.AddRange(infoIphone.iphmodcor);

            panelPrincipal.Enabled = true;
            ConvertImagem(infoIphone.iphmodfoto);
        }

        private void ConvertImagem(byte[] foto)
        {
            if (foto != null)
            {
                MemoryStream memoryStream = new MemoryStream(foto);
                pictureBoxImagem.Image = Image.FromStream(memoryStream);
            }
            else
                pictureBoxImagem.Image = null;
        }

        private string strConver(string[] texto)
        {
            string novotxt = string.Empty;

            foreach (string txt in texto)
                novotxt += " - " + txt + Environment.NewLine;

            return novotxt;
        }

        private void ComboBoxCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCor.Text = comboBoxCor.Text;

            if (comboBoxTipo.Text == "Iphone")
            {
                foreach (IphoneModeloCorInfo cor in colecaoCorSelecionada)
                {
                    if (comboBoxCor.Text == cor.iphcordescricao)
                    {
                        SelecionadaFoto = cor;
                        ConvertImagem(cor.modcorfoto);
                        break;
                    }
                }
            }
        }

        private void ComboBoxNumMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNumMod.Text = comboBoxNumMod.Text;
        }

        private void ComboBoxCapacidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCap.Text = comboBoxCapacidade.Text;
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (CampoObrigatorio())
            {
                PreencherCelular();

                SelecionadoIphone = infoCelular;
                this.DialogResult = DialogResult.Yes;

                //thread = new Thread(Salvar);
                //form1.ExecutarThread(thread);
            }
        }

        private bool CampoObrigatorio()
        {
            if (comboBoxNumMod.SelectedIndex == -1)
            {
                FormMessage.ShowMessegeWarning("Selecione o modelo!");
                labelNumMod.ForeColor = Color.Red;
                comboBoxNumMod.Select();
                return false;
            }

            if (comboBoxCapacidade.SelectedIndex == -1)
            {
                FormMessage.ShowMessegeWarning("Selecione a capacidade!");
                labelCapacidade.ForeColor = Color.Red;
                comboBoxCapacidade.Select();
                return false;
            }

            if (comboBoxCor.SelectedIndex == -1)
            {
                FormMessage.ShowMessegeWarning("Selecione a cor!");
                labelCor.ForeColor = Color.Red;
                comboBoxCor.Select();
                return false;
            }

            if (string.IsNullOrWhiteSpace(maskedTextBoxSenha.Text))
            {
                FormMessage.ShowMessegeWarning("Insira a senha do aparelho!");
                labelSenha.ForeColor = Color.Red;
                maskedTextBoxSenha.Select();
                return false;
            }

            return true;
        }

        //private void Salvar()
        //{
        //    infoCelular.celid = negocioServ.InsertIphoneCelular(infoCelular);
        //    SelecionadoIphone = infoCelular;
        //    Form1.encerrarThread = true;
        //    this.DialogResult = DialogResult.Yes;
        //}

        private void PreencherCelular()
        {
            infoCelular = new IphoneCelularInfo
            {
                celanocompra = maskedTextBoxAno.Text,
                celcapacidade = textBoxCap.Text,
                celcor = textBoxCor.Text,
                celidcor = SelecionadaFoto.modcoridcor,
                celid = 0,
                celidcliente = 0,
                celidmodiphone = infoIphone.iphmodid,
                celimei = maskedTextBoxImei.Text,
                celmodelo = textBoxNumMod.Text,
                celobs = textBoxObs.Text,
                celserie = textBoxSerie.Text,
                celiphonedescricao = textBoxModelo.Text,
                celicloudlogin = textBoxEmail.Text,
                celicloudsenha = textBoxSenha.Text,
                celsenha = maskedTextBoxSenha.Text,
                celbateria = maskedTextBoxBateria.Text
            };
        }

        private void TipoSelecionando()
        {
            switch (comboBoxTipo.Text)
            {
                case "Iphone":

                    comboBoxModelo.DataSource = colecaoIphone;

                    if (tabControl1.TabPages.Count == 1)
                        tabControl1.TabPages.Add(tabPage2);

                    textBoxDetalhes.ScrollBars = ScrollBars.None;

                    break;
                case "Ipad":

                    comboBoxModelo.DataSource = colecaoIpad;

                    if (tabControl1.TabPages.Count > 1)
                        tabControl1.TabPages.RemoveAt(1);

                    textBoxDetalhes.ScrollBars = ScrollBars.Vertical;

                    break;
                case "Apple Watch":
                    //comboBoxModelo.DataSource = null;
                    break;
                default:
                    break;
            }

        }

        private void ButtonFoto_Click(object sender, EventArgs e)
        {
            FormIphoneSalvarFoto formIphoneSalvarFoto = new FormIphoneSalvarFoto(colecaoIphone);
            formIphoneSalvarFoto.ShowDialog(this);
            formIphoneSalvarFoto.Dispose();
        }

        private void Pesquisar()
        {
            bool find = false;

            foreach (IphoneModeloInfo phone in Form1.IphoneColecao)
            {
                foreach (string num in phone.iphmodnum)
                {
                    if (num == textBoxNum.Text)
                    {
                        if (phone.iphmodipad)
                            comboBoxTipo.SelectedItem = "Ipad";
                        else
                            comboBoxTipo.SelectedItem = "Iphone";

                        comboBoxModelo.SelectedIndex = -1;
                        infoIphone = phone;
                        PreencherForm();
                        textBoxModelo.Text = phone.iphmoddescricao;
                        comboBoxNumMod.Text = num;
                        textBoxNumMod.Text = num;
                        find = true;
                    }
                }
            }

            if (find == false)
            {
                comboBoxNumMod.SelectedIndex = -1;
                textBoxModelo.Text = string.Empty;
                textBoxNumMod.Text = string.Empty;
                textBoxAno.Text = string.Empty;

                if (tabControl1.TabPages.Count > 1)
                    tabControl1.TabPages.RemoveAt(1);

                textBoxNum.Select();
                FormMessage.ShowMessegeWarning("Nenhum aparelho identificado!");
            }
            else
            {
                if (comboBoxTipo.Text == "Iphone")
                    if (tabControl1.TabPages.Count == 1)
                        tabControl1.TabPages.Add(tabPage2);

                comboBoxCapacidade.Select();

            }
        }

        private void TextBoxNum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length == 5)
                Pesquisar();
        }

        private void ComboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoSelecionando();
        }
    }
}
