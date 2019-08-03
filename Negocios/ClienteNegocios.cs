using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using AccessDB;
using System.Data;

namespace Negocios
{
    public class ClienteNegocios : PessoaNegocio
    {
        enum Tipo { Id, Cpf, Nome, Email, Telefone }
        private string EmpConexao { get; set; }

        public ClienteNegocios(string conexao, EnumAssistencia assistencia) : base(conexao, assistencia)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

    }
}
