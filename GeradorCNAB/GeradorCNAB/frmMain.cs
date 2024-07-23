using GeradorCNAB.Controllers;
using GeradorCNAB.Models.API;
using GeradorCNAB.Models.Arquivos;
using GeradorCNAB.Models.Lotes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorCNAB
{
    public partial class frmMain : Form
    {
        static HttpClient client = new HttpClient();
        string caminhoArquivo = "";

        List<Lote_Inf> lotes = new List<Lote_Inf>();
        public frmMain()
        {
            InitializeComponent();
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            try
            {
                PesquisarTodosBancosAsync();
                PesquisarEstadosAsync();
                caminhoArquivo = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
                txtCaminhoArquivo.Text = caminhoArquivo;

                cmbTipoInscricaoEmpresaArquivo.DisplayMember = "Item2";
                cmbTipoInscricaoEmpresaArquivo.ValueMember = "Item1";

                cmbTipoInscricaoEmpresa_Lote.DisplayMember = "Item2";
                cmbTipoInscricaoEmpresa_Lote.ValueMember = "Item1";
                foreach (var item in ComboBoxComponets.tipoRegistroEmpresa)
                {
                    cmbTipoInscricaoEmpresaArquivo.Items.Add(new { Item1 = item.Item1, Item2 = item.Item2 });
                    cmbTipoInscricaoEmpresa_Lote.Items.Add(new { Item1 = item.Item1, Item2 = item.Item2 });


                }
                cmbTipoInscricaoEmpresaArquivo.SelectedIndex = 0;
                cmbTipoInscricaoEmpresa_Lote.SelectedIndex = 0;

                cmbTipoOperacao.DisplayMember = "Item2";
                cmbTipoOperacao.ValueMember = "Item1";
                foreach (var item in ComboBoxComponets.tipoOperacao)
                {
                    cmbTipoOperacao.Items.Add(new { Item1 = item.Item1, Item2 = item.Item2 });
                }
                cmbTipoOperacao.SelectedIndex = 0;

                cmbTipoServico.DisplayMember = "Item2";
                cmbTipoServico.ValueMember = "Item1";
                foreach (var item in ComboBoxComponets.tipoServico)
                {
                    cmbTipoServico.Items.Add(new { Item1 = item.Item1, Item2 = item.Item2 });
                }
                cmbTipoServico.SelectedIndex = 0;

                cmbIndicativoFormaPagamento_Lote.DisplayMember = "Item2";
                cmbIndicativoFormaPagamento_Lote.ValueMember = "Item1";
                foreach (var item in ComboBoxComponets.indicativoFormaPagamento)
                {
                    cmbIndicativoFormaPagamento_Lote.Items.Add(new { Item1 = item.Item1, Item2 = item.Item2 });
                }
                cmbIndicativoFormaPagamento_Lote.SelectedIndex = 0;
                
            }
            catch(Exception ex)
            {
                Console.Write("Erro:" + ex.Message);
            }
        }

        private async Task PesquisarTodosBancosAsync()
        {
            try
            {
                HttpResponseMessage response = 
                    await client.GetAsync($"https://brasilapi.com.br/api/banks/v1");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    String jsonString = await response.Content.ReadAsStringAsync();
                    List<Bancos> bancos = JsonConvert.DeserializeObject<List<Bancos>>(jsonString);
                    bancos = bancos
                        .Where(b => b.code.HasValue)
                        .OrderBy(b => b.code)
                        .ToList();
                    cmbBancos.DataSource = bancos;
                    cmbBancos.DisplayMember = "DisplayName";

                    //List<Bancos> bancosLote = JsonConvert.DeserializeObject<List<Bancos>>(jsonString);
                    List<Bancos> bancosLote = bancos
                        .Where(b => b.code.HasValue)
                        .OrderBy(b => b.code)
                        .ToList();

                    cmbBancosLote.DataSource = bancosLote;
                    cmbBancosLote.DisplayMember = "DisplayName";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private async Task PesquisarEstadosAsync()
        {
            try
            {
                HttpResponseMessage response =
                    await client.GetAsync($"https://brasilapi.com.br/api/ibge/uf/v1");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    String jsonString = await response.Content.ReadAsStringAsync();
                    List<Estado_IBGE> estados = JsonConvert.DeserializeObject<List<Estado_IBGE>>(jsonString);
                    estados = estados
                        .OrderBy(b => b.sigla)
                        .ToList();
                    cmbEstado_Lote.DataSource = estados;
                    cmbEstado_Lote.DisplayMember = "DisplayName";
                    cmbEstado_Lote.ValueMember = "Sigla";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        private bool ValidarCamposHeaderArquivo()
        {
            if (cmbBancos.SelectedIndex < 0)
            {
                cmbBancos.Focus();
                return false;
            }

            if (txtAgencia.Text.Replace(" ","") == "")
            {
                txtAgencia.Focus();
                return false;
            }

            if(txtDVAgencia.Text.Replace(" ","") == "")
            {
                txtDVAgencia.Focus();
                return false;
            }

            if(txtConta.Text.Replace(" ","") == "")
            {
                txtConta.Focus();
                return false;
            }

            if(txtDVConta.Text.Replace(" ","") == "")
            {
                txtDVConta.Focus();
                return false;
            }

            if(txtNomeEmpresa.Text.Replace(" ","") == "")
            {
                txtNomeEmpresa.Focus();
                return false;
            }

            if(txtNSA.Text.Replace(" ","") == "")
            {
                txtNSA.Text = "000001";
            }

            if(txtVLayout.Text.Replace(" ","") == "")
            {
                txtVLayout.Text = "103";
            }

            return true;
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
           if(ValidarCamposHeaderArquivo())
            {
                Header_Arquivo header = PreencherHeader();
                Trailer_Arquivo trailer = PreencherTrailer();
                lotes.Add(PreencherLote());
                Arquivo arquivo = new Arquivo();
                arquivo.GerarArquivo(caminhoArquivo, header, trailer, lotes);
                MessageBox.Show("Arquivo Gerado com sucesso");
            }
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                fbdArquivoSaida.ShowDialog();
                string result = fbdArquivoSaida.SelectedPath;
                if (!String.IsNullOrEmpty(result)){
                    caminhoArquivo = result;
                    txtCaminhoArquivo.Text = caminhoArquivo;
                }
            }
            catch(Exception ex)
            {
                Console.Write("Erro:" + ex.Message);
            }
        }

        private Header_Arquivo PreencherHeader()
        {
            Header_Arquivo header;
            try
            {
                Bancos banco = (Bancos)cmbBancos.SelectedItem;
                string Banco = banco.code.ToString();
                string Lote = txtNSA.Text;
                string Registro = "0";
                string CNAB1 = "";
                string Empresa_Inscricao_Tipo = cmbTipoInscricaoEmpresaArquivo.SelectedItem.GetType().GetProperty("Item1").GetValue(cmbTipoInscricaoEmpresaArquivo.SelectedItem, null).ToString();
                string Empresa_Inscricao_Numero = txtNumeroInscricaoEmpresa.Text;
                string Empresa_Convenio = txtCodigoConvenioBanco.Text;
                string Empresa_ContaCorrente_Agencia_Codigo = txtAgencia.Text;
                string Empresa_ContaCorrente_Agencia_DV = txtDVAgencia.Text;
                string Empresa_ContaCorrente_Conta_Numero = txtConta.Text;
                string Empresa_ContaCorrente_Conta_AG_DV = "";
                string Empresa_ContaCorrente_Conta_DV = txtDVConta.Text;
                string Empresa_Nome = txtNomeEmpresa.Text;
                string NomeBanco = banco.fullName;
                string CNAB2 = "";
                string Arquivo_Codigo = "1";
                string Arquivo_DataGeracao = dtpDataGeracaoArquivo.Text;
                string Arquivo_HoraGeracao = dtpHorarioGeracaoArquivo.Text;
                string Arquivo_SequenciaNSA = txtNSA.Text;
                string Arquivo_Leiaute = txtVLayout.Text;
                string Arquivo_Densidade = "";
                string Reservado_Banco = "";
                string Reservado_Empresa = "";
                string CNAB3 = "";

                header = new Header_Arquivo(Banco, Lote, Registro, CNAB1, Empresa_Inscricao_Tipo, Empresa_Inscricao_Numero, Empresa_Convenio,
                    Empresa_ContaCorrente_Agencia_Codigo, Empresa_ContaCorrente_Agencia_DV, Empresa_ContaCorrente_Conta_Numero,
                    Empresa_ContaCorrente_Conta_AG_DV, Empresa_ContaCorrente_Conta_DV, Empresa_Nome, NomeBanco, CNAB2, Arquivo_Codigo,
                    Arquivo_DataGeracao, Arquivo_HoraGeracao, Arquivo_SequenciaNSA, Arquivo_Leiaute, Arquivo_Densidade, Reservado_Banco,
                    Reservado_Empresa, CNAB3
                    );

            }catch(Exception ex)
            {
                Console.Write("Erro:" + ex.Message);
                header = null;
            }

            return header;
        }

        private Trailer_Arquivo PreencherTrailer()
        {
            Trailer_Arquivo trailer;
            try
            {
                Bancos banco = (Bancos)cmbBancos.SelectedItem;
                string Banco = banco.code.ToString();
                string Lote = "";
                string Registro = "9";
                string CNAB1 = "";
                string Totais_QtdLotes = "0";
                string Totais_QtdRegistros = "0";
                string Totais_QtdContas_Concil = "0";
                string CNAB2 ="";
                trailer = new Trailer_Arquivo(Banco, Lote, Registro, CNAB1, Totais_QtdLotes, Totais_QtdRegistros, Totais_QtdContas_Concil, CNAB2);
            }catch(Exception ex)
            {
                Console.Write("Erro:" + ex.Message);
                trailer = null;
            }
            return trailer;
        }

        private Lote_Inf PreencherLote()
        {
            Lote_Inf lote;
            try
            {
                //Header do lote
                lote = new Lote_Inf();
                Header_Lote header;
                Bancos banco = (Bancos)cmbBancosLote.SelectedItem;
                string Controle_Banco = banco.code.ToString();
                string Controle_Lote = "";
                string Controle_Registro = "1";
                string Servico_Operacao = cmbTipoOperacao.SelectedItem.GetType().GetProperty("Item1").GetValue(cmbTipoOperacao.SelectedItem, null).ToString();
                string Servico_Servico = cmbTipoServico.SelectedItem.GetType().GetProperty("Item1").GetValue(cmbTipoServico.SelectedItem, null).ToString();
                string Servico_Forma_Lancamento = cmbTipoOperacao.SelectedItem.GetType().GetProperty("Item1").GetValue(cmbTipoOperacao.SelectedItem, null).ToString();
                string Servico_Layout_Lote = cmbIndicativoFormaPagamento_Lote.SelectedItem.GetType().GetProperty("Item1").GetValue(cmbIndicativoFormaPagamento_Lote.SelectedItem, null).ToString();
                string CNAB1 = "";
                string Empresa_Inscricao_Tipo = cmbTipoInscricaoEmpresa_Lote.SelectedItem.GetType().GetProperty("Item1").GetValue(cmbTipoInscricaoEmpresa_Lote.SelectedItem, null).ToString();
                string Empresa_Inscricao_Numero = txtNumeroInscricaoEmpresa_Lote.Text;
                string Empresa_Convenio = txtCodigoConvenioBanco_Lote.Text;
                string Empresa_ContaCorrente_Agencia_Codigo = txtAgencia_Lote.Text;
                string Empresa_ContaCorrente_Agencia_DV = txtDVAgencia_Lote.Text;
                string Empresa_ContaCorrente_Conta_Numero = txtConta_Lote.Text;
                string Empresa_ContaCorrente_Conta_AG_DV = "";
                string Empresa_ContaCorrente_Conta_DV = txtDVConta_Lote.Text;
                string Empresa_Nome = txtNomeEmpresa_Lote.Text;
                string Empresa_Informacao1 = txtMensagem_Lote.Text;
                string Endereco_Logradouro = txtLogradouro_Lote.Text;
                string Endereco_Numero = txtLogradouroNumero_Lote.Text;
                string Endereco_Complemento = txtLogradouroComplemento_Lote.Text;
                string Endereco_Cidade = txtLogradouroCidade_Lote.Text;
                string Endereco_CEP = txtCEP_Lote.Text;
                string Endereco_Complemento_CEP = txtCEP_Lote.Text.Substring(txtCEP_Lote.Text.Length-3, 3);
                string Endereco_Sigla_Estado = cmbEstado_Lote.SelectedItem.GetType().GetProperty("sigla").GetValue(cmbEstado_Lote.SelectedItem, null).ToString();
                string Indicativo_Forma_Pagamento = cmbIndicativoFormaPagamento_Lote.SelectedItem.GetType().GetProperty("Item1").GetValue(cmbIndicativoFormaPagamento_Lote.SelectedItem, null).ToString();
                string CNAB2 = "";
                string Ocorrencias = "";
                header = new Header_Lote(Controle_Banco, Controle_Lote, Controle_Registro, Servico_Operacao,
                                Servico_Servico, Servico_Forma_Lancamento, Servico_Layout_Lote, CNAB1,
                                Empresa_Inscricao_Tipo, Empresa_Inscricao_Numero, Empresa_Convenio,
                                Empresa_ContaCorrente_Agencia_Codigo, Empresa_ContaCorrente_Agencia_DV,
                                Empresa_ContaCorrente_Conta_Numero, Empresa_ContaCorrente_Conta_AG_DV,
                                Empresa_ContaCorrente_Conta_DV, Empresa_Nome, Empresa_Informacao1,
                                Endereco_Logradouro, Endereco_Numero, Endereco_Complemento, Endereco_Cidade,
                                Endereco_CEP, Endereco_Complemento_CEP, Endereco_Sigla_Estado, Indicativo_Forma_Pagamento,
                                CNAB2,Ocorrencias);
                lote.header = header;

                //Trailer do Lote
                string Controle_Registro_Lote = "5";
                string Totais_Qtd_Registros="0";
                string Totais_Valor = "0";
                string Totais_Qtd_Moeda ="0";
                string Numero_aviso_Debito = "0";
                Trailer_Lote trailer = new Trailer_Lote(Controle_Banco, Controle_Lote,
                    Controle_Registro_Lote, CNAB1, Totais_Qtd_Registros,
                    Totais_Valor, Totais_Qtd_Moeda, Numero_aviso_Debito,CNAB2, Ocorrencias);
                lote.trailer = trailer;

            }
            catch(Exception ex)
            {
                Console.Write("Erro:" + ex.Message);
                lote = null;
            }
            return lote;
        }

    }
}
