using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manero.Migrations.Identity
{
    /// <inheritdoc />
    public partial class identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cvv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleCategoryEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleCategoryEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SizeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    ManeroUserId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ManeroUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AddressEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => new { x.ManeroUserId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_UserAddresses_Addresses_AddressEntityId",
                        column: x => x.AddressEntityId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddresses_AspNetUsers_ManeroUserId1",
                        column: x => x.ManeroUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserOrders",
                columns: table => new
                {
                    ManeroUserId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderEntityId = table.Column<int>(type: "int", nullable: false),
                    ManeroUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrders", x => new { x.ManeroUserId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_UserOrders_AspNetUsers_ManeroUserId1",
                        column: x => x.ManeroUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrders_OrderEntity_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "OrderEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethodCards",
                columns: table => new
                {
                    PaymentCardId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentCardEntityId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethodCards", x => new { x.PaymentCardId, x.PaymentMethodId });
                    table.ForeignKey(
                        name: "FK_PaymentMethodCards_PaymentCards_PaymentCardEntityId",
                        column: x => x.PaymentCardEntityId,
                        principalTable: "PaymentCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethodCards_PaymentMethods_PaymentMethodEntityId",
                        column: x => x.PaymentMethodEntityId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPaymentMethods",
                columns: table => new
                {
                    ManeroUserId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    ManeroUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PaymentMethodEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPaymentMethods", x => new { x.ManeroUserId, x.PaymentMethodId });
                    table.ForeignKey(
                        name: "FK_UserPaymentMethods_AspNetUsers_ManeroUserId1",
                        column: x => x.ManeroUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserPaymentMethods_PaymentMethods_PaymentMethodEntityId",
                        column: x => x.PaymentMethodEntityId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryEntity",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: false),
                    CategoryEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryEntity", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategoryEntity_CategoryEntity_CategoryEntityId",
                        column: x => x.CategoryEntityId,
                        principalTable: "CategoryEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryEntity_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductColorEntity",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColorEntity", x => new { x.ProductId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_ProductColorEntity_ColorEntity_ColorId",
                        column: x => x.ColorId,
                        principalTable: "ColorEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColorEntity_ProductEntity_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImageEntity",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: false),
                    ImageEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImageEntity", x => new { x.ProductId, x.ImageId });
                    table.ForeignKey(
                        name: "FK_ProductImageEntity_ImageEntity_ImageEntityId",
                        column: x => x.ImageEntityId,
                        principalTable: "ImageEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductImageEntity_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrderEntity",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrderEntity", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ProductOrderEntity_OrderEntity_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrderEntity_ProductEntity_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPromoCodes",
                columns: table => new
                {
                    ManeroUserId = table.Column<int>(type: "int", nullable: false),
                    PromoCodeId = table.Column<int>(type: "int", nullable: false),
                    ManeroUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PromoCodeEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPromoCodes", x => new { x.ManeroUserId, x.PromoCodeId });
                    table.ForeignKey(
                        name: "FK_UserPromoCodes_AspNetUsers_ManeroUserId1",
                        column: x => x.ManeroUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserPromoCodes_PromoCodes_PromoCodeEntityId",
                        column: x => x.PromoCodeEntityId,
                        principalTable: "PromoCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviewEntity",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: false),
                    ReviewEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviewEntity", x => new { x.ProductId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_ProductReviewEntity_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductReviewEntity_ReviewEntity_ReviewEntityId",
                        column: x => x.ReviewEntityId,
                        principalTable: "ReviewEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ManeroUserId = table.Column<int>(type: "int", nullable: false),
                    ReviewEntityId = table.Column<int>(type: "int", nullable: false),
                    ManeroUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => new { x.ManeroUserId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_UserReviews_AspNetUsers_ManeroUserId1",
                        column: x => x.ManeroUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserReviews_ReviewEntity_ReviewEntityId",
                        column: x => x.ReviewEntityId,
                        principalTable: "ReviewEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSaleCategoryEntity",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SaleCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: false),
                    SaleCategoryEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSaleCategoryEntity", x => new { x.ProductId, x.SaleCategoryId });
                    table.ForeignKey(
                        name: "FK_ProductSaleCategoryEntity_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSaleCategoryEntity_SaleCategoryEntity_SaleCategoryEntityId",
                        column: x => x.SaleCategoryEntityId,
                        principalTable: "SaleCategoryEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizeEntity",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeEntityId = table.Column<int>(type: "int", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizeEntity", x => new { x.ProductId, x.SizeId });
                    table.ForeignKey(
                        name: "FK_ProductSizeEntity_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizeEntity_SizeEntity_SizeEntityId",
                        column: x => x.SizeEntityId,
                        principalTable: "SizeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTagEntity",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagEntityId = table.Column<int>(type: "int", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTagEntity", x => new { x.TagId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductTagEntity_ProductEntity_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTagEntity_TagEntity_TagEntityId",
                        column: x => x.TagEntityId,
                        principalTable: "TagEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethodCards_PaymentCardEntityId",
                table: "PaymentMethodCards",
                column: "PaymentCardEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethodCards_PaymentMethodEntityId",
                table: "PaymentMethodCards",
                column: "PaymentMethodEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryEntity_CategoryEntityId",
                table: "ProductCategoryEntity",
                column: "CategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryEntity_ProductEntityId",
                table: "ProductCategoryEntity",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorEntity_ColorId",
                table: "ProductColorEntity",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImageEntity_ImageEntityId",
                table: "ProductImageEntity",
                column: "ImageEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImageEntity_ProductEntityId",
                table: "ProductImageEntity",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrderEntity_OrderId",
                table: "ProductOrderEntity",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviewEntity_ProductEntityId",
                table: "ProductReviewEntity",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviewEntity_ReviewEntityId",
                table: "ProductReviewEntity",
                column: "ReviewEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleCategoryEntity_ProductEntityId",
                table: "ProductSaleCategoryEntity",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleCategoryEntity_SaleCategoryEntityId",
                table: "ProductSaleCategoryEntity",
                column: "SaleCategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeEntity_ProductEntityId",
                table: "ProductSizeEntity",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeEntity_SizeEntityId",
                table: "ProductSizeEntity",
                column: "SizeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTagEntity_ProductEntityId",
                table: "ProductTagEntity",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTagEntity_TagEntityId",
                table: "ProductTagEntity",
                column: "TagEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_AddressEntityId",
                table: "UserAddresses",
                column: "AddressEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_ManeroUserId1",
                table: "UserAddresses",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrders_ManeroUserId1",
                table: "UserOrders",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrders_OrderEntityId",
                table: "UserOrders",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMethods_ManeroUserId1",
                table: "UserPaymentMethods",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMethods_PaymentMethodEntityId",
                table: "UserPaymentMethods",
                column: "PaymentMethodEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_ManeroUserId1",
                table: "UserPromoCodes",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_PromoCodeEntityId",
                table: "UserPromoCodes",
                column: "PromoCodeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ManeroUserId1",
                table: "UserReviews",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ReviewEntityId",
                table: "UserReviews",
                column: "ReviewEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PaymentMethodCards");

            migrationBuilder.DropTable(
                name: "ProductCategoryEntity");

            migrationBuilder.DropTable(
                name: "ProductColorEntity");

            migrationBuilder.DropTable(
                name: "ProductImageEntity");

            migrationBuilder.DropTable(
                name: "ProductOrderEntity");

            migrationBuilder.DropTable(
                name: "ProductReviewEntity");

            migrationBuilder.DropTable(
                name: "ProductSaleCategoryEntity");

            migrationBuilder.DropTable(
                name: "ProductSizeEntity");

            migrationBuilder.DropTable(
                name: "ProductTagEntity");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "UserOrders");

            migrationBuilder.DropTable(
                name: "UserPaymentMethods");

            migrationBuilder.DropTable(
                name: "UserPromoCodes");

            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PaymentCards");

            migrationBuilder.DropTable(
                name: "CategoryEntity");

            migrationBuilder.DropTable(
                name: "ColorEntity");

            migrationBuilder.DropTable(
                name: "ImageEntity");

            migrationBuilder.DropTable(
                name: "SaleCategoryEntity");

            migrationBuilder.DropTable(
                name: "SizeEntity");

            migrationBuilder.DropTable(
                name: "ProductEntity");

            migrationBuilder.DropTable(
                name: "TagEntity");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "OrderEntity");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ReviewEntity");
        }
    }
}
