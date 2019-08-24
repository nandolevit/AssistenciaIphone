using System;
using System.Text;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho.Computadores
{
    public class Computador : IAparelho
    {
        public PC_RamColecao Memoria { get; set; }
        public PC_StorageColecao Hd { get; set; }
        public PC_Specification Specification { get; set; }
        public PC_VideoColecao VideoPlaca { get; set; }
        public PC_Processor_Windows MyProperty { get; set; }

        public int Id { get; set; }
        public int Ano { get; set; }
        public string AparelhoLinha { get; set; }
        public string Categoria { get; set; }
        public string CategoriaSub { get; set; }
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public PessoaInfo Pessoa { get; set; }
        public string Senha { get; set; }
        public string Serie { get; set; }
        public string Sistema { get; set; }
        public string SistemaVersao { get; set; }
        public string Obs { get; set; }

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
