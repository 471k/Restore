using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class OrderEntityUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06168779-a6dc-40d9-9eab-7eba2bcb0110",
                column: "ConcurrencyStamp",
                value: "14752d34-2dbc-4834-9169-46a222c7145d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf665b6-d262-4851-a994-b497e6e258c8",
                column: "ConcurrencyStamp",
                value: "de1c6f78-d600-43c5-a176-07355ee2aa2b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Orders",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06168779-a6dc-40d9-9eab-7eba2bcb0110",
                column: "ConcurrencyStamp",
                value: "8b66b5c2-d5cd-45d3-af77-7ed72a7ae3fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf665b6-d262-4851-a994-b497e6e258c8",
                column: "ConcurrencyStamp",
                value: "65d6f173-4e25-4c10-90b5-66730d487ceb");
        }
    }
}
