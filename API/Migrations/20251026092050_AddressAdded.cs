using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddressAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Line1 = table.Column<string>(type: "TEXT", nullable: false),
                    Line2 = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06168779-a6dc-40d9-9eab-7eba2bcb0110",
                column: "ConcurrencyStamp",
                value: "ebd1095d-64c1-41b1-87c1-16156ab4fd22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf665b6-d262-4851-a994-b497e6e258c8",
                column: "ConcurrencyStamp",
                value: "3ff70b75-fe47-437b-82c2-a31c7cd420c7");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06168779-a6dc-40d9-9eab-7eba2bcb0110",
                column: "ConcurrencyStamp",
                value: "f4732ceb-f863-4000-bcbf-282d0dcec4b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcf665b6-d262-4851-a994-b497e6e258c8",
                column: "ConcurrencyStamp",
                value: "37219004-81d4-46ba-8122-53dbd023fdb1");
        }
    }
}
