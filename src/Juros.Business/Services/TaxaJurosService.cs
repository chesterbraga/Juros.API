using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace Juros.Business.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly HttpClient _httpClient;

        public TaxaJurosService(HttpClient client)
        {            
            _httpClient = client;         
        }

        public async Task<double> GetTaxaJuros()
        {
            var response = await _httpClient.GetAsync("taxajuros");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<double>(responseStream);
        }
    }
}