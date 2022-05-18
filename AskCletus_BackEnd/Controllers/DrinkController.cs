using AskCletus_BackEnd.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AskCletus_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinkController : ControllerBase
    {
        private readonly CocktailClient _cocktailClient;

        public DrinkController(CocktailClient cocktailClient)
        {
            _cocktailClient = cocktailClient;
        }

        //[HttpGet]
        //public IActionResult GetRandomDrinks()
        //{

        //}
    }
}
