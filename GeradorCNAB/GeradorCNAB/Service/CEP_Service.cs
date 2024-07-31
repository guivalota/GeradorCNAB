using GeradorCNAB.Models.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeradorCNAB.Service
{
    public class CEP_Service
    {
        private readonly HttpClient client;
        public CEP_Service()
        {
            client = new HttpClient();
        }


        public async Task<List<Estado_IBGE>> PesquisarEstadosAsync()
        {
            List<Estado_IBGE> estados = new List<Estado_IBGE>();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://brasilapi.com.br/api/ibge/uf/v1");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    estados = JsonConvert.DeserializeObject<List<Estado_IBGE>>(jsonString);
                    estados = estados.OrderBy(b => b.sigla).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return estados;
        }

        public async Task<List<Bancos>> PesquisarTodosBancosAsync()
        {
            List<Bancos> bancos = new List<Bancos>();
            try
            {
                HttpResponseMessage response =
                    await client.GetAsync($"https://brasilapi.com.br/api/banks/v1");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    bancos = JsonConvert.DeserializeObject<List<Bancos>>(jsonString);
                    bancos = bancos
                        .Where(b => b.code.HasValue)
                        .OrderBy(b => b.code)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return bancos;
        }

        public async Task<CEP_Inf> PesquisarCEPAsync(string cep)
        {
            CEP_Inf retorno = null;
            try
            {
                HttpResponseMessage response =
                    await client.GetAsync($"https://brasilapi.com.br/api/cep/v1/"+cep);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    retorno = new CEP_Inf();
                    string jsonString = await response.Content.ReadAsStringAsync();
                    retorno = JsonConvert.DeserializeObject<CEP_Inf>(jsonString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return retorno;
        }
    }
}
