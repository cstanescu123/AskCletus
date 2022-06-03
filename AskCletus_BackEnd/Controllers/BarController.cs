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
        private readonly IDrinkContext _drinkContext;

        public BarController(IDrinkContext drinkContext)
        {
            _drinkContext = drinkContext;
        }

        [HttpGet]
        public IActionResult GetBars()
        {
            var myBars = _drinkContext.GetBars();
            return Ok(myBars);
        }

        [HttpGet]
        [Route("{userId}")]
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
        public IActionResult AddIngredient([FromBody] PostBarRequest postBarRequest)
        {
            var myBar = new Ingredients();
            myBar.Ingredient = postBarRequest.Ingredient;
            myBar.UserId = postBarRequest.UserId;

            var dbBar = _drinkContext.AddBar(myBar);
            return Created($"https://localhost:5001/{dbBar.Ingredient}", dbBar);
        }

        [HttpDelete("{ingredientId}")]
        public IActionResult DeleteBar([FromRoute] int ingredientId)
        {
            var dbUserBar = _drinkContext.DeleteBar(ingredientId);
            if (dbUserBar != null)
            {
                return Accepted("Bar deleted");
            }
                return NotFound("This bar does not exist");
        }
    }
}
