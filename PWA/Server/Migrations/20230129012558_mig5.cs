using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "325d23cb-01ae-4cb0-b5fb-3f7898ffe551");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b950b683-7ffc-4b52-9067-827a61ea1bf8");

            migrationBuilder.AddColumn<bool>(
                name: "isdeleted",
                schema: "dbo",
                table: "Post",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3f909b7-5509-4a6e-97af-c3b5ad6b92ce", "e14f5607-6415-477b-be79-7670059c1152", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d009549d-1f50-415b-8041-eddb77705fe5", "9cab83ac-c5b6-4de7-890c-95f086b2fd3b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f909b7-5509-4a6e-97af-c3b5ad6b92ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d009549d-1f50-415b-8041-eddb77705fe5");

            migrationBuilder.DropColumn(
                name: "isdeleted",
                schema: "dbo",
                table: "Post");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "325d23cb-01ae-4cb0-b5fb-3f7898ffe551", "fe5a9123-b68c-410c-9a11-554715aa44e4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b950b683-7ffc-4b52-9067-827a61ea1bf8", "c0510b12-3607-4b34-a9ea-1311a9c4fb97", "Admin", "ADMIN" });
        }
    }
}
