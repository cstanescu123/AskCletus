using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
using Microsoft.AspNetCore.Mvc;


namespace AskCletus_BackEnd.Controllers
{
    public class DrinkHistoryController : Controller
    {

        private readonly IDrinkHistoryContext _drinkHistoryContext;

        public DrinkHistoryController(IDrinkHistoryContext drinkHistoryContext)
        {
            _drinkHistoryContext = drinkHistoryContext;
        }


        [HttpPost]
    
         public IActionResult AddDrink([FromBody] PostHistoryRequest postHistoryRequest)
        {
            var drink = new DrinkHistory();
            drink.Name = postHistoryRequest.Name;
            drink.Description = postHistoryRequest.Description;
            drink.Id = postHistoryRequest.Id;
            drink.Title = postHistoryRequest.Title;

            var dbDrink = _drinkHistoryContext.AddDrink(drink);
            return Ok(_drinkHistoryContext.GetDrinks);
        }
    }
}
