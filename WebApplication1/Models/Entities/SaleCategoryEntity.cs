using Manero.Models.Entities.LinkEntities;

namespace Manero.Models.Entities;

public class SaleCategoryEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<ProductSaleCategoryEntity> ProductSaleCategories { get; set; } = new HashSet<ProductSaleCategoryEntity>();
}
