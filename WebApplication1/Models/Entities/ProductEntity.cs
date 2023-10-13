using System.ComponentModel.DataAnnotations.Schema;
using Manero.Models.Entities.LinkEntities;

namespace Manero.Models.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public Guid ArticleNumber { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public ICollection<ProductOrderEntity> ProductOrders { get; set; } = new HashSet<ProductOrderEntity>();
        public ICollection<ProductColorEntity> ProductColors { get; set; } = new HashSet<ProductColorEntity>();
        public ICollection<ProductCategoryEntity> ProductCategories { get; set; } = new HashSet<ProductCategoryEntity>();
        public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();
        public ICollection<ProductImageEntity> ProductImages { get; set; } = new HashSet<ProductImageEntity>();
        public ICollection<ProductSizeEntity> ProductSizes { get; set; } = new HashSet<ProductSizeEntity>();

        public ICollection<ProductSaleCategoryEntity> ProductSaleCategories { get; set; } = new HashSet<ProductSaleCategoryEntity>();

        public ICollection<ProductReviewEntity> ProductReviews { get; set; } = new HashSet<ProductReviewEntity>();


    }

}

