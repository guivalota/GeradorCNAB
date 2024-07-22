using GeradorCNAB.Models.API;
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

    }
}
