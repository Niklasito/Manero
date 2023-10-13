using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Contexts;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options) : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<ColorEntity> Colors { get; set; }
    public DbSet<SizeEntity> Sizes { get; set; }
    public DbSet<ImageEntity> Images { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<SaleCategoryEntity> SaleCategories { get; set; }

    public DbSet<ReviewEntity> Reviews { get; set; }


    public DbSet<ProductOrderEntity> ProductOrders { get; set; }
    public DbSet<ProductColorEntity> ProductColors { get; set; }
    public DbSet<ProductSizeEntity> ProductSizes { get; set; }

    public DbSet<ProductImageEntity> ProductImages { get; set; }
    public DbSet<ProductTagEntity> ProductTags { get; set; }
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
    public DbSet<ProductSaleCategoryEntity> ProductSaleCategories { get; set; }

    public DbSet<ProductReviewEntity> ProductReviews { get; set; }

}
