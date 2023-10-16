using System.ComponentModel.DataAnnotations;

namespace Manero.Models.ViewModels
{
    public class UserLoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must enter your E-mail address")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must provide your Password")]
        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; } = false;

        public string ReturnUrl { get; set; } = "/";
    }
}
