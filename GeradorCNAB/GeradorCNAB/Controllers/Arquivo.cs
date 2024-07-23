using GeradorCNAB.Models.Arquivos;
using GeradorCNAB.Models.Lotes;
using System;
using System.Collections.Generic;
using System.IO;

namespace GeradorCNAB.Controllers
{
    enum Sentido
    {
        Left,
        Right
    }
    public class Arquivo
    {
        private static string nomeArquivo = "teste.txt";
        public void GerarArquivo(string caminhoArquivo, Header_Arquivo header, Trailer_Arquivo trailer, List<Lote_Inf> lote)
        {
            header = FormatarHeaderArquivo(header);
            lote = FormatarLote(lote);
            trailer = FormatarTrailerArquivo(trailer);
            CriarArquivo(caminhoArquivo, header, trailer, lote);
        }

        private Header_Arquivo FormatarHeaderArquivo(Header_Arquivo header)
        {
            header.Banco = FormatarCampo(header.Banco, '0', 3, Sentido.Left);
            header.Lote = FormatarCampo(header.Lote, '0', 4, Sentido.Right);
            header.Registro = FormatarCampo(header.Registro, '0', 1, Sentido.Right);
            header.CNAB1 = FormatarCampo(header.CNAB1, ' ', 9, Sentido.Right);
            header.Empresa_Inscricao_Tipo = FormatarCampo(header.Empresa_Inscricao_Tipo, ' ', 1, Sentido.Right);
            header.Empresa_Inscricao_Numero = FormatarCampo(header.Empresa_Inscricao_Numero, ' ', 14, Sentido.Right);
            header.Empresa_Convenio = FormatarCampo(header.Empresa_Convenio, ' ', 20, Sentido.Right);
            header.Empresa_ContaCorrente_Agencia_Codigo = FormatarCampo(header.Empresa_ContaCorrente_Agencia_Codigo, '0', 5, Sentido.Left);
            header.Empresa_ContaCorrente_Agencia_DV = FormatarCampo(header.Empresa_ContaCorrente_Agencia_DV, '0', 1, Sentido.Left);
            header.Empresa_ContaCorrente_Conta_Numero = FormatarCampo(header.Empresa_ContaCorrente_Conta_Numero, '0', 12, Sentido.Left);
            header.Empresa_ContaCorrente_Conta_DV = FormatarCampo(header.Empresa_ContaCorrente_Conta_DV, '0', 1, Sentido.Left);
            header.Empresa_ContaCorrente_Conta_AG_DV = FormatarCampo(header.Empresa_ContaCorrente_Conta_AG_DV, '0', 1, Sentido.Left);
            header.Empresa_Nome = FormatarCampo(header.Empresa_Nome, ' ', 30, Sentido.Right);
            header.NomeBanco = FormatarCampo(header.NomeBanco, ' ', 30, Sentido.Right);
            header.CNAB2 = FormatarCampo(header.CNAB2, ' ', 10, Sentido.Left);
            header.Arquivo_Codigo = FormatarCampo(header.Arquivo_Codigo, ' ', 1, Sentido.Left);
            header.Arquivo_DataGeracao = FormatarCampo(RemoverCaracteres(header.Arquivo_DataGeracao), ' ', 8, Sentido.Left);
            header.Arquivo_HoraGeracao = FormatarCampo(RemoverCaracteres(header.Arquivo_HoraGeracao), ' ', 6, Sentido.Left);
            header.Arquivo_SequenciaNSA = FormatarCampo(header.Arquivo_SequenciaNSA, ' ', 6, Sentido.Left);
            header.Arquivo_Leiaute = FormatarCampo(header.Arquivo_Leiaute, '0', 3, Sentido.Left);
            header.Arquivo_Densidade = FormatarCampo(header.Arquivo_Densidade, ' ', 5, Sentido.Right);
            header.Reservado_Banco = FormatarCampo(header.Reservado_Banco, ' ', 20, Sentido.Right);
            header.Reservado_Empresa = FormatarCampo(header.Reservado_Empresa, ' ', 20, Sentido.Right);
            header.CNAB3 = FormatarCampo(header.CNAB3, ' ', 29, Sentido.Right);
            return header;
        }

        private Trailer_Arquivo FormatarTrailerArquivo(Trailer_Arquivo trailer)
        {
            trailer.Banco = FormatarCampo(trailer.Banco, '0', 3, Sentido.Left);
            trailer.Lote = FormatarCampo(trailer.Lote, '9', 4, Sentido.Left);
            trailer.Registro = FormatarCampo(trailer.Registro, '9', 1, Sentido.Left);
            trailer.CNAB1 = FormatarCampo(trailer.CNAB1, ' ', 9, Sentido.Left);
            trailer.Totais_QtdLotes = FormatarCampo(trailer.Totais_QtdLotes, '0', 6, Sentido.Left);
            trailer.Totais_QtdRegistros = FormatarCampo(trailer.Totais_QtdRegistros, '0', 6, Sentido.Left);
            trailer.Totais_QtdContas_Concil = FormatarCampo(trailer.Totais_QtdContas_Concil, '0', 6, Sentido.Right);
            trailer.CNAB2 = FormatarCampo(trailer.CNAB2, ' ', 205, Sentido.Left);
            return trailer;
        }

        private List<Lote_Inf> FormatarLote(List<Lote_Inf> lote)
        {
            foreach(Lote_Inf item in lote)
            {
                item.header = FormatarHeaderLote(item.header);
                item.trailer = FormatarTrailerLote(item.trailer);
            }
            return lote;
        }

        private Header_Lote FormatarHeaderLote(Header_Lote header)
        {
            header.Controle_Banco = FormatarCampo(header.Controle_Banco, '0', 3, Sentido.Left);
            header.Controle_Lote = FormatarCampo(header.Controle_Lote, '0', 4, Sentido.Right);
            header.Controle_Registro = FormatarCampo(header.Controle_Registro, '0', 1, Sentido.Right);
            header.Servico_Operacao = FormatarCampo(header.Servico_Operacao, ' ', 1, Sentido.Left);
            header.Servico_Servico = FormatarCampo(header.Servico_Servico, '0', 2, Sentido.Right);
            header.Servico_Forma_Lancamento = FormatarCampo(header.Servico_Forma_Lancamento, '0', 2, Sentido.Right);
            header.Servico_Layout_Lote = FormatarCampo(header.Servico_Layout_Lote, '0', 3, Sentido.Left);
            header.CNAB1 = FormatarCampo(header.CNAB1, ' ', 1, Sentido.Right);
            header.Empresa_Inscricao_Tipo = FormatarCampo(header.Empresa_Inscricao_Tipo, ' ', 1, Sentido.Right);
            header.Empresa_Inscricao_Numero = FormatarCampo(header.Empresa_Inscricao_Numero, ' ', 14, Sentido.Right);
            header.Empresa_Convenio = FormatarCampo(header.Empresa_Convenio, ' ', 20, Sentido.Right);
            header.Empresa_ContaCorrente_Agencia_Codigo = FormatarCampo(header.Empresa_ContaCorrente_Agencia_Codigo, '0', 5, Sentido.Left);
            header.Empresa_ContaCorrente_Agencia_DV = FormatarCampo(header.Empresa_ContaCorrente_Agencia_DV, '0', 1, Sentido.Left);
            header.Empresa_ContaCorrente_Conta_Numero = FormatarCampo(header.Empresa_ContaCorrente_Conta_Numero, '0', 12, Sentido.Left);
            header.Empresa_ContaCorrente_Conta_DV = FormatarCampo(header.Empresa_ContaCorrente_Conta_DV, '0', 1, Sentido.Left);
            header.Empresa_ContaCorrente_Conta_AG_DV = FormatarCampo(header.Empresa_ContaCorrente_Conta_AG_DV, '0', 1, Sentido.Left);
            header.Empresa_Nome = FormatarCampo(header.Empresa_Nome, ' ', 30, Sentido.Right);
            header.Empresa_Informacao1 = FormatarCampo(header.Empresa_Informacao1, ' ', 40, Sentido.Right);
            header.Endereco_Logradouro = FormatarCampo(header.Endereco_Logradouro, ' ', 30, Sentido.Right);
            header.Endereco_Numero = FormatarCampo(header.Endereco_Numero, '0', 5, Sentido.Left);
            header.Endereco_Complemento = FormatarCampo(header.Endereco_Complemento, ' ', 15, Sentido.Right);
            header.Endereco_Cidade = FormatarCampo(header.Endereco_Cidade, ' ', 20, Sentido.Right);
            header.Endereco_CEP = FormatarCampo(header.Endereco_CEP, ' ', 5, Sentido.Left);
            header.Endereco_Complemento_CEP= FormatarCampo(header.Endereco_Complemento_CEP, ' ', 3, Sentido.Left);
            header.Endereco_Sigla_Estado= FormatarCampo(header.Endereco_Sigla_Estado, ' ', 2, Sentido.Left);
            header.Indicativo_Forma_Pagamento= FormatarCampo(header.Indicativo_Forma_Pagamento, '0', 2, Sentido.Left);
            header.Ocorrencias = FormatarCampo(header.Ocorrencias, ' ', 6, Sentido.Right);
            header.CNAB2 = FormatarCampo(header.CNAB2, ' ', 10, Sentido.Left);
            return header;
        }

        private Trailer_Lote FormatarTrailerLote(Trailer_Lote trailer)
        {
            trailer.Controle_Banco = FormatarCampo(trailer.Controle_Banco, '0', 3, Sentido.Left);
            trailer.Controle_Lote = FormatarCampo(trailer.Controle_Lote, '0', 4, Sentido.Right);
            trailer.Controle_Registro = FormatarCampo(trailer.Controle_Registro, '0', 1, Sentido.Right);
            trailer.CNAB1 = FormatarCampo(trailer.CNAB1, ' ', 9, Sentido.Right);
            trailer.Totais_Qtd_Registros = FormatarCampo(trailer.Totais_Qtd_Registros, '0', 6, Sentido.Left);
            trailer.Totais_Valor = FormatarCampo(trailer.Totais_Valor, '0', 16+2, Sentido.Left);
            trailer.Totais_Qtd_Moeda = FormatarCampo(trailer.Totais_Qtd_Moeda, '0', 13+5, Sentido.Left);
            trailer.Numero_aviso_Debito = FormatarCampo(trailer.Numero_aviso_Debito, '0', 6, Sentido.Left);
            trailer.CNAB2 = FormatarCampo(trailer.CNAB2, ' ', 165, Sentido.Right);
            trailer.Ocorrencia = FormatarCampo(trailer.Ocorrencia, ' ', 10, Sentido.Right);
            return trailer;
        }

        private string RemoverCaracteres(string item)
        {
            return item
                .Replace("-", "")
                .Replace(":", "")
                .Replace("-", "")
                .Replace("\\", "")
                .Replace("/","")
                .Replace(".", "")
                .Replace(",", "")
                .Replace(" ", "");
        }

        private string FormatarCampo(string item, char charReplace, int maxNumber, Sentido sentido)
        {
            if (item.Length > maxNumber)
                return item.Substring(0, maxNumber);
            if(sentido == Sentido.Left)
                return item.PadLeft(maxNumber, charReplace);
            else
                return item.PadRight(maxNumber, charReplace);
        }


        private void CriarArquivo(string caminhoArquivo, Header_Arquivo header_Arquivo,
            Trailer_Arquivo trailer_Arquivo, List<Lote_Inf> lote)
        {
            try
            {
                StreamWriter sw = new StreamWriter(caminhoArquivo+"\\"+nomeArquivo);
                sw.WriteLine(header_Arquivo.EscreverLinha());
                foreach(Lote_Inf item in lote)
                {
                    sw.WriteLine(item.EscreverLinha());
                }
                sw.WriteLine(trailer_Arquivo.EscreverLinha());
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
            }
        }
    }
}
