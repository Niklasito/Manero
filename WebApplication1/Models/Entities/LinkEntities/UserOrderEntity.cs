using Manero.Models.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey(nameof(UserId), nameof(OrderId))]
public class UserOrderEntity
{
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public ManeroUser User { get; set; } = null!;

    [ForeignKey(nameof(OrderEntity))]
    public int OrderId { get; set; }
    
    public OrderEntity OrderEntity { get; set; } = null!;
}
