using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class PublicIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublicId",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06168779-a6dc-40d9-9eab-7eba2bcb0110",
                column: "ConcurrencyStamp",
                value: "7341b25b-3a91-46e0-a93b-390d67b13f93");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf665b6-d262-4851-a994-b497e6e258c8",
                column: "ConcurrencyStamp",
                value: "3c751b3e-64ca-4b0f-a4c0-d6f3a02da5dc");
        }
    }
}
