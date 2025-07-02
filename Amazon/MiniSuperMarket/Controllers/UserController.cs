using Microsoft.AspNetCore.Mvc;
using MiniSuperMarket.Models;
using Microsoft.Data.SqlClient;
namespace MiniSuperMarket.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            Users user = new Users();
           
            return View(user);
        }

        [HttpPost]
        public IActionResult SaveData(string save, string clear, string delete, Users user)
        {
            if(user.Email =="jssuthahar@gmail.com")
            {
                ModelState.AddModelError("Email", "Email already exists. Please use a different email address.");
            }

            if (ModelState.IsValid )
            {
                SqlConnection ocon = new SqlConnection("Data Source=DESKTOP-OCCP11M\\SQLEXPRESS;Initial Catalog=MiniSuperMarket;Integrated Security=True;Encrypt=false");
                ocon.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName, Password, Email, PhoneNumber, Address) VALUES (@UserName, @Password, @Email, @PhoneNumber, @Address)", ocon);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                int rowsAffected = cmd.ExecuteNonQuery();
                ocon.Close();
            }
                return View("Register", new Users());
         

        }
        [HttpPost]
        public IActionResult ClearData(Users users)
        {
            return View("Register", new Users());
        }
        [HttpPost]
        public IActionResult DeleteData(Users users)
        {
            SqlConnection ocon = new SqlConnection("Data Source=DESKTOP-OCCP11M\\SQLEXPRESS;Initial Catalog=MiniSuperMarket;Integrated Security=True;Encrypt=false");
            ocon.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", ocon);
            cmd.Parameters.AddWithValue("@UserID", users.UserID);
            int rowsAffected = cmd.ExecuteNonQuery();
            ocon.Close();
            return View("Register", new Users());
        }
    }
}
