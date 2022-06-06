﻿using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DrinkHistoryController : Controller
    {
        private readonly IDrinkContext _drinkHistoryContext;
        private readonly ICocktailClient _cocktailClient;

        public DrinkHistoryController(IDrinkContext drinkHistoryContext, ICocktailClient cocktailClient)
        {
            _drinkHistoryContext = drinkHistoryContext;
            _cocktailClient = cocktailClient;
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
        public async Task<IActionResult> GetMyHistory([FromRoute]int userId)
        {
            var myBars = _drinkHistoryContext.GetDrinkHistory(userId);

            var drinkIdsTasks = myBars
                .Select(bar => _cocktailClient.GetDrinkById(bar.DrinkId));

            var drinks = (await Task.WhenAll(drinkIdsTasks))
                .Select(x => { Console.Write(x.drinks); return x.drinks; })
                .Where(list => list is not null)
                .SelectMany(list => list)
                .ToList();

            return Ok(drinks);
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
