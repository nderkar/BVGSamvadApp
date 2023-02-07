using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig91 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "494e1687-731a-44ab-b6aa-a8ab861c1ec7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bec16006-f0d8-4d67-a4ca-e2bd8250fcd4");

            migrationBuilder.CreateTable(
                name: "PostComment",
                schema: "dbo",
                columns: table => new
                {
                    commentid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    postid = table.Column<long>(type: "bigint", nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.commentid);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d75fc50-849b-43b9-9d0e-70107aea241d", "2511a571-41eb-48d6-8ad6-f9415edc873f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1594450-26f7-4658-8fea-bf23e5c8dffb", "8d41a3d0-96e5-4a20-9405-68f16e4d6484", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostComment",
                schema: "dbo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d75fc50-849b-43b9-9d0e-70107aea241d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1594450-26f7-4658-8fea-bf23e5c8dffb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "494e1687-731a-44ab-b6aa-a8ab861c1ec7", "4b1388a3-2446-499c-a43b-3a877c21fc8a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bec16006-f0d8-4d67-a4ca-e2bd8250fcd4", "47168455-28d1-4965-a88c-17141905480d", "Admin", "ADMIN" });
        }
    }
}
