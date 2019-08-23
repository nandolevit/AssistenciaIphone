using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get { return CnpjFormat(); } }
        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }

        public override int Id { get; set; }
        public override DateTime Nascimento { get; set; }
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
        public override bool booPF { get; set; }

        private string CnpjFormat()
        {
            return string.Format("00.000.000/0000-00", Convert.ToDouble(Ident));
        }
    }
}
