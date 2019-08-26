using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    [Serializable]
    public class IphoneModeloInfo
    {
        public int iphmodid { get; set; }
        public int iphmodlancamento { get; set; }
        public string iphmoddescricao { get; set; }
        public string[] iphmodcor { get; set; }
        public string[] iphmodcapacidade { get; set; }
        public string[] iphmodnum { get; set; }
        public string[] iphmoddetalhes { get; set; }
        public string[] iphmodpesodimensoes { get; set; }
        public string[] iphmodtela { get; set; }
        public string[] iphmodcameratraseira { get; set; }
        public string[] iphmodcamerafrontal { get; set; }
        public string[] iphmodgravacao { get; set; }
        public string[] iphmodtvvideo { get; set; }
        public string[] iphmodbotoescontroles { get; set; }
        public string[] iphmodenergiabateria { get; set; }
        public string[] iphmodsensores { get; set; }
        public string[] iphmodconteudocaixa { get; set; }
        public string[] iphmodresistente { get; set; }
        public byte[] iphmodfoto { get; set; }
        public bool iphmodipad { get; set; }
    }
}
