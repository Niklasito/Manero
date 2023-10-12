using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities
{
    [PrimaryKey("ProductId", "ReviewId")]
    public class ProductReviewEntity
    {
        public int ProductId { get; set; }
        public ProductEntity ProductEntity { get; set; } = null!;

        public int ReviewId { get; set; }
        public ReviewEntity ReviewEntity { get; set; } = null!;
    }
}
