namespace Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

[PrimaryKey("ProductId", "SizeId")]
    
public class ProductSizeEntity
{
    public int SizeId { get; set; }

    public SizeEntity SizeEntity { get; set; } = null!;

    public int ProductId { get; set; }

    public ProductEntity ProductEntity { get; set; } = null!;
}
