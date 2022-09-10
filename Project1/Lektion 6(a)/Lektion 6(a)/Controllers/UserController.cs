using Microsoft.AspNetCore.Mvc;

namespace Lektion_6_a_.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
