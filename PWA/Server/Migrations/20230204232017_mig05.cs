using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e2cd5b3-664e-4ac8-a11e-ee89c362f619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25b3ebf-3657-4130-a507-64fdbf6eecdc");

            migrationBuilder.CreateTable(
                name: "PostLike",
                schema: "dbo",
                columns: table => new
                {
                    likeid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    currentPostid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLike", x => x.likeid);
                    table.ForeignKey(
                        name: "FK_PostLike_Post_currentPostid",
                        column: x => x.currentPostid,
                        principalSchema: "dbo",
                        principalTable: "Post",
                        principalColumn: "postid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ee951b8-4b41-4709-88e5-c680fa495535", "cd99d603-039b-495c-9378-929f93589f52", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e82fec68-c932-438e-908a-c6faaee5cf7a", "dea910bc-0e94-410e-9033-e598e5fea1b8", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_currentPostid",
                schema: "dbo",
                table: "PostLike",
                column: "currentPostid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostLike",
                schema: "dbo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee951b8-4b41-4709-88e5-c680fa495535");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e82fec68-c932-438e-908a-c6faaee5cf7a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e2cd5b3-664e-4ac8-a11e-ee89c362f619", "a65519a6-6192-486c-88db-d70898fc1a87", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c25b3ebf-3657-4130-a507-64fdbf6eecdc", "26c4a938-9a9e-413e-b64c-82df10180337", "Admin", "ADMIN" });
        }
    }
}
