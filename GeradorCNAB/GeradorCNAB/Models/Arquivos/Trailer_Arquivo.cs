using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Arquivos
{
    public class Trailer_Arquivo
    {
        public string Banco { get; set; }
        public string Lote { get; set; }
        public string Registro { get; set; }
        public string CNAB1 { get; set; }
        public string Totais_QtdLotes { get; set; }
        public string Totais_QtdRegistros { get; set; }
        public string Totais_QtdContas_Concil { get; set; }
        public string CNAB2 { get; set; }

        public Trailer_Arquivo(){}

        public Trailer_Arquivo(string banco, string lote, string registro, string cNAB1,
            string totais_QtdLotes, string totais_QtdRegistros, string totais_QtdContas_Concil,string cNAB2)
        {
            Banco = banco;
            Lote = lote;
            Registro = registro;
            CNAB1 = cNAB1;
            Totais_QtdLotes = totais_QtdLotes;
            Totais_QtdRegistros = totais_QtdRegistros;
            Totais_QtdContas_Concil = totais_QtdContas_Concil;
            CNAB2 = cNAB2;
        }

        public string EscreverLinha()
        {
            return Banco + Lote + Registro + CNAB1 + Totais_QtdLotes + Totais_QtdRegistros +
                Totais_QtdContas_Concil + CNAB2;
        }
    }
}
