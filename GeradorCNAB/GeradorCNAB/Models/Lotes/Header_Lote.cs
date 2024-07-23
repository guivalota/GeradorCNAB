using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Lotes
{
    public class Header_Lote
    {
        public string Controle_Banco;
        public string Controle_Lote;
        public string Controle_Registro;
        public string Servico_Operacao;
        public string Servico_Servico;
        public string Servico_Forma_Lancamento;
        public string Servico_Layout_Lote;
        public string CNAB1;
        public string Empresa_Inscricao_Tipo;
        public string Empresa_Inscricao_Numero;
        public string Empresa_Convenio;
        public string Empresa_ContaCorrente_Agencia_Codigo;
        public string Empresa_ContaCorrente_Agencia_DV;
        public string Empresa_ContaCorrente_Conta_Numero;
        public string Empresa_ContaCorrente_Conta_AG_DV;
        public string Empresa_ContaCorrente_Conta_DV;
        public string Empresa_Nome;
        public string Empresa_Informacao1;
        public string Endereco_Logradouro;
        public string Endereco_Numero;
        public string Endereco_Complemento;
        public string Endereco_Cidade;
        public string Endereco_CEP;
        public string Endereco_Complemento_CEP;
        public string Endereco_Sigla_Estado;
        public string Indicativo_Forma_Pagamento;
        public string CNAB2;
        public string Ocorrencias;

        public Header_Lote(string controle_Banco, string controle_Lote, string controle_Registro, string servico_Operacao, string servico_Servico, string servico_Forma_Lancamento, string servico_Layout_Lote, string cNAB1, string empresa_Inscricao_Tipo, string empresa_Inscricao_Numero, string empresa_Convenio, string empresa_ContaCorrente_Agencia_Codigo, string empresa_ContaCorrente_Agencia_DV, string empresa_ContaCorrente_Conta_Numero, string empresa_ContaCorrente_Conta_AG_DV, string empresa_ContaCorrente_Conta_DV, string empresa_Nome, string empresa_Informacao1, string endereco_Logradouro, string endereco_Numero, string endereco_Complemento, string endereco_Cidade, string endereco_CEP, string endereco_Complemento_CEP, string endereco_Sigla_Estado, string indicativo_Forma_Pagamento, string cNAB2, string ocorrencias)
        {
            Controle_Banco = controle_Banco;
            Controle_Lote = controle_Lote;
            Controle_Registro = controle_Registro;
            Servico_Operacao = servico_Operacao;
            Servico_Servico = servico_Servico;
            Servico_Forma_Lancamento = servico_Forma_Lancamento;
            Servico_Layout_Lote = servico_Layout_Lote;
            CNAB1 = cNAB1;
            Empresa_Inscricao_Tipo = empresa_Inscricao_Tipo;
            Empresa_Inscricao_Numero = empresa_Inscricao_Numero;
            Empresa_Convenio = empresa_Convenio;
            Empresa_ContaCorrente_Agencia_Codigo = empresa_ContaCorrente_Agencia_Codigo;
            Empresa_ContaCorrente_Agencia_DV = empresa_ContaCorrente_Agencia_DV;
            Empresa_ContaCorrente_Conta_Numero = empresa_ContaCorrente_Conta_Numero;
            Empresa_ContaCorrente_Conta_AG_DV = empresa_ContaCorrente_Conta_AG_DV;
            Empresa_ContaCorrente_Conta_DV = empresa_ContaCorrente_Conta_DV;
            Empresa_Nome = empresa_Nome;
            Empresa_Informacao1 = empresa_Informacao1;
            Endereco_Logradouro = endereco_Logradouro;
            Endereco_Numero = endereco_Numero;
            Endereco_Complemento = endereco_Complemento;
            Endereco_Cidade = endereco_Cidade;
            Endereco_CEP = endereco_CEP;
            Endereco_Complemento_CEP = endereco_Complemento_CEP;
            Endereco_Sigla_Estado = endereco_Sigla_Estado;
            Indicativo_Forma_Pagamento = indicativo_Forma_Pagamento;
            CNAB2 = cNAB2;
            Ocorrencias = ocorrencias;
        }

        public string EscreverLinha()
        {
            return Controle_Banco + Controle_Lote + Controle_Registro + Servico_Operacao +
            Servico_Servico + Servico_Forma_Lancamento + Servico_Layout_Lote + CNAB1 +
            Empresa_Inscricao_Tipo + Empresa_Inscricao_Numero + Empresa_Convenio +
            Empresa_ContaCorrente_Agencia_Codigo + Empresa_ContaCorrente_Agencia_DV +
            Empresa_ContaCorrente_Conta_Numero + Empresa_ContaCorrente_Conta_AG_DV +
            Empresa_ContaCorrente_Conta_DV + Empresa_Nome + Empresa_Informacao1 +
            Endereco_Logradouro + Endereco_Numero + Endereco_Complemento + Endereco_Cidade +
            Endereco_CEP + Endereco_Complemento_CEP + Endereco_Sigla_Estado + 
            Indicativo_Forma_Pagamento + CNAB2 + Ocorrencias;
        }
    }
}
