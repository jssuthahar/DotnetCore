using JSShopAPI.BusinessLogic;
using JSShopAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JSShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserLogic _userLogic;
        public UserController(UserLogic userLogic) {

            _userLogic = userLogic;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] Student student)
        {
            if(student == null)
            {
                return BadRequest("Student is null.");
            }
            int val=  _userLogic.Register(student);
            if(val > 0)
            {
                return Ok("Student Registered Successfully");
            }
            else
            {
                return BadRequest("Student Registration Failed");
            }
        }
        [HttpGet("Login")]
        public IActionResult Login([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student is null.");
            }
            object val = _userLogic.LoginCheck(student);
            if (val != null)
            {
                return Ok(val.ToString());
            }
            else
            {
                return BadRequest("Login Failed");
            }
        }
        [HttpGet("GetStudent")]
        public IActionResult GetStudent([FromQuery] string email, string password)
        {
            if (email == null || password == null)
            {
                return BadRequest("Email or Password is null.");
            }
            Student student = _userLogic.GetStudnet(email, password);
            if (student != null)
            {
                return Ok(student);
            }
            else
            {
                return BadRequest("Student Not Found");
            }
        }
    }
}
