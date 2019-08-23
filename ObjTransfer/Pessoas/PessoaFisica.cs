using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
     public class PessoaFisica : PessoaInfo
    {
        public string Cpf { get { return CpfFormat(); } }
        public string Rg { get; set; }


        private string CpfFormat()
        {
            return string.Format("000.000.000-00", Convert.ToDouble(base.Ident));
        }
    }
}
