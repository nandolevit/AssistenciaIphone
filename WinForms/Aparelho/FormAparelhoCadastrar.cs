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
using ObjTransfer.Aparelho;

namespace WinForms.Aparelho
{
    public partial class FormAparelhoCadastrar : Form
    {
        AparelhoNegocio negocioAparelho;
        SistemaOperacionalColecao colecaoSistema;
        AparelhoLinha linhaAparelho;
        PessoaInfo infoPessoa;

        public FormAparelhoCadastrar(AparelhoLinha linha, PessoaInfo pessoa)
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            linhaAparelho = linha;
            textBoxLinha.Text = linha.linhadescricao;
            infoPessoa = pessoa;
            textBoxNome.Text = pessoa.pssnome;
        }

        private void FormAparelhoCadastrar_Load(object sender, EventArgs e)
        {
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            colecaoSistema = negocioAparelho.ConsultarSistemaPorLinha(linhaAparelho.linhaid);
            colecaoSistema.Sort((s1, s2) => s2.Descricao.CompareTo(s1.Descricao));

            comboBoxSistema.ValueMember = "Id";
            comboBoxSistema.DisplayMember = "Descricao";
            comboBoxSistema.DataSource = colecaoSistema;

            if (linhaAparelho.linhaid == 1 || linhaAparelho.linhaid == 3)
            {
                comboBoxMarca.DisplayMember = "Descricao";
                comboBoxMarca.ValueMember = "Id";

                AparelhoMarca marca = new AparelhoMarca
                {
                    Descricao = "APPLE",
                    Id = 1
                };

                comboBoxMarca.Items.Add(marca);
                comboBoxMarca.SelectedIndex = 0;
            }
        }

        private void ComboBoxSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            int id = Convert.ToInt32(comboBoxSistema.SelectedValue);
            SistemaOperacionalVersaoColecao versao = negocioAparelho.ConsultarSistemaVersao(id);

            if (versao == null)
            {
                comboBoxVersao.DropDownStyle = ComboBoxStyle.Simple;
                comboBoxVersao.DataSource = versao;
            }
            else
            {
                comboBoxVersao.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxVersao.ValueMember = "Id";
                comboBoxVersao.DisplayMember = "Descricao";
                comboBoxVersao.DataSource = versao;
            }

            comboBoxVersao.Select();
        }

        private void ComboBoxVersao_SelectedIndexChanged(object sender, EventArgs e)
        {
            negocioAparelho = new AparelhoNegocio(Form1.Empresa.empconexao);
            int id = Convert.ToInt32(comboBoxVersao.SelectedValue);
            SistemaOperacionalModeloColecao modelo = negocioAparelho.ConsultarSistemaModelo(id);

            if (modelo != null)
            {
                labelModelo.Visible = true;
                comboBoxModelo.Visible = true;
                comboBoxModelo.ValueMember = "Id";
                comboBoxModelo.DisplayMember = "Descricao";
                comboBoxModelo.DataSource = modelo;
                comboBoxModelo.Select();
            }
            else
            {
                labelModelo.Visible = false;
                comboBoxModelo.Visible = false;
            }
        }
    }
}
