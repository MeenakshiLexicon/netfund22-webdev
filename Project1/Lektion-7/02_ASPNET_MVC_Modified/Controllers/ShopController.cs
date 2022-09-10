using Microsoft.AspNetCore.Mvc;

namespace _02_ASPNET_MVC_Modified.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult WishList()
        {
            return View();
        }


        public IActionResult Compare()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

    }




}
