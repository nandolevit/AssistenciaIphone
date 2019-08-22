using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho.Celulares
{
    public abstract class Celular : IAparelho
    {
        public abstract string IMEI { get; set; }
        public string IMEI2 { get; set; }
        public abstract string Capacidade { get; set; }
        public abstract string Conector { get; set; }
        public abstract string Tela { get; set; }
        public abstract string Chip { get; set; }
        public abstract string Bateria { get; set; }
        public abstract string ContaLogin { get; set; }
        public abstract string ContaSenha { get; set; }

        public abstract int Id { get; set; }
        public abstract int Ano { get; set; }
        public abstract string AparelhoLinha { get; set; }
        public abstract string Categoria { get; set; }
        public abstract string CategoriaSub { get; set; }
        public abstract string Cor { get; set; }
        public abstract string Descricao { get; set; }
        public abstract string Marca { get; set; }
        public abstract string Modelo { get; set; }
        public abstract Pessoa Pessoa { get; set; }
        public abstract string Senha { get; set; }
        public abstract string Serie { get; set; }
        public abstract string Sistema { get; set; }
        public abstract string SistemaVersao { get; set; }
        public abstract string Obs { get; set; }
    }
}
