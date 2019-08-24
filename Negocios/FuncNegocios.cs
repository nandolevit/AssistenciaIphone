using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccessDB;
using ObjTransfer;
using ObjTransfer.Pessoas;

namespace Negocios
{
    public class FuncNegocios : PessoaNegocio
    {
        private string EmpConexao { get; set; }
        AccessDbMySql accessDbMySql;

        public FuncNegocios(string conexao, EnumAssistencia assistencia) : base(conexao, assistencia)
        {
            EmpConexao = conexao;
            accessDbMySql = new AccessDbMySql(EmpConexao);
        }

        public CodDescricaoColecao ConsultarCargos()
        {
            if (accessDbMySql.Conectar())
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarCargo");

                if (dataTable != null)
                {
                    CodDescricaoColecao codDescricaoColecao = new CodDescricaoColecao();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        CodDescricaoInfo cod = new CodDescricaoInfo
                        {
                            cod = Convert.ToInt32(row["cargoid"]),
                            descricao = Convert.ToString(row["cargodescricao"])
                        };

                        codDescricaoColecao.Add(cod);
                    }

                    return codDescricaoColecao;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public PessoaColecao ConsultarFuncTecnico()
        {
            if (accessDbMySql.Conectar())
            {
                DataTable dataTable = new DataTable();

                dataTable = accessDbMySql.dataTableMySql("spConsultarPessoaTecnico");

                if (dataTable != null)
                    return base.PreencherPessoa(dataTable);
                else
                    return null;
            }
            else
                return null;
        }
    }
}
