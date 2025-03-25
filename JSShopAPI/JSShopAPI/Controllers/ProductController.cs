using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;

namespace JSShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from ProductController!";
        }
        [HttpGet("Getemployeename")]
        public string[] Getdata()
        {
            string[] names = { "John", "Doe", "Jane" };
            return names;
        }
        [HttpGet("GetDataVale")]
        public IActionResult GetDataVale()
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Doe");
            return Ok(names);
        }
        [HttpGet("Getnames")]
        public IActionResult Getnames()
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Doe");
            return new JsonResult(names);
        }
        [HttpGet("GetDatafromSAP")]
        public IActionResult GetDatafromSAP()
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Doe");
            return new StatusCodeResult(StatusCodes.Status426UpgradeRequired);
        }
        [HttpGet("UnGetDatafromSAP")]
        public IActionResult UnGetDatafromSAP()
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Doe");
            return new UnauthorizedResult();
        }
        [HttpPost("Register")]
        public IActionResult RegisterEmployee([FromQuery] Product name)
        {
           return Ok("Employee Registered Successfully");
        }

        [HttpPost("UpdateEmployee/{name}")]
        public IActionResult UpdateEmployee([FromRoute] string name)
        {
            return Ok("Employee Registered Successfully");
        }


        [HttpPost("RegisterForm")]
        public IActionResult RegisterForm([FromForm] Product proddetails, [FromHeader] string useragent)
        {
            if (useragent == "Js")
            {
                return Ok(proddetails.Price.ToString());
            }
            else
            {
                return new UnauthorizedResult();
            }
        }
    }

   
    public class Product
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
