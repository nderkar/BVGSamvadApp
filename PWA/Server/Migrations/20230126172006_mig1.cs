using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "779c1fd0-4109-4c5f-a4c9-bf08d95c0fbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0c93c9d-20d3-4863-97b6-3906ccd6cf8d");

            migrationBuilder.CreateTable(
                name: "Post",
                schema: "dbo",
                columns: table => new
                {
                    postid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postmessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    likecount = table.Column<int>(type: "int", nullable: false),
                    commentcount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.postid);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bfa8c5d-84f5-4f55-a0b7-fd43f29c6c4e", "f9df91d8-25bb-4fde-9626-070a9f5b63a0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84707b12-260c-4372-9638-c3407f3ce301", "c293f353-a897-4fe3-8b8a-7b723aacf682", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post",
                schema: "dbo");

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
                values: new object[] { "779c1fd0-4109-4c5f-a4c9-bf08d95c0fbd", "c9427cbc-7544-482f-b85e-ef54d51c398a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0c93c9d-20d3-4863-97b6-3906ccd6cf8d", "53cc293a-9c3c-405e-b17f-16b24ba85e72", "User", "USER" });
        }
    }
}
