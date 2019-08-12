using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
     public class PessoaFisica : Pessoa
    {
        public string Cpf { get { return CpfFormat(base.Ident); } }
        public string Rg { get; set; }
        public DateTime Niver { get; set; }

        private string CpfFormat(string cpf)
        {
            if (cpf.Length == 14)
                return string.Format("000.000.000-00", Convert.ToDouble(cpf));
            else
                return cpf;
        }
    }
}
