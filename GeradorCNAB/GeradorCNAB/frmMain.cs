using GeradorCNAB.Controllers;
using GeradorCNAB.Models.API;
using GeradorCNAB.Models.Arquivos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorCNAB
{
    public partial class frmMain : Form
    {
        static HttpClient client = new HttpClient();
        string caminhoArquivo = "";
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
                foreach (var item in ComboBoxComponets.tipoRegistroEmpresa)
                {
                    cmbTipoInscricaoEmpresaArquivo.Items.Add(new { Item1 = item.Item1, Item2 = item.Item2 });
                    
                }
                cmbTipoInscricaoEmpresaArquivo.SelectedIndex = 0;

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
                Arquivo arquivo = new Arquivo();
                arquivo.GerarArquivo(caminhoArquivo, header, trailer);
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

    }
}
