using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey(nameof(ProductId), nameof(CategoryId))]
public class ProductCategoryEntity
{

    [ForeignKey(nameof(ProductEntity))]
    public int ProductId { get; set; }
    public ProductEntity ProductEntity { get; set; } = null!;

    [ForeignKey(nameof(CategoryEntity))]
    public int CategoryId { get; set; }

    public CategoryEntity CategoryEntity { get; set; } = null!;
}
