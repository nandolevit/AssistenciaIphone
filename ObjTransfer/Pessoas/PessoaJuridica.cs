using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get { return CnpjFormat(base.Ident); } }
        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime Fundada { get; set; }

        private string CnpjFormat(string pj)
        {
            if (pj.Length == 14)
                return string.Format("00.000.000/0000-00", Convert.ToDouble(pj));
            else
                return pj;
        }
    }
}
