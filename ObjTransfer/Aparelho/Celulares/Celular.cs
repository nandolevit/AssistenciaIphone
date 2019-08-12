using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Aparelho.Enum;

namespace ObjTransfer.Aparelho.Celulares
{
    class Celular : Aparelho
    {
        public enum EnumSistemaCel : int
        {
            Android = EnumSistema.Android,
            Windows_Phone = EnumSistema.Windows_Phone,
            Ios = EnumSistema.Ios
        }

        public string IMEI { get; set; }
        public string Capacidade { get; set; }
        public string Bateria { get; set; }
        public EnumCelularChip Chip { get; set; }
        public EnumCelularConector Conector { get; set; }
    }
}
