using Microsoft.AspNetCore.Mvc;

namespace AskCletus_BackEnd.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
