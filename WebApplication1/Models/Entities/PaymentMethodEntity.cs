using Manero.Models.Entities.LinkEntities;

namespace Manero.Models.Entities;

public class PaymentMethodEntity
{
    public int Id { get; set; }
    public string PaymentMethod { get; set; } = null!;

    public ICollection<UserPaymentMethodEntity> UserPaymentMethods { get; set; } = new HashSet<UserPaymentMethodEntity>();
    public ICollection<PaymentMethodCardEntity> PaymentMethodCards { get; set; } = new HashSet<PaymentMethodCardEntity>();
}
