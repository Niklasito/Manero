using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey("PaymentCardId", "PaymentMethodId")]
public class PaymentMethodCardEntity
{
    public int PaymentCardId { get; set; }
    public PaymentCardEntity PaymentCardEntity { get; set; } = null!;

    public int PaymentMethodId { get; set; }
    public PaymentMethodEntity PaymentMethodEntity { get; set; } = null!;
}
