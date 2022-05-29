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
        public async Task<IActionResult> GetSingleSearch([FromQuery] string drink)
        {
            CocktailResponse singleSearch = await _cocktailClient.SearchSearchByName(drink);
            return Ok(singleSearch);
        }



    }

}
