using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig77 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_Post_currentPostid",
                schema: "dbo",
                table: "PostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostLike_currentPostid",
                schema: "dbo",
                table: "PostLike");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee951b8-4b41-4709-88e5-c680fa495535");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e82fec68-c932-438e-908a-c6faaee5cf7a");

            migrationBuilder.AddColumn<long>(
                name: "postid",
                schema: "dbo",
                table: "PostLike",
                type: "bigint",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d38a356f-7cfd-4e80-8c75-853a128349bf", "d7eb04f9-d9b6-404f-9c02-c965274034e9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8bed3e2-c546-4e9e-8335-bab8f543b487", "f44de444-0efb-46be-891e-e923f5217c24", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_postid",
                schema: "dbo",
                table: "PostLike",
                column: "postid");

            migrationBuilder.AddForeignKey(
                name: "FK_PostLike_Post_postid",
                schema: "dbo",
                table: "PostLike",
                column: "postid",
                principalSchema: "dbo",
                principalTable: "Post",
                principalColumn: "postid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_Post_postid",
                schema: "dbo",
                table: "PostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostLike_postid",
                schema: "dbo",
                table: "PostLike");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d38a356f-7cfd-4e80-8c75-853a128349bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8bed3e2-c546-4e9e-8335-bab8f543b487");

            migrationBuilder.DropColumn(
                name: "postid",
                schema: "dbo",
                table: "PostLike");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PostLike_Post_currentPostid",
                schema: "dbo",
                table: "PostLike",
                column: "currentPostid",
                principalSchema: "dbo",
                principalTable: "Post",
                principalColumn: "postid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
