using Manero.Models.Entities;
using Manero.Models.Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace Manero.Models.ViewModels;

public class UserCreateAccountViewModel
{

    [Display(Name = "Name")]
    [Required(ErrorMessage = "You must enter your name")]
    public string Name { get; set; } = null!;

    [Display(Name = "E-mail")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "You must enter your E-mail address")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must enter a valid E-mail address")]
    public string Email { get; set; } = null!;


    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be between 8 and 15 characters and contain at least one uppercase letter, one lowercase letter, one digit and one special character")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password must be between 8 and 15 characters and contain at least one uppercase letter, one lowercase letter, one digit and one special character")]
    public string Password { get; set; } = null!;

    [Display(Name = "Confirm Password *")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "You must confirm your password")]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;

 
    public static implicit operator ManeroUser(UserCreateAccountViewModel model)
    {
        return new ManeroUser
        {
            UserName = model.Email,
            Name = model.Name,
            Email = model.Email,

        };
    }

}
