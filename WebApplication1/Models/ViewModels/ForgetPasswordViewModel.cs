using Manero.Models.Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace Manero.Models.ViewModels;

    public class ForgetPasswordViewModel
    {
    [Display(Name = "E-mail")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "You must enter your E-mail address")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must enter a valid E-mail address")]
    public string Email { get; set; } = null!;



    public static implicit operator ManeroUser(ForgetPasswordViewModel model)
    {
        return new ManeroUser
        {
           
            Email = model.Email,

        };
    }


}

