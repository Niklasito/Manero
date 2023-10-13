namespace Manero.Models.Entities;

public class CategoryEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<ProductCategoryEntity> ProductCategories { get; set; } = new HashSet<ProductCategoryEntity>();
}
