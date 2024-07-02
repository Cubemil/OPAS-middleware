using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class newLayout072024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Verjaehrungsfrist",
                table: "OffenseRecords",
                newName: "Ortsteil");

            migrationBuilder.RenameColumn(
                name: "Anrede",
                table: "OffenseRecords",
                newName: "Geschlecht");

            migrationBuilder.RenameColumn(
                name: "Aktenzeichen",
                table: "OffenseRecords",
                newName: "Geburtsort");

            migrationBuilder.AddColumn<string>(
                name: "Bemerkungen",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fallnummer",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bemerkungen",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Fallnummer",
                table: "OffenseRecords");

            migrationBuilder.RenameColumn(
                name: "Ortsteil",
                table: "OffenseRecords",
                newName: "Verjaehrungsfrist");

            migrationBuilder.RenameColumn(
                name: "Geschlecht",
                table: "OffenseRecords",
                newName: "Anrede");

            migrationBuilder.RenameColumn(
                name: "Geburtsort",
                table: "OffenseRecords",
                newName: "Aktenzeichen");
        }
    }
}
