using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Segmentos
{
    class SegmentoA
    {
        public string Controle_Banco { get; set; }
        public string Controle_Lote { get; set; }
        public string Controle_Registro { get; set; }
        public string Servico_Numero { get; set; }
        public string Servico_Segmento { get; set; }
        public string Servico_Movimento_Tipo { get; set; }
        public string Servico_Movimento_Codigo { get; set; }
        public string Favorecido_Camara { get; set; }
        public string Favorecido_Banco { get; set; }
        public string Favorecido_ContaCorrente_Agencia_Codigo { get; set; }
        public string Favorecido_ContaCorrente_Agencia_DV { get; set; }
        public string Favorecido_ContaCorrente_Conta_Numero { get; set; }
        public string Favorecido_ContacCorrente_Conta_DV { get; set; }
        public string Favorecido_Contacorrente_DV { get; set; }
        public string Favorecido_Nome { get; set; }
        public string Favorecido_SeuNumero { get; set; }
        public string Data_Pagamento { get; set; }
        public string Credito_Moeda_Tipo { get; set; }
        public string Credito_Moeda_Quantidade { get; set; }
        public string Credito_ValorPagamento { get; set; }
        public string Credito_NossoNumero { get; set; }
        public string Credito_DataReal { get; set; }
        public string Credito_ValorReal { get; set; }
        public string Informacao2 { get; set; }
        public string CodigoFinalidadeDOC { get; set; }
        public string CodigoFinalidadeTED { get; set; }
        public string CodigoFinalidadeComplementar { get; set; }
        public string CNAB1 { get; set; }
        public string Aviso { get; set; }
        public string Ocorrencia { get; set; }
        public SegmentoB SegmentoB { get; set; } = null;
    }
}
