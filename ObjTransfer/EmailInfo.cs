using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class EmailInfo
    {
        public string[] emailTo { get; set; }
        public string[] emailCC { get; set; }
        public string[] emailCCo { get; set; }
        public string emailAssunto { get; set; }
        public string emailMessage { get; set; }
        public string[] emailAnexo { get; set; }

    }
}
