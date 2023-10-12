using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities;
[PrimaryKey("ProductId", "ColorId")]
public class ProductColorEntity
{
    public int ColorId { get; set; }

    public ColorEntity Color { get; set; } = null!;
    public int ProductId { get; set; }

    public ProductEntity Product { get; set; } = null!;
}
