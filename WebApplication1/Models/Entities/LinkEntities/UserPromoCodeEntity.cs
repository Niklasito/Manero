using Manero.Models.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manero.Models.Entities.LinkEntities;


[PrimaryKey(nameof(UserId), nameof(PromoCodeId))]
public class UserPromoCodeEntity
{

    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public ManeroUser User { get; set; } = null!;

    [ForeignKey(nameof(PromoCodeEntity))]
    public int PromoCodeId { get; set; }
    public PromoCodeEntity PromoCodeEntity { get; set; } = null!;

}
