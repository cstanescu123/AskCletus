using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.DALModels;
using AskCletus_BackEnd.Services.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IDrinkContext _userContext;

        public UserController(IDrinkContext userContext)
        {
            _userContext = userContext;
        }
       
        [HttpGet]
        [Route("{userId}")]
        public IActionResult GetUser([FromRoute] int userId)
        {
            var user = _userContext.GetUser(userId);
            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{userId}")]
        public IActionResult DeleteUser([FromRoute] int userId)
        {
            var dbDrinks = _userContext.DeleteUser(userId);

            if (dbDrinks == null)
            {
                return NotFound($"{nameof(userId)}: {userId} does not exist");
            }
            return Accepted($"User with ID: {userId} has been removed");
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetAllUsers()
        {
            var users = _userContext.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser([FromBody] PostUserRequest postUserRequest)
        {
            var user = new User();
            user.UserName = postUserRequest.UserName;
            user.Email = postUserRequest.Email;
            user.Token = postUserRequest.Token;

            var dbUser = _userContext.AddUser(user);
            return Created($"https://localhost:5001/{dbUser.UserId}", dbUser);
        }

        [HttpPost]
        [Route("UpdateUser")]

        public IActionResult UpdateUser(User user, int userId)
        {
            var updatedUser = _userContext.UpdateUser(user, userId);
            return Ok(updatedUser);
        }
    }
}
