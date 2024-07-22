using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Lotes
{
    class Trailer_Lote
    {
        public string Controle_Banco { get; set; }
        public string Controle_Lote { get; set; }
        public string Controle_Registro { get; set; }
        public string CNAB1 { get; set; }
        public string Totais_Qtd_Registros { get; set; }
        public string Totais_Valor { get; set; }
        public string Totais_Qtd_Moeda { get; set; }
        public string Numero_aviso_Debito { get; set; }
        public string CNAB2 { get; set; }
        public string Ocorrencia { get; set; }
    }
}
