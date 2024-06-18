using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class AddIdRemoveDescriptionSplitHouseNumOffenseRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OffenseRecords",
                table: "OffenseRecords");

            migrationBuilder.RenameColumn(
                name: "Hausnummer",
                table: "OffenseRecords",
                newName: "HausnummerInt");

            migrationBuilder.RenameColumn(
                name: "Beschreibung",
                table: "OffenseRecords",
                newName: "HausnummerExtra");

            migrationBuilder.AddColumn<int>(
                name: "RecordId",
                table: "OffenseRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OffenseRecords",
                table: "OffenseRecords",
                column: "RecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OffenseRecords",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "RecordId",
                table: "OffenseRecords");

            migrationBuilder.RenameColumn(
                name: "HausnummerInt",
                table: "OffenseRecords",
                newName: "Hausnummer");

            migrationBuilder.RenameColumn(
                name: "HausnummerExtra",
                table: "OffenseRecords",
                newName: "Beschreibung");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OffenseRecords",
                table: "OffenseRecords",
                column: "Aktenzeichen");
        }
    }
}
