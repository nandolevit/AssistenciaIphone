using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    public abstract class Pessoa
    {
        public abstract int Id { get; set; }
        public abstract DateTime Nascimento { get; set; }
        public abstract UserInfo User { get; set; }
        public abstract EnumPessoaTipo Tipo { get; set; }
        public abstract DateTime DataRegistro { get; set; }
        public abstract string Nome { get; set; }
        public abstract string Ident { get; set; }
        public abstract string Email { get; set; }
        public abstract string Telefone { get; set; }
        public abstract CepInfo Endereco { get; set; }
        public abstract bool Padrao { get; set; }
        public abstract EnumAssistencia Assistencia { get; set; }
        public abstract bool booPF { get; set; }
    }
}
