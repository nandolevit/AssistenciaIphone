using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjTransfer.Pessoas
{
    public class Empresa
    {
        public string Cod { get; set; }
        public string Conexao { get; set; }
        public bool Ativa { get; set; }
        public DateTime Vencimento { get; set; }
        public string OBS { get; set; }
        public EnumEmpresaNegocio Negocio { get; set; }
    }
}
