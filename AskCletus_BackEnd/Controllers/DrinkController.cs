using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.ApiModels.Cocktails;
using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
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
        public async Task<IActionResult> GetRecent()
        {
            CocktailResponse popularCocktails = await _cocktailClient.GetRecent();
            return Ok(popularCocktails);
        }

        [HttpGet]
        [Route("Random")]
        public async Task<IActionResult> GetRandomDrink()
        {
            CocktailResponse popularCocktails = await _cocktailClient.GetRandomDrink();
            return Ok(popularCocktails);
        }

        [HttpGet]
        [Route("DrinkName")]
        public async Task<IActionResult> GetSingleDrinkSearch([FromQuery] string drinkName)
        {
            CocktailResponse singleSearch = await _cocktailClient.SearchSearchByName(drinkName);
            return Ok(singleSearch);
        }

        [HttpGet]
        [Route("IngredientSearch")]
        public async Task<IActionResult> GetSingleIngredientSearch([FromQuery] string ingredientName)
        {
            CocktailResponse singleSearch = await _cocktailClient.SearchSearchByIngredient(ingredientName);
            return Ok(singleSearch);
        }
    }
}
