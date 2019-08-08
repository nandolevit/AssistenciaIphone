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

namespace WinForms
{
    public partial class FormAprelhoDefeito : Form
    {
        Form1 form1 = new Form1();
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        //public string DefeitoInfo { get; set; }

        Thread thread;
        PessoaInfo infoCliente;
        IphoneCelularInfo infoCelular;
        IphoneCelularColecao colecaoCelular;
        ServicoIphoneInfo infoDefeito;

        public ServicoIphoneInfo SelecionandoDefeito { get; set; }
        public IphoneCelularInfo SelecionadoCelular { get; set; }

        public FormAprelhoDefeito(PessoaInfo cliente)
        {
            Inicializar();
            infoCliente = cliente;

            pictureBoxLoad.Visible = true;
            thread = new Thread(ConsultarAparelhoCliente);
            form1.ExecutarThread(thread);

        }

        //public FormProdutoDefeito(ClienteInfo cliente, IphoneCelularInfo phone)
        //{
        //    Inicializar();
        //    infoCelular = phone;
        //    infoCliente = cliente;

        //    if (infoCelular != null)
        //    {
        //        textBoxCodProd.Text = string.Format("{0:0000}", infoCelular.celid);
        //        textBoxProdDescricao.Text = infoCelular.ToString();
        //    }
        //}

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AcceptButton = buttonSalvar;
            textBoxCodProd.Select();

        }

        private void ConsultarAparelhoCliente()
        {
            colecaoCelular = negocioServ.ConsultarIphoneCelularIdCliente(infoCliente.pssid);
            textBoxDefeito.Select();
            Form1.encerrarThread = true;
            pictureBoxLoad.Visible = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxDefeito.Text.Trim()) || string.IsNullOrEmpty(textBoxCodProd.Text)))
            {
                PreencherDefeito();
                SelecionadoCelular = infoCelular;
                SelecionandoDefeito = infoDefeito;
                this.DialogResult = DialogResult.Yes;
            }
            else
                FormMessage.ShowMessegeWarning("Informar o aparelho e o defeito do aparelho!");
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormProdutoDefeito_Load(object sender, EventArgs e)
        {
            if (colecaoCelular != null)
            {
                if (colecaoCelular.Count > 1)
                    AbrirListaAparelho(true);
                else
                {
                    textBoxCodProd.Text = string.Format("{0:00000}", colecaoCelular[0].celid);
                    textBoxProdDescricao.Text = colecaoCelular[0].ToString();
                    infoCelular = colecaoCelular[0];
                }
            }
            else
                AbrirIphoneModelo();
        }

        private void AbrirListaAparelho(bool modelo = false)
        {
            Form_ConsultarColecao colecao = new Form_ConsultarColecao();
            if (colecaoCelular != null)
            {
                foreach (IphoneCelularInfo aparelho in colecaoCelular)
                {
                    Form_Consultar form_Consultar = new Form_Consultar
                    {
                        Cod = string.Format("{0:00000}", aparelho.celid),
                        Descricao = aparelho.ToString()
                    };

                    colecao.Add(form_Consultar);
                }
            }

            FormConsultar_Cod_Descricao formConsultar_Cod_Descricao = new FormConsultar_Cod_Descricao(colecao, "Aparelho");
            if (formConsultar_Cod_Descricao.ShowDialog(this) == DialogResult.Yes)
            {
                Form_Consultar consultar = formConsultar_Cod_Descricao.Selecionado;
                textBoxCodProd.Text = consultar.Cod;
                textBoxProdDescricao.Text = consultar.Descricao;
                infoCelular = negocioServ.ConsultarIphoneCelularId(Convert.ToInt32(consultar.Cod));
                SelecionadoCelular = infoCelular;
            }
            else
                if (modelo)
                    AbrirIphoneModelo();

            formConsultar_Cod_Descricao.Dispose();
        }

        private void PreencherDefeito()
        {
            infoDefeito = new ServicoIphoneInfo
            {
                iphdefautofrontal = textBoxAutoFrontal.Text,
                iphdefautointerno = textBoxAutoInterno.Text,
                iphdefcamfrontal = textBoxCamFrontal.Text,
                iphdefcamtraseira = textBoxCamTraseira.Text,
                iphdefcarcaca = textBoxCarcaca.Text,
                iphdefconector = textBoxConector.Text,
                iphdefdefeito = textBoxDefeito.Text,
                iphdefflash = textBoxFlash.Text,
                iphdeffone = textBoxFone.Text,
                iphdefhome = textBoxHome.Text,
                iphdefid = 0,
                iphdefmicrofone = textBoxMicro.Text,
                iphdefmicrofonetraseiro = textBoxMicroTraseira.Text,
                iphdefobs = textBoxObs.Text,
                iphdefparafuso = textBoxParafuso.Text,
                iphdefsensorprox = textBoxSensor.Text,
                iphdeftouchdisplay = textBoxDisplay.Text,
                iphdefbandeja = textBoxBandeja.Text,
                iphdefdesligar = textBoxDesligar.Text,
                iphdefsilencioso = textBoxSilencioso.Text,
                iphdefvolume = textBoxVolume.Text,
                
            };
        }

        private void ButtonBuscarAparelho_Click(object sender, EventArgs e)
        {
            AbrirListaAparelho();
        }

        private void ButtonAddAparelho_Click(object sender, EventArgs e)
        {
            AbrirIphoneModelo();
        }

        private void AbrirIphoneModelo()
        {
            FormIphoneModelo formIphoneModelo = new FormIphoneModelo();
            if (formIphoneModelo.ShowDialog(this) == DialogResult.Yes)
            {
                infoCelular = formIphoneModelo.SelecionadoIphone;
                textBoxCodProd.Text = string.Format("{0:00000}", infoCelular.celid);
                textBoxProdDescricao.Text = infoCelular.ToString();
            }
            formIphoneModelo.Dispose();
        }
    }
}
