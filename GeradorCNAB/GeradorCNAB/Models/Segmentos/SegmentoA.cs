using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Segmentos
{
    public class SegmentoA
    {
        public string Controle_Banco = "";
        public string Controle_Lote = "";
        public string Controle_Registro = "";
        public string Servico_Numero = "";
        public string Servico_Segmento = "";
        public string Servico_Movimento_Tipo = "";
        public string Servico_Movimento_Codigo = "";
        public string Favorecido_Camara = "";
        public string Favorecido_Banco = "";
        public string Favorecido_ContaCorrente_Agencia_Codigo = "";
        public string Favorecido_ContaCorrente_Agencia_DV = "";
        public string Favorecido_ContaCorrente_Conta_Numero = "";
        public string Favorecido_ContacCorrente_Conta_DV = "";
        public string Favorecido_Contacorrente_DV = "";
        public string Favorecido_Nome = "";
        public string Favorecido_SeuNumero = "";
        public string Data_Pagamento = "";
        public string Credito_Moeda_Tipo = "";
        public string Credito_Moeda_Quantidade = "";
        public string Credito_ValorPagamento = "";
        public string Credito_NossoNumero = "";
        public string Credito_DataReal = "";
        public string Credito_ValorReal = "";
        public string Informacao2 = "";
        public string CodigoFinalidadeDOC = "";
        public string CodigoFinalidadeTED = "";
        public string CodigoFinalidadeComplementar = "";
        public string CNAB1 = "";
        public string Aviso = "";
        public string Ocorrencia = "";
        public SegmentoB SegmentoB = null;

        public SegmentoA(string controle_Banco, string controle_Lote, string controle_Registro, string servico_Numero, string servico_Segmento, string servico_Movimento_Tipo, string servico_Movimento_Codigo, string favorecido_Camara, string favorecido_Banco, string favorecido_ContaCorrente_Agencia_Codigo, string favorecido_ContaCorrente_Agencia_DV, string favorecido_ContaCorrente_Conta_Numero, string favorecido_ContacCorrente_Conta_DV, string favorecido_Contacorrente_DV, string favorecido_Nome, string favorecido_SeuNumero, string data_Pagamento, string credito_Moeda_Tipo, string credito_Moeda_Quantidade, string credito_ValorPagamento, string credito_NossoNumero, string credito_DataReal, string credito_ValorReal, string informacao2, string codigoFinalidadeDOC, string codigoFinalidadeTED, string codigoFinalidadeComplementar, string cNAB1, string aviso, string ocorrencia, SegmentoB segmentoB)
        {
            Controle_Banco = controle_Banco;
            Controle_Lote = controle_Lote;
            Controle_Registro = controle_Registro;
            Servico_Numero = servico_Numero;
            Servico_Segmento = servico_Segmento;
            Servico_Movimento_Tipo = servico_Movimento_Tipo;
            Servico_Movimento_Codigo = servico_Movimento_Codigo;
            Favorecido_Camara = favorecido_Camara;
            Favorecido_Banco = favorecido_Banco;
            Favorecido_ContaCorrente_Agencia_Codigo = favorecido_ContaCorrente_Agencia_Codigo;
            Favorecido_ContaCorrente_Agencia_DV = favorecido_ContaCorrente_Agencia_DV;
            Favorecido_ContaCorrente_Conta_Numero = favorecido_ContaCorrente_Conta_Numero;
            Favorecido_ContacCorrente_Conta_DV = favorecido_ContacCorrente_Conta_DV;
            Favorecido_Contacorrente_DV = favorecido_Contacorrente_DV;
            Favorecido_Nome = favorecido_Nome;
            Favorecido_SeuNumero = favorecido_SeuNumero;
            Data_Pagamento = data_Pagamento;
            Credito_Moeda_Tipo = credito_Moeda_Tipo;
            Credito_Moeda_Quantidade = credito_Moeda_Quantidade;
            Credito_ValorPagamento = credito_ValorPagamento;
            Credito_NossoNumero = credito_NossoNumero;
            Credito_DataReal = credito_DataReal;
            Credito_ValorReal = credito_ValorReal;
            Informacao2 = informacao2;
            CodigoFinalidadeDOC = codigoFinalidadeDOC;
            CodigoFinalidadeTED = codigoFinalidadeTED;
            CodigoFinalidadeComplementar = codigoFinalidadeComplementar;
            CNAB1 = cNAB1;
            Aviso = aviso;
            Ocorrencia = ocorrencia;
            SegmentoB = segmentoB;
        }

        public string EscreverLinha()
        {
            string b = "";
            if(SegmentoB != null)
            {
                b = Environment.NewLine + SegmentoB.EscreverLinha();
            }
            return Controle_Banco + Controle_Lote + Controle_Registro + Servico_Numero +
                Servico_Segmento + Servico_Movimento_Tipo + Servico_Movimento_Codigo +
                Favorecido_Camara + Favorecido_Banco + Favorecido_ContaCorrente_Agencia_Codigo +
                Favorecido_ContaCorrente_Agencia_DV + Favorecido_ContaCorrente_Conta_Numero +
                Favorecido_ContacCorrente_Conta_DV + Favorecido_Contacorrente_DV + 
                Favorecido_Nome + Favorecido_SeuNumero + Data_Pagamento + Credito_Moeda_Tipo +
                Credito_Moeda_Quantidade + Credito_ValorPagamento + Credito_NossoNumero +
                Credito_DataReal + Credito_ValorReal + Informacao2 + CodigoFinalidadeDOC +
                CodigoFinalidadeTED + CodigoFinalidadeComplementar + CNAB1 + Aviso +
                Ocorrencia + b ;
        }

    }
}
