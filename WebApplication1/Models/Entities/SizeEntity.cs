namespace Manero.Models.Entities;

public class SizeEntity
{
    public int Id { get; set; }
    public string Size { get; set; } = null!;

    public ICollection<ProductSizeEntity> ProductSizes { get; set; } = new HashSet<ProductSizeEntity>();
}
