using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manero.Models.Entities.LinkEntities
{
    [PrimaryKey(nameof(ProductId), nameof(ReviewId))]
    public class ProductReviewEntity
    {
        [ForeignKey(nameof(ProductEntity))]
        public int ProductId { get; set; }
        public ProductEntity ProductEntity { get; set; } = null!;

        [ForeignKey(nameof(ReviewEntity))]
        public int ReviewId { get; set; }
        public ReviewEntity ReviewEntity { get; set; } = null!;
    }
}
