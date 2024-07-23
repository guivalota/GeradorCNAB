using GeradorCNAB.Models.Segmentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Lotes
{
    public class Lote_Inf
    {
        public Header_Lote header { get; set; }
        public List <SegmentoA> segmentos { get; set; }
        public Trailer_Lote trailer { get; set; }

        public string EscreverLinha()
        {
            return header.EscreverLinha() + Environment.NewLine +trailer.EscreverLinha();
        }
    }
}
