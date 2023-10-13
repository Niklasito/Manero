using Manero.Models.Entities.LinkEntities;

namespace Manero.Models.Entities;

public class PromoCodeEntity
{
    public int Id { get; set; }
    public string PromoCode { get; set; } = null!;

    public decimal Discount { get; set; }

    public ICollection<UserPromoCodeEntity> UserPromoCodes { get; set; } = new HashSet<UserPromoCodeEntity>();
}
