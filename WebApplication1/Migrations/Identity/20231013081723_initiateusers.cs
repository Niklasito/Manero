using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manero.Migrations.Identity
{
    /// <inheritdoc />
    public partial class initiateusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Addresses_AddressEntityId",
                table: "UserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ManeroUserId1",
                table: "UserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_AspNetUsers_ManeroUserId1",
                table: "UserOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_OrderEntity_OrderEntityId",
                table: "UserOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPaymentMethods_AspNetUsers_ManeroUserId1",
                table: "UserPaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPaymentMethods_PaymentMethods_PaymentMethodEntityId",
                table: "UserPaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPromoCodes_AspNetUsers_ManeroUserId1",
                table: "UserPromoCodes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPromoCodes_PromoCodes_PromoCodeEntityId",
                table: "UserPromoCodes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_AspNetUsers_ManeroUserId1",
                table: "UserReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_ReviewEntity_ReviewEntityId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserReviews",
                table: "UserReviews");

            migrationBuilder.DropIndex(
                name: "IX_UserReviews_ManeroUserId1",
                table: "UserReviews");

            migrationBuilder.DropIndex(
                name: "IX_UserReviews_ReviewEntityId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPromoCodes",
                table: "UserPromoCodes");

            migrationBuilder.DropIndex(
                name: "IX_UserPromoCodes_ManeroUserId1",
                table: "UserPromoCodes");

            migrationBuilder.DropIndex(
                name: "IX_UserPromoCodes_PromoCodeEntityId",
                table: "UserPromoCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPaymentMethods",
                table: "UserPaymentMethods");

            migrationBuilder.DropIndex(
                name: "IX_UserPaymentMethods_ManeroUserId1",
                table: "UserPaymentMethods");

            migrationBuilder.DropIndex(
                name: "IX_UserPaymentMethods_PaymentMethodEntityId",
                table: "UserPaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrders",
                table: "UserOrders");

            migrationBuilder.DropIndex(
                name: "IX_UserOrders_ManeroUserId1",
                table: "UserOrders");

            migrationBuilder.DropIndex(
                name: "IX_UserOrders_OrderEntityId",
                table: "UserOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_AddressEntityId",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_ManeroUserId1",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "ManeroUserId",
                table: "UserReviews");

            migrationBuilder.DropColumn(
                name: "ManeroUserId1",
                table: "UserReviews");

            migrationBuilder.DropColumn(
                name: "ReviewEntityId",
                table: "UserReviews");

            migrationBuilder.DropColumn(
                name: "ManeroUserId",
                table: "UserPromoCodes");

            migrationBuilder.DropColumn(
                name: "ManeroUserId1",
                table: "UserPromoCodes");

            migrationBuilder.DropColumn(
                name: "PromoCodeEntityId",
                table: "UserPromoCodes");

            migrationBuilder.DropColumn(
                name: "ManeroUserId",
                table: "UserPaymentMethods");

            migrationBuilder.DropColumn(
                name: "ManeroUserId1",
                table: "UserPaymentMethods");

            migrationBuilder.DropColumn(
                name: "PaymentMethodEntityId",
                table: "UserPaymentMethods");

            migrationBuilder.DropColumn(
                name: "ManeroUserId",
                table: "UserOrders");

            migrationBuilder.DropColumn(
                name: "ManeroUserId1",
                table: "UserOrders");

            migrationBuilder.DropColumn(
                name: "OrderEntityId",
                table: "UserOrders");

            migrationBuilder.DropColumn(
                name: "ManeroUserId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "AddressEntityId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "ManeroUserId1",
                table: "UserAddresses");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserReviews",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserPromoCodes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserPaymentMethods",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserOrders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserAddresses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserReviews",
                table: "UserReviews",
                columns: new[] { "UserId", "ReviewId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPromoCodes",
                table: "UserPromoCodes",
                columns: new[] { "UserId", "PromoCodeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPaymentMethods",
                table: "UserPaymentMethods",
                columns: new[] { "UserId", "PaymentMethodId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrders",
                table: "UserOrders",
                columns: new[] { "UserId", "OrderId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses",
                columns: new[] { "UserId", "AddressId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ReviewId",
                table: "UserReviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_PromoCodeId",
                table: "UserPromoCodes",
                column: "PromoCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMethods_PaymentMethodId",
                table: "UserPaymentMethods",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrders_OrderId",
                table: "UserOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_AddressId",
                table: "UserAddresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_Addresses_AddressId",
                table: "UserAddresses",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AspNetUsers_UserId",
                table: "UserAddresses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_AspNetUsers_UserId",
                table: "UserOrders",
                column: "UserId",
                principalTable: "AspNetUsers",
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
                name: "FK_UserPaymentMethods_AspNetUsers_UserId",
                table: "UserPaymentMethods",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPaymentMethods_PaymentMethods_PaymentMethodId",
                table: "UserPaymentMethods",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPromoCodes_AspNetUsers_UserId",
                table: "UserPromoCodes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPromoCodes_PromoCodes_PromoCodeId",
                table: "UserPromoCodes",
                column: "PromoCodeId",
                principalTable: "PromoCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_AspNetUsers_UserId",
                table: "UserReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Addresses_AddressId",
                table: "UserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AspNetUsers_UserId",
                table: "UserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_AspNetUsers_UserId",
                table: "UserOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOrders_OrderEntity_OrderId",
                table: "UserOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPaymentMethods_AspNetUsers_UserId",
                table: "UserPaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPaymentMethods_PaymentMethods_PaymentMethodId",
                table: "UserPaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPromoCodes_AspNetUsers_UserId",
                table: "UserPromoCodes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPromoCodes_PromoCodes_PromoCodeId",
                table: "UserPromoCodes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_AspNetUsers_UserId",
                table: "UserReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_ReviewEntity_ReviewId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserReviews",
                table: "UserReviews");

            migrationBuilder.DropIndex(
                name: "IX_UserReviews_ReviewId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPromoCodes",
                table: "UserPromoCodes");

            migrationBuilder.DropIndex(
                name: "IX_UserPromoCodes_PromoCodeId",
                table: "UserPromoCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPaymentMethods",
                table: "UserPaymentMethods");

            migrationBuilder.DropIndex(
                name: "IX_UserPaymentMethods_PaymentMethodId",
                table: "UserPaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrders",
                table: "UserOrders");

            migrationBuilder.DropIndex(
                name: "IX_UserOrders_OrderId",
                table: "UserOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_AddressId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserReviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserPromoCodes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserPaymentMethods");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserOrders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserAddresses");

            migrationBuilder.AddColumn<int>(
                name: "ManeroUserId",
                table: "UserReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManeroUserId1",
                table: "UserReviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewEntityId",
                table: "UserReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManeroUserId",
                table: "UserPromoCodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManeroUserId1",
                table: "UserPromoCodes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PromoCodeEntityId",
                table: "UserPromoCodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManeroUserId",
                table: "UserPaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManeroUserId1",
                table: "UserPaymentMethods",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodEntityId",
                table: "UserPaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManeroUserId",
                table: "UserOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManeroUserId1",
                table: "UserOrders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderEntityId",
                table: "UserOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManeroUserId",
                table: "UserAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressEntityId",
                table: "UserAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ManeroUserId1",
                table: "UserAddresses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserReviews",
                table: "UserReviews",
                columns: new[] { "ManeroUserId", "ReviewId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPromoCodes",
                table: "UserPromoCodes",
                columns: new[] { "ManeroUserId", "PromoCodeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPaymentMethods",
                table: "UserPaymentMethods",
                columns: new[] { "ManeroUserId", "PaymentMethodId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrders",
                table: "UserOrders",
                columns: new[] { "ManeroUserId", "OrderId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAddresses",
                table: "UserAddresses",
                columns: new[] { "ManeroUserId", "AddressId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ManeroUserId1",
                table: "UserReviews",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ReviewEntityId",
                table: "UserReviews",
                column: "ReviewEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_ManeroUserId1",
                table: "UserPromoCodes",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserPromoCodes_PromoCodeEntityId",
                table: "UserPromoCodes",
                column: "PromoCodeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMethods_ManeroUserId1",
                table: "UserPaymentMethods",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserPaymentMethods_PaymentMethodEntityId",
                table: "UserPaymentMethods",
                column: "PaymentMethodEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrders_ManeroUserId1",
                table: "UserOrders",
                column: "ManeroUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrders_OrderEntityId",
                table: "UserOrders",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_AddressEntityId",
                table: "UserAddresses",
                column: "AddressEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_ManeroUserId1",
                table: "UserAddresses",
                column: "ManeroUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_Addresses_AddressEntityId",
                table: "UserAddresses",
                column: "AddressEntityId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ManeroUserId1",
                table: "UserAddresses",
                column: "ManeroUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_AspNetUsers_ManeroUserId1",
                table: "UserOrders",
                column: "ManeroUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrders_OrderEntity_OrderEntityId",
                table: "UserOrders",
                column: "OrderEntityId",
                principalTable: "OrderEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPaymentMethods_AspNetUsers_ManeroUserId1",
                table: "UserPaymentMethods",
                column: "ManeroUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPaymentMethods_PaymentMethods_PaymentMethodEntityId",
                table: "UserPaymentMethods",
                column: "PaymentMethodEntityId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPromoCodes_AspNetUsers_ManeroUserId1",
                table: "UserPromoCodes",
                column: "ManeroUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPromoCodes_PromoCodes_PromoCodeEntityId",
                table: "UserPromoCodes",
                column: "PromoCodeEntityId",
                principalTable: "PromoCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_AspNetUsers_ManeroUserId1",
                table: "UserReviews",
                column: "ManeroUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_ReviewEntity_ReviewEntityId",
                table: "UserReviews",
                column: "ReviewEntityId",
                principalTable: "ReviewEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
