using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
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

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    TraitId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_Traits", x => x.TraitId);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTraits",
                columns: table => new
                {
                    CharacterTraitId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TraitId = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTraits", x => x.CharacterTraitId);
                    table.ForeignKey(
                        name: "FK_CharacterTraits_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTraits_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "TraitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Bio", "Echo", "Experience", "Faction", "Fortune", "Judgement", "Level", "Magnetism", "Might", "Name", "Spryness" },
                values: new object[] { 1, "Driven to drink by mediocrity.", 8, 0, null, 15, 6, 2, 9, 10, "Garrick", 12 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Bio", "Echo", "Experience", "Faction", "Fortune", "Judgement", "Level", "Magnetism", "Might", "Name", "Spryness" },
                values: new object[] { 2, "Small business owner.", 15, 0, null, 1, 1, 5, 15, 15, "Nori", 15 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Bio", "Echo", "Experience", "Faction", "Fortune", "Judgement", "Level", "Magnetism", "Might", "Name", "Spryness" },
                values: new object[] { 3, "A small dragon in a big body", 1, 0, null, 6, 15, 10, 8, 25, "Ulstyr", 10 });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTraits_CharacterId",
                table: "CharacterTraits",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTraits_TraitId",
                table: "CharacterTraits",
                column: "TraitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterTraits");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Traits");
        }
    }
}
