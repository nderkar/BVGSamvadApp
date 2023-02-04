using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f909b7-5509-4a6e-97af-c3b5ad6b92ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d009549d-1f50-415b-8041-eddb77705fe5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e307600-3594-4410-a589-c9200ad08810", "f663a867-045a-431c-8aad-421e6224433f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d298f02c-1cd3-45ed-819d-9a20281c56e7", "97215394-1859-4565-b7fc-2fa85d978691", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e307600-3594-4410-a589-c9200ad08810");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d298f02c-1cd3-45ed-819d-9a20281c56e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3f909b7-5509-4a6e-97af-c3b5ad6b92ce", "e14f5607-6415-477b-be79-7670059c1152", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d009549d-1f50-415b-8041-eddb77705fe5", "9cab83ac-c5b6-4de7-890c-95f086b2fd3b", "Admin", "ADMIN" });
        }
    }
}
