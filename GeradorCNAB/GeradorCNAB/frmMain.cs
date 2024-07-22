using GeradorCNAB.Controllers;
using GeradorCNAB.Models.API;
using GeradorCNAB.Models.Arquivos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frmMain()
        {
            PesquisarTodosBancosAsync();
            InitializeComponent();
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
                    cmbBancos.ValueMember = "Code";
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
                Arquivo arquivo = new Arquivo();
                arquivo.HeaderArquiv(header);
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
                string Empresa_Inscricao_Tipo = "";//cmbTipoInscricaoEmpresa.SelectedValue.ToString();
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
                header = null;
            }

            return header;
        }
    }
}
