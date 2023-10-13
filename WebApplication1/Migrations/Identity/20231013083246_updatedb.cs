using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manero.Migrations.Identity
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryEntity_CategoryEntity_CategoryEntityId",
                table: "ProductCategoryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryEntity_ProductEntity_ProductEntityId",
                table: "ProductCategoryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorEntity_ColorEntity_ColorId",
                table: "ProductColorEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorEntity_ProductEntity_ProductId",
                table: "ProductColorEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImageEntity_ImageEntity_ImageEntityId",
                table: "ProductImageEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImageEntity_ProductEntity_ProductEntityId",
                table: "ProductImageEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrderEntity_OrderEntity_OrderId",
                table: "ProductOrderEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrderEntity_ProductEntity_ProductId",
                table: "ProductOrderEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviewEntity_ProductEntity_ProductEntityId",
                table: "ProductReviewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviewEntity_ReviewEntity_ReviewEntityId",
                table: "ProductReviewEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSaleCategoryEntity_ProductEntity_ProductEntityId",
                table: "ProductSaleCategoryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSaleCategoryEntity_SaleCategoryEntity_SaleCategoryEntityId",
                table: "ProductSaleCategoryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeEntity_ProductEntity_ProductEntityId",
                table: "ProductSizeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeEntity_SizeEntity_SizeEntityId",
                table: "ProductSizeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagEntity_ProductEntity_ProductEntityId",
                table: "ProductTagEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagEntity_TagEntity_TagEntityId",
                table: "ProductTagEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_OrderEntity_OrderId",
                table: "UserOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_ReviewEntity_ReviewId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagEntity",
                table: "TagEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeEntity",
                table: "SizeEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleCategoryEntity",
                table: "SaleCategoryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReviewEntity",
                table: "ReviewEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTagEntity",
                table: "ProductTagEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizeEntity",
                table: "ProductSizeEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSaleCategoryEntity",
                table: "ProductSaleCategoryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductReviewEntity",
                table: "ProductReviewEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductOrderEntity",
                table: "ProductOrderEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImageEntity",
                table: "ProductImageEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductEntity",
                table: "ProductEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColorEntity",
                table: "ProductColorEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategoryEntity",
                table: "ProductCategoryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderEntity",
                table: "OrderEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageEntity",
                table: "ImageEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorEntity",
                table: "ColorEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryEntity",
                table: "CategoryEntity");

            migrationBuilder.RenameTable(
                name: "TagEntity",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "SizeEntity",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "SaleCategoryEntity",
                newName: "SaleCategories");

            migrationBuilder.RenameTable(
                name: "ReviewEntity",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "ProductTagEntity",
                newName: "ProductTags");

            migrationBuilder.RenameTable(
                name: "ProductSizeEntity",
                newName: "ProductSizes");

            migrationBuilder.RenameTable(
                name: "ProductSaleCategoryEntity",
                newName: "ProductSaleCategories");

            migrationBuilder.RenameTable(
                name: "ProductReviewEntity",
                newName: "ProductReviews");

            migrationBuilder.RenameTable(
                name: "ProductOrderEntity",
                newName: "ProductOrders");

            migrationBuilder.RenameTable(
                name: "ProductImageEntity",
                newName: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductEntity",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "ProductColorEntity",
                newName: "ProductColors");

            migrationBuilder.RenameTable(
                name: "ProductCategoryEntity",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "OrderEntity",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "ImageEntity",
                newName: "Images");

            migrationBuilder.RenameTable(
                name: "ColorEntity",
                newName: "Colors");

            migrationBuilder.RenameTable(
                name: "CategoryEntity",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagEntity_TagEntityId",
                table: "ProductTags",
                newName: "IX_ProductTags_TagEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagEntity_ProductEntityId",
                table: "ProductTags",
                newName: "IX_ProductTags_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeEntity_SizeEntityId",
                table: "ProductSizes",
                newName: "IX_ProductSizes_SizeEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeEntity_ProductEntityId",
                table: "ProductSizes",
                newName: "IX_ProductSizes_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSaleCategoryEntity_SaleCategoryEntityId",
                table: "ProductSaleCategories",
                newName: "IX_ProductSaleCategories_SaleCategoryEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSaleCategoryEntity_ProductEntityId",
                table: "ProductSaleCategories",
                newName: "IX_ProductSaleCategories_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviewEntity_ReviewEntityId",
                table: "ProductReviews",
                newName: "IX_ProductReviews_ReviewEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviewEntity_ProductEntityId",
                table: "ProductReviews",
                newName: "IX_ProductReviews_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOrderEntity_OrderId",
                table: "ProductOrders",
                newName: "IX_ProductOrders_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImageEntity_ProductEntityId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImageEntity_ImageEntityId",
                table: "ProductImages",
                newName: "IX_ProductImages_ImageEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColorEntity_ColorId",
                table: "ProductColors",
                newName: "IX_ProductColors_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategoryEntity_ProductEntityId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategoryEntity_CategoryEntityId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_CategoryEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleCategories",
                table: "SaleCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                columns: new[] { "TagId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSaleCategories",
                table: "ProductSaleCategories",
                columns: new[] { "ProductId", "SaleCategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductReviews",
                table: "ProductReviews",
                columns: new[] { "ProductId", "ReviewId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductOrders",
                table: "ProductOrders",
                columns: new[] { "ProductId", "OrderId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                columns: new[] { "ProductId", "ImageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors",
                columns: new[] { "ProductId", "ColorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Categories_CategoryEntityId",
                table: "ProductCategories",
                column: "CategoryEntityId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductEntityId",
                table: "ProductCategories",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Colors_ColorId",
                table: "ProductColors",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Products_ProductId",
                table: "ProductColors",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Images_ImageEntityId",
                table: "ProductImages",
                column: "ImageEntityId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductEntityId",
                table: "ProductImages",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrders_Orders_OrderId",
                table: "ProductOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrders_Products_ProductId",
                table: "ProductOrders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductEntityId",
                table: "ProductReviews",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Reviews_ReviewEntityId",
                table: "ProductReviews",
                column: "ReviewEntityId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSaleCategories_Products_ProductEntityId",
                table: "ProductSaleCategories",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSaleCategories_SaleCategories_SaleCategoryEntityId",
                table: "ProductSaleCategories",
                column: "SaleCategoryEntityId",
                principalTable: "SaleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Products_ProductEntityId",
                table: "ProductSizes",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Sizes_SizeEntityId",
                table: "ProductSizes",
                column: "SizeEntityId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Products_ProductEntityId",
                table: "ProductTags",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Tags_TagEntityId",
                table: "ProductTags",
                column: "TagEntityId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_Orders_OrderId",
                table: "UserOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_Reviews_ReviewId",
                table: "UserReviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Categories_CategoryEntityId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductEntityId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Colors_ColorId",
                table: "ProductColors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Products_ProductId",
                table: "ProductColors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Images_ImageEntityId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductEntityId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrders_Orders_OrderId",
                table: "ProductOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrders_Products_ProductId",
                table: "ProductOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductEntityId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Reviews_ReviewEntityId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSaleCategories_Products_ProductEntityId",
                table: "ProductSaleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSaleCategories_SaleCategories_SaleCategoryEntityId",
                table: "ProductSaleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Products_ProductEntityId",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Sizes_SizeEntityId",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Products_ProductEntityId",
                table: "ProductTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Tags_TagEntityId",
                table: "ProductTags");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_Orders_OrderId",
                table: "UserOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_Reviews_ReviewId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleCategories",
                table: "SaleCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSaleCategories",
                table: "ProductSaleCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductReviews",
                table: "ProductReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductOrders",
                table: "ProductOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "TagEntity");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "SizeEntity");

            migrationBuilder.RenameTable(
                name: "SaleCategories",
                newName: "SaleCategoryEntity");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "ReviewEntity");

            migrationBuilder.RenameTable(
                name: "ProductTags",
                newName: "ProductTagEntity");

            migrationBuilder.RenameTable(
                name: "ProductSizes",
                newName: "ProductSizeEntity");

            migrationBuilder.RenameTable(
                name: "ProductSaleCategories",
                newName: "ProductSaleCategoryEntity");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductEntity");

            migrationBuilder.RenameTable(
                name: "ProductReviews",
                newName: "ProductReviewEntity");

            migrationBuilder.RenameTable(
                name: "ProductOrders",
                newName: "ProductOrderEntity");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImageEntity");

            migrationBuilder.RenameTable(
                name: "ProductColors",
                newName: "ProductColorEntity");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductCategoryEntity");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "OrderEntity");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "ImageEntity");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "ColorEntity");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryEntity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTags_TagEntityId",
                table: "ProductTagEntity",
                newName: "IX_ProductTagEntity_TagEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTags_ProductEntityId",
                table: "ProductTagEntity",
                newName: "IX_ProductTagEntity_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizes_SizeEntityId",
                table: "ProductSizeEntity",
                newName: "IX_ProductSizeEntity_SizeEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizes_ProductEntityId",
                table: "ProductSizeEntity",
                newName: "IX_ProductSizeEntity_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSaleCategories_SaleCategoryEntityId",
                table: "ProductSaleCategoryEntity",
                newName: "IX_ProductSaleCategoryEntity_SaleCategoryEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSaleCategories_ProductEntityId",
                table: "ProductSaleCategoryEntity",
                newName: "IX_ProductSaleCategoryEntity_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_ReviewEntityId",
                table: "ProductReviewEntity",
                newName: "IX_ProductReviewEntity_ReviewEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_ProductEntityId",
                table: "ProductReviewEntity",
                newName: "IX_ProductReviewEntity_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrderEntity",
                newName: "IX_ProductOrderEntity_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductEntityId",
                table: "ProductImageEntity",
                newName: "IX_ProductImageEntity_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ImageEntityId",
                table: "ProductImageEntity",
                newName: "IX_ProductImageEntity_ImageEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColors_ColorId",
                table: "ProductColorEntity",
                newName: "IX_ProductColorEntity_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ProductEntityId",
                table: "ProductCategoryEntity",
                newName: "IX_ProductCategoryEntity_ProductEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_CategoryEntityId",
                table: "ProductCategoryEntity",
                newName: "IX_ProductCategoryEntity_CategoryEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagEntity",
                table: "TagEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeEntity",
                table: "SizeEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleCategoryEntity",
                table: "SaleCategoryEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReviewEntity",
                table: "ReviewEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTagEntity",
                table: "ProductTagEntity",
                columns: new[] { "TagId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizeEntity",
                table: "ProductSizeEntity",
                columns: new[] { "ProductId", "SizeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSaleCategoryEntity",
                table: "ProductSaleCategoryEntity",
                columns: new[] { "ProductId", "SaleCategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductEntity",
                table: "ProductEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductReviewEntity",
                table: "ProductReviewEntity",
                columns: new[] { "ProductId", "ReviewId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductOrderEntity",
                table: "ProductOrderEntity",
                columns: new[] { "ProductId", "OrderId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImageEntity",
                table: "ProductImageEntity",
                columns: new[] { "ProductId", "ImageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColorEntity",
                table: "ProductColorEntity",
                columns: new[] { "ProductId", "ColorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategoryEntity",
                table: "ProductCategoryEntity",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderEntity",
                table: "OrderEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageEntity",
                table: "ImageEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorEntity",
                table: "ColorEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryEntity",
                table: "CategoryEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryEntity_CategoryEntity_CategoryEntityId",
                table: "ProductCategoryEntity",
                column: "CategoryEntityId",
                principalTable: "CategoryEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryEntity_ProductEntity_ProductEntityId",
                table: "ProductCategoryEntity",
                column: "ProductEntityId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorEntity_ColorEntity_ColorId",
                table: "ProductColorEntity",
                column: "ColorId",
                principalTable: "ColorEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorEntity_ProductEntity_ProductId",
                table: "ProductColorEntity",
                column: "ProductId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImageEntity_ImageEntity_ImageEntityId",
                table: "ProductImageEntity",
                column: "ImageEntityId",
                principalTable: "ImageEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImageEntity_ProductEntity_ProductEntityId",
                table: "ProductImageEntity",
                column: "ProductEntityId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrderEntity_OrderEntity_OrderId",
                table: "ProductOrderEntity",
                column: "OrderId",
                principalTable: "OrderEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrderEntity_ProductEntity_ProductId",
                table: "ProductOrderEntity",
                column: "ProductId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviewEntity_ProductEntity_ProductEntityId",
                table: "ProductReviewEntity",
                column: "ProductEntityId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviewEntity_ReviewEntity_ReviewEntityId",
                table: "ProductReviewEntity",
                column: "ReviewEntityId",
                principalTable: "ReviewEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSaleCategoryEntity_ProductEntity_ProductEntityId",
                table: "ProductSaleCategoryEntity",
                column: "ProductEntityId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSaleCategoryEntity_SaleCategoryEntity_SaleCategoryEntityId",
                table: "ProductSaleCategoryEntity",
                column: "SaleCategoryEntityId",
                principalTable: "SaleCategoryEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeEntity_ProductEntity_ProductEntityId",
                table: "ProductSizeEntity",
                column: "ProductEntityId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeEntity_SizeEntity_SizeEntityId",
                table: "ProductSizeEntity",
                column: "SizeEntityId",
                principalTable: "SizeEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagEntity_ProductEntity_ProductEntityId",
                table: "ProductTagEntity",
                column: "ProductEntityId",
                principalTable: "ProductEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagEntity_TagEntity_TagEntityId",
                table: "ProductTagEntity",
                column: "TagEntityId",
                principalTable: "TagEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_OrderEntity_OrderId",
                table: "UserOrders",
                column: "OrderId",
                principalTable: "OrderEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_ReviewEntity_ReviewId",
                table: "UserReviews",
                column: "ReviewId",
                principalTable: "ReviewEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
