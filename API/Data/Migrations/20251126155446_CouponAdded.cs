using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CouponAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Coupon_AmountOff",
                table: "Baskets",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coupon_CouponId",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coupon_Name",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Coupon_PercentOff",
                table: "Baskets",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Coupon_PromotionCode",
                table: "Baskets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06168779-a6dc-40d9-9eab-7eba2bcb0110",
                column: "ConcurrencyStamp",
                value: "ec441574-9ac2-4e40-8d14-2eb996ec76c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf665b6-d262-4851-a994-b497e6e258c8",
                column: "ConcurrencyStamp",
                value: "51c18c07-1442-4a75-a469-962c978ee15f");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coupon_AmountOff",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Coupon_CouponId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Coupon_Name",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Coupon_PercentOff",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Coupon_PromotionCode",
                table: "Baskets");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06168779-a6dc-40d9-9eab-7eba2bcb0110",
                column: "ConcurrencyStamp",
                value: "a0735463-b646-47cd-9616-d5aa94c9a926");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf665b6-d262-4851-a994-b497e6e258c8",
                column: "ConcurrencyStamp",
                value: "8d0a9946-dea5-4c4e-8486-836d485c17de");
        }
    }
}
