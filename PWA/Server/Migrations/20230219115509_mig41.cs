using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samvad_App.Server.Migrations
{
    public partial class mig41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6257442d-70d4-42a9-90e4-642dfd46f39b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc416abf-3c31-4a60-9357-eb051fa87daa");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dac348c-a631-4980-ad7d-6270181d2995", "8756da91-987e-4305-a743-97205cc82fa1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9811ec6-cc3e-436a-bb93-9fb510373a51", "1fd823ec-220f-4a50-80ac-c2ebc1e8b433", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dac348c-a631-4980-ad7d-6270181d2995");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9811ec6-cc3e-436a-bb93-9fb510373a51");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6257442d-70d4-42a9-90e4-642dfd46f39b", "46d1f0ba-4480-4bc6-a9da-f939c443f4e3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc416abf-3c31-4a60-9357-eb051fa87daa", "59336861-02e1-4122-84a6-4286d54b2a91", "User", "USER" });
        }
    }
}
