using GeradorCNAB.Models.Lotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Arquivos
{
    class Arquivo_Inf
    {
        Header_Arquivo header { get; set; }
        List<Lote_Inf> lotes { get; set; }
        Trailer_Arquivo trailer { get; set; }
    }
}
