using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjTransfer;
using ObjTransfer.Pessoas;
using AccessDB;
using System.Data;

namespace Negocios
{
    public class PessoaNegocio
    {
        private string EmpConexao { get; set; }
        AccessDbMySql accessDbMySql;
        EnumAssistencia Assistencia;
        public PessoaNegocio(string conexao, EnumAssistencia assistencia)
        {
            EmpConexao = conexao;
            Assistencia = assistencia;
            accessDbMySql = new AccessDbMySql(EmpConexao);
        }

        public PessoaInfo ConsultarPessoaPadrao(EnumPessoaTipo tipo, bool pad = true)
        {
            if (accessDbMySql.Conectar())
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
            if (accessDbMySql.Conectar())
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
            if (accessDbMySql.Conectar())
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
            if (accessDbMySql.Conectar())
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
            if (accessDbMySql.Conectar())
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
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@id", pessoa.Id);
                accessDbMySql.AddParametrosMySql("@cpf", pessoa.Ident);
                accessDbMySql.AddParametrosMySql("@email", pessoa.Email);
                accessDbMySql.AddParametrosMySql("@bairro", pessoa.Endereco.Bairro);
                accessDbMySql.AddParametrosMySql("@cep", pessoa.Endereco.Cep);
                accessDbMySql.AddParametrosMySql("@cidade", pessoa.Endereco.Cidade);
                accessDbMySql.AddParametrosMySql("@comp", pessoa.Endereco.Complemento);
                accessDbMySql.AddParametrosMySql("@log", pessoa.Endereco.Logradouro);
                accessDbMySql.AddParametrosMySql("@uf", pessoa.Endereco.Uf);
                accessDbMySql.AddParametrosMySql("@niver", pessoa.Nascimento);
                accessDbMySql.AddParametrosMySql("@nome", pessoa.Nome);
                accessDbMySql.AddParametrosMySql("@telefone", pessoa.Telefone);

                return accessDbMySql.ExecutarScalarMySql("spUpdatePessoa");
            }
            else
                return 0;
        }

        public int InsertPessoa(PessoaInfo pessoa)
        {
            if (accessDbMySql.Conectar())
            {
                accessDbMySql.AddParametrosMySql("@assist", Assistencia);
                accessDbMySql.AddParametrosMySql("@ident", pessoa.Ident);
                accessDbMySql.AddParametrosMySql("@email", pessoa.Email);
                accessDbMySql.AddParametrosMySql("@bairro", pessoa.Endereco.Bairro);
                accessDbMySql.AddParametrosMySql("@cep", pessoa.Endereco.Cep);
                accessDbMySql.AddParametrosMySql("@cidade", pessoa.Endereco.Cidade);
                accessDbMySql.AddParametrosMySql("@comp", pessoa.Endereco.Complemento);
                accessDbMySql.AddParametrosMySql("@log", pessoa.Endereco.Logradouro);
                accessDbMySql.AddParametrosMySql("@ref", pessoa.Endereco.PontoReferencia);
                accessDbMySql.AddParametrosMySql("@uf", pessoa.Endereco.Uf);
                accessDbMySql.AddParametrosMySql("@tipo", pessoa.Tipo);
                accessDbMySql.AddParametrosMySql("@iduser", pessoa.User.useidfuncionario);
                accessDbMySql.AddParametrosMySql("@nascimento", pessoa.Nascimento);
                accessDbMySql.AddParametrosMySql("@nome", pessoa.Nome);
                accessDbMySql.AddParametrosMySql("@telefone", pessoa.Telefone);
                accessDbMySql.AddParametrosMySql("@padrao", pessoa.Padrao);
                accessDbMySql.AddParametrosMySql("@pessoa", pessoa.booPF);

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
                PessoaInfo pessoa = new PessoaInfo
                {
                    Assistencia = (EnumAssistencia)Convert.ToInt32(row["pessoaassistencia"]),
                    Ident = Convert.ToString(row["pessoaident"]),
                    DataRegistro = Convert.ToDateTime(row["pessoadataregistro"]).Date,
                    Nome = Convert.ToString(row["pessoanome"]),
                    Email = Convert.ToString(row["pessoaemail"]),
                    Id = Convert.ToInt32(row["pessoaid"]),
                    Tipo = (EnumPessoaTipo)Convert.ToInt32(row["pessoaassistencia"]),
                    Nascimento = Convert.ToDateTime(row["pessoaniver"]).Date,
                    Telefone = Convert.ToString(row["pessoatelefone"]),
                };

                pessoa.Endereco = new EnderecoInfo
                {
                    Bairro = Convert.ToString(row["pessoaendbairro"]),
                    Cep = Convert.ToString(row["pessoaendcep"]),
                    Cidade = Convert.ToString(row["pessoaendcidade"]),
                    Complemento = Convert.ToString(row["pessoaendcomplemento"]),
                    Logradouro = Convert.ToString(row["pessoaendlogradouro"]),
                    PontoReferencia = Convert.ToString(row["pessoaendpontoref"]),
                    Uf = Convert.ToString(row["pessoaenduf"]),
                };

                UserNegocio userNegocio = new UserNegocio(EmpConexao);
                pessoa.User = userNegocio.ConsultarUsuarioFuncId(Convert.ToInt32(row["pessoaiduser"]));

                colecao.Add(pessoa);
            }

            return colecao;
        }

    }
}
