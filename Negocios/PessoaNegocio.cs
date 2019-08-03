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
    public class PessoaNegocio
    {
        private string EmpConexao { get; set; }
        AccessDbMySql accessDbMySql = new AccessDbMySql();
        EnumPessoaTipo enumTipo;
        EnumAssistencia Assistencia;
        public PessoaNegocio(string conexao, EnumAssistencia assistencia)
        {
            EmpConexao = conexao;
            Assistencia = assistencia;
        }

        public PessoaInfo ConsultarPessoaPadrao(EnumPessoaTipo tipo, bool pad = true)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@tipo", tipo);
                accessDbMySql.AddParametrosMySql("@padrao", pad);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPessoaPadrao");
                if (dataTable != null)
                    return PreencherPessoa(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }
        public PessoaInfo ConsultarPessoaCpf(string cpf)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@cpf", cpf);
                accessDbMySql.AddParametrosMySql("@assist", Assistencia);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPessoaCpf");
                if (dataTable != null)
                    return PreencherPessoa(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public CepInfo ConsultarCep(string cepArg)
        {
            CepDB cepDB = new CepDB(cepArg);
            return cepDB.BuscarCorreios();
        }

        public PessoaInfo ConsultarPessoaId(int id)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", id);

                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPessoaId");
                if (dataTable != null)
                    return PreencherPessoa(dataTable)[0];
                else
                    return null;
            }
            else
                return null;
        }

        public PessoaColecao ConsultarPessoaPorTipo(EnumPessoaTipo tipo)
        {
            return ConsultarPessoaDescricao("%", tipo);
        }

        public PessoaColecao ConsultarPessoaDescricaoTodos(string descricao, EnumAssistencia assistencia)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@descricao", descricao);
                accessDbMySql.AddParametrosMySql("@assist", assistencia);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPessoaDescricaoTodos");
                if (dataTable != null)
                    return PreencherPessoa(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public PessoaColecao ConsultarPessoaDescricao(string descricao, EnumPessoaTipo tipo)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@descricao", descricao);
                accessDbMySql.AddParametrosMySql("@tipo", tipo);
                accessDbMySql.AddParametrosMySql("@assist", Assistencia);
                DataTable dataTable = accessDbMySql.dataTableMySql("spConsultarPessoaDescricao");
                if (dataTable != null)
                    return PreencherPessoa(dataTable);
                else
                    return null;
            }
            else
                return null;
        }

        public int UpdatePessoa(PessoaInfo pessoa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@id", pessoa.pssid);
                accessDbMySql.AddParametrosMySql("@cpf", pessoa.psscpf);
                accessDbMySql.AddParametrosMySql("@email", pessoa.pssemail);
                accessDbMySql.AddParametrosMySql("@bairro", pessoa.pssendbairro);
                accessDbMySql.AddParametrosMySql("@cep", pessoa.pssendcep);
                accessDbMySql.AddParametrosMySql("@cidade", pessoa.pssendcidade);
                accessDbMySql.AddParametrosMySql("@comp", pessoa.pssendcomplemento);
                accessDbMySql.AddParametrosMySql("@log", pessoa.pssendlogradouro);
                accessDbMySql.AddParametrosMySql("@uf", pessoa.pssenduf);
                accessDbMySql.AddParametrosMySql("@niver", pessoa.pssniver);
                accessDbMySql.AddParametrosMySql("@nome", pessoa.pssnome);
                accessDbMySql.AddParametrosMySql("@telefone", pessoa.psstelefone);

                return accessDbMySql.ExecutarScalarMySql("spUpdatePessoa");
            }
            else
                return 0;
        }

        public int InsertPessoa(PessoaInfo pessoa)
        {
            if (accessDbMySql.Conectar(EmpConexao))
            {
                accessDbMySql.AddParametrosMySql("@assist", Assistencia);
                accessDbMySql.AddParametrosMySql("@cpf", pessoa.psscpf);
                accessDbMySql.AddParametrosMySql("@email", pessoa.pssemail);
                accessDbMySql.AddParametrosMySql("@bairro", pessoa.pssendbairro);
                accessDbMySql.AddParametrosMySql("@cep", pessoa.pssendcep);
                accessDbMySql.AddParametrosMySql("@cidade", pessoa.pssendcidade);
                accessDbMySql.AddParametrosMySql("@comp", pessoa.pssendcomplemento);
                accessDbMySql.AddParametrosMySql("@log", pessoa.pssendlogradouro);
                accessDbMySql.AddParametrosMySql("@uf", pessoa.pssenduf);
                accessDbMySql.AddParametrosMySql("@tipo", pessoa.pssidtipo);
                accessDbMySql.AddParametrosMySql("@user", pessoa.pssiduser);
                accessDbMySql.AddParametrosMySql("@niver", pessoa.pssniver);
                accessDbMySql.AddParametrosMySql("@nome", pessoa.pssnome);
                accessDbMySql.AddParametrosMySql("@telefone", pessoa.psstelefone);
                accessDbMySql.AddParametrosMySql("@padrao", pessoa.psspadrao);

                return accessDbMySql.ExecutarScalarMySql("spInsertPessoa");
            }
            else
                return 0;
        }

        protected PessoaColecao PreencherPessoa(DataTable dataTable)
        {
            PessoaColecao colecao = new PessoaColecao();
            foreach (DataRow row in dataTable.Rows)
            {
                enumTipo = new EnumPessoaTipo();
                EnumAssistencia assist = new EnumAssistencia();

                switch (Convert.ToInt32(row["pssassistencia"]))
                {
                    case 1:
                        enumTipo = EnumPessoaTipo.Cliente;
                        break;
                    case 2:
                        enumTipo = EnumPessoaTipo.Funcionario;
                        break;
                    case 3:
                        enumTipo = EnumPessoaTipo.Fornecedor;
                        break;
                    default:
                        break;
                }

                if (Convert.ToBoolean(row["pssassistencia"]))
                    assist = EnumAssistencia.Assistencia;
                else
                    assist = EnumAssistencia.Loja;

                PessoaInfo pessoa = new PessoaInfo
                {
                    pssassistencia = assist,
                    psscpf = Convert.ToString(row["psscpf"]),
                    pssdataregistro = Convert.ToDateTime(row["pssdataregistro"]).Date,
                    pssnome = Convert.ToString(row["pssnome"]),
                    pssemail = Convert.ToString(row["pssemail"]),
                    pssendbairro = Convert.ToString(row["pssendbairro"]),
                    pssendcep = Convert.ToString(row["pssendcep"]),
                    pssendcidade = Convert.ToString(row["pssendcidade"]),
                    pssendcomplemento = Convert.ToString(row["pssendcomplemento"]),
                    pssendlogradouro = Convert.ToString(row["pssendlogradouro"]),
                    pssenduf = Convert.ToString(row["pssenduf"]),
                    pssid = Convert.ToInt32(row["pssid"]),
                    pssidtipo = enumTipo,
                    pssiduser = Convert.ToInt32(row["pssiduser"]),
                    pssniver = Convert.ToDateTime(row["pssniver"]).Date,
                    psstelefone = Convert.ToString(row["psstelefone"]),
                };

                colecao.Add(pessoa);
            }

            return colecao;
        }

    }
}
