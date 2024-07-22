using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Segmentos
{
    public class SegmentoA
    {
        public string Controle_Banco;
        public string Controle_Lote;
        public string Controle_Registro;
        public string Servico_Numero;
        public string Servico_Segmento;
        public string Servico_Movimento_Tipo;
        public string Servico_Movimento_Codigo;
        public string Favorecido_Camara;
        public string Favorecido_Banco;
        public string Favorecido_ContaCorrente_Agencia_Codigo;
        public string Favorecido_ContaCorrente_Agencia_DV;
        public string Favorecido_ContaCorrente_Conta_Numero;
        public string Favorecido_ContacCorrente_Conta_DV;
        public string Favorecido_Contacorrente_DV;
        public string Favorecido_Nome;
        public string Favorecido_SeuNumero;
        public string Data_Pagamento;
        public string Credito_Moeda_Tipo;
        public string Credito_Moeda_Quantidade;
        public string Credito_ValorPagamento;
        public string Credito_NossoNumero;
        public string Credito_DataReal;
        public string Credito_ValorReal;
        public string Informacao2;
        public string CodigoFinalidadeDOC;
        public string CodigoFinalidadeTED;
        public string CodigoFinalidadeComplementar;
        public string CNAB1;
        public string Aviso;
        public string Ocorrencia;
        public SegmentoB SegmentoB = null;
    }
}
