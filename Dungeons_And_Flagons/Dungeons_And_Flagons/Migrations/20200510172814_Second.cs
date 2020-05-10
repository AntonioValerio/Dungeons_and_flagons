using Microsoft.EntityFrameworkCore.Migrations;

namespace Dungeons_And_Flagons.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Subraces_Subrace",
                table: "Spells");

            migrationBuilder.DropIndex(
                name: "IX_Spells_Subrace",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "Subrace",
                table: "Spells");

            migrationBuilder.AddColumn<int>(
                name: "permissions",
                table: "Subraces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SubracesSpell",
                columns: table => new
                {
                    SubraceID = table.Column<int>(nullable: false),
                    SpellID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubracesSpell", x => new { x.SubraceID, x.SpellID });
                    table.ForeignKey(
                        name: "FK_SubracesSpell_Spells_SpellID",
                        column: x => x.SpellID,
                        principalTable: "Spells",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubracesSpell_Subraces_SubraceID",
                        column: x => x.SubraceID,
                        principalTable: "Subraces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubracesSpell_SpellID",
                table: "SubracesSpell",
                column: "SpellID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubracesSpell");

            migrationBuilder.DropColumn(
                name: "permissions",
                table: "Subraces");

            migrationBuilder.AddColumn<int>(
                name: "Subrace",
                table: "Spells",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Spells_Subrace",
                table: "Spells",
                column: "Subrace");

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Subraces_Subrace",
                table: "Spells",
                column: "Subrace",
                principalTable: "Subraces",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
