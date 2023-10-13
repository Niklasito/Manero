using Manero.Models.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manero.Models.Entities.LinkEntities;


[PrimaryKey(nameof(UserId), nameof(PaymentMethodId))]
public class UserPaymentMethodEntity
{
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public ManeroUser User { get; set; } = null!;

    [ForeignKey(nameof(PaymentMethodEntity))]
    public int PaymentMethodId { get; set; }

    public PaymentMethodEntity PaymentMethodEntity { get; set; } = null!;
}
