using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    public class PessoaInfo
    {
        public int Id { get; set; }
        public DateTime Nascimento { get; set; }
        public UserInfo User { get; set; }
        public EnumPessoaTipo Tipo { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Nome { get; set; }
        public string Ident { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public EnderecoInfo Endereco { get; set; }
        public bool Padrao { get; set; }
        public EnumAssistencia Assistencia { get; set; }
        public bool booPF { get; set; }

        public string IdentFormat()
        {
            if (booPF)
                return string.Format("000,000,000-00", Convert.ToDouble(Ident));
            else
                return string.Format("00,000,000/0000-00", Convert.ToDouble(Ident));
        }
    }
}
