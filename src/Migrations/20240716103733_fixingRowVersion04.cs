using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class fixingRowVersion04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "OffenseRecords",
                type: "BLOB",
                rowVersion: true,
                nullable: false,
                defaultValueSql: "randomblob(8)",
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldRowVersion: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "OffenseRecords",
                type: "BLOB",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldRowVersion: true,
                oldDefaultValueSql: "randomblob(8)");
        }
    }
}
