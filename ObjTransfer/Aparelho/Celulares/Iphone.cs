using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho.Celulares
{
    public class Iphone : Celular
    {
        public string BateriaSaude { get; set; }

        public override string IMEI { get; set; }
        public override string Capacidade { get; set; }
        public override string Conector { get; set; }
        public override string Tela { get; set; }
        public override string Chip { get; set; }
        public override string Bateria { get; set; }
        public override string ContaLogin { get; set; }
        public override string ContaSenha { get; set; }
        public override string Obs { get; set; }

        public override int Id { get; set; }
        public override int Ano { get; set; }
        public override string AparelhoLinha { get; set; }
        public override string Categoria { get; set; }
        public override string CategoriaSub { get; set; }
        public override string Cor { get; set; }
        public override string Descricao { get; set; }
        public override string Marca { get; set; }
        public override string Modelo { get; set; }
        public override Pessoa Pessoa { get; set; }
        public override string Senha { get; set; }
        public override string Serie { get; set; }
        public override string Sistema { get; set; }
        public override string SistemaVersao { get; set; }
    }
}
