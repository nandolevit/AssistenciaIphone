using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
