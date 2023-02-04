using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class migserver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bfa8c5d-84f5-4f55-a0b7-fd43f29c6c4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84707b12-260c-4372-9638-c3407f3ce301");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "325d23cb-01ae-4cb0-b5fb-3f7898ffe551", "fe5a9123-b68c-410c-9a11-554715aa44e4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b950b683-7ffc-4b52-9067-827a61ea1bf8", "c0510b12-3607-4b34-a9ea-1311a9c4fb97", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "325d23cb-01ae-4cb0-b5fb-3f7898ffe551");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b950b683-7ffc-4b52-9067-827a61ea1bf8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bfa8c5d-84f5-4f55-a0b7-fd43f29c6c4e", "f9df91d8-25bb-4fde-9626-070a9f5b63a0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84707b12-260c-4372-9638-c3407f3ce301", "c293f353-a897-4fe3-8b8a-7b723aacf682", "User", "USER" });
        }
    }
}
