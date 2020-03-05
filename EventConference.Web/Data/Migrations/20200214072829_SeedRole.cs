using Microsoft.EntityFrameworkCore.Migrations;

namespace EventConference.Web.Data.Migrations
{
    public partial class SeedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "705a966d-8077-4341-ba97-2df9ed47e720", "49bb0579-4369-445e-8166-7efe8bea2b77", "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6c0586f-efe7-4ee3-8660-0e0aa0426046", "35ddf615-b52d-4d02-b0a7-a10bc1b621a5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "705a966d-8077-4341-ba97-2df9ed47e720");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6c0586f-efe7-4ee3-8660-0e0aa0426046");
        }
    }
}
