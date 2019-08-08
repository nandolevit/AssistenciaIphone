using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public static IPAddress[] localAdress;
        public static bool ConectedSystem { get; set; }
        public static bool FecharFormCarregando { get; set; }

        public static EmpresaInfo Empresa { get; set; }
        public static EmpresaEmailInfo EmpresaEmail { get; set; }
        public static UnidadeInfo Unidade { get; set; }
        public static UnidadeColecao colecaoUnidade { get; set; }
        public static UserInfo User { get; set; }
        public static ComputerInfo Server { get; set; }
        public static ComputerInfo Computer { get; set; }
        public static UserLoginInfo Login { get; set; } //registra a hora do login e a saída do usuário
        public static IphoneModeloColecao IphoneColecao { get; set; }
        public static IphoneModeloCorColecao IphoneCorColecao { get; set; }

        public static string Caminho { get { return @"C:\Users\Public\LevitSoft\emp.lvt"; } }
        public static string FileNameEmp { get { return "emp.lvt"; } }
        public static string FileNameUnid { get { return "unid.lvt"; } }
        public static string FileNameComp { get { return "comp.lvt"; } }
        public static string FileIphone { get { return "phone.lvt"; } }
        public static string FileIphoneCores { get { return "phoneCor.lvt"; } }

        public static bool encerrarThread;

        bool encerrarLogin; //caso true, abre o formulario de login
        bool abrirformPessoa; //abre o formulario de cadastro de funcinário, para quem não tem login

        PessoaNegocio negocioPessoa;
        UserNegocio userNegocio;
        EmpresaNegocios negocioEmp;
        Thread threadLogin;
        CaixaNegocios caixaNegocios;
        SerializarNegocios serializarNegocios = new SerializarNegocios(Caminho);
        OnlineNegocio negocioOnline;
        AccessLogin accessLogin;

        public Form1()
        {
            InitializeComponent();
        }

        public static void ConfiguracaoRede()
        {
            Computer.comphostname = Dns.GetHostName();
            localAdress = Dns.GetHostAddresses(Computer.comphostname);
            Computer.compip = localAdress[localAdress.Length - 1].ToString();
            Computer.compuser = (User == null) ? 0 : User.useid;

            foreach (NetworkInterface inter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (inter.OperationalStatus == OperationalStatus.Up)
                {
                    if (inter.NetworkInterfaceType == NetworkInterfaceType.Ethernet || inter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        Computer.compmac = inter.GetPhysicalAddress().ToString();
                        Computer.compadaptador = inter.Description;
                    }
                }
            }
        }

        private bool Desserializar()
        {
            Empresa = (serializarNegocios.DesserializarObjeto(FileNameEmp) as EmpresaInfo);
            Computer = (serializarNegocios.DesserializarObjeto(FileNameComp) as ComputerInfo);
            IphoneColecao = (serializarNegocios.DesserializarObjeto(FileIphone) as IphoneModeloColecao);
            IphoneCorColecao = (serializarNegocios.DesserializarObjeto(FileIphoneCores) as IphoneModeloCorColecao);

            if (Empresa == null || Computer == null || IphoneColecao == null || IphoneCorColecao == null)
                return false;
            else
                return true;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPessoa(EnumPessoaTipo.Cliente);
        }

        private void MenuItemCliente_Click(object sender, EventArgs e)
        {
            BuscarPessoa(EnumPessoaTipo.Cliente);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Computer = new ComputerInfo();
            ConfiguracaoRede();
            toolStripStatusLabelPcNome.Text = Computer.comphostname;
            toolStripStatusLabelIP.Text = Computer.compip;

            if (Desserializar())
            {
                try
                {
                    if (Dns.GetHostAddresses("empresadb.mysql.uhserver.com") != null)
                    {
                        IPAddress[] ip = Dns.GetHostAddresses("empresadb.mysql.uhserver.com");
                        ConectedSystem = true;
                    }
                    else
                    {
                        ConectedSystem = false;
                    }
                }
                catch (Exception)
                {
                    ConectedSystem = false;
                }

                if (ConectedSystem)
                {

                    Thread t = new Thread(ConsultarNovoIphone);
                    ExecutarThread(t);

                    threadLogin = new Thread(UpdateUserLogin);
                    threadLogin.Start();

                    EmpresaNegocios empresaNegocios = new EmpresaNegocios(Empresa.empconexao);

                    //if (Unidade != null)
                    //{
                    //    ComputerColecao colecao = empresaNegocios.ConsultarComputadorIdUnid(Unidade.uniid);

                    //    if (colecao != null)
                    //        foreach (ComputerInfo comp in colecao)
                    //            if (comp.compserver)
                    //            {
                    //                Server = comp;
                    //                break;
                    //            }
                    //}

                    if (Empresa != null)
                    {
                        Empresa = empresaNegocios.ConsultarEmpresaSysId(Empresa.empcod);

                        if (Empresa.empativada == 1)
                        {
                            TimeSpan timeSpan = Empresa.empdataativo.Subtract(DateTime.Now.Date);
                            if (timeSpan.Days > 0)
                            {
                                if (timeSpan.Days < 7)
                                    FormMessage.ShowMessegeWarning(Empresa.empobs.Replace("**", timeSpan.Days.ToString()));

                                colecaoUnidade = empresaNegocios.ConsultarUnidade();
                                EmpresaEmail = negocioEmp.ConsultarEmpresaEmail(Empresa.empid);
                                InicializarSistema();
                                this.Text += " :: " + Empresa.empfantasia;
                            }
                            else
                            {
                                if (timeSpan.Days < -15)
                                {
                                    FormMessage.ShowMessegeWarning("Seu sistema está bloqueado!");
                                    Application.Exit();
                                }
                                else
                                    FormMessage.ShowMessegeWarning("Seu sistema será bloqueado em * dias!".Replace("*", (-timeSpan.Days).ToString()));
                            }
                        }
                        else
                        {
                            FormMessage.ShowMessegeWarning("Seu sistema está bloqueado!");
                            Application.Exit();
                        }
                    }
                    else
                        FormMessage.ShowMessegeWarning("Falha!");
                }
                else
                {
                    FormMessage.ShowMessegeWarning("Este computador está sem conexão com a internet, o sistema será encerrado!");
                    Application.Exit();
                }
            }
            else
                AbrirFormEmpresa();

            if (Empresa != null)
                caixaNegocios = new CaixaNegocios(Empresa.empconexao);

        }

        private void ConsultarNovoIphone()
        {
            ServicoNegocio serv = new ServicoNegocio(Empresa.empconexao);
            List<int> lista = serv.ConsultarNovoIphoneModelo();

            if (lista.Count > 0)
            {
                foreach (int item in lista)
                {
                    IphoneModeloInfo mod = serv.ConsultarIphoneModeloId(item);

                    if (mod != null)
                        IphoneColecao.Add(mod);
                }

                if (serializarNegocios.ExcluirArquivo(FileIphone))
                    serializarNegocios.SerializarObjeto(IphoneColecao, FileIphone);
            }
            encerrarThread = true;
        }

        private void AbrirFormEmpresa()
        {
            FormEmpresa formEmpresa = new FormEmpresa();
            if (formEmpresa.ShowDialog(this) == DialogResult.Yes)
            {
                Desserializar();
                negocioPessoa = new PessoaNegocio(Empresa.empconexao, EnumAssistencia.Assistencia);
                PessoaInfo pessoa = negocioPessoa.ConsultarPessoaPadrao(EnumPessoaTipo.Funcionario, false);

                if (pessoa == null)
                {
                    FormPessoa formPessoa = new FormPessoa(EnumPessoaTipo.Funcionario);
                    formPessoa.ShowDialog(this);
                    formPessoa.Dispose();
                }
            }

            formEmpresa.Dispose();

            FormMessage.ShowMessegeWarning("As configurações foram realizadas com sucesso! O sistema será encerrado, abra-o novamente.");
            Application.Exit();
        }

        public void ExecutarThread(Thread thread)
        {
            thread.Start();


            DateTime temp1 = DateTime.Now;
            DateTime temp2;

            while (true)
            {
                temp2 = DateTime.Now;
                TimeSpan span = temp2 - temp1;

                if (encerrarThread)
                    break;
            }

            thread.Abort();
            encerrarThread = false;
        }

        private void InicializarSistema()
        {
            AoCarregar();
        }

        private void AoCarregar()
        {
            toolStripStatusLabelUsuario.Text = "USUÁRIO: ";
            toolStripStatusLabelLocal.Text = "UNIDADE: ";

            accessLogin = new AccessLogin(Form1.Empresa.empconexao);
            negocioEmp = new EmpresaNegocios(Form1.Empresa.empconexao);
            

        Iniciar:
            if (accessLogin.UserExist())
            {
                FormLogin formLogin = new FormLogin();
                if (formLogin.ShowDialog(this) == DialogResult.Yes)
                {
                    if (User.usenovologin == 0)
                    {
                        if (EmpresaEmail == null)
                            buttonEmail.Enabled = false;

                        panelPrincipal.Enabled = true;
                        menuStripPrincipal.Enabled = true;

                        if (Unidade.uniassistencia == EnumAssistencia.Loja)
                        {
                            MenuItemEstoque.Visible = false;
                            buttonOs.Enabled = false;
                            iphoneToolStripMenuItem.Visible = true;
                        }
                        else
                        {
                            MenuItemEstoque.Visible = true;
                            buttonOs.Enabled = true;
                            iphoneToolStripMenuItem.Visible = false;
                        }

                        if (User.usecargo == 1)
                        {
                            MenuItemCadFuncionario.Visible = true;
                            MenuItemConsultarFunc.Visible = true;
                        }
                        else
                        {
                            MenuItemCadFuncionario.Visible = false;
                            MenuItemConsultarFunc.Visible = false;
                        }

                        panelOnline.Visible = true;
                        FormOnline formOnline = new FormOnline();
                        formOnline.MdiParent = this;
                        panelOnline.Controls.Add(formOnline);
                        formOnline.Show();

                        toolStripStatusLabelUsuario.Text += User.uselogin;
                        toolStripStatusLabelLocal.Text += Unidade.uniunidade;
                        buttonCliente.Select();
                    }
                    else
                    {
                        FormAlterarSenha formAlterarSenha = new FormAlterarSenha(User);
                        if (formAlterarSenha.ShowDialog(this) == DialogResult.Yes)
                            AoCarregar();

                        formAlterarSenha.Dispose();
                    }
                }

                formLogin.Dispose();

                if (Unidade != null)
                    negocioPessoa = new PessoaNegocio(Empresa.empconexao, Unidade.uniassistencia);
            }
            else
            {
                FormPessoa formPessoa = new FormPessoa(EnumPessoaTipo.Funcionario);
                if (formPessoa.ShowDialog(this) == DialogResult.Yes)
                {
                    goto Iniciar;
                }
                else
                    Application.Exit();
            }
        }

        private void UpdateUserLogin()
        {
            userNegocio = new UserNegocio(Empresa.empconexao);
            negocioEmp = new EmpresaNegocios(Form1.Empresa.empconexao);
            negocioOnline = new OnlineNegocio(Form1.Empresa.empconexao);

            DateTime tempo = DateTime.Now;
            DateTime tempo1;
            DateTime emp1 = DateTime.Now;
            DateTime emp2;

            while (true)
            {
                tempo1 = DateTime.Now;
                TimeSpan min = tempo1 - tempo;

                if (min.TotalSeconds > 1)
                {
                    ////ConectedSystem = userNegocio.TestarConexaoSemPersistencia();

                    if (ConectedSystem)
                    {
                        if (min.TotalSeconds > 15)
                        {
                            tempo = DateTime.Now;

                            if (Login != null)
                                negocioOnline.UpdateUserLogin(Login.loginid);

                            ConfiguracaoRede();
                            negocioEmp.UpdateComputadorLog(Computer);
                            abrirformPessoa = negocioEmp.ConsultarComputadorOnlineCriarLogin(Computer.compid);
                        }

                        emp2 = DateTime.Now;
                        TimeSpan min2 = emp2 - emp1;

                        if (min2.TotalMinutes > 60)
                        {
                            emp1 = DateTime.Now;

                            EmpresaNegocios empresaNegocios = new EmpresaNegocios(Empresa.empconexao);

                            Empresa = empresaNegocios.ConsultarEmpresaSysId(Empresa.empcod);

                            if (Empresa.empativada == 0)
                            {
                                MessageBox.Show("Seu sistema está bloqueado!");
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private void MenuItemOrdemServ_Click(object sender, EventArgs e)
        {
            BuscarServico();
        }

        private void MenuItemFuncionario_Click(object sender, EventArgs e)
        {
            CadPessoa(EnumPessoaTipo.Funcionario);
        }

        private void MenuItemAlterarSenha_Click(object sender, EventArgs e)
        {
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha(true);
            if (formAlterarSenha.ShowDialog(this) == DialogResult.Yes)
            {
                FecharForm();
                AoCarregar();
            }

            formAlterarSenha.Dispose();
        }

        private bool AbertoForm(Form form)
        {
            bool ver = true;

            string nome = string.Empty;

            foreach (Form frm in Application.OpenForms)
            {
                nome += frm.Name + Environment.NewLine;

                if (form.Name == frm.Name)
                {
                    frm.Activate();
                    ver = false;
                    FormMessage.ShowMessegeInfo("Fomulário já está aberto");
                }
            }

            if (ver)
                return ver;
            else
                return false;
        }

        private void MenuItemConsultarFunc_Click(object sender, EventArgs e)
        {
            BuscarPessoa(EnumPessoaTipo.Funcionario);
        }

        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogarNovamente();
        }
        private void LogarNovamente()
        {
            FecharForm();
            AoCarregar();
        }

        private void FecharForm()
        {
            List<Form> formList = new List<Form>();

            foreach (Form frm in Application.OpenForms)
                if (frm.Name != "Form1")
                    formList.Add(frm);

            foreach (Form frm1 in formList)
                frm1.Close();

            User = null;
        }

        private void AbrirForm(Form form, bool panel = false)
        {
            if (AbertoForm(form))
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.MdiParent = this;
                panelCentral.Controls.Add(form);
                form.Show();
                form.MaximizeBox = true;

                if (panel)
                {
                    panelOnline.Visible = false;
                    form.FormClosed += new FormClosedEventHandler(this.EventoTornarPanelOnlineVisivel);
                }
                else
                    form.Select();


                form.WindowState = FormWindowState.Maximized;
            }
        }

        private void EventoTornarPanelOnlineVisivel(object sender, EventArgs e)
        {
            panelOnline.Visible = true;
        }

        private void MenuItemSobre_Click(object sender, EventArgs e)
        {
            FormEmpresa formEmpresa = new FormEmpresa(Empresa);
            AbrirForm(formEmpresa);
        }

        private void MenuItemEntradaSaida_Click(object sender, EventArgs e)
        {
            FormEntradaSaida formEntradaSaida = new FormEntradaSaida();
            AbrirForm(formEntradaSaida);
        }

        private void MenuItemProduto_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            AbrirForm(formProdutos);
        }

        private void MenuItemLancarEstoque_Click(object sender, EventArgs e)
        {
            FormEstoqueContagem formEstoqueContagem = new FormEstoqueContagem();
            AbrirForm(formEstoqueContagem, true);
        }


        private void MenuItemProdutos_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void MenuItemVender_Click(object sender, EventArgs e)
        {
            Vender();
        }

        private void AbrirVenda()
        {
            FormVenda formVenda = new FormVenda();
            AbrirForm(formVenda, true);
        }

        private void MenuItemUnidade_Click(object sender, EventArgs e)
        {
            FormUnidade formUnidade = new FormUnidade();
            AbrirForm(formUnidade);
        }

        private void MenuItemLancarEstoque_Click_1(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormProdEstoque formProdEstoque = new FormProdEstoque();
                AbrirForm(formProdEstoque);
            }
        }

        private void MenuItemimprimir2Via_Click(object sender, EventArgs e)
        {
            FormCupom formCupom = new FormCupom();
            AbrirForm(formCupom);
        }

        private void MenuItemCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();

            if (caixa.CaixaAberto() != null)
            {
                FormCaixa formCaixa = new FormCaixa(EnumCaixa.Caixa);
                AbrirForm(formCaixa);
            }
            else
                caixa.VerificarCaixa();
        }

        private void MenuItempagamentoRecebimentoDiversos_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormLancamentos formLancamentos = new FormLancamentos(true);
                AbrirForm(formLancamentos);
            }

        }

        private void MenuItemSangria_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormSangria formSangria = new FormSangria();
                AbrirForm(formSangria);
            }

        }

        private void MenuItemTrocaDeTurno_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormCaixa formCaixa = new FormCaixa(EnumCaixa.Turno);
                AbrirForm(formCaixa);
            }
        }

        private void AbrirVendaPeriodo()
        {
            FormVendaRelatorio formVendaRelatorio = new FormVendaRelatorio();
            AbrirForm(formVendaRelatorio, true);
        }

        private void MenuItemVendaPeriodo_Click(object sender, EventArgs e)
        {
            AbrirVendaPeriodo();
        }

        private void AbrirFormConexao()
        {
            if (Application.OpenForms["FormConexao"] == null)
            {
                FormConexao formConexao = new FormConexao();
                formConexao.ShowDialog();
                formConexao.Dispose();
            }
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
            toolStripStatusLabelTime.Text.ToUpper();

            try
            {
                if (Dns.GetHostAddresses("empresadb.mysql.uhserver.com") != null)
                {
                    IPAddress[] ip = Dns.GetHostAddresses("empresadb.mysql.uhserver.com");
                    ConectedSystem = true;
                }
                else
                {
                    ConectedSystem = false;
                    AbrirFormConexao();
                }
            }
            catch (Exception)
            {
                ConectedSystem = false;
                AbrirFormConexao();
            }

            if (abrirformPessoa)
            {
                abrirformPessoa = false;

                if (Application.OpenForms["FormLogin"] != null)
                    Application.OpenForms["FormLogin"].Dispose();

                FecharForm();
                FormPessoa formPessoa = new FormPessoa(EnumPessoaTipo.Funcionario, EnumAssistencia.Assistencia);
                if(formPessoa.ShowDialog(this) == DialogResult.Yes)
                {
                    AoCarregar();
                }
                else
                {
                    Application.Exit();
                }
                formPessoa.Dispose();

                //if (Application.OpenForms["FormPessoa"] == null)
                //{
                    
                //}
            }
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            CadPessoa(EnumPessoaTipo.Cliente);
        }

        private void CadPessoa(EnumPessoaTipo pessoa)
        {
            FormPessoa formPessoa = new FormPessoa(pessoa);
            if (pessoa == EnumPessoaTipo.Cliente)
            {
                if (formPessoa.ShowDialog(this) == DialogResult.Yes)
                {
                    if (Unidade.uniassistencia == EnumAssistencia.Assistencia)
                    {
                        PessoaInfo p = formPessoa.SelecionadoPessoa;
                        int id = p.pssid;

                        if (id > 0)
                        {
                            switch (Empresa.empnegocio)
                            {
                                case EnumEmpresaNegocio.Loja_Iphone:

                                    FormServicoTipo formServicoTipo = new FormServicoTipo();
                                    if (formServicoTipo.ShowDialog(this) == DialogResult.Yes)
                                    {
                                        FormServico formServico = new FormServico(p);
                                        if (formServico.ShowDialog(this) == DialogResult.Yes)
                                        {
                                            FormMessage.ShowMessegeInfo("Registro salvo com sucesso!");
                                        }
                                    }
                                    else if (formServicoTipo.DialogResult == DialogResult.OK)
                                    {
                                        FormLerText formLerText = new FormLerText();
                                        formLerText.ShowDialog();
                                        formLerText.Dispose();
                                    }
                                    formServicoTipo.Dispose();

                                    break;
                                case EnumEmpresaNegocio.Refrigeracao:
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }

                formPessoa.Dispose();
            }
            else
                AbrirForm(formPessoa);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            AbrirForm(formProdutos);
        }

        private void buttonOs_Click(object sender, EventArgs e)
        {
            BuscarServico();
        }

        private void BuscarServico()
        {
            if (Unidade.uniassistencia == EnumAssistencia.Assistencia)
            {
                FormServicoListar formServicoListar = new FormServicoListar();
                AbrirForm(formServicoListar, true);
            }
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarPessoa(EnumPessoaTipo.Cliente);
        }

        private void BuscarPessoa(EnumPessoaTipo enumPessoa)
        {
            FormPessoaConsultar formClienteConsultar = new FormPessoaConsultar(enumPessoa);
            AbrirForm(formClienteConsultar);
        }

        private void buttonProdutoBuscar_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void BuscarProduto()
        {
            FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar();
            AbrirForm(formProdutosConsultar);
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vender();
        }

        private void Vender()
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                AbrirVenda();
            }
        }

        private void buttonPeriodo_Click(object sender, EventArgs e)
        {
            AbrirVendaPeriodo();
            //formVendaRelatorio.WindowState = FormWindowState.Maximized;
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            FormEntradaSaida formEntradaSaida = new FormEntradaSaida();
            AbrirForm(formEntradaSaida, true);
        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            FecharForm();
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha(true);
            formAlterarSenha.ShowDialog(this);

            if (formAlterarSenha.DialogResult == DialogResult.Yes)
                AoCarregar();

            formAlterarSenha.Dispose();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void buttonCaixa_Click(object sender, EventArgs e)
        {
            AbrirCaixa(EnumCaixa.Caixa);
        }

        private void AbrirCaixa(EnumCaixa enumCaixa)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormCaixa formCaixa = new FormCaixa(enumCaixa);
                AbrirForm(formCaixa);
            }
        }

        private void buttonTurno_Click(object sender, EventArgs e)
        {
            AbrirCaixa(EnumCaixa.Turno);
        }

        private void relatorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioVendaVendedor formRelatorioVendaVendedor = new FormRelatorioVendaVendedor();
            AbrirForm(formRelatorioVendaVendedor, true);
        }

        private void contarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstoqueContagem formEstoqueContagem = new FormEstoqueContagem(true);
            AbrirForm(formEstoqueContagem, true);
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutoEstoqueDetalhes formProdutoEstoqueDetalhes = new FormProdutoEstoqueDetalhes();
            AbrirForm(formProdutoEstoqueDetalhes, true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadLogin != null)
                threadLogin.Abort();

            if (Application.OpenForms["FormOnline"] != null)
                Application.OpenForms["FormOnline"].Close();
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPessoa(EnumPessoaTipo.Fornecedor);
        }


        private void ButtonFornecedor_Click(object sender, EventArgs e)
        {
            CadPessoa(EnumPessoaTipo.Fornecedor);
        }

        private void ButtonEmail_Click(object sender, EventArgs e)
        {
            FormEmail formEmail = new FormEmail();
            formEmail.ShowDialog(this);
        }

        private void IphoneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormIphoneCadastrar formIphoneCadastrar = new FormIphoneCadastrar();
            AbrirForm(formIphoneCadastrar);
        }
    }
}
