namespace Manero.Models.Entities.LinkEntities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

[PrimaryKey(nameof(ProductId), nameof(SizeId))]

public class ProductSizeEntity
{ 
    
    [ForeignKey(nameof(ProductEntity))]
    public int ProductId { get; set; }

    public ProductEntity ProductEntity { get; set; } = null!;
    
    [ForeignKey(nameof(SizeEntity))]
    public int SizeId { get; set; }

    public SizeEntity SizeEntity { get; set; } = null!;

   
}
