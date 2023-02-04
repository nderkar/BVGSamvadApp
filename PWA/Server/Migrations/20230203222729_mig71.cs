using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig71 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b74a5df-74f8-4bfa-95e0-28f24c946f73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cf0a2f5-15ab-4b98-835f-85c8b7144d2f");

            migrationBuilder.AddColumn<string>(
                name: "extlink1",
                schema: "dbo",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "extlink2",
                schema: "dbo",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e2cd5b3-664e-4ac8-a11e-ee89c362f619", "a65519a6-6192-486c-88db-d70898fc1a87", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c25b3ebf-3657-4130-a507-64fdbf6eecdc", "26c4a938-9a9e-413e-b64c-82df10180337", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e2cd5b3-664e-4ac8-a11e-ee89c362f619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25b3ebf-3657-4130-a507-64fdbf6eecdc");

            migrationBuilder.DropColumn(
                name: "extlink1",
                schema: "dbo",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "extlink2",
                schema: "dbo",
                table: "Post");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b74a5df-74f8-4bfa-95e0-28f24c946f73", "3b441778-e4bb-4872-8bb6-e39747faf4cd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cf0a2f5-15ab-4b98-835f-85c8b7144d2f", "497eed34-233c-44d8-97a0-1b1679ce8374", "Admin", "ADMIN" });
        }
    }
}
