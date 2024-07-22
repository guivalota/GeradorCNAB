using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Arquivos
{
    class Trailer_Arquivo
    {
        public string Banco { get; set; }
        public string Lote { get; set; }
        public string Registro { get; set; }
        public string CNAB1 { get; set; }
        public string Totais_QtdLotes { get; set; }
        public string Totais_QtdRegistros { get; set; }
        public string Totais_QtdContas_Concil { get; set; }
        public string CNAB2 { get; set; }
    }
}
