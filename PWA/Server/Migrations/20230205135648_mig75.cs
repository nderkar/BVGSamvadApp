using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig75 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1f05ef8-000a-40c7-81ac-4cee240c9084");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fbe6cb-a1da-4fa2-b081-359b244dfe11");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "494e1687-731a-44ab-b6aa-a8ab861c1ec7", "4b1388a3-2446-499c-a43b-3a877c21fc8a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bec16006-f0d8-4d67-a4ca-e2bd8250fcd4", "47168455-28d1-4965-a88c-17141905480d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "494e1687-731a-44ab-b6aa-a8ab861c1ec7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bec16006-f0d8-4d67-a4ca-e2bd8250fcd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1f05ef8-000a-40c7-81ac-4cee240c9084", "ca99b855-096b-42f8-a7f9-f09cd36bfc92", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6fbe6cb-a1da-4fa2-b081-359b244dfe11", "f0b6aeb1-295e-41af-bb26-6f23d05825d1", "Admin", "ADMIN" });
        }
    }
}
