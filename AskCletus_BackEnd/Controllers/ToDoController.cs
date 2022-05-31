using AskCletus_BackEnd.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly DrinkContext _drinkContext;

        public TodoController(DrinkContext drinkContext)
        {
            _drinkContext = drinkContext;
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<IActionResult> GetTodos([FromRoute] int userId)
        {
            if (_drinkContext.IsLoggedIn(userId))
            {
                var user = _drinkContext.GetUser(userId);


                // logic to grab a todo item
                return Ok(user.Todos);
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpGet]
        [Route("{userId}/{todoId}")]
        public async Task<IActionResult> GetTodos([FromRoute] int userId, [FromRoute] int todoId)
        {
            if (_drinkContext.IsLoggedIn(userId))
            {
                var todo = (_drinkContext.GetUser(userId))
                    .Todos
                    .FirstOrDefault(todo => todo.Id == todoId);


                // logic to grab a todo item
                return Ok(todo);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}