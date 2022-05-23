using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
using Microsoft.AspNetCore.Mvc;


namespace AskCletus_BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DrinkHistoryController : Controller
    {
        private readonly IDrinkContext _drinkHistoryContext;

        public DrinkHistoryController(IDrinkContext drinkHistoryContext)
        {
            _drinkHistoryContext = drinkHistoryContext;
        }

        [HttpPost]
        [Route("AddDrink")]
        public IActionResult AddDrink([FromBody] PostHistoryRequest postHistoryRequest)
        {
            var drink = new DrinkHistory();
            drink.DrinkId = postHistoryRequest.DrinkId;
            drink.Date = postHistoryRequest.Date;
            drink.UserId = postHistoryRequest.UserId;
            var dbDrink = _drinkHistoryContext.AddDrink(drink);
            return Created($"https://localhost:5001/{dbDrink}", dbDrink);
        }
    }
}
