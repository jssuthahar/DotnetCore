using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Scripting.Hosting;
using System.ComponentModel.DataAnnotations;

namespace MiniSuperMarket.Models
{
    public class Users
    {
        [Display(Name ="User ID")]
        [ValidateNever]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Please enter username")]
        [MaxLength(50, ErrorMessage = "Username cannot exceed 50 characters")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-zA-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+])[A-Za-z\\d][A-Za-z\\d!@#$%^&*()_+]{7,19}$",
            ErrorMessage = "Password must be 8-20 characters long, contain at least one letter, one number, and one special character.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [NoEmailAttrribute(ErrorMessage = "Email cannot end with @gmail.com")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [DataType(DataType.Date)]
        [ValidateNever]
        [Display(Name = "Data of Birth")]
        public string DOB { get; set; }
        [Range(0, 120, ErrorMessage = "Age must be between 0 and 120")]
       
        public int Age { get; set; }
      
    }
    public class NoEmailAttrribute:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is string email)
                return !email.EndsWith("@gmail.com");
            return true;
        }
    }
}
