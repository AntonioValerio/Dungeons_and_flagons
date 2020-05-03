using Microsoft.EntityFrameworkCore.Migrations;

namespace Dungeons_And_Flagons.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Spellslots = table.Column<int>(nullable: false),
                    Source = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Classes_Sources_Source",
                        column: x => x.Source,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subraces",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainRace = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Source = table.Column<int>(nullable: false),
                    BookID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subraces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Subraces_Sources_BookID",
                        column: x => x.BookID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subclasses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Classe = table.Column<int>(nullable: false),
                    Source = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subclasses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Subclasses_Classes_Classe",
                        column: x => x.Classe,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subclasses_Sources_Source",
                        column: x => x.Source,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    CastingTime = table.Column<int>(nullable: false),
                    Range = table.Column<int>(nullable: false),
                    Target = table.Column<string>(nullable: true),
                    Components = table.Column<string>(nullable: true),
                    School = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Source = table.Column<int>(nullable: false),
                    Subrace = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Spells_Sources_Source",
                        column: x => x.Source,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spells_Subraces_Subrace",
                        column: x => x.Subrace,
                        principalTable: "Subraces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClasseSpells",
                columns: table => new
                {
                    ClasseID = table.Column<int>(nullable: false),
                    SpellID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasseSpells", x => new { x.ClasseID, x.SpellID });
                    table.ForeignKey(
                        name: "FK_ClasseSpells_Classes_ClasseID",
                        column: x => x.ClasseID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClasseSpells_Spells_SpellID",
                        column: x => x.SpellID,
                        principalTable: "Spells",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubclassSpell",
                columns: table => new
                {
                    SubclassID = table.Column<int>(nullable: false),
                    SpellID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubclassSpell", x => new { x.SubclassID, x.SpellID });
                    table.ForeignKey(
                        name: "FK_SubclassSpell_Spells_SpellID",
                        column: x => x.SpellID,
                        principalTable: "Spells",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubclassSpell_Subclasses_SubclassID",
                        column: x => x.SubclassID,
                        principalTable: "Subclasses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Source",
                table: "Classes",
                column: "Source");

            migrationBuilder.CreateIndex(
                name: "IX_ClasseSpells_SpellID",
                table: "ClasseSpells",
                column: "SpellID");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_Source",
                table: "Spells",
                column: "Source");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_Subrace",
                table: "Spells",
                column: "Subrace");

            migrationBuilder.CreateIndex(
                name: "IX_Subclasses_Classe",
                table: "Subclasses",
                column: "Classe");

            migrationBuilder.CreateIndex(
                name: "IX_Subclasses_Source",
                table: "Subclasses",
                column: "Source");

            migrationBuilder.CreateIndex(
                name: "IX_SubclassSpell_SpellID",
                table: "SubclassSpell",
                column: "SpellID");

            migrationBuilder.CreateIndex(
                name: "IX_Subraces_BookID",
                table: "Subraces",
                column: "BookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClasseSpells");

            migrationBuilder.DropTable(
                name: "SubclassSpell");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Subclasses");

            migrationBuilder.DropTable(
                name: "Subraces");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
