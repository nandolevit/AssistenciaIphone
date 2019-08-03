using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class ServicoIphoneInfo : ServicoInfo
    {
        public int iphdefid { get; set; }
        public int iphdefidservico { get; set; }
        public string iphdefdefeito { get; set; }
        public string iphdefobs { get; set; }
        public string iphdeftouchdisplay { get; set; }
        public string iphdefcamfrontal { get; set; }
        public string iphdefsensorprox { get; set; }
        public string iphdefhome { get; set; }
        public string iphdefautofrontal { get; set; }
        public string iphdefconector { get; set; }
        public string iphdeffone { get; set; }
        public string iphdefautointerno { get; set; }
        public string iphdefmicrofone { get; set; }
        public string iphdefparafuso { get; set; }
        public string iphdefcarcaca { get; set; }
        public string iphdefcamtraseira { get; set; }
        public string iphdefmicrofonetraseiro { get; set; }
        public string iphdefflash { get; set; }
        public string iphdefvolume { get; set; }
        public string iphdefbandeja { get; set; }
        public string iphdefdesligar { get; set; }
        public string iphdefsilencioso { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(iphdeftouchdisplay))
                sb.AppendLine("**Touch/Display: " + iphdeftouchdisplay);

            if (!string.IsNullOrEmpty(iphdefcamfrontal))
                sb.AppendLine("**Câmera frontal: " + iphdefcamfrontal);

            if (!string.IsNullOrEmpty(iphdefsensorprox))
                sb.AppendLine("**Sensor de proximidade: " + iphdefsensorprox);

            if (!string.IsNullOrEmpty(iphdefhome))
                sb.AppendLine("**Botão home/Touch ID: " + iphdefhome);

            if (!string.IsNullOrEmpty(iphdefautofrontal))
                sb.AppendLine("**Auto-falante frontal: " + iphdefautofrontal);

            if (!string.IsNullOrEmpty(iphdefconector))
                sb.AppendLine("**Conector Lightning: " + iphdefconector);

            if (!string.IsNullOrEmpty(iphdeffone))
                sb.AppendLine("**Miniconector de fone de ouvido: " + iphdeffone);

            if (!string.IsNullOrEmpty(iphdefautointerno))
                sb.AppendLine("**Auto-falante interno: " + iphdefautointerno);

            if (!string.IsNullOrEmpty(iphdefmicrofone))
                sb.AppendLine("**Microfone: " + iphdefmicrofone);

            if (!string.IsNullOrEmpty(iphdefparafuso))
                sb.AppendLine("**Parafuso da carcaça: " + iphdefparafuso);

            if (!string.IsNullOrEmpty(iphdefparafuso))
                sb.AppendLine("**Parafuso da carcaça: " + iphdefparafuso);

            if (!string.IsNullOrEmpty(iphdefcarcaca))
                sb.AppendLine("**Estado da carcaça: " + iphdefcarcaca);

            if (!string.IsNullOrEmpty(iphdefcamtraseira))
                sb.AppendLine("**Câmera traseira: " + iphdefcamtraseira);

            if (!string.IsNullOrEmpty(iphdefmicrofonetraseiro))
                sb.AppendLine("**Microfone traseiro: " + iphdefmicrofonetraseiro);

            if (!string.IsNullOrEmpty(iphdefflash))
                sb.AppendLine("**Flash: " + iphdefflash);

            if (!string.IsNullOrEmpty(iphdefautointerno))
                sb.AppendLine("**Auto-falante interno: " + iphdefautointerno);

            if (!string.IsNullOrEmpty(iphdefvolume))
                sb.AppendLine("**Botão de Volume: " + iphdefvolume);

            if (!string.IsNullOrEmpty(iphdefbandeja))
                sb.AppendLine("**Bandeja de Chip: " + iphdefbandeja);

            if (!string.IsNullOrEmpty(iphdefdesligar))
                sb.AppendLine("**Botão Ligar/Desligar: " + iphdefdesligar);

            if (!string.IsNullOrEmpty(iphdefsilencioso))
                sb.AppendLine("**Botão Tocar/Silencioso: " + iphdefsilencioso);

            return sb.ToString();
        }
    }
}
