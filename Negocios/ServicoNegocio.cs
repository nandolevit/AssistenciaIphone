using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using ObjTransfer.Aparelho.Celulares;
using AccessDB;
using System.Data;

namespace Negocios
{
    public class ServicoNegocio
    {
        private static string EmpConexao { get; set; }

        public ServicoNegocio(string conexao)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql= new AccessDbMySql(EmpConexao);

        #region Servico
        public GridServicoInfo ConsultarGridServicoOs(int id)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarvServicoIphoneOs");
                if (dataTable != null)
                    return PreencherGridServico(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public GridServicoColecao ConsultarGridServicoDia()
        {
            if (accessDbMySql.Conectar())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarvServicoIphoneDia");
                if (dataTable != null)
                    return PreencherGridServico(dataTable);
                else
                    return null;
            }
            else
                return null;

        }
        public GridServicoColecao ConsultarGridServicoCliente(string nome)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@nome", nome);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarvServicoIphoneCliente");
                if (dataTable != null)
                    return PreencherGridServico(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        private GridServicoColecao PreencherGridServico(DataTable dataTable)
        {
            GridServicoColecao colecao = new GridServicoColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                GridServicoInfo grid = new GridServicoInfo
                {
                    aparelho = Convert.ToString(row["serapadescricao"]),
                    atendente = Convert.ToString(row["funnome"]),
                    cliente = Convert.ToString(row["clinome"]),
                    entrada = Convert.ToDateTime(row["serdataagend"]).Date,
                    ordem = Convert.ToInt32(row["serid"]),
                    status = Convert.ToString(row["statusdescricao"]),
                };

                colecao.Add(grid);
            }

            return colecao;
        }

        private int InsertServico(ServicoInfo servico)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@agend", servico.serdataagend);
                accessDbMySql.AddParametrosMySql("@atend", servico.seridatendente);
                accessDbMySql.AddParametrosMySql("@idstat", servico.seridstatus);
                accessDbMySql.AddParametrosMySql("@resp", servico.seridtec_resp);
                accessDbMySql.AddParametrosMySql("@unid", servico.seridunid);
                accessDbMySql.AddParametrosMySql("@tipo", servico.seridtipoaparelho);
                accessDbMySql.AddParametrosMySql("@descricao", servico.seraparelhodescricao);
                accessDbMySql.AddParametrosMySql("@cliente", servico.seridcliente);

                return accessDbMySql.ExecutarScalarMySql("spInsertServico");
            }
            else
                return 0;
        }

        #endregion Servico

        #region Iphone

        public int InsertIphoneCompra(IphoneCompraInfo compraInfo)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@compra", compraInfo.iphcompradatacompra);
                accessDbMySql.AddParametrosMySql("@garantia", compraInfo.iphcompradatagarantia);
                accessDbMySql.AddParametrosMySql("@apple", compraInfo.iphcompragarantiaapple);
                accessDbMySql.AddParametrosMySql("@dias", compraInfo.iphcompragarantiadias);
                accessDbMySql.AddParametrosMySql("@aparelho", compraInfo.iphcompraidaparelho);
                accessDbMySql.AddParametrosMySql("@fornecedor", compraInfo.iphcompraidfornecedor);
                accessDbMySql.AddParametrosMySql("@novo", compraInfo.iphcompranovo);
                accessDbMySql.AddParametrosMySql("@valorcompra", compraInfo.iphcompravalorcompra);
                accessDbMySql.AddParametrosMySql("@valorvenda", compraInfo.iphcompravalorvenda);
                accessDbMySql.AddParametrosMySql("@func", compraInfo.iphcompraidfunc);

                return accessDbMySql.ExecutarScalarMySql("spInsertIphoneCompra");
            }
            else
                return 0;
        }

        public int UpdateServicoIphone(ServicoIphoneInfo defeito)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@autofrontal", defeito.iphdefautofrontal);
                accessDbMySql.AddParametrosMySql("@autointerno", defeito.iphdefautointerno);
                accessDbMySql.AddParametrosMySql("@camfrontal", defeito.iphdefcamfrontal);
                accessDbMySql.AddParametrosMySql("@camtraseira", defeito.iphdefcamtraseira);
                accessDbMySql.AddParametrosMySql("@carcaca", defeito.iphdefcarcaca);
                accessDbMySql.AddParametrosMySql("@conector", defeito.iphdefconector);
                accessDbMySql.AddParametrosMySql("@defeito", defeito.iphdefdefeito);
                accessDbMySql.AddParametrosMySql("@flash", defeito.iphdefflash);
                accessDbMySql.AddParametrosMySql("@fone", defeito.iphdeffone);
                accessDbMySql.AddParametrosMySql("@home", defeito.iphdefhome);
                accessDbMySql.AddParametrosMySql("@id", defeito.iphdefid);
                accessDbMySql.AddParametrosMySql("@microfone", defeito.iphdefmicrofone);
                accessDbMySql.AddParametrosMySql("@microfonetraseiro", defeito.iphdefmicrofonetraseiro);
                accessDbMySql.AddParametrosMySql("@obs", defeito.iphdefobs);
                accessDbMySql.AddParametrosMySql("@parafuso", defeito.iphdefparafuso);
                accessDbMySql.AddParametrosMySql("@sensorprox", defeito.iphdefsensorprox);
                accessDbMySql.AddParametrosMySql("@display", defeito.iphdeftouchdisplay);
                accessDbMySql.AddParametrosMySql("@volume", defeito.iphdefvolume);
                accessDbMySql.AddParametrosMySql("@silencioso", defeito.iphdefsilencioso);
                accessDbMySql.AddParametrosMySql("@desligar", defeito.iphdefdesligar);
                accessDbMySql.AddParametrosMySql("@bandeja", defeito.iphdefbandeja);

                return accessDbMySql.ExecutarScalarMySql("sUpdateServicoIphone");
            }
            else
                return 0;
        }

        public int InsertServicoIphone(ServicoIphoneInfo defeito)
        {
            int id = InsertServico(defeito);

            if (id > 0)
            {
                if (accessDbMySql.Conectar())
                {
                    accessDbMySql.AddParametrosMySql("@autofrontal", defeito.iphdefautofrontal);
                    accessDbMySql.AddParametrosMySql("@autointerno", defeito.iphdefautointerno);
                    accessDbMySql.AddParametrosMySql("@camfrontal", defeito.iphdefcamfrontal);
                    accessDbMySql.AddParametrosMySql("@camtraseira", defeito.iphdefcamtraseira);
                    accessDbMySql.AddParametrosMySql("@carcaca", defeito.iphdefcarcaca);
                    accessDbMySql.AddParametrosMySql("@conector", defeito.iphdefconector);
                    accessDbMySql.AddParametrosMySql("@defeito", defeito.iphdefdefeito);
                    accessDbMySql.AddParametrosMySql("@flash", defeito.iphdefflash);
                    accessDbMySql.AddParametrosMySql("@fone", defeito.iphdeffone);
                    accessDbMySql.AddParametrosMySql("@home", defeito.iphdefhome);
                    accessDbMySql.AddParametrosMySql("@id", defeito.iphdefid);
                    accessDbMySql.AddParametrosMySql("@servico", id);
                    accessDbMySql.AddParametrosMySql("@microfone", defeito.iphdefmicrofone);
                    accessDbMySql.AddParametrosMySql("@microfonetraseiro", defeito.iphdefmicrofonetraseiro);
                    accessDbMySql.AddParametrosMySql("@obs", defeito.iphdefobs);
                    accessDbMySql.AddParametrosMySql("@parafuso", defeito.iphdefparafuso);
                    accessDbMySql.AddParametrosMySql("@sensor", defeito.iphdefsensorprox);
                    accessDbMySql.AddParametrosMySql("@display", defeito.iphdeftouchdisplay);
                    accessDbMySql.AddParametrosMySql("@volume", defeito.iphdefvolume);
                    accessDbMySql.AddParametrosMySql("@silencioso", defeito.iphdefsilencioso);
                    accessDbMySql.AddParametrosMySql("@desligar", defeito.iphdefdesligar);
                    accessDbMySql.AddParametrosMySql("@bandeja", defeito.iphdefbandeja);

                    return accessDbMySql.ExecutarScalarMySql("spInsertServicoIphone");
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        public ServicoIphoneInfo ConsultarServicoIphoneId(int id)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@phone", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneDefeitoId");
                if (dataTable != null)
                    return PreencherServicoIphone(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        private ServicoIphoneColecao PreencherServicoIphone(DataTable dataTable)
        {
            ServicoIphoneColecao colecao = new ServicoIphoneColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                ServicoIphoneInfo defeito = new ServicoIphoneInfo
                {
                    iphdefautofrontal = Convert.ToString(row["iphdefautofrontal"]),
                    iphdefautointerno = Convert.ToString(row["iphdefautointerno"]),
                    iphdefcamfrontal = Convert.ToString(row["iphdefcamfrontal"]),
                    iphdefcamtraseira = Convert.ToString(row["iphdefcamtraseira"]),
                    iphdefcarcaca = Convert.ToString(row["iphdefcarcaca"]),
                    iphdefconector = Convert.ToString(row["iphdefconector"]),
                    iphdefdefeito = Convert.ToString(row["iphdefdefeito"]),
                    iphdefflash = Convert.ToString(row["iphdefflash"]),
                    iphdeffone = Convert.ToString(row["iphdeffone"]),
                    iphdefhome = Convert.ToString(row["iphdefhome"]),
                    iphdefid = Convert.ToInt32(row["iphdefid"]),
                    iphdefmicrofone = Convert.ToString(row["iphdefmicrofone"]),
                    iphdefmicrofonetraseiro = Convert.ToString(row["iphdefmicrofonetraseiro"]),
                    iphdefobs = Convert.ToString(row["iphdefobs"]),
                    iphdefparafuso = Convert.ToString(row["iphdefparafuso"]),
                    iphdefsensorprox = Convert.ToString(row["iphdefsensorprox"]),
                    iphdeftouchdisplay = Convert.ToString(row["iphdeftouchdisplay"])
                };

                colecao.Add(defeito);
            }

            return colecao;
        }

        public Celular ConsultarCelularId(int id)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("");
                if (dataTable != null)
                    return PreencherIphoneCelular(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public CelularColecao ConsultarCelularIdCliente(int id)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("");
                if (dataTable != null)
                    return PreencherIphoneCelular(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        private CelularColecao PreencherIphoneCelular(DataTable dataTable)
        {
            CelularColecao colecao = new CelularColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                Celular phone = new Celular
                {
                    
                };

                colecao.Add(phone);
            }

            return colecao;
        }

        public int InsertIphoneCelular(Iphone phone)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@compra", phone.Ano);
                accessDbMySql.AddParametrosMySql("@capacidade", phone.Capacidade);
                accessDbMySql.AddParametrosMySql("@cor", phone.Cor);
                accessDbMySql.AddParametrosMySql("@cliente", phone.Pessoa.Id);
                accessDbMySql.AddParametrosMySql("@imei", phone.IMEI);
                accessDbMySql.AddParametrosMySql("@imei2", phone.IMEI2);
                accessDbMySql.AddParametrosMySql("@modelo", phone.Modelo);
                accessDbMySql.AddParametrosMySql("@obs", phone.Obs);
                accessDbMySql.AddParametrosMySql("@serie", phone.Serie);
                accessDbMySql.AddParametrosMySql("@descricao", phone.Descricao);
                accessDbMySql.AddParametrosMySql("@senha", phone.Senha);
                accessDbMySql.AddParametrosMySql("@contalogin", phone.ContaLogin);
                accessDbMySql.AddParametrosMySql("@contasenha", phone.ContaSenha);
                accessDbMySql.AddParametrosMySql("@bateria", phone.Bateria);
                accessDbMySql.AddParametrosMySql("@linha", phone.AparelhoLinha);
                accessDbMySql.AddParametrosMySql("@saude", phone.BateriaSaude);

                accessDbMySql.AddParametrosMySql("@contasenha", phone.);
                accessDbMySql.AddParametrosMySql("@bateria", phone.Bateria);

                return accessDbMySql.ExecutarScalarMySql("spInsertIphoneCelular");
            }
            else
                return 0;
        }

        public IphoneModeloCorColecao ConsultarIphoneModeloCorFotoId(int id)
        {
            if (accessDbMySql.ConectarSys())
            {
                accessDbMySql.AddParametrosMySql("@phone", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneModeloCorFotoId");

                if (dataTable != null)
                {
                    IphoneModeloCorColecao colecao = new IphoneModeloCorColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        IphoneModeloCorInfo cor = new IphoneModeloCorInfo
                        {
                            modcorfoto = DBNull.Value.Equals(row["modcorfoto"]) ? null : (byte[])row["modcorfoto"],
                            modcorid = Convert.ToInt32(row["modcorid"]),
                            modcoridcor = Convert.ToInt32(row["modcoridcor"]),
                            modcoridiphone = Convert.ToInt32(row["modcoridiphone"]),
                            iphcordescricao = Convert.ToString(row["iphcordescricao"])
                        };

                        colecao.Add(cor);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;

        }

        public IphoneModeloCorColecao ConsultarIphoneModeloCorFoto()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneModeloCorFoto");

                if (dataTable != null)
                {
                    IphoneModeloCorColecao colecao = new IphoneModeloCorColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        IphoneModeloCorInfo cor = new IphoneModeloCorInfo
                        {
                            modcorfoto = DBNull.Value.Equals(row["modcorfoto"]) ? null : (byte[])row["modcorfoto"],
                            modcorid = Convert.ToInt32(row["modcorid"]),
                            modcoridcor = Convert.ToInt32(row["modcoridcor"]),
                            modcoridiphone = Convert.ToInt32(row["modcoridiphone"]),
                            iphcordescricao = Convert.ToString(row["iphcordescricao"])
                        };

                        colecao.Add(cor);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;

        }

        public int UpdateFotoIphoneModelo(IphoneModeloCorInfo cor)
        {
            if (accessDbMySql.ConectarSys())
            {
                accessDbMySql.AddParametrosMySql("@phone", cor.modcoridiphone);
                accessDbMySql.AddParametrosMySql("@foto", cor.modcorfoto);

                return accessDbMySql.ExecutarScalarMySql("spUpdateFotoIphoneModelo");
            }
            else
                return 0;
        }

        public int InsertIphoneModeloCor(IphoneModeloCorInfo cor)
        {
            if (accessDbMySql.ConectarSys())
            {
                accessDbMySql.AddParametrosMySql("@phone", cor.modcoridiphone);
                accessDbMySql.AddParametrosMySql("@cor", cor.modcoridcor);
                accessDbMySql.AddParametrosMySql("@foto", cor.modcorfoto);

                return accessDbMySql.ExecutarScalarMySql("spInsertIphoneModeloCor");
            }
            else
                return 0;
        }

        public CodDescricaoColecao ConsultarIphoneCorColecao()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneCor");

                if (dataTable != null)
                {
                    CodDescricaoColecao colecao = new CodDescricaoColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        CodDescricaoInfo cod = new CodDescricaoInfo
                        {
                            cod = Convert.ToInt32(row["iphcorid"]),
                             descricao = Convert.ToString(row["iphcordescricao"])
                        };

                        colecao.Add(cod);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;

        }

        public IphoneModeloColecao ConsultarIphoneColecao()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneColecao");

                if (dataTable != null)
                    return PreencherIphoneModelo(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public List<int> ConsultarNovoIphoneModelo() //esse metodo serve consultar se há um novo modelo de cadastrado
        {
            string diretorio = @"C:\Users\Public\LevitSoft\";
            SerializarNegocios serial = new SerializarNegocios(diretorio);
            IphoneModeloColecao phone = (IphoneModeloColecao)serial.DesserializarObjeto(@"phone.lvt");
            List<int> lista = new List<int>();
            HashSet<int> setNovo = new HashSet<int>();
            HashSet<int> set = new HashSet<int>();

            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarNovoModelo");

                if (dataTable != null)
                {
                    foreach (DataRow row in dataTable.Rows)
                        setNovo.Add(Convert.ToInt32(row[0]));

                    foreach (IphoneModeloInfo item in phone)
                        set.Add(item.iphmodid);

                    HashSet<int> listaSet = new HashSet<int>(setNovo);
                    listaSet.ExceptWith(set);

                    if (listaSet.Count > 0)
                        foreach (int item in listaSet)
                            lista.Add(item);

                    return lista;
                }
                else
                    return lista;
            }
            else
                return lista;
        }

        public IphoneModeloInfo ConsultarIphoneModeloId(int id)
        {
            if (accessDbMySql.ConectarSys())
            {
                accessDbMySql.AddParametrosMySql("@cod", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarIphoneId");

                if (dataTable != null)
                    return PreencherIphoneModelo(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public IphoneModeloColecao PreencherIphoneModelo(DataTable dataTable)
        {
            IphoneModeloColecao colecao = new IphoneModeloColecao();
            foreach (DataRow iphone in dataTable.Rows)
            {
                IphoneModeloInfo phone = new IphoneModeloInfo
                {
                    iphmodbotoescontroles = Convert.ToString(iphone["iphmodbotoescontroles"]).Split(';'),
                    iphmodcamerafrontal = Convert.ToString(iphone["iphmodcamerafrontal"]).Split(';'),
                    iphmodcameratraseira = Convert.ToString(iphone["iphmodcameratraseira"]).Split(';'),
                    iphmodcapacidade = Convert.ToString(iphone["iphmodcapacidade"]).Split(';'),
                    iphmodconteudocaixa = Convert.ToString(iphone["iphmodconteudocaixa"]).Split(';'),
                    iphmodcor = Convert.ToString(iphone["iphmodcor"]).Split(';'),
                    iphmoddetalhes = Convert.ToString(iphone["iphmoddetalhes"]).Split(';'),
                    iphmodenergiabateria = Convert.ToString(iphone["iphmodenergiabateria"]).Split(';'),
                    iphmodgravacao = Convert.ToString(iphone["iphmodgravacao"]).Split(';'),
                    iphmodid = Convert.ToInt32(iphone["iphmodid"]),
                    iphmodlancamento = Convert.ToInt32(iphone["iphmodlancamento"]),
                    iphmodnum = Convert.ToString(iphone["iphmodnum"]).Split(';'),
                    iphmodpesodimensoes = Convert.ToString(iphone["iphmodpesodimensoes"]).Split(';'),
                    iphmodresistente = Convert.ToString(iphone["iphmodresistente"]).Split(';'),
                    iphmodsensores = Convert.ToString(iphone["iphmodsensores"]).Split(';'),
                    iphmodtela = Convert.ToString(iphone["iphmodtela"]).Split(';'),
                    iphmodtvvideo = Convert.ToString(iphone["iphmodtvvideo"]).Split(';'),
                    iphmoddescricao = Convert.ToString(iphone["iphmoddescricao"]),
                    iphmodipad = Convert.ToBoolean(iphone["iphmodipad"]),
                    iphmodfoto = DBNull.Value.Equals(iphone["iphmodfoto"]) ? null : (byte[])iphone["iphmodfoto"]
                };
                colecao.Add(phone);
            }

            return colecao;
        }

        #endregion Iphone
    }
}

