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
    public class UserNegocio : PessoaNegocio
    {
        private static string EmpConexao { get; set; }

        //public UserNegocio() : base(conexao, EnumAssistencia.Assistencia)
        //{ }

        public UserNegocio(string conexao) : base(conexao, EnumAssistencia.Assistencia)
        {
            EmpConexao = conexao;
        }

        AccessDbMySql accessDbMySql = new AccessDbMySql();

        public int UpdateUserAdmin(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                return accessDbMySql.ExecutarScalarMySql("spUpdateUserAdmin");
            }
            else
                return 0;
        }

        public bool TestarConexaoSemPersistencia(string access)
        {
            bool teste = accessDbMySql.ConectarSemPersistencia(access);
            accessDbMySql.FecharConexao();
            return teste;
        }

        public bool TestarConexaoSemPersistencia()
        {
            bool teste = accessDbMySql.ConectarSemPersistencia(DadosDB.ConexaoSys);
            accessDbMySql.FecharConexao();
            return teste;
        }

        public bool TestarConexao()
        {
            bool teste = accessDbMySql.ConectarSys();
            accessDbMySql.FecharConexao();
            return teste;
        }

        
        public UserColecao ConsultarTodosLogins()
        {

            if (accessDbMySql.Conectar(EmpConexao))
            {
                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarCadastroTodosLogins");
                if (dataTable != null)
                    return PreencherUserColecao(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdateUser(UserInfo userInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@login", userInfo.uselogin);
                accessDbMySql.AddParametrosMySql("@id", userInfo.useid);
                accessDbMySql.AddParametrosMySql("@senha", userInfo.usesenha);
                
                return accessDbMySql.ExecutarScalarMySql("spUpdateLogin");
            }
            else
                return 0;
        }

        public UserInfo ConsultarUsuarioFuncId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DeletarUserLogin();
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarUsuarioFuncId");
                if (dataTable != null)
                    return PreencherUserColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public UserInfo ConsultarUsuarioId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                DeletarUserLogin();
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarUsuarioId");
                if (dataTable != null)
                    return PreencherUserColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public UserInfo ConsultarLogin(string login)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@login", login);

                DataTable dataTable = new DataTable();
                dataTable = accessDbMySql.dataTableMySql("spConsultarLogin");
                if (dataTable != null)
                    return PreencherUserColecao(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        private void DeletarUserLogin()
        {
            if (accessDbMySql.Conectar(EmpConexao))
                accessDbMySql.ExecutarScalarMySql("spDeletarUserLogin");
        }

        public int InsertUser(UserInfo userInfo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@funcionario", userInfo.useidfuncionario);
                accessDbMySql.AddParametrosMySql("@login", userInfo.uselogin);
                accessDbMySql.AddParametrosMySql("@senha", userInfo.usesenha);

                return accessDbMySql.ExecutarScalarMySql("spInsertUser");
            }
            else
                return 0;
        }

        private UserColecao PreencherUserColecao(DataTable dataTable)
        {
            UserColecao userColecao = new UserColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                UserInfo userInfo = new UserInfo
                {
                    useativo = Convert.ToInt32(row["useativo"]),
                    useid = Convert.ToInt32(row["useid"]),
                    useidfuncionario = Convert.ToInt32(row["useidfuncionario"]),
                    uselogin = Convert.ToString(row["uselogin"]),
                    usenovologin = Convert.ToInt32(row["usenovologin"]),
                    usenome = Convert.ToString(row["pssnome"]),
                    usecargo = Convert.ToInt32(row["usecargo"]),
                    usesenha = Convert.ToString(row["usesenha"])
                };

                userColecao.Add(userInfo);
            }

            return userColecao;
        }
    }
}
