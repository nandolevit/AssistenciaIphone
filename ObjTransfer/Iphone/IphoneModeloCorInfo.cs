using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class IphoneModeloCorInfo
    {
        public int modcorid { get; set; }
        public int modcoridiphone { get; set; }
        public int modcoridcor { get; set; }
        public byte[] modcorfoto { get; set; }
        public string iphcordescricao { get; set; }
    }
}
