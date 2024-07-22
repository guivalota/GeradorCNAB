using GeradorCNAB.Models.Arquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Controllers
{
    enum Sentido
    {
        Left,
        Right
    }
    public class Arquivo
    {
        public string caminhoArquivo = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + "\\teste.txt";

        public void HeaderArquiv(Header_Arquivo header)
        {
            header = FormatarHeaderArquivo(header);
            CriarArquivo(header);
        }

        private Header_Arquivo FormatarHeaderArquivo(Header_Arquivo header)
        {
            header.Banco = FormatarCampo(header.Banco, '0', 3, Sentido.Left);
            header.Lote = FormatarCampo(header.Lote, '0', 4, Sentido.Right);
            header.Registro = FormatarCampo(header.Registro, '0', 1, Sentido.Right);
            header.CNAB1 = FormatarCampo(header.CNAB1, ' ', 9, Sentido.Right);

            header.Empresa_Inscricao_Tipo = FormatarCampo(header.Empresa_Inscricao_Tipo, ' ', 1, Sentido.Right);
            header.Empresa_Inscricao_Numero = FormatarCampo(header.Empresa_Inscricao_Numero, ' ', 14, Sentido.Right);
            header.Empresa_Convenio = FormatarCampo(header.Empresa_Convenio, ' ', 17, Sentido.Right);
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
            header.Arquivo_SequenciaNSA = FormatarCampo(header.Arquivo_SequenciaNSA, ' ', 3, Sentido.Left);
            header.Arquivo_Densidade = FormatarCampo(header.Arquivo_Densidade, ' ', 5, Sentido.Right);
            header.Reservado_Banco = FormatarCampo(header.Reservado_Banco, ' ', 20, Sentido.Right);
            header.Reservado_Empresa = FormatarCampo(header.Reservado_Empresa, ' ', 20, Sentido.Right);
            header.CNAB3 = FormatarCampo(header.CNAB3, ' ', 29, Sentido.Right);
            return header;
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
            {
                return item.Substring(0, maxNumber);
            }
            if(sentido == Sentido.Left)
            {
                return item.PadLeft(maxNumber, charReplace);
            }
            else
            {
                return item.PadRight(maxNumber, charReplace);
            }
        }


        private void CriarArquivo(Header_Arquivo header_Arquivo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(caminhoArquivo);
                sw.WriteLine(header_Arquivo.EscreverLinha());

                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
            }
        }
    }
}
