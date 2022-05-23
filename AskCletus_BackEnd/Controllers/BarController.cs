using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AskCletus_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarController : ControllerBase
    {
        private readonly ICocktailClient _cocktailClient;
        private readonly IDrinkContext _drinkContext;

        public BarController(IDrinkContext drinkContext, ICocktailClient cocktailClient)
        {
             _cocktailClient = cocktailClient;
            _drinkContext = drinkContext;
        }

        //[HttpGet]
        //[Route("Bars")]
        //public IActionResult GetMyBar()
        //{
        //    var myBars = _drinkContext.GetBars();
        //    return Ok(myBars);
        //}

        [HttpGet("{userId}")]
        public IActionResult GetBar([FromRoute] int userId)
        {
            var myBar = _drinkContext.GetMyBar(userId);
            if (myBar != null)
            {
                return Ok(myBar);
            }
            return NotFound("That bar does not exist");
        }

        [HttpPost]
        [Route("AddIngredient")]
        public IActionResult AddIngredient([FromBody] PostBarRequest postBarRequest)
        {
            var myBar = new UserBar();
            myBar.Ingredients = postBarRequest.Ingredients;

            var dbBar = _drinkContext.AddBar(myBar);
            return Created($"https://localhost:5001/{dbBar.Ingredients}", dbBar);
        }

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        [HttpDelete("{userId}")]
        public IActionResult DeleteBar([FromRoute] int userId)
        {
            var dbUserBar = _drinkContext.DeleteBar(userId);
            if (dbUserBar != null)
            {
                return Accepted("Bar deleted");
            }
                return NotFound("This bar does not exist");
        }
    }
}
