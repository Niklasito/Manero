using Manero.Models.Entities;
using Manero.Models.Entities.Identity;

namespace Manero.Models.ViewModels
{
    public class EditProfileViewModel
    {
        public ManeroUser User { get; set; } = null!;
        public AddressEntity Address { get; set; } = null!;
    }
}
