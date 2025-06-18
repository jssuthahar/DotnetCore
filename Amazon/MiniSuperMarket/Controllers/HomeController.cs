using Microsoft.AspNetCore.Mvc;
using MiniSuperMarket.Models;

namespace MiniSuperMarket.Controllers
{
    public class HomeController : Controller
    {
        List<Product> products;
        public HomeController()
        {
            products = new List<Product>
            {
                new Product { Pid = 1, Pname = "Laptop", ProductCategory = PCategory.Electronics, ProductDescription = "High performance laptop", price = 50000, Pimage="/images/Laptop/laptop.jpg"},
                new Product { Pid = 2, Pname = "Mobile", ProductCategory = PCategory.Electronics, ProductDescription = "Latest smartphone", price = 30000,Pimage="/images/Laptop/laptop1.jpg" },
                new Product { Pid = 3, Pname = "Camera", ProductCategory = PCategory.Electronics, ProductDescription = "Digital camera with high resolution", price = 20000,Pimage="/images/Laptop/laptop2.jpg" },
                 new Product { Pid = 4, Pname = "Apple", ProductCategory = PCategory.Electronics, ProductDescription = "High performance laptop", price = 50000, Pimage="/images/Mobile/Mobile.jpg"},
                new Product { Pid = 5, Pname = "Samsung", ProductCategory = PCategory.Electronics, ProductDescription = "Latest smartphone", price = 30000,Pimage="/images/Mobile/Mobile1.jpg" },
                new Product { Pid = 6, Pname = "Google", ProductCategory = PCategory.Electronics, ProductDescription = "Digital camera with high resolution", price = 20000,Pimage="/images/mobile/Mobile2.jpg" }
            };
        }
        public IActionResult Index()
        {
            ViewData["Location"] = "Bangalore";
            ViewData["Product"] = new List<string> { "Laptop",
                "Mobile",
                "Computer",
                "Camera"
            };
            ViewBag.FilterOptions = new List<string> { "All", "All Categories", "Amazon Devices", "Next Day Delivery", "Same Day Delivery" };
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
            // Product producs=new Product() { Pimage = "/images/Laptop/laptop.jpg", Pname = "Laptop", Pid = 1, ProductCategory = PCategory.Electronics, ProductDescription = "High performance laptop", price = 50000 };


            ViewBag.FilterOptions = new List<string> { "All", "All Categories", "Amazon Devices", "Next Day Delivery", "Same Day Delivery" };
            return View(products);
        }
        public IActionResult AboutProduct(string id)
        {
            var product = products.FirstOrDefault(p => p.Pid == Convert.ToInt32(id));
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
