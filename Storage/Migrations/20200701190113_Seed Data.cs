using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "TraitId", "Echo", "Fortune", "Judgement", "Magnetism", "Might", "Name", "Spryness" },
                values: new object[] { 1, -3, 0, 0, 0, 1, "Hardheaded", 1 });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "TraitId", "Echo", "Fortune", "Judgement", "Magnetism", "Might", "Name", "Spryness" },
                values: new object[] { 2, 0, 0, 0, 0, -1, "Wimpy", 2 });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "TraitId", "Echo", "Fortune", "Judgement", "Magnetism", "Might", "Name", "Spryness" },
                values: new object[] { 3, 0, -10, 4, 0, 1, "Big Booty", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3);
        }
    }
}
