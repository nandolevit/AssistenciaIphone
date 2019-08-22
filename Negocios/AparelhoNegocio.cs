using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ObjTransfer.Aparelho;
using ObjTransfer.Aparelho.Celulares;
using ObjTransfer.Aparelho.Computadores;
using AccessDB;

namespace Negocios
{
    public class AparelhoNegocio
    {
        public string EmpConexao { get; set; }
        AccessDbMySql accessDbMySql;

        public AparelhoNegocio(string empConexao)
        {
            EmpConexao = empConexao;
            accessDbMySql = new AccessDbMySql(EmpConexao);
        }

        public Iphone ConsultarIphone(int id)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@id", id);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarAparelhoIphone");
                if (dataTable != null)
                {

                }
            }
        }

        public int InsertIphone(Iphone iphone)
        {
            iphone.Id = InsertAparelho(iphone);

            if (iphone.Id > 0)
            {
                int id = InsertCelular(iphone);

                if (id > 0)
                {
                    if (accessDbMySql.Conectar())
                    {
                        accessDbMySql.AddParametrosMySql("@saude", iphone.BateriaSaude);
                        accessDbMySql.AddParametrosMySql("@id", id);

                        return accessDbMySql.ExecutarScalarMySql("spInsertIphone");
                    }
                    else
                        return 0;
                }
                else
                    return 0;
            }
            else
                return 0;
        }

        private int InsertCelular(Celular cel)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@imei", cel.IMEI);
                accessDbMySql.AddParametrosMySql("@imei2", cel.IMEI2);
                accessDbMySql.AddParametrosMySql("@bateria", cel.Bateria);
                accessDbMySql.AddParametrosMySql("@capacidade", cel.Capacidade);
                accessDbMySql.AddParametrosMySql("@chip", cel.Chip);
                accessDbMySql.AddParametrosMySql("@conector", cel.Conector);
                accessDbMySql.AddParametrosMySql("@login", cel.ContaLogin);
                accessDbMySql.AddParametrosMySql("@senha", cel.ContaSenha);
                accessDbMySql.AddParametrosMySql("@tela", cel.Tela);
                accessDbMySql.AddParametrosMySql("@aparelho", cel.Id);

                return accessDbMySql.ExecutarScalarMySql("spInsertCelular");
            }
            else
                return 0;
        }

        private int InsertAparelho(IAparelho aparelho)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@ano", aparelho.Ano);
                accessDbMySql.AddParametrosMySql("@linha", aparelho.AparelhoLinha);
                accessDbMySql.AddParametrosMySql("@categoria", aparelho.Categoria);
                accessDbMySql.AddParametrosMySql("@sub", aparelho.CategoriaSub);
                accessDbMySql.AddParametrosMySql("@cor", aparelho.Cor);
                accessDbMySql.AddParametrosMySql("@descricao", aparelho.Descricao);
                accessDbMySql.AddParametrosMySql("@marca", aparelho.Marca);
                accessDbMySql.AddParametrosMySql("@modelo", aparelho.Modelo);
                accessDbMySql.AddParametrosMySql("@pessoa", aparelho.Pessoa.Id);
                accessDbMySql.AddParametrosMySql("@senha", aparelho.Senha);
                accessDbMySql.AddParametrosMySql("@serie", aparelho.Serie);
                accessDbMySql.AddParametrosMySql("@sistema", aparelho.Sistema);
                accessDbMySql.AddParametrosMySql("@versao", aparelho.SistemaVersao);
                accessDbMySql.AddParametrosMySql("@obs", aparelho.Obs);

                return accessDbMySql.ExecutarScalarMySql("spInsertAparelho");
            }
            else
                return 0;
        }

        public ProcessadorModeloColecao ConsultarProcessadorModelo()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProcessadorModelo");
                if (dataTable != null)
                {
                    ProcessadorModeloColecao colecao = new ProcessadorModeloColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ProcessadorModelo linha = new ProcessadorModelo
                        {
                            Descricao = Convert.ToString(row["procmoddescricao"]),
                            Id = Convert.ToInt32(row["procmodid"]),
                            IdLinha = Convert.ToInt32(row["procmodidproc"]),
                        };

                        colecao.Add(linha);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public ProcessadorLinhaColecao ConsultarProcessadorLinha()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarProcessador");
                if (dataTable != null)
                {
                    ProcessadorLinhaColecao colecao = new ProcessadorLinhaColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ProcessadorLinha linha = new ProcessadorLinha
                        {
                            Descricao = Convert.ToString(row["procdescricao"]),
                            Id = Convert.ToInt32(row["procid"])
                        };

                        colecao.Add(linha);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public AparelhoMarcaColecao ConsultarAparelhoMarca(int linha)
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable;

                if (linha == 2)
                    dataTable = accessDbMySql.dataTableMySql("spConsultarAparelhoMarcaPc");
                else
                    dataTable = accessDbMySql.dataTableMySql("spConsultarAparelhoMarcaCelular");

                if (dataTable != null)
                {
                    AparelhoMarcaColecao colecao = new AparelhoMarcaColecao();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string descricao = Convert.ToString(row["marcadescricao"]);
                        AparelhoMarca marca = new AparelhoMarca
                        {
                            Descricao = descricao.Substring(0, 1).ToUpper() + descricao.Substring(1).ToLower(),
                            Id = Convert.ToInt32(row["marcaid"])
                        };

                        colecao.Add(marca);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public SistemaOperacionalModeloColecao ConsultarSistemaModelo()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSistemaModelo");

                if (dataTable != null)
                {
                    SistemaOperacionalModeloColecao colecao = new SistemaOperacionalModeloColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        SistemaOperacionalModelo operacional = new SistemaOperacionalModelo
                        {
                            Descricao = Convert.ToString(row["winverdescricao"]),
                            Id = Convert.ToInt32(row["winverid"]),
                            IdSo = Convert.ToInt32(row["winveridwin"])
                        };

                        colecao.Add(operacional);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public SistemaOperacionalVersaoColecao ConsultarSistemaVersao()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSistemaVersao");

                if (dataTable != null)
                {
                    SistemaOperacionalVersaoColecao colecao = new SistemaOperacionalVersaoColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        SistemaOperacionalVersao operacional = new SistemaOperacionalVersao
                        {
                            Descricao = Convert.ToString(row["windescricao"]),
                            Id = Convert.ToInt32(row["winid"]),
                            IdSo = Convert.ToInt32(row["winidso"])
                        };

                        colecao.Add(operacional);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public SistemaOperacionalColecao ConsultarSistemaPorLinha()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSistemaPorLinha");

                if (dataTable != null)
                {
                    SistemaOperacionalColecao colecao = new SistemaOperacionalColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        SistemaOperacional operacional = new SistemaOperacional
                        {
                            Descricao = Convert.ToString(row["sodescricao"]),
                            Id = Convert.ToInt32(row["soid"]),
                            Soidlinha = Convert.ToInt32(row["soidlinha"])
                        };

                        colecao.Add(operacional);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public AparelhoLinhaColecao ConsultarAparelhoLinha()
        {
            if (accessDbMySql.ConectarSys())
            {
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarAparelhoLinha");

                if (dataTable != null)
                {
                    AparelhoLinhaColecao colecao = new AparelhoLinhaColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        AparelhoLinha linha = new AparelhoLinha
                        {
                            linhadescricao = Convert.ToString(row["linhadescricao"]),
                            linhaid = Convert.ToInt32(row["linhaid"]),
                            linhaidtipo = Convert.ToInt32(row["linhaidtipo"])
                        };

                        colecao.Add(linha);
                    }

                    return colecao;
                }
                else
                    return null;
            }
            else
                return null;
        }
    }
}
