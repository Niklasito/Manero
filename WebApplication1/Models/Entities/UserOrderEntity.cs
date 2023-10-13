using Manero.Models.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities;

[PrimaryKey("ManeroUserId", "OrderId")]
public class UserOrderEntity
{
    public int ManeroUserId { get; set; }
    public OrderEntity OrderEntity { get; set; } = null!;

    public int OrderId { get; set; }
    public ManeroUser ManeroUser { get; set; } = null!;

}
