using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    public class PessoaJuridica : PessoaInfo
    {
        public string Cnpj { get { return CnpjFormat(); } }
        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }

        private string CnpjFormat()
        {
            return string.Format("00.000.000/0000-00", Convert.ToDouble(base.Ident));
        }
    }
}
