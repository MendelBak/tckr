using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tckr.Models
{
    public class RegisterViewModel : BaseEntity
    {
        [Required]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match!")]
        [MinLength(8)]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage="Password must be at least 8 characters long and contain 1 Capital letter, 1 lowercase letter, and 1 number or special character.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string Bio { get; set; }
        
        public string Homepage { get; set; }
    }

    public class LoginViewModel : BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class AllUserViewModels
    {
        public LoginViewModel Log { get; set; }
        public RegisterViewModel Reg { get; set; }
    }
}
