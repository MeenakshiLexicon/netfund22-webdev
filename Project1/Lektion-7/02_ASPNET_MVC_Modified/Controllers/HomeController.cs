using Microsoft.AspNetCore.Mvc;

namespace _02_ASPNET_MVC_Modified.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
