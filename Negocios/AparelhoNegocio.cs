using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ObjTransfer.Aparelho;
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
                        AparelhoMarca marca = new AparelhoMarca
                        {
                            Descricao = Convert.ToString(row["marcadescricao"]),
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

        public SistemaOperacionalModeloColecao ConsultarSistemaModelo(int win)
        {
            if (accessDbMySql.ConectarSys())
            {
                accessDbMySql.AddParametrosMySql("@win", win);
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

        public SistemaOperacionalVersaoColecao ConsultarSistemaVersao(int win)
        {
            if (accessDbMySql.ConectarSys())
            {
                accessDbMySql.AddParametrosMySql("@win", win);
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

        public SistemaOperacionalColecao ConsultarSistemaPorLinha(int lina)
        {
            if (accessDbMySql.ConectarSys())
            {
                accessDbMySql.AddParametrosMySql("@linha", lina);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarSistemaPorLinha");

                if (dataTable != null)
                {
                    SistemaOperacionalColecao colecao = new SistemaOperacionalColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        SistemaOperacional operacional = new SistemaOperacional
                        {
                            Descricao = Convert.ToString(row["sodescricao"]),
                            Id = Convert.ToInt32(row["soid"])
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
