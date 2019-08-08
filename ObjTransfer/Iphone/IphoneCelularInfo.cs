using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer
{
    public class IphoneCelularInfo
    {
        public int celid { get; set; }
        public int celidmodiphone { get; set; }
        public string celiphonedescricao { get; set; }
        public int celidcliente { get; set; }
        public string celcor { get; set; }
        public string celcapacidade { get; set; }
        public string celmodelo { get; set; }
        public string celimei { get; set; }
        public string celanocompra { get; set; }
        public string celserie { get; set; }
        public string celobs { get; set; }
        public string celsenha { get; set; }
        public string celicloudlogin { get; set; }
        public string celicloudsenha { get; set; }
        public int celidcor { get; set; }
        public string celbateria { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(celiphonedescricao)) sb.Append(celiphonedescricao);
            if (!string.IsNullOrEmpty(celcor)) sb.Append(", Cor: " + celcor);
            if (!string.IsNullOrEmpty(celcapacidade)) sb.Append(", Capacidade: " + celcapacidade);
            if (!string.IsNullOrEmpty(celbateria)) sb.Append(", Bateria: " + celbateria + "%");
            if (!string.IsNullOrEmpty(celmodelo)) sb.Append(", Modelo: " + celmodelo);
            if (!string.IsNullOrEmpty(celimei)) sb.Append(", IMEI: " + celimei);
            if (!string.IsNullOrEmpty(celserie)) sb.Append(", SÉRIE: " + celserie);
            if (!string.IsNullOrEmpty(celanocompra)) sb.Append(", Ano: " + celanocompra);

            return sb.ToString();
        }
    }
}
