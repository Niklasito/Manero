using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manero.Models.Entities.LinkEntities;

[PrimaryKey(nameof(ProductId), nameof(SaleCategoryId))]
public class ProductSaleCategoryEntity
{

    [ForeignKey(nameof(ProductEntity))]
    public int ProductId { get; set; }
    public ProductEntity ProductEntity { get; set; } = null!;

    [ForeignKey(nameof(SaleCategoryEntity))]
    public int SaleCategoryId { get; set; }
    public SaleCategoryEntity SaleCategoryEntity { get; set; } = null!;

}
