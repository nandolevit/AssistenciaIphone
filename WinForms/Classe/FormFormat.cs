using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using System.Reflection;

namespace WinForms
{
    public class FormFormat
    {


        //criação de delegates de mensagem
        //mensagem de confirmação tipo sim/não
        private delegate DialogResult DelMessageQuestion(string mensagem);
        private static DelMessageQuestion DelQ = new DelMessageQuestion(FormMessage.ShowMessegeQuestion);
        //mensagem de aviso
        private delegate void DelMessgeWarning(string mensagem);
        private static DelMessgeWarning DelW = new DelMessgeWarning(FormMessage.ShowMessegeWarning);
        //messagem de informação
        private delegate void DelMessageInfo(string mensagem);
        private static DelMessageInfo DelI = new DelMessageInfo(FormMessage.ShowMessegeInfo);


        private static DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        private static string txt = string.Empty;

        Form form = new Form();
        //é para saber se o texto foi colado ou digitado, pois se for digitado o número de digítos será maior ou igual ao tamanho do texto
        //private static int contarDigitos = 0;

        public FormFormat(Form frm)
        {
            form = frm;
        }

        //formata todos os formulários do sistema
        public void formatar()
        {
            form.KeyPreview = true;
            form.KeyDown += new KeyEventHandler(AoApertar_KeyDown);
            //form.Load += new EventHandler(Form_Load);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.ShowInTaskbar = false;
            form.ShowIcon = false;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            EventoFormControle();

        }

        public static void GridFormat(DataGridView grid)
        {
            //desativa a função de ordenar pelas colunas
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //modo exibição das células
                grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            }

            //formata o grid para receber propriedade dentro de propriedade
            grid.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGridView_CellFormatting);

            //desativa a alteração pelas linhas
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;

            //ativa cor de linhas alternadas
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            //desativa a multi seleção
            grid.MultiSelect = false;
            //somente leitura
            grid.ReadOnly = true;
            //desativa o cabeçalho de lina
            grid.RowHeadersVisible = false;
            //ativa o modo de seleção de linha inteira
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //desativa o modo de gerar colunas automáticamente
            grid.AutoGenerateColumns = false;
            //desativa a tabulação
            grid.TabStop = false;
        }

        private static void ControlePanel(Control c)
        {
            Panel p = (Panel)c;

            foreach (Control co in p.Controls)
            {
                EventoControle(co);
            }
        }
        private static void ControleGroup(Control c)
        {
            GroupBox g = (GroupBox)c;

            foreach (Control gr in g.Controls)
            {
                EventoControle(gr);
            }
        }

        private void EventoFormControle()
        {
            foreach (Control c in form.Controls)
            {
                EventoControle(c);
            }
        }

        private static void FormatTextBox_AoPerderFoco(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (!FormTextoFormat.ValidaEmail(box.Text))
            {
                FormMessage.ShowMessegeWarning("E-mail inválido, campo será definico como \" sem@email.com\"");
                box.Text = "sem@email.com";
            }
        }

        private static void EventoControle(Control c)
        {
            if (c != null)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox box = (TextBox)c;

                    if (box.Name != "textBoxSenha")
                    {
                        box.TextChanged += new EventHandler(FormatTextBox_AoAlterar);
                        box.CharacterCasing = CharacterCasing.Upper; //converte para maiúsculo
                    }

                    if (box.Name == "textBoxEmail")
                    {
                        box.CharacterCasing = CharacterCasing.Lower;
                        box.LostFocus += new EventHandler(FormatTextBox_AoPerderFoco);
                    }

                    box.MaxLength = 255;
                }
                else if (c.GetType() == typeof(MaskedTextBox))
                {
                    MaskedTextBox mask = (MaskedTextBox)c;
                    EventoMaskTextBox(mask);
                }
                else if (c.GetType() == typeof(DataGridView))
                {
                    DataGridView grid = (DataGridView)c;
                    GridFormat(grid);
                }
                else
                {
                    if (c.GetType() == typeof(Panel))
                    {
                        ControlePanel(c);
                    }
                    else if (c.GetType() == typeof(GroupBox))
                    {
                        ControleGroup(c);
                    }
                    else if (c.GetType() == typeof(TabControl))
                    {

                        TabControl t = (TabControl)c;

                        foreach (Control ta in t.Controls)
                        {

                            foreach (Control pa in ta.Controls)
                            {
                                EventoControle(pa);
                                if (pa.GetType() == typeof(Panel))
                                {
                                    ControlePanel(pa);
                                }
                                else if (pa.GetType() == typeof(GroupBox))
                                {
                                    ControleGroup(pa);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void EventoMaskTextBox(MaskedTextBox mask)
        {
            mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mask.Click += new EventHandler(FormatMaskedTextBox_Click);

            if (mask.Mask == "(00) 0 0000-0000")
                mask.TextChanged += new EventHandler(FormatMaskedTelefone_TextChange);
        }

        private static void FormatTextBox_AoAlterar(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (!string.IsNullOrEmpty(box.Text))
                FormTextoFormat.NovoTextoUpper(box);
        }

        private static void AoApertar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Form frm = sender as Form;
                    frm.Close();
                    break;
                default:
                    break;
            }
        }

        private static void Form_Load(object sender, EventArgs e)
        {
            Form frm = (Form)sender;
            frm.Activate();
        }
        private static void FormatMaskedTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBox mask = sender as MaskedTextBox;
            mask.Select(0, 0);
        }

        private static void FormatMaskedTelefone_TextChange(object sender, EventArgs e)
        {
            MaskedTextBox mask = sender as MaskedTextBox;

            if (mask.Text.Length > 2)
            {
                char n = mask.Text[2];

                if (n == '9')
                    mask.Mask = "(00) 0 0000-0000";
                else
                    mask.Mask = "(00) 0000-0000";
            }
        }

        private static void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView view = (DataGridView)sender;

            if ((view.Rows[e.RowIndex].DataBoundItem != null) && (view.Columns[e.ColumnIndex].DataPropertyName.Contains('.')))
            {
                e.Value = CarregarPropriedade(view.Rows[e.RowIndex].DataBoundItem, view.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private static object CarregarPropriedade(object propObjeto, string propName)
        {
            object retProp = string.Empty;

            if (propName.Contains('.'))
            {
                PropertyInfo[] propInfo;
                string propAntesPonto;

                propAntesPonto = propName.Substring(0, propName.IndexOf('.'));
                propInfo = propObjeto.GetType().GetProperties();

                foreach (PropertyInfo info in propInfo)
                {
                    if (info.Name == propAntesPonto)
                    {
                        retProp = CarregarPropriedade(info.GetValue(propObjeto, null), propName.Substring(propName.IndexOf('.')) + 1);
                    }
                }
            }
            else
            {
                Type propTipo;
                PropertyInfo proInfo;

                propTipo = propObjeto.GetType();
                proInfo = propTipo.GetProperty(propName);
                retProp = proInfo.GetValue(propObjeto, null);
            }

            return retProp;
        }
    }
}
