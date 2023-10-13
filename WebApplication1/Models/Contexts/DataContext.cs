using Manero.Models.Entities;
using Manero.Models.Entities.Identity;
using Manero.Models.Entities.LinkEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Contexts;

public class DataContext : IdentityDbContext<ManeroUser>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserOrderEntity> UserOrders { get; set; }
    public DbSet<UserReviewEntity> UserReviews { get; set; }
    public DbSet<UserAddressEntity> UserAddresses { get; set; }
    public DbSet<UserPaymentMethodEntity> UserPaymentMethods { get; set; }
    public DbSet<UserPromoCodeEntity> UserPromoCodes { get; set; }
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<PaymentMethodEntity> PaymentMethods { get; set; }
    public DbSet<PromoCodeEntity> PromoCodes { get; set; }
    public DbSet<PaymentMethodCardEntity> PaymentMethodCards { get; set; }
    public DbSet<PaymentCardEntity> PaymentCards { get; set; }

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
