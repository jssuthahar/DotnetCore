using Microsoft.AspNetCore.Mvc;

namespace MiniSuperMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Location"] = "Bangalore";
            ViewData["Product"]= new List<string> { "Laptop",
                "Mobile",
                "Computer",
                "Camera"
            };
            ViewBag.FilterOptions = new List<string> { "All", "All Categories", "Amazon Devices", "Next Day Delivery","Same Day Delivery" };
            TempData["Message"] = "Welcome to Mini Super Market!";
            TempData["ProductCount"] = 5;

            return View();
        }
        public IActionResult Product()
        {
            ViewData["Location"] = "Bangalore";
            ViewData["Product"] = new List<string> { "Laptop",
                "Mobile",
                "Computer",
                "Camera"
            };
            ViewBag.FilterOptions = new List<string> { "All", "All Categories", "Amazon Devices", "Next Day Delivery", "Same Day Delivery" };
            return View();
        }
    }
}
