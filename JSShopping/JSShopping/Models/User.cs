using System.ComponentModel.DataAnnotations;

namespace JSShopping.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "CustomerNameRequired")]
        [Display(Name = "CustomerName")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Hashed password in real-world apps
    }
}
