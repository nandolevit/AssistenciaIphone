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
using Negocios;
using System.Threading;

namespace WinForms
{
    public partial class FormServicoListar : Form
    {
        Form1 form1 = new Form1();
        Thread thread;

        GridServicoColecao colecaoGrid;

        bool radio;
        string palavraPesquisa;
        string status;
        string atend;
        DateTime dataIni;
        DateTime dataFim;
        ServicoNegocio negocioServ = new ServicoNegocio(Form1.Empresa.empconexao);
        
        public FormServicoListar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormConsultarServico_Load(object sender, EventArgs e)
        {

            textBoxPesquisar.Select();
        }

        private void PreencherComboboxAtendente()
        {
            FuncNegocios funcNegocios = new FuncNegocios(Form1.Empresa.empconexao, Form1.Unidade.uniassistencia);
            PessoaColecao colecao = new PessoaColecao();
            PessoaColecao funcColecao = funcNegocios.ConsultarPessoaPorTipo(EnumPessoaTipo.Funcionario);

            PessoaInfo funcInfo = new PessoaInfo
            {
                pssid = 0,
                pssnome = "*TODOS ATENDENTES*"
            };

            colecao.Add(funcInfo);

            foreach (PessoaInfo func in funcColecao)
                colecao.Add(func);

            comboBoxAtendente.DisplayMember = "funnome";
            comboBoxAtendente.ValueMember = "funid";
            comboBoxAtendente.DataSource = colecao;
        }

        private void PreencherComboboxStatus()
        {
            //CodDescricaoColecao colecao = servicoNegocio.ConsultarStatus();
            CodDescricaoColecao codDescricao = new CodDescricaoColecao();

            CodDescricaoInfo descricao = new CodDescricaoInfo
            {
                cod = 0,
                descricao = "*TODOS STATUS*"
            };
            codDescricao.Add(descricao);
            //foreach (CodDescricaoInfo cod in colecao)
            //    codDescricao.Add(cod);
            
            comboBoxStatus.DisplayMember = "descricao";
            comboBoxStatus.ValueMember = "cod";
            comboBoxStatus.DataSource = codDescricao;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxDetalhada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDetalhada.Checked)
            {
                groupBoxDetalhada.Enabled = true;
                groupBoxTipo.Enabled = false;

                PreencherComboboxStatus();
                PreencherComboboxAtendente();

            }
            else
            {
                groupBoxDetalhada.Enabled = false;
                groupBoxTipo.Enabled = true;
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }


        private void radioButtonOs_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPesquisar.Select();
            textBoxPesquisar.Clear();
        }

        private void FormConsultarServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkBoxDetalhada.Checked)
                {

                }
                else
                {
                    Pesquisar();
                }
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
        }

        private void buttonPesquisarDetalhada_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(comboBoxStatus.SelectedValue) == 0)
                status = "%";
            else
                status = Convert.ToString(comboBoxStatus.SelectedValue);

            if (Convert.ToInt32(comboBoxAtendente.SelectedValue) == 0)
                atend = "%";
            else
                atend = Convert.ToString(comboBoxAtendente.SelectedValue);


            dataIni = dateTimePickerIni.Value;
            dataFim = dateTimePickerFim.Value;
        }

        private void checkBoxGarantia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAtendente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerIni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pesquisar()
        {
            palavraPesquisa = textBoxPesquisar.Text;
            radio = radioButtonOs.Checked;

            pictureBoxLoad.Visible = true;
            thread = new Thread(new ThreadStart(PesquisarThread));
            form1.ExecutarThread(thread);
            PreencherGrid();
        }

        private void PesquisarThread()
        {
            if (!string.IsNullOrEmpty(palavraPesquisa))
            {
                colecaoGrid = new GridServicoColecao();

                if (radio)
                {
                    if (int.TryParse(palavraPesquisa, out int cod))
                    {
                        GridServicoInfo grid = negocioServ.ConsultarGridServicoOs(cod);

                        if (grid != null)
                            colecaoGrid.Add(grid);
                    }
                    else
                        FormMessage.ShowMessegeWarning("Insira um valor válido!");
                }
                else
                    colecaoGrid = negocioServ.ConsultarGridServicoCliente(palavraPesquisa);
            }
            else
                colecaoGrid = negocioServ.ConsultarGridServicoDia();

            Form1.encerrarThread = true;
            pictureBoxLoad.Visible = false;
        }

        private void PreencherGrid()
        {
            if (colecaoGrid == null)
            {
                colecaoGrid = new GridServicoColecao();
                GridServicoInfo grid = new GridServicoInfo
                {
                    aparelho = "Nenhuma Ordem de Serviço foi encontrada!"
                };

                colecaoGrid.Add(grid);
            }


            dataGridViewConsultar.DataSource = null;
            dataGridViewConsultar.DataSource = colecaoGrid;
        }

        private void dataGridViewConsultar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            FormServico formServico = new FormServico();
            if (formServico.ShowDialog(this) == DialogResult.Yes)
            {

            }
        }
    }
}
