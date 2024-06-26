using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class addTatbestand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vertragsunternehmensnummer",
                table: "OffenseRecords",
                newName: "Verzugsende");

            migrationBuilder.RenameColumn(
                name: "Krankenversicherungsname",
                table: "OffenseRecords",
                newName: "VerzugBis");

            migrationBuilder.AddColumn<DateTime>(
                name: "Aufforderungsdatum",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Beitragsrückstand",
                table: "OffenseRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gesamtsollbetrag",
                table: "OffenseRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Krankenversicherung",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Startdatum",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Verjaehrungsfrist",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Versicherungsunternehmensnummer",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aufforderungsdatum",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Beitragsrückstand",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Gesamtsollbetrag",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Krankenversicherung",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Startdatum",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Verjaehrungsfrist",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Versicherungsunternehmensnummer",
                table: "OffenseRecords");

            migrationBuilder.RenameColumn(
                name: "Verzugsende",
                table: "OffenseRecords",
                newName: "Vertragsunternehmensnummer");

            migrationBuilder.RenameColumn(
                name: "VerzugBis",
                table: "OffenseRecords",
                newName: "Krankenversicherungsname");
        }
    }
}
