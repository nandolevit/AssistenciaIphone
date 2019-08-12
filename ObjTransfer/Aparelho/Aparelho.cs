using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Aparelho.Enum;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho
{
    public class Aparelho
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public  string Descricao { get; set; }
        public string Serie { get; set; }
        public int Tipo { get; set; }
        public int CorId { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public string Modelo { get; set; }
        public DateTime DataCompra { get; set; }
        public string Sistema { get; set; }
        public EnumSistema SistemaTipo { get; set; }

    }
}
