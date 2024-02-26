using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReadersDelightWeb.Models
{
    public class RegisterViewModel
    {
        // Username
        [Required(ErrorMessage = "Username is Required")]
        [StringLength(50, ErrorMessage = "Username must be between 3 to 50 characters", MinimumLength = 3)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        //Email
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //Password and Re-Type Password
        [Required(ErrorMessage ="Password is required")]
        [StringLength(100,ErrorMessage = "The {0} must be atleast {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage = "The password and confirmation password do not match ")]
        public string ConfirmPassword { get; set;}
        
    }
}
