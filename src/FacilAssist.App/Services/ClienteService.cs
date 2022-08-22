using FacilAssist.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FacilAssist.App.View.Services
{
    public class ClienteService : IClienteService
    {
        string urlBase = "http://localhost:50221/api/Cliente";

        public async void BuscarTodos()
        {
            var uri = $"{urlBase}/BuscarTodos";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var clienteJsonString = await response.Content.ReadAsStringAsync();
                        var lista = JsonConvert.DeserializeObject<Cliente[]>(clienteJsonString).ToList();
                    }
                    else
                    {
                        var opa = $"Não foi possível obter o clientes :{response.StatusCode}";
                    }
                }
            }
        }

        public async void BuscarPorCodigo(int codigo)
        {
            using (var client = new HttpClient())
            {
                var uri = $"{urlBase}/BuscarPorCodigo/{codigo}";

                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    var lista = JsonConvert.DeserializeObject<Cliente>(ProdutoJsonString);
                }
                else
                {
                    var opa = $"Falha ao obter o cliente : :{response.StatusCode}";
                }
            }
        }

        public async Task<string> Adicionar(Cliente cliente)
        {
            var novoCliente = new Cliente();

            using (var client = new HttpClient())
            {
                var uri = $"{urlBase}/Adicionar";
                var clienteSerialized = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(clienteSerialized, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }

        }

        public async void Atualizar(Cliente cliente)
        {
            urlBase += $"/Atualizar";
            var serializedProduto = JsonConvert.SerializeObject(cliente);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsync(urlBase, content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var opa = $"Produto atualizado :{responseMessage.StatusCode}";
                }
                else
                {
                    var opa = $"Falha ao atualizar o cliente : :{responseMessage.StatusCode}";
                }
            }
        }

        public async Task<string> Excluir(int codigo)
        {

            var uri = $"{urlBase}/Excluir/{codigo}";

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(uri);
                var response = client.DeleteAsync($"/Excluir/{codigo}").Result;
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"Falha ao obter o cliente :{response.StatusCode}";
                }
            }

        }

    }
}
