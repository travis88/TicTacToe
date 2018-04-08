using Microsoft.AspNetCore.Mvc;

namespace TicTacToe.Controllers
{
    public class UserRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}