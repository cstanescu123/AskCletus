using AskCletus_BackEnd.Services;
using AskCletus_BackEnd.Services.DALModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AskCletus_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly GitHubService _gitHubService;
        private readonly IDrinkContext _drinkContext;

        public AuthController(IDrinkContext drinkContext, GitHubService gitHubService)
        {
            _gitHubService = gitHubService;
            _drinkContext = drinkContext;
        }

        [HttpGet]
        [Route("login/{code}/{authority}")]
        //public async Task<IActionResult> Login([FromRoute] string code, [FromRoute] Authority authority)
        public async Task<IActionResult> Login(string code, Authority authority)
        {
            var token = authority switch
            {
                Authority.Github => await _gitHubService.GetToken(code),
            };

            var githubUser = await _gitHubService.GetGithubUser(token.AccessToken);
            var user = await _drinkContext.UpsertGithubUser(githubUser, token.AccessToken);

            if (githubUser == null)
            {
                return Unauthorized();
            }

            // this is YOUR application DATABASE

            //save user into database

            return Ok(user);
        }

        [HttpGet]
        [Route("auto-login/{userId}")]
        public async Task<IActionResult> AutoLogin([FromRoute] int userId)
        {
            var user = await _drinkContext.GetUser(userId);

            if (user == null)
            {
                return NotFound();
            }

            var githubUser = await _gitHubService.GetGithubUser(user.Token);

            if (githubUser == null)
            {
                await _drinkContext.UpdateUserToken(userId, null);
                return Unauthorized();
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("logout/{userId}")]
        public async Task<IActionResult> Logout(int userId)
        {
            await _drinkContext.Logout(userId);
            return Ok();
        }
    }
}