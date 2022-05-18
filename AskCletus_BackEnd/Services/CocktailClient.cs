using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Services
{
    public class CocktailClient
    {
        private readonly HttpClient _httpClient;
        private string _baseUrl;

        public CocktailClient(HttpClient client, IOptions<CocktailClientConfig> config)
        {
            _httpClient = client;
            _baseUrl = config.Value.BaseUrl;
        }

        public async Task<CocktailResponse> GetPopularCocktails()
        {
            var response = await _httpClient.GetAsync("recent");
            var content = await response.Content.ReadAsStreamAsync();
            var cocktailResponse = await JsonSerializer.DeserializeAsync<CocktailResponse>(content);
            return cocktailResponse;
        }
    }
}
