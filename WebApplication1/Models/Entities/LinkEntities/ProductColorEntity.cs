using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manero.Models.Entities.LinkEntities;
[PrimaryKey(nameof(ProductId), nameof(ColorId))]
public class ProductColorEntity
{
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public ProductEntity Product { get; set; } = null!;

    [ForeignKey(nameof(Color))]
    public int ColorId { get; set; }

    public ColorEntity Color { get; set; } = null!;
    
}
