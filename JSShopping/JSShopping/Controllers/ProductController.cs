using JSShopping.Models;
using Microsoft.AspNetCore.Mvc;
using JSShopping.Helper;
namespace JSShopping.Controllers
{
    public class ProductController : Controller
    {
        private readonly EmailService emailService;
        public ProductController(EmailService _emailService)
        {
            emailService = _emailService;
        }
        public async Task<IActionResult> Index()
        {
         //   await emailService.EmailAsync("jssuthahar@gmail.com", "MSDEVBUILD", "Welcome to Dotnet core");
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000, ImageUrl = "laptop.jpg" },
            new Product { Id = 2, Name = "Phone", Price = 500, ImageUrl = "phone.jpg" },
            new Product { Id = 3, Name = "Tablet", Price = 300, ImageUrl = "tablet.jpg" },
            new Product { Id = 4, Name = "Monitor", Price = 200, ImageUrl = "monitor.jpg" },
            new Product { Id = 5, Name = "Keyboard", Price = 50, ImageUrl = "keyboard.jpg" },
            new Product { Id = 6, Name = "Mouse", Price = 30, ImageUrl = "mouse.jpg" },
            new Product { Id = 7, Name = "Printer", Price = 150, ImageUrl = "printer.jpg" },
            new Product { Id = 8, Name = "Headphones", Price = 80, ImageUrl = "headphones.jpg" },
            new Product { Id = 9, Name = "Speakers", Price = 120, ImageUrl = "speaker.jpg" },
            new Product { Id = 10, Name = "Webcam", Price = 60, ImageUrl = "webcam.jpg" }
        };
            ViewData["ShopName"] = "MSDEVBUILD Shop";
            return View(products);
        }
    }
}
