using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.Arquivos
{
    class Header_Arquivo
    {
        public string Banco { get; set; }
        public string Lote { get; set; }
        public string Registro { get; set; }
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
        public string NomeBanco { get; set; }
        public string CNAB2 { get; set; }
        public string Arquivo_Codigo { get; set; }
        public string Arquivo_DataGeracao { get; set; }
        public string Arquivo_HoraGeracao { get; set; }
        public string Arquivo_SequenciaNSA { get; set; }
        public string Arquivo_Leiaute { get; set; }
        public string Arquivo_Densidade { get; set; }
        public string Reservado_Banco { get; set; }
        public string Reservado_Empresa { get; set; }
        public string CNAB3 { get; set; }
    }
}
