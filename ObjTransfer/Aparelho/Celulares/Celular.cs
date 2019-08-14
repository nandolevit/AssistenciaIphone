using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Aparelho.Enum;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho.Celulares
{
    class Celular : IAparelho
    {
        public string IMEI { get; set; }
        public string Capacidade { get; set; }
        public string Bateria { get; set; }
        public EnumCelularChip Chip { get; set; }
        public EnumCelularConector Conector { get; set; }

        public int Id { get ; set ; }
        public Pessoa Pessoa { get; set; }
        public string Descricao { get; set; }
        public string Serie { get; set; }
        public int Tipo { get; set; }
        public AparelhoMarca Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Sistema { get; set; }
        public string Cor { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
