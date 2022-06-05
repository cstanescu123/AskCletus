using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Services
{
    public class CocktailClient : ICocktailClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public CocktailClient(HttpClient client, IOptions<CocktailClientConfig> config)
        {
            _httpClient = client;
            _baseUrl = config.Value.BaseUrl;
        }

        public async Task<CocktailResponse> GetDrinkById(int drinkId)
        {
            var response = await _httpClient.GetAsync($"lookup.php?i={drinkId}");
            var content = await response.Content.ReadAsStreamAsync();
            var cocktailResponse = await JsonSerializer.DeserializeAsync<CocktailResponse>(content);
            return cocktailResponse;
        }

        public async Task<CocktailResponse> GetRecent()
        {
            var response = await _httpClient.GetAsync("recent.php");
            var content = await response.Content.ReadAsStreamAsync();
            var cocktailResponse = await JsonSerializer.DeserializeAsync<CocktailResponse>(content);
            return cocktailResponse;
        }
        
        public async Task<CocktailResponse> GetRandomDrink()
        {
            var response = await _httpClient.GetAsync("randomselection.php");
            var content = await response.Content.ReadAsStreamAsync();
            var cocktailResponse = await JsonSerializer.DeserializeAsync<CocktailResponse>(content);
            return cocktailResponse;
        }

        public async Task<CocktailResponse> SearchSearchByName(string search)
        {
            var searchResult = await _httpClient.GetAsync($"search.php?s={search}");
            var content = await searchResult.Content.ReadAsStreamAsync();
            var cocktailResponse = await JsonSerializer.DeserializeAsync<CocktailResponse>(content);
            return cocktailResponse;
        }

        public async Task<CocktailResponse> SearchSearchByIngredient(string search)
        {
            var searchResult = await _httpClient.GetAsync($"filter.php?i={search}");
            var content = await searchResult.Content.ReadAsStreamAsync();
            var cocktailResponse = await JsonSerializer.DeserializeAsync<CocktailResponse>(content);
            return cocktailResponse;
        }
        public async Task<CocktailResponse> SearchByMultiIngredients(string? itemOne, string? itemTwo, string? itemThree, string? itemFour)
        {
            var searchResult = await _httpClient.GetAsync($"filter.php?i={itemTwo},{itemTwo},{itemThree},{itemFour}");
            var content = await searchResult.Content.ReadAsStreamAsync();
            var cocktailResponse = await JsonSerializer.DeserializeAsync<CocktailResponse>(content);
            return cocktailResponse;
        }

    }
}