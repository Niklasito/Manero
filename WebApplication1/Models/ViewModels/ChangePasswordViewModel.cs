using System.ComponentModel.DataAnnotations;

namespace Manero.Models.ViewModels;

    public class ChangePasswordViewModel
    {

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
}

