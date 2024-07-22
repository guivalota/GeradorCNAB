using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Lotes
{
    class Header_Lote
    {
        public string Controle_Banco { get; set; }
        public string Controle_Lote { get; set; }
        public string Controle_Registro { get; set; }
        public string Servico_Operacao { get; set; }
        public string Servico_Servico { get; set; }
        public string Servico_Forma_Lancamento { get; set; }
        public string Servico_Layout_Lote { get; set; }
        public string CNAB1 { get; set; }
        public string Empresa_Inscricao_Tipo { get; set; }
        public string Empresa_Inscricao_Numero { get; set; }
        public string Empresa_Convenio { get; set; }
        public string Empresa_ContaCorrente_Agencia_Codigo { get; set; }
        public string Empresa_ContaCorrente_Agencia_DV { get; set; }
        public string Empresa_ContaCorrente_Conta_Numero { get; set; }
        public string Empresa_ContaCorrente_Conta_AG_DV { get; set; }
        public string Empresa_ContaCorrente_Conta_DV { get; set; }
        public string Empresa_Nome { get; set; }
        public string Empresa_Informacao1 { get; set; }
        public string Endereco_Logradouro { get; set; }
        public string Endereco_Numero { get; set; }
        public string Endereco_Complemento { get; set; }
        public string Endereco_Cidade { get; set; }
        public string Endereco_CEP { get; set; }
        public string Endereco_Complemento_CEP { get; set; }
        public string Endereco_Sigla_Estado { get; set; }
        public string Indicativo_Forma_Pagamento { get; set; }
        public string CNAB2 { get; set; }
        public string Ocorrencias { get; set; }
    }
}
