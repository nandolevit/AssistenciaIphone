using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho
{
    public interface IAparelho
    {
        int Id { get; set; }
        int Ano { get; set; }
        string AparelhoLinha { get; set; }
        string Categoria { get; set; }
        string CategoriaSub { get; set; }
        string Cor { get; set; }
        string Descricao { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        Pessoa Pessoa { get; set; }
        string Senha { get; set; }
        string Serie { get; set; }
        string Sistema { get; set; }
        string SistemaVersao { get; set; }
        string Obs { get; set; }
    }
}
