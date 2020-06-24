using Microsoft.EntityFrameworkCore.Migrations;

namespace Dungeons_And_Flagons.Migrations
{
    public partial class _2406 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "permissions",
                table: "Subraces");

            migrationBuilder.DropColumn(
                name: "Target",
                table: "Spells");

            migrationBuilder.AlterColumn<string>(
                name: "Range",
                table: "Spells",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CastingTime",
                table: "Spells",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Spells",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Sources",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Permission",
                table: "Sources",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "Permission",
                table: "Sources");

            migrationBuilder.AddColumn<int>(
                name: "permissions",
                table: "Subraces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Range",
                table: "Spells",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CastingTime",
                table: "Spells",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Target",
                table: "Spells",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
