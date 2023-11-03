using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey(nameof(ProductId), nameof(ImageId))]
public class ProductImageEntity
{
    [ForeignKey(nameof(ProductEntity))]
    public int ProductId { get; set; }
    public ProductEntity ProductEntity { get; set; } = null!;

 

    [ForeignKey(nameof(ImageEntity))]
    public int ImageId { get; set; }

    public ImageEntity ImageEntity { get; set; } = null!;
}
