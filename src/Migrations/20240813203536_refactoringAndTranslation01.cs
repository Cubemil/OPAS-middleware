using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class refactoringAndTranslation01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Startdatum",
                table: "OffenseRecords",
                newName: "Geburtsname");

            migrationBuilder.RenameColumn(
                name: "Gesamtsollbetrag",
                table: "OffenseRecords",
                newName: "Sollbeitrag");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginnRueckstand",
                table: "OffenseRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Folgemeldung",
                table: "OffenseRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginnRueckstand",
                table: "OffenseRecords");

            migrationBuilder.DropColumn(
                name: "Folgemeldung",
                table: "OffenseRecords");

            migrationBuilder.RenameColumn(
                name: "Sollbeitrag",
                table: "OffenseRecords",
                newName: "Gesamtsollbetrag");

            migrationBuilder.RenameColumn(
                name: "Geburtsname",
                table: "OffenseRecords",
                newName: "Startdatum");
        }
    }
}
