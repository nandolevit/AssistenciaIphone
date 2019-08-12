using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Aparelho.Enum;
using ObjTransfer.Aparelho.Computadores;

namespace ObjTransfer.Aparelho.Computadores
{
    public class Computador : Aparelho
    {
        public enum EnumSistemaPc : int
        {
            Windows = EnumSistema.Windows,
            Linux = EnumSistema.Linux,
            Ios = EnumSistema.Ios
        }
        public EnumTipoPc CategoriaPc { get; set; }
        public PC_RamColecao Memoria { get; set; }
        public PC_Storage Hd { get; set; }
        public PC_Specification Specification { get; set; }
        public PC_VideoColecao VideoPlaca { get; set; }

    }
}
