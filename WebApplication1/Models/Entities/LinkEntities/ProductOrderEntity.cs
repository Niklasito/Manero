using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey(nameof(ProductId), nameof(OrderId))]
public class ProductOrderEntity
{
    
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }

    public ProductEntity Product { get; set; } = null!;
    
    [ForeignKey(nameof(Order))]
    public int OrderId { get; set; }

    public OrderEntity Order { get; set; } = null!;

    



}
