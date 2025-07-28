using Microsoft.AspNetCore.Mvc;
using MiniSuperMarket.Models;
using Microsoft.Data.SqlClient;
using MiniSuperMarket.Data;
using MiniSuperMarket.Interface;
using Microsoft.IdentityModel.Tokens;
namespace MiniSuperMarket.Controllers
{
    public class UserController : Controller
    {
        private ICalc calc;
        private readonly AppDBContext _dbcontext;
        public UserController(ICalc calcobj, AppDBContext dbcontext)
        {
            calc = calcobj;
            _dbcontext = dbcontext;


        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowData()
        {

            byte[] pdfcontnet=System.IO.File.ReadAllBytes("C:\\Users\\Hp\\Documents\\GitHub\\DotnetCore\\Amazon\\MiniSuperMarket\\wwwroot\\Sara.pdf");
            return File(pdfcontnet, "application/pdf","Jsquare.pdf");
        }
        public IActionResult WelcomePage()
        {
            return Content("<h1>Welcome to Mini Super Market</h1>", "text/html");
        }
        public IActionResult ShowProduct()
        {
            return RedirectToRoute(new { controller = "Home", action = "Product" });
        }
        public IActionResult JsDevBrains()
        {
            return Redirect("https://jsdevbrains.com");
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
        public IActionResult SaveData(string Action, Users user)
        {
           
            calc.Subtract(0, 20);
            if (user.Email =="jssuthahar@gmail.com")
            {
                ModelState.AddModelError("Email", "Email already exists. Please use a different email address.");
            }

            if (ModelState.IsValid )
            {
                _dbcontext.Users.Add(user);
                _dbcontext.SaveChanges();
                //SqlConnection ocon = new SqlConnection("Data Source=DESKTOP-OCCP11M\\SQLEXPRESS;Initial Catalog=MiniSuperMarket;Integrated Security=True;Encrypt=false");
                //ocon.Open();
                //SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName, Password, Email, PhoneNumber, Address) VALUES (@UserName, @Password, @Email, @PhoneNumber, @Address)", ocon);
                //cmd.Parameters.AddWithValue("@UserName", user.UserName);
                //cmd.Parameters.AddWithValue("@Password", user.Password);
                //cmd.Parameters.AddWithValue("@Email", user.Email);
                //cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                //cmd.Parameters.AddWithValue("@Address", user.Address);
                //int rowsAffected = cmd.ExecuteNonQuery();
                //ocon.Close();
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
            cmd.Parameters.AddWithValue("@UserID", users.Id);
            int rowsAffected = cmd.ExecuteNonQuery();
            ocon.Close();
            return View("Register", new Users());
        }
        [Route("Users/RemoveData/{Id}")]
        public IActionResult RemoveData(string Id)
        {
            var data = _dbcontext.Users.FirstOrDefault(x => x.Id == Convert.ToInt32(Id));
            if(data is not null)
            {
                _dbcontext.Users.Remove(data);
                _dbcontext.SaveChanges();
            }


            return View("Register", new Users());
        }
        [Route("Users/Readdata/{Id}")]
        public IActionResult ReadData(string Id)
        {
            var data = _dbcontext.Users.FirstOrDefault(x => x.Id == Convert.ToInt32(Id));
            

            return View("Register", data);
        }
        [Route("Users/UpdateData/{Id}")]
        public IActionResult UpdateData([FromRoute] string Id,[FromQuery] string name)
        {
            var data = _dbcontext.Users.FirstOrDefault(x => x.Id == Convert.ToInt32(Id));
            if(data is not null)
            {
                data.UserName = name;
                _dbcontext.SaveChanges();
            }

            return View("Register", data);
        }

    }
}
