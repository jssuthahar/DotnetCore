using Microsoft.AspNetCore.Mvc;

namespace MiniSuperMarket.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Return()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
