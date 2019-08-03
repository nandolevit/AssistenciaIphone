using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class PessoaInfo
    {
        public int pssid { get; set; }
        public int pssiduser { get; set; }
        public EnumPessoaTipo pssidtipo { get; set; }

        public DateTime pssniver { get; set; }
        public DateTime pssdataregistro { get; set; }

        public string pssnome { get; set; }
        public string psscpf { get; set; }
        public string pssemail { get; set; }
        public string psstelefone { get; set; }
        public string pssendcep { get; set; }
        public string pssendcomplemento { get; set; }
        public string pssendlogradouro { get; set; }
        public string pssendbairro { get; set; }
        public string pssendcidade { get; set; }
        public string pssenduf { get; set; }

        public bool psspadrao { get; set; }
        public EnumAssistencia pssassistencia { get; set; }
    }
}
