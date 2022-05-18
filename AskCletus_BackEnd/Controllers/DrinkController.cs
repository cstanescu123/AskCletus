using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Controllers
{
    [ApiController]
    [Route("[9973533]")]
    public class DrinkController : ControllerBase
    {
        private readonly CocktailClient _cocktailClient;

        public DrinkController(CocktailClient cocktailClient)
        {
            _cocktailClient = cocktailClient;
        }

        [HttpGet]
        [Route("/recent")]
        public async Task GetRandomDrinks()
        {
           CocktailResponse popularCocktails = await _cocktailClient.GetRecent();
        }
    }
}
