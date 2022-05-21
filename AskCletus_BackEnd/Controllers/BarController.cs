using AskCletus_BackEnd.Services;
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

        public BarController(ICocktailClient cocktailClient, IDrinkContext drinkContext)
        {
            _cocktailClient = cocktailClient;
            _drinkContext = drinkContext;
        }
        // GET: api/<BarController>
        [HttpGet]
        [Route("MyBar")]
        public IActionResult GetMyBar()
        {
            return Ok();
        }

        // GET api/<BarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
