using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;

namespace WinForms
{
    public partial class FormPessoaConsultar : Form
    {
        Form1 form1 = new Form1();
        Thread thread;
        PessoaNegocio negocioPessoa;
        PessoaInfo inforPessoa;
        PessoaColecao colecaoPessoa;

        EnumPessoaTipo enumPessoa;
        public bool Todos { get; set; }
        public PessoaInfo SelecionadoCliente { get; set; }
        string pesquisa;

        public FormPessoaConsultar(bool todos)
        {
            Inicializar();
            Todos = todos;
        }

        public FormPessoaConsultar(EnumPessoaTipo pessoa)
        {
            Inicializar();
            enumPessoa = pessoa;
            labelTitle.Text += pessoa.ToString();
        }

        private void Inicializar()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonBuscar;
            negocioPessoa = new PessoaNegocio(Form1.Empresa.empconexao, Form1.Unidade.uniassistencia);
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            RealizarPesquisa();
        }

        private void RealizarPesquisaThread()
        {
            if (Todos)
                colecaoPessoa = negocioPessoa.ConsultarPessoaDescricaoTodos(pesquisa, Form1.Unidade.uniassistencia);
            else
                colecaoPessoa = negocioPessoa.ConsultarPessoaDescricao(pesquisa, enumPessoa);

            Form1.encerrarThread = true;
            pictureBoxLoad.Visible = false;
        }

        private void RealizarPesquisa()
        {
            pesquisa = textBoxPesquisar.Text.Trim();
            pictureBoxLoad.Visible = true;
            thread = new Thread(RealizarPesquisaThread);
            form1.ExecutarThread(thread);
            this.Activate();
            PreencherGrid();
        }
        
        private void PreencherGrid()
        {
            if (colecaoPessoa != null)
            {
                pictureBoxLoad.Visible = false;
                dataGridViewPesquisarCliente.DataSource = colecaoPessoa;
                dataGridViewPesquisarCliente.Select();
            }
            else
            {
                PessoaInfo cliente = new PessoaInfo
                {
                    pssnome = "NENHUM REGISTRO FOI ENCONTRADO!"
                };

                colecaoPessoa = new PessoaColecao
                {
                    cliente
                };

                dataGridViewPesquisarCliente.DataSource = null;
                dataGridViewPesquisarCliente.DataSource = colecaoPessoa;
                textBoxPesquisar.Select();
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            AbrirCliente();
        }

        private void dataGridViewPesquisarCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirCliente();
        }

        private void AbrirCliente()
        {
            if (colecaoPessoa[0].pssnome != "NENHUM REGISTRO FOI ENCONTRADO!")
            {
                Selecionado();

                if (this.Modal)
                    DialogResult = DialogResult.Yes;
                else
                {
                    FormPessoa formCadastroPessoa = new FormPessoa(inforPessoa);
                    formCadastroPessoa.ShowDialog(this);
                    formCadastroPessoa.Dispose();
                }
            }
            else
                FormMessage.ShowMessegeWarning("NENHUM REGISTRO FOI ENCONTRADO!");
        }

        private void Selecionado()
        {
            if (dataGridViewPesquisarCliente.SelectedRows.Count > 0)
            {
                inforPessoa = (PessoaInfo)dataGridViewPesquisarCliente.SelectedRows[0].DataBoundItem;
                SelecionadoCliente = inforPessoa;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            RealizarPesquisa();
        }

        private void FormClienteConsultar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AbrirCliente();
                    break;
                default:
                    break;
            }
        }

        private void FormClienteConsultar_Load(object sender, EventArgs e)
        {
            textBoxPesquisar.Select();
        }
    }
}
