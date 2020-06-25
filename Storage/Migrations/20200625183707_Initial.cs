using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterStorage.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Faction = table.Column<string>(nullable: true),
                    Experience = table.Column<int>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Might = table.Column<int>(nullable: false),
                    Spryness = table.Column<int>(nullable: false),
                    Judgement = table.Column<int>(nullable: false),
                    Echo = table.Column<int>(nullable: false),
                    Magnetism = table.Column<int>(nullable: false),
                    Fortune = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Bio", "Echo", "Experience", "Faction", "Fortune", "Judgement", "Level", "Magnetism", "Might", "Name", "Spryness" },
                values: new object[,]
                {
                    { 1, "Driven to drink by mediocrity.", 8, 0, null, 15, 6, 2, 9, 10, "Garrick", 12 },
                    { 2, "Small business owner.", 15, 0, null, 1, 1, 5, 15, 15, "Nori", 15 },
                    { 3, "A small dragon in a big body", 1, 0, null, 6, 15, 10, 8, 25, "Ulstyr", 10 },
                    { 4, "Brian made this guy and he is a stupid idiot", 8, 0, null, 15, 6, 2, 9, 1, "Larry", 6 },
                    { 5, "Brian made this guy and he is a stupid idiot", 44, 0, null, 1, 1, 5, 44, 4, "Robert Smith", 44 },
                    { 6, "Brian made this guy and he is a stupid idiot", 1, 0, null, 6, 15, 9, 8, 9, "Farts", 9 },
                    { 7, "Brian made this guy and he is a stupid idiot", 8, 0, null, 15, 19, 2, 9, 6, "Cuck Fucker", 19 },
                    { 8, "Brian made this guy and he is a stupid idiot", 15, 0, null, 1, 1, 5, 15, 400, "Wage cuck", 15 },
                    { 9, "Brian made this guy and he is a stupid idiot", 1, 0, null, 16, 15, 6, 8, 55, "Orc", 6 },
                    { 10, "Brian made this guy and he is a stupid idiot", 8, 0, null, 15, 6, 2, 6, 16, "Elf", 6 },
                    { 21, "Brian made this guy and he is a stupid idiot", 90, 0, null, 1, 1, 5, 90, 90, "Boy", 90 },
                    { 31, "Hail Stan", 666, 0, null, 666, 666, 666, 666, 666, "Gnome", 666 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
