using Microsoft.AspNetCore.Mvc;

namespace MiniSuperMarket.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}
