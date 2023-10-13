using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey("ProductId", "SaleCategoryId")]
public class ProductSaleCategoryEntity
{
    public int ProductId { get; set; }
    public ProductEntity ProductEntity { get; set; } = null!;

    public int SaleCategoryId { get; set; }
    public SaleCategoryEntity SaleCategoryEntity { get; set; } = null!;

}
