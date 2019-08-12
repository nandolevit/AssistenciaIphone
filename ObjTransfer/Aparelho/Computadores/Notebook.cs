using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Aparelho.Enum;

namespace ObjTransfer.Aparelho.Computadores
{
    public class Notebook : Computador
    {
        public PC_Monitor Tela { get; set; }

        public Notebook()
        {
            base.CategoriaPc = EnumTipoPc.Notebook;
        }
    }
}
