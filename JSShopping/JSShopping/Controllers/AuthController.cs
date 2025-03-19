using JSShopping.Helper;
using JSShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace JSShopping.Controllers;

public class AuthController : Controller
{
    private const string UserSessionKey = "UserSession";
    private static List<User> _users = new List<User>(); // Simulates a database
    private readonly EmailService _emailService;
    private readonly IWebHostEnvironment _env;

    public AuthController(EmailService emailService, IWebHostEnvironment env)
    {
        _emailService = emailService;
        _env = env;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(User model)
    {
        if (_users.Any(u => u.Email == model.Email))
        {
            ViewBag.Message = "Email already registered!";
            return View();
        }

        _users.Add(model);

        // Get the email template file path
        string templatePath = Path.Combine(_env.WebRootPath, "Templates", "WelcomeEmailTemplate.html");

        // Set placeholders for dynamic content
        var placeholders = new Dictionary<string, string>
        {
            { "UserName", model.Name },
            { "ShopLink", "https://www.msdevbuild.com" }
        };

        // Send Welcome Email
        string subject = "Welcome to MSDEVBUILD Shop!";
        await _emailService.SendEmailAsync(model.Email, subject, templatePath, placeholders);


        return RedirectToAction("Login");
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        if (user == null)
        {
            ViewBag.Message = "Invalid login credentials!";
            return View();
        }

        // Store user session
        HttpContext.Session.SetString(UserSessionKey, JsonConvert.SerializeObject(user));
        return RedirectToAction("Index", "Product");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Remove(UserSessionKey);
        return RedirectToAction("Login");
    }
}
