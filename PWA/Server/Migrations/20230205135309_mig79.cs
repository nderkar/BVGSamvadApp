using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig79 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_Post_postid",
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
                name: "currentPostid",
                schema: "dbo",
                table: "PostLike");

            migrationBuilder.AlterColumn<long>(
                name: "postid",
                schema: "dbo",
                table: "PostLike",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1f05ef8-000a-40c7-81ac-4cee240c9084", "ca99b855-096b-42f8-a7f9-f09cd36bfc92", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6fbe6cb-a1da-4fa2-b081-359b244dfe11", "f0b6aeb1-295e-41af-bb26-6f23d05825d1", "Admin", "ADMIN" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostLike_Post_postid",
                schema: "dbo",
                table: "PostLike",
                column: "postid",
                principalSchema: "dbo",
                principalTable: "Post",
                principalColumn: "postid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_Post_postid",
                schema: "dbo",
                table: "PostLike");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1f05ef8-000a-40c7-81ac-4cee240c9084");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6fbe6cb-a1da-4fa2-b081-359b244dfe11");

            migrationBuilder.AlterColumn<long>(
                name: "postid",
                schema: "dbo",
                table: "PostLike",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "currentPostid",
                schema: "dbo",
                table: "PostLike",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d38a356f-7cfd-4e80-8c75-853a128349bf", "d7eb04f9-d9b6-404f-9c02-c965274034e9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8bed3e2-c546-4e9e-8335-bab8f543b487", "f44de444-0efb-46be-891e-e923f5217c24", "Admin", "ADMIN" });

            migrationBuilder.AddForeignKey(
                name: "FK_PostLike_Post_postid",
                schema: "dbo",
                table: "PostLike",
                column: "postid",
                principalSchema: "dbo",
                principalTable: "Post",
                principalColumn: "postid");
        }
    }
}
