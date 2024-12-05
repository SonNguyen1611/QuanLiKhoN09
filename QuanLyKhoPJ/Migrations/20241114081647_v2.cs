using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhoPJ.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntryBill_Suplier_SuplierId",
                table: "EntryBill");

            migrationBuilder.DropIndex(
                name: "IX_EntryBill_SuplierId",
                table: "EntryBill");

            migrationBuilder.DropColumn(
                name: "SuplierId",
                table: "EntryBill");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuplierId",
                table: "EntryBill",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntryBill_SuplierId",
                table: "EntryBill",
                column: "SuplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntryBill_Suplier_SuplierId",
                table: "EntryBill",
                column: "SuplierId",
                principalTable: "Suplier",
                principalColumn: "SuplierId");
        }
    }
}
