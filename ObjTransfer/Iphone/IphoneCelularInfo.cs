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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.IsNullOrEmpty(celiphonedescricao) ? "" : celiphonedescricao);
            sb.Append(string.IsNullOrEmpty(celmodelo) ? "" : ", Modelo: " + celmodelo);
            sb.Append(string.IsNullOrEmpty(celimei) ? "" : ", IMEI: " + celimei);
            sb.Append(string.IsNullOrEmpty(celserie) ? "" : ", SÉRIE: " + celserie);
            sb.Append(string.IsNullOrEmpty(celanocompra) ? "" : ", Ano: " + celanocompra);
            sb.Append(string.IsNullOrEmpty(celcapacidade) ? "" : ", Capacidade: " + celcapacidade);
            sb.Append(string.IsNullOrEmpty(celcor) ? "" : ", Cor: " + celcor);

            return sb.ToString();
        }
    }
}
