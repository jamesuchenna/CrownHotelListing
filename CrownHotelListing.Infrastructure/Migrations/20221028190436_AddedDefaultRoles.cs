using Microsoft.EntityFrameworkCore.Migrations;

namespace CrownHotelListing.Infrastructure.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80df5d6d-eb79-47e8-a4b6-93a3c46e0501", "394c6c42-c501-4b5f-a07a-50a6000c270c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4b0979c-d1cc-4673-b5a1-03cdf08dede1", "80a5e99c-9314-4ffa-8895-a2ba6d4949ff", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80df5d6d-eb79-47e8-a4b6-93a3c46e0501");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4b0979c-d1cc-4673-b5a1-03cdf08dede1");
        }
    }
}
