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
