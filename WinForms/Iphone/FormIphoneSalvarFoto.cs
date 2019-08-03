using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormIphoneSalvarFoto : Form
    {
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        IphoneModeloColecao colecaoIphone;
        CodDescricaoColecao colecaoCod;
        string foto;
        byte[] imagem_byte = null;

        public FormIphoneSalvarFoto(IphoneModeloColecao colecao)
        {
            InitializeComponent();
            colecaoIphone = colecao;
            colecaoCod = negocioServ.ConsultarIphoneCorColecao();


            comboBoxModelo.ValueMember = "iphmodid";
            comboBoxModelo.DisplayMember = "iphmoddescricao";
            comboBoxModelo.DataSource = colecaoIphone;
            comboBoxModelo.SelectedIndex = -1;
        }

        private void AbrirFoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foto = openFileDialog.FileName;
                textBoxCaminho.Text = foto;
                pictureBoxFoto.ImageLocation = foto;
            }
        }

        private void ButtonFoto_Click(object sender, EventArgs e)
        {
            AbrirFoto();
        }

        private void SalvarFoto()
        {
            FileStream fileStream = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imagem_byte = binaryReader.ReadBytes((int)fileStream.Length);
        }

        private void ComboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCor.ValueMember = "cod";
            comboBoxCor.DisplayMember = "descricao";

            foreach (IphoneModeloInfo phone in colecaoIphone)
            {
                if (Convert.ToInt32( comboBoxModelo.SelectedValue) == phone.iphmodid)
                {
                    CodDescricaoColecao colecao = new CodDescricaoColecao();
                    foreach (string cor in phone.iphmodcor)
                    {
                        foreach (CodDescricaoInfo item in colecaoCod)
                        {
                            if (item.descricao == cor)
                            {
                                colecao.Add(item);
                                break;
                            }
                        }
                    }

                    comboBoxCor.DataSource = colecao;
                }
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            SalvarFoto();
            IphoneModeloCorInfo iphoneModeloCorInfo = new IphoneModeloCorInfo
            {
                modcorfoto = imagem_byte,
                modcoridcor = Convert.ToInt32(comboBoxCor.SelectedValue),
                modcoridiphone = Convert.ToInt32(comboBoxModelo.SelectedValue)
            };

            if (negocioServ.InsertIphoneModeloCor(iphoneModeloCorInfo) > 0)
                FormMessage.ShowMessegeInfo("Salvo com sucesso!");
            else
                FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
        }

        private void ButtonPrincipal_Click(object sender, EventArgs e)
        {
            //aqui salva a foto na tabela tabiphonemodelo que será a foto principal
            SalvarFoto();
            IphoneModeloCorInfo iphoneModeloCorInfo = new IphoneModeloCorInfo
            {
                modcorfoto = imagem_byte,
                modcoridcor = Convert.ToInt32(comboBoxCor.SelectedValue),
                modcoridiphone = Convert.ToInt32(comboBoxModelo.SelectedValue)
            };

            if (negocioServ.UpdateFotoIphoneModelo(iphoneModeloCorInfo) > 0)
                FormMessage.ShowMessegeInfo("Salvo com sucesso!");
            else
                FormMessage.ShowMessegeWarning("Falha ao tentar salvar!");
        }
    }
}
