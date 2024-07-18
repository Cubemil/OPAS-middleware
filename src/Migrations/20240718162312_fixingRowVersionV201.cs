using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class fixingRowVersionV201 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RowVersion",
                table: "OffenseRecords",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldRowVersion: true,
                oldDefaultValueSql: "randomblob(8)");
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
                defaultValueSql: "randomblob(8)",
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
