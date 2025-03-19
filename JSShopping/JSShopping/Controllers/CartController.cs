using JSShopping.Helper;
using JSShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace JSShopping.Controllers
{
    public class CartController : Controller
    {
        private readonly IStringLocalizer<CartController> _localizer;
        public CartController(IStringLocalizer<CartController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["CartTitle"] = _localizer["CartTitle"];

            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            ViewData["ShopName"] = "MSDEVBUILD Shop";
            return View(cart);
        }

        public IActionResult AddToCart(int id, string name, decimal price)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(c => c.ProductId == id);

            if (item == null)
            {
                cart.Add(new CartItem { ProductId = id, Name = name, Price = price, Quantity = 1 });
            }
            else
            {
                item.Quantity++;
            }

            HttpContext.Session.SetObjectAsJson("Cart", cart);

            // Store the cart count in the session
            HttpContext.Session.SetInt32("CartCount", cart.Sum(c => c.Quantity));

            return RedirectToAction("Index");
        }
   

        public IActionResult PlaceOrder()
        {
            HttpContext.Session.Remove("Cart");
            ViewData["ShopName"] = "MSDEVBUILD Shop";
            return View("OrderSuccess");
        }
    }
}
