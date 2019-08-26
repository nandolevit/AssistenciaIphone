using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Pessoas;
using ObjTransfer.Aparelho.Celulares;

namespace ObjTransfer
{
    public class IphoneCompraInfo
    {

        public int iphcompraid { get; set; }
        public string Descricao { get; set; }
        public string DescricaoGarantia { get; set; }
        public string DescricaoEstado { get; set; }
        public string DescricaoMargem { get; set; }
        public PessoaInfo iphcomprafornecedor { get; set; }
        public IphoneInfo iphcompraaparelho { get; set; }
        public bool iphcompranovo { get; set; }
        public bool iphcompragarantiaapple { get; set; }
        public int iphcompragarantiadias { get; set; }
        public DateTime iphcompradatacompra { get; set; }
        public DateTime iphcompradatagarantia { get; set; }
        public decimal iphcompravalorcompra { get; set; }
        public decimal iphcompravalorvenda { get; set; }
        public UserInfo iphcomprafunc { get; set; }
        public DateTime iphcompradatacontrole { get; set; }

    }
}
