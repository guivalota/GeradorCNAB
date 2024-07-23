using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Models.API
{
    public static class ComboBoxComponets
    {
        public static List<(string, string)> tipoRegistroEmpresa = new List<(string, string)>
                {
                    ("0", "0 - Isento / Não Informado"),
                    ("1", "1 - CPF"),
                    ("2", "2 - CGS / CNPJ"),
                    ("3", "3 - PIS / PASEP"),
                    ("9", "9 - Outros")
                };
        public static List<(string, string)> tipoOperacao = new List<(string, string)>
                {
                    ("C", "Lançamento a Crédito"),
                    ("D", "Lançamento a Débito"),
                    ("E", "Extrato para Conciliação"),
                    ("G", "Extrato para Gestão de Caixa"),
                    ("I", "Informações de Títulos Capturados do Próprio Banco"),
                    ("R", "Arquivo Remessa"),
                    ("T", "Arquivo Retorno")
                };
        
        public static List<(string, string)> tipoServico = new List<(string, string)>
                {
                    ("01", "01 - Cobrança"),
                    ("03", "03 - Boleto de Pagamento Eletrônico"),
                    ("04", "04 - Conciliação Bancária"),
                    ("05", "05 - Débitos"),
                    ("06", "06 - Custódia de Cheques"),
                    ("07", "07 - Gestão de Caixa"),
                    ("08", "08 - Consulta/Informação Margem"),
                    ("09", "09 - Averbação da Consignação/Retenção"),
                    ("10", "10 - Pagamento Dividendos"),
                    ("11", "11 - Manutenção da Consignação"),
                    ("12", "12 - Consignação de Parcelas"),
                    ("13", "13 - Glosa da Consignação (INSS)"),
                    ("14", "14 - Consulta de Tributos a pagar"),
                    ("20", "20 - Pagamento Fornecedor"),
                    ("22", "22 - Pagamento de Contas, Tributos e Impostos"),
                    ("23", "23 - Interoperabilidade entre Contas de Instituições de Pagamentos"),
                    ("25", "25 - Compror"),
                    ("26", "26 - Compror Rotativo"),
                    ("29", "29 - Alegação do Pagador"),
                    ("30", "30 - Pagamento Salários"),
                    ("32", "32 - Pagamento de honorários"),
                    ("33", "33 - Pagamento de bolsa auxílio"),
                    ("34", "34 - Pagamento de prebenda (remuneração a padres e sacerdotes)"),
                    ("40", "40 - Vendor"),
                    ("41", "41 - Vendor a Termo"),
                    ("50", "50 - Pagamento Sinistro Segurados"),
                    ("60", "60 - Pagamento Despesas Viajante em Trânsito"),
                    ("70", "70 - Pagamento Autorizado"),
                    ("75", "75 - Pagamento Credenciados"),
                    ("77", "77 - Pagamento Remuneração"),
                    ("80", "80 - Pagamento Representantes / Vendedores Autorizados"),
                    ("90", "90 - Pagamento Beneficios"),
                    ("98", "98 - Pagamentos Diversos"),
                };

        public static List<(string, string)> indicativoFormaPagamento = new List<(string, string)>
                {
                    ("01", "Débito em Conta Corrente"),
                    ("02", "Débito Empréstimo/Financiamento"),
                    ("03", "Débito Cartão de Crédito")
                };

    }
}
