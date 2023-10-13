using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey("ProductId", "ImageId")]
public class ProductImageEntity
{
    public int ProductId { get; set; }
    public ProductEntity ProductEntity { get; set; } = null!;

    public int ImageId { get; set; }

    public ImageEntity ImageEntity { get; set; } = null!;
}
