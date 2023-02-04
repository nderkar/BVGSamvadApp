using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e307600-3594-4410-a589-c9200ad08810");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d298f02c-1cd3-45ed-819d-9a20281c56e7");

            migrationBuilder.CreateTable(
                name: "PostAsset",
                schema: "dbo",
                columns: table => new
                {
                    assetid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postid = table.Column<long>(type: "bigint", nullable: false),
                    asseturl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assettype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostAsset", x => x.assetid);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "811aba93-909f-48d7-b1c3-c39600e91803", "c2cd4ac9-ca77-48c5-a753-a37f34437415", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7752fd8-49d6-46ec-8cd4-1ca8e32b711c", "f3d7f9a1-6940-41a4-8a2e-64fba8b448f2", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostAsset",
                schema: "dbo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811aba93-909f-48d7-b1c3-c39600e91803");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7752fd8-49d6-46ec-8cd4-1ca8e32b711c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e307600-3594-4410-a589-c9200ad08810", "f663a867-045a-431c-8aad-421e6224433f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d298f02c-1cd3-45ed-819d-9a20281c56e7", "97215394-1859-4565-b7fc-2fa85d978691", "User", "USER" });
        }
    }
}
