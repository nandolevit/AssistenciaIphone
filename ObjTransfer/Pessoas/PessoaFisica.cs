using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
     public class PessoaFisica : Pessoa
    {
        public string Cpf { get { return CpfFormat(); } }
        public string Rg { get; set; }

        public override int Id { get; set; }
        public override DateTime Criacao { get; set; }
        public override UserInfo User { get; set; }
        public override EnumPessoaTipo Tipo { get; set; }
        public override DateTime DataRegistro { get; set; }
        public override string Nome { get; set; }
        public override string Ident { get; set; }
        public override string Email { get; set; }
        public override string Telefone { get; set; }
        public override CepInfo Endereco { get; set; }
        public override bool Padrao { get; set; }
        public override EnumAssistencia Assistencia { get; set; }

        private string CpfFormat()
        {
            return string.Format("000.000.000-00", Convert.ToDouble(Ident));
        }
    }
}
