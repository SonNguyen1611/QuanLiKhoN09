using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhoPJ.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityAddLast",
                table: "Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantityAddLast",
                table: "Product",
                type: "int",
                nullable: true);
        }
    }
}
