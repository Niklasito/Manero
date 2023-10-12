using Microsoft.EntityFrameworkCore;


namespace Manero.Models.Entities;

[PrimaryKey("ProductId", "CategoryId")]
public class ProductCategoryEntity
{
    public int ProductId { get; set; }
    public ProductEntity ProductEntity { get; set; } = null!;

    public int CategoryId { get; set; }

    public CategoryEntity CategoryEntity { get; set; } = null!;
}
