using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinkController : ControllerBase
    {
        private readonly ICocktailClient _cocktailClient;

        public DrinkController(ICocktailClient cocktailClient)
        {
            _cocktailClient = cocktailClient;
        }

        [HttpGet]
        [Route("recent")]
        public async Task<IActionResult> GetRandomDrinks()
        {
           CocktailResponse popularCocktails = await _cocktailClient.GetRecent();
            return Ok(popularCocktails);
        }
    }
}
