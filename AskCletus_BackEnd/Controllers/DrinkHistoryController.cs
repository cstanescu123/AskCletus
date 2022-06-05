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

        [HttpGet]
        public IActionResult GetBars()
        {
            var myBars = _drinkHistoryContext.GetHistory();
            return Ok(myBars);
        }

        //create new api response model (not into sql) that allows me to call the below function as it is intended

        [HttpGet]
        [Route("{userId}")]
        public IActionResult GetMyHistory([FromRoute]int userId)
        {
            var myBars = _drinkHistoryContext.GetDrinkHistory(userId);
            return Ok(myBars);
        }

        [HttpPost]
        public IActionResult AddDrink([FromBody] PostHistoryRequest postHistoryRequest)
        {
            var drink = new DrinkHistory();
            drink.DrinkId = postHistoryRequest.DrinkId;
            drink.Date = System.DateTime.UtcNow;
            drink.UserId = postHistoryRequest.UserId;
            var dbDrink = _drinkHistoryContext.AddDrink(drink);
            return Created($"https://localhost:5001/{dbDrink}", dbDrink);
        }
    }
}
