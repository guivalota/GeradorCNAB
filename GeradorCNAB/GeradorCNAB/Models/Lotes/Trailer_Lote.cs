using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Lotes
{
    public class Trailer_Lote
    {
        public string Controle_Banco;
        public string Controle_Lote;
        public string Controle_Registro;
        public string CNAB1;
        public string Totais_Qtd_Registros;
        public string Totais_Valor;
        public string Totais_Qtd_Moeda;
        public string Numero_aviso_Debito;
        public string CNAB2;
        public string Ocorrencia;

        public Trailer_Lote(string controle_Banco, string controle_Lote, string controle_Registro, string cNAB1, string totais_Qtd_Registros, string totais_Valor, string totais_Qtd_Moeda, string numero_aviso_Debito, string cNAB2, string ocorrencia)
        {
            Controle_Banco = controle_Banco;
            Controle_Lote = controle_Lote;
            Controle_Registro = controle_Registro;
            CNAB1 = cNAB1;
            Totais_Qtd_Registros = totais_Qtd_Registros;
            Totais_Valor = totais_Valor;
            Totais_Qtd_Moeda = totais_Qtd_Moeda;
            Numero_aviso_Debito = numero_aviso_Debito;
            CNAB2 = cNAB2;
            Ocorrencia = ocorrencia;
        }

        public string EscreverLinha()
        {
            return Controle_Banco + Controle_Lote + Controle_Registro + CNAB1 +
                    Totais_Qtd_Registros + Totais_Valor + Totais_Qtd_Moeda +
                    Numero_aviso_Debito + CNAB2 + Ocorrencia;
        }
    }
}
