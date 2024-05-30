using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OffenseRecords",
                columns: table => new
                {
                    Aktenzeichen = table.Column<string>(type: "TEXT", nullable: false),
                    Anrede = table.Column<string>(type: "TEXT", nullable: false),
                    Vorname = table.Column<string>(type: "TEXT", nullable: false),
                    Nachname = table.Column<string>(type: "TEXT", nullable: false),
                    Titel = table.Column<string>(type: "TEXT", nullable: false),
                    Geburtsdatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Plz = table.Column<string>(type: "TEXT", nullable: false),
                    Wohnort = table.Column<string>(type: "TEXT", nullable: false),
                    Str = table.Column<string>(type: "TEXT", nullable: false),
                    Hausnummer = table.Column<string>(type: "TEXT", nullable: false),
                    Versicherungsnummer = table.Column<string>(type: "TEXT", nullable: false),
                    Krankenversicherungsname = table.Column<string>(type: "TEXT", nullable: false),
                    Vertragsunternehmensnummer = table.Column<string>(type: "TEXT", nullable: false),
                    Beschreibung = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffenseRecords", x => x.Aktenzeichen);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OffenseRecords");
        }
    }
}
