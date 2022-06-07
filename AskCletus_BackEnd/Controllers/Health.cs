using Microsoft.AspNetCore.Mvc;

namespace AskCletus_BackEnd.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Health : ControllerBase
    {
        [HttpGet]
        public IActionResult Healthy()
        {
            return Ok(new { IsOkay = true });
        }
    }
}
