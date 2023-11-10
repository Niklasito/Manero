using Manero.Models.Entities;
using Manero.Models.Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace Manero.Helpers.Dtos
{
    public class EditProfileModel
    {
        public string ProfileId { get; set; } = null!;

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You must enter your name")]
        public string ProfileName { get; set; } = null!;

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must enter your E-mail address")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must enter a valid E-mail address")]
        public string Email {  get; set; } = null!;
        public string? PhoneNumber { get; set; } 
        public string? City { get; set; } 

        public static implicit operator ManeroUser(EditProfileModel model)
        {
            return new ManeroUser
            {
                Id = model.ProfileId,
                Name = model.ProfileName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };
        }

        public static implicit operator AddressEntity(EditProfileModel model)
        {
            return new AddressEntity
            {
                City = model.City
            };
        }
    }
}
