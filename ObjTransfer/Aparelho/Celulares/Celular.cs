using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho.Celulares
{
    public class Celular : IAparelho
    {
        public string IMEI { get; set; }
        public string Capacidade { get; set; }
        public string Conector { get; set; }
        public string Tela { get; set; }
        public string Chip { get; set; }
        public string Bateria { get; set; }
        public int BateriaSaude { get; set; }
        public string ContaLogin { get; set; }
        public string ContaSenha { get; set; }

        public int Id { get; set; }
        public int Ano { get; set; }
        public string AparelhoLinha { get; set; }
        public string Categoria { get; set; }
        public string CategoriaSub { get; set; }
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Pessoa Pessoa { get; set; }
        public string Senha { get; set; }
        public string Serie { get; set; }
        public string Sistema { get; set; }
        public string SistemaVersao { get; set; }
    }
}
