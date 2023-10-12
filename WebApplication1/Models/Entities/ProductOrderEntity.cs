using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities;

[PrimaryKey("ProductId", "OrderId")]
public class ProductOrderEntity
{

    public int OrderId { get; set; }

    public OrderEntity Order { get; set; } = null!;
    public int ProductId { get; set; }

    public ProductEntity Product { get; set; } = null!;


   
}
