using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    class Unidade : PessoaJuridica
    {
        public string Descricao { get; set; }
        public bool Ativa { get; set; }
        public string HostServer { get; set; }
        public int ComputadorQuant { get; set; }
        public bool Sede { get; set; }
    }
}
