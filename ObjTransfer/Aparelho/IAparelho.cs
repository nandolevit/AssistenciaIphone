using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjTransfer.Aparelho.Enum;
using ObjTransfer.Pessoas;

namespace ObjTransfer.Aparelho
{
    interface IAparelho
    {
        int Id { get; set; }
        Pessoa Pessoa { get; set; }
        string Descricao { get; set; }
        string Serie { get; set; }
        int Tipo { get; set; }
        AparelhoMarca Marca { get; set; }
        string Modelo { get; set; }
        string Cor { get; set; }
        int Ano { get; set; }
        string Sistema { get; set; }
    }
}
