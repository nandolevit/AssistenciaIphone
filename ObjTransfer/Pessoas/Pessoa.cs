using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public UserInfo User { get; set; }
        public EnumPessoaTipo Tipo { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Nome { get; set; }
        public string Ident { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public CepInfo Endereco { get; set; }

        public bool Padrao { get; set; }
        public EnumAssistencia Assistencia { get; set; }
    }
}
