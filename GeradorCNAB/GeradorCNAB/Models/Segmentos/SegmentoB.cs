using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Segmentos
{
    class SegmentoB
    {
        public string Controle_Banco { get; set; }
        public string Controle_Lote { get; set; }
        public string Controle_Registro { get; set; }
        public string Servico_Numero { get; set; }
        public string Servico_Segmento { get; set; }
        public string CNAB1 { get; set; }
        public string DadosComplementares_Favorecido_Inscricao_Tipo { get; set; }
        public string DadosComplementares_Favorecido_Inscricao_Numero { get; set; }
        public string DadosComplementares_Favorecido_Logradouro { get; set; }
        public string DadosComplementares_Favorecido_Numero { get; set; }
        public string DadosComplementares_Favorecido_Complemento { get; set; }
        public string DadosComplementares_Favorecido_Bairro { get; set; }
        public string DadosComplementares_Favorecido_Cidade { get; set; }
        public string DadosComplementares_Favorecido_CEP { get; set; }
        public string DadosComplementares_Favorecido_ComplementoCEP { get; set; }
        public string DadosComplementares_Favorecido_Estado { get; set; }
        public string DadosComplementares_Pagamento_Vencimento { get; set; }
        public string DadosComplementares_Pagamento_ValorDocumento { get; set; }
        public string DadosComplementares_Pagamento_Abatimento { get; set; }
        public string DadosComplementares_Pagamento_Desconto { get; set; }
        public string DadosComplementares_Pagamento_Mora { get; set; }
        public string DadosComplementares_Pagamento_Multa { get; set; }
        public string DadosComplementares_CodDocFavorecido { get; set; }
        public string Aviso { get; set; }
        public string CodigoUGCentralizadora { get; set; }
        public string IndentificacaoBancoSPB { get; set; }
    }
}
