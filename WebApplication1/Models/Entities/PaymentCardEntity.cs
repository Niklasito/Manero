using Manero.Models.Entities.LinkEntities;

namespace Manero.Models.Entities;

public class PaymentCardEntity
{
    public int Id { get; set; }
    public string CardNumber { get; set; } = null!;
    public string CardHolderName { get; set; } = null!;
    public string ExpirationDate { get; set; } = null!;
    public string Cvv { get; set; } = null!;

    public ICollection<PaymentMethodCardEntity> PaymenMethodCards { get; set; } = new HashSet<PaymentMethodCardEntity>();
}
