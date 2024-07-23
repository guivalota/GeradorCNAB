using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Segmentos
{
    public class SegmentoB
    {
        public string Controle_Banco = "";
        public string Controle_Lote = "";
        public string Controle_Registro = "";
        public string Servico_Numero = "";
        public string Servico_Segmento = "";
        public string CNAB1 = "";
        public string DadosComplementares_Favorecido_Inscricao_Tipo = "";
        public string DadosComplementares_Favorecido_Inscricao_Numero = "";
        public string DadosComplementares_Favorecido_Logradouro = "";
        public string DadosComplementares_Favorecido_Numero = "";
        public string DadosComplementares_Favorecido_Complemento = "";
        public string DadosComplementares_Favorecido_Bairro = "";
        public string DadosComplementares_Favorecido_Cidade = "";
        public string DadosComplementares_Favorecido_CEP = "";
        public string DadosComplementares_Favorecido_ComplementoCEP = "";
        public string DadosComplementares_Favorecido_Estado = "";
        public string DadosComplementares_Pagamento_Vencimento = "";
        public string DadosComplementares_Pagamento_ValorDocumento = "";
        public string DadosComplementares_Pagamento_Abatimento = "";
        public string DadosComplementares_Pagamento_Desconto = "";
        public string DadosComplementares_Pagamento_Mora = "";
        public string DadosComplementares_Pagamento_Multa = "";
        public string DadosComplementares_CodDocFavorecido = "";
        public string Aviso = "";
        public string CodigoUGCentralizadora = "";
        public string IndentificacaoBancoSPB = "";

        public SegmentoB(string controle_Banco, string controle_Lote, string controle_Registro, string servico_Numero, string servico_Segmento, string cNAB1, string dadosComplementares_Favorecido_Inscricao_Tipo, string dadosComplementares_Favorecido_Inscricao_Numero, string dadosComplementares_Favorecido_Logradouro, string dadosComplementares_Favorecido_Numero, string dadosComplementares_Favorecido_Complemento, string dadosComplementares_Favorecido_Bairro, string dadosComplementares_Favorecido_Cidade, string dadosComplementares_Favorecido_CEP, string dadosComplementares_Favorecido_ComplementoCEP, string dadosComplementares_Favorecido_Estado, string dadosComplementares_Pagamento_Vencimento, string dadosComplementares_Pagamento_ValorDocumento, string dadosComplementares_Pagamento_Abatimento, string dadosComplementares_Pagamento_Desconto, string dadosComplementares_Pagamento_Mora, string dadosComplementares_Pagamento_Multa, string dadosComplementares_CodDocFavorecido, string aviso, string codigoUGCentralizadora, string indentificacaoBancoSPB)
        {
            Controle_Banco = controle_Banco;
            Controle_Lote = controle_Lote;
            Controle_Registro = controle_Registro;
            Servico_Numero = servico_Numero;
            Servico_Segmento = servico_Segmento;
            CNAB1 = cNAB1;
            DadosComplementares_Favorecido_Inscricao_Tipo = dadosComplementares_Favorecido_Inscricao_Tipo;
            DadosComplementares_Favorecido_Inscricao_Numero = dadosComplementares_Favorecido_Inscricao_Numero;
            DadosComplementares_Favorecido_Logradouro = dadosComplementares_Favorecido_Logradouro;
            DadosComplementares_Favorecido_Numero = dadosComplementares_Favorecido_Numero;
            DadosComplementares_Favorecido_Complemento = dadosComplementares_Favorecido_Complemento;
            DadosComplementares_Favorecido_Bairro = dadosComplementares_Favorecido_Bairro;
            DadosComplementares_Favorecido_Cidade = dadosComplementares_Favorecido_Cidade;
            DadosComplementares_Favorecido_CEP = dadosComplementares_Favorecido_CEP;
            DadosComplementares_Favorecido_ComplementoCEP = dadosComplementares_Favorecido_ComplementoCEP;
            DadosComplementares_Favorecido_Estado = dadosComplementares_Favorecido_Estado;
            DadosComplementares_Pagamento_Vencimento = dadosComplementares_Pagamento_Vencimento;
            DadosComplementares_Pagamento_ValorDocumento = dadosComplementares_Pagamento_ValorDocumento;
            DadosComplementares_Pagamento_Abatimento = dadosComplementares_Pagamento_Abatimento;
            DadosComplementares_Pagamento_Desconto = dadosComplementares_Pagamento_Desconto;
            DadosComplementares_Pagamento_Mora = dadosComplementares_Pagamento_Mora;
            DadosComplementares_Pagamento_Multa = dadosComplementares_Pagamento_Multa;
            DadosComplementares_CodDocFavorecido = dadosComplementares_CodDocFavorecido;
            Aviso = aviso;
            CodigoUGCentralizadora = codigoUGCentralizadora;
            IndentificacaoBancoSPB = indentificacaoBancoSPB;
        }

        public string EscreverLinha()
        {
            return Controle_Banco + Controle_Lote + Controle_Registro + Servico_Numero +
                Servico_Segmento + CNAB1 + DadosComplementares_Favorecido_Inscricao_Tipo +
                DadosComplementares_Favorecido_Inscricao_Numero + DadosComplementares_Favorecido_Logradouro +
                DadosComplementares_Favorecido_Numero + DadosComplementares_Favorecido_Complemento +
                DadosComplementares_Favorecido_Bairro + DadosComplementares_Favorecido_Cidade +
                DadosComplementares_Favorecido_CEP + DadosComplementares_Favorecido_ComplementoCEP +
                DadosComplementares_Favorecido_Estado + DadosComplementares_Pagamento_Vencimento +
                DadosComplementares_Pagamento_ValorDocumento + DadosComplementares_Pagamento_Abatimento +
                DadosComplementares_Pagamento_Desconto + DadosComplementares_Pagamento_Mora +
                DadosComplementares_Pagamento_Multa + DadosComplementares_CodDocFavorecido +
                Aviso + CodigoUGCentralizadora + IndentificacaoBancoSPB;
        }
    }
}
