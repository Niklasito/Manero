using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manero.Migrations
{
    /// <inheritdoc />
    public partial class updatetables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Categories_CategoryEntityId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductEntityId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Images_ImageEntityId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductEntityId",
                table: "ProductImages");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.DropIndex(
                name: "IX_ProductTags_ProductEntityId",
                table: "ProductTags");

            migrationBuilder.DropIndex(
                name: "IX_ProductTags_TagEntityId",
                table: "ProductTags");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_ProductEntityId",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_SizeEntityId",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSaleCategories_ProductEntityId",
                table: "ProductSaleCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductSaleCategories_SaleCategoryEntityId",
                table: "ProductSaleCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ProductEntityId",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ReviewEntityId",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ImageEntityId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductEntityId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_CategoryEntityId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_ProductEntityId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "TagEntityId",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductSizes");

            migrationBuilder.DropColumn(
                name: "SizeEntityId",
                table: "ProductSizes");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductSaleCategories");

            migrationBuilder.DropColumn(
                name: "SaleCategoryEntityId",
                table: "ProductSaleCategories");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "ReviewEntityId",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "ImageEntityId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CategoryEntityId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_SizeId",
                table: "ProductSizes",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleCategories_SaleCategoryId",
                table: "ProductSaleCategories",
                column: "SaleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ReviewId",
                table: "ProductReviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ImageId",
                table: "ProductImages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Categories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Images_ImageId",
                table: "ProductImages",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Reviews_ReviewId",
                table: "ProductReviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSaleCategories_Products_ProductId",
                table: "ProductSaleCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSaleCategories_SaleCategories_SaleCategoryId",
                table: "ProductSaleCategories",
                column: "SaleCategoryId",
                principalTable: "SaleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Products_ProductId",
                table: "ProductSizes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Sizes_SizeId",
                table: "ProductSizes",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Products_ProductId",
                table: "ProductTags",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Tags_TagId",
                table: "ProductTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Categories_CategoryId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Images_ImageId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Reviews_ReviewId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSaleCategories_Products_ProductId",
                table: "ProductSaleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSaleCategories_SaleCategories_SaleCategoryId",
                table: "ProductSaleCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Products_ProductId",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Sizes_SizeId",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Products_ProductId",
                table: "ProductTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Tags_TagId",
                table: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.DropIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_SizeId",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSaleCategories_SaleCategoryId",
                table: "ProductSaleCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ReviewId",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ImageId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories");

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagEntityId",
                table: "ProductTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeEntityId",
                table: "ProductSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductSaleCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaleCategoryEntityId",
                table: "ProductSaleCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReviewEntityId",
                table: "ProductReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageEntityId",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryEntityId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                columns: new[] { "TagId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductEntityId",
                table: "ProductTags",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagEntityId",
                table: "ProductTags",
                column: "TagEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductEntityId",
                table: "ProductSizes",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_SizeEntityId",
                table: "ProductSizes",
                column: "SizeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleCategories_ProductEntityId",
                table: "ProductSaleCategories",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleCategories_SaleCategoryEntityId",
                table: "ProductSaleCategories",
                column: "SaleCategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductEntityId",
                table: "ProductReviews",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ReviewEntityId",
                table: "ProductReviews",
                column: "ReviewEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ImageEntityId",
                table: "ProductImages",
                column: "ImageEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductEntityId",
                table: "ProductImages",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryEntityId",
                table: "ProductCategories",
                column: "CategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductEntityId",
                table: "ProductCategories",
                column: "ProductEntityId");

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
        }
    }
}
