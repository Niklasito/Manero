using Manero.Models.Entities.LinkEntities;
using Microsoft.AspNetCore.Identity;

namespace Manero.Models.Entities.Identity;

public class ManeroUser : IdentityUser
{
    public string Name { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;

    public ICollection<UserOrderEntity> UserOrders { get; set; } = new HashSet<UserOrderEntity>();
    public ICollection<UserReviewEntity> UserReviews { get; set; } = new HashSet<UserReviewEntity>();

    public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();

    public ICollection<UserPromoCodeEntity> UserPromoCodes { get; set; } = new HashSet<UserPromoCodeEntity>();

    public ICollection<UserPaymentMethodEntity> UserPaymentMethods { get; set; } = new HashSet<UserPaymentMethodEntity>();
}
