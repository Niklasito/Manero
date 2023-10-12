namespace Manero.Models.Entities;

public class OrderEntity
{
    public int Id { get; set; }
    public Guid OrderNumber { get; set; } = Guid.NewGuid();
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public ICollection<ProductOrderEntity> ProductOrders { get; set; } = new HashSet<ProductOrderEntity>();

    
}
