using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Arquivos
{
    class Header_Arquivo
    {
        public string Banco;
        public string Lote;
        public string Registro;
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
        public string NomeBanco;
        public string CNAB2;
        public string Arquivo_Codigo;
        public string Arquivo_DataGeracao;
        public string Arquivo_HoraGeracao;
        public string Arquivo_SequenciaNSA;
        public string Arquivo_Leiaute;
        public string Arquivo_Densidade;
        public string Reservado_Banco;
        public string Reservado_Empresa;
        public string CNAB3;

        public Header_Arquivo(string banco, string lote, string registro, string cNAB1,
            string empresa_Inscricao_Tipo, string empresa_Inscricao_Numero, string empresa_Convenio,
            string empresa_ContaCorrente_Agencia_Codigo, string empresa_ContaCorrente_Agencia_DV,
            string empresa_ContaCorrente_Conta_Numero, string empresa_ContaCorrente_Conta_AG_DV,
            string empresa_ContaCorrente_Conta_DV, string empresa_Nome, string nomeBanco, string cNAB2,
            string arquivo_Codigo, string arquivo_DataGeracao, string arquivo_HoraGeracao,
            string arquivo_SequenciaNSA, string arquivo_Leiaute, string arquivo_Densidade,
            string reservado_Banco, string reservado_Empresa, string cNAB3)
        {
            Banco = banco;
            Lote = lote;
            Registro = registro;
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
            NomeBanco = nomeBanco;
            CNAB2 = cNAB2;
            Arquivo_Codigo = arquivo_Codigo;
            Arquivo_DataGeracao = arquivo_DataGeracao;
            Arquivo_HoraGeracao = arquivo_HoraGeracao;
            Arquivo_SequenciaNSA = arquivo_SequenciaNSA;
            Arquivo_Leiaute = arquivo_Leiaute;
            Arquivo_Densidade = arquivo_Densidade;
            Reservado_Banco = reservado_Banco;
            Reservado_Empresa = reservado_Empresa;
            CNAB3 = cNAB3;
        }
    }
}
