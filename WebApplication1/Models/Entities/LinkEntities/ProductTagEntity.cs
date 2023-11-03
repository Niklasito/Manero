using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Manero.Models.Entities.LinkEntities
{
    
    [PrimaryKey(nameof(ProductId), nameof(TagId))]
    
    public class ProductTagEntity
    {
        
        [ForeignKey(nameof(ProductEntity))]
        public int ProductId { get; set; }
        public ProductEntity ProductEntity { get; set; } = null!;

        [ForeignKey(nameof(TagEntity))]
        public int TagId { get; set; }
        public TagEntity TagEntity { get; set; } = null!;

        
    }
}
