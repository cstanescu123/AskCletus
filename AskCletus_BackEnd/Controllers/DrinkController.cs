﻿using AskCletus_BackEnd.Services;
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
        private readonly IDrinkContext _drinkContext;

        public DrinkController(ICocktailClient cocktailClient, IDrinkContext drinkContext)
        {
            _cocktailClient = cocktailClient;
            _drinkContext = drinkContext;
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
    }

}
