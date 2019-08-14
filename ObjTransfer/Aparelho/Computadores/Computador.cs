using System;
using System.Text;
using ObjTransfer.Aparelho.Enum;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho.Computadores
{
    public class Computador : IAparelho
    {
        public EnumTipoPc CategoriaPc { get; set; }
        public PC_RamColecao Memoria { get; set; }
        public PC_StorageColecao Hd { get; set; }
        public PC_Specification Specification { get; set; }
        public PC_VideoColecao VideoPlaca { get; set; }

        public int Id { get; set; }
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
            StringBuilder sb = new StringBuilder();

            sb.Append(Descricao);
            sb.Append(Descricao);
            sb.Append(Descricao);
            sb.Append(Descricao);
            sb.Append(Descricao);
            sb.Append(Descricao);
            sb.Append(Descricao);
            sb.Append(Descricao);
            sb.Append(Descricao);
            return base.ToString();
        }

    }
}
