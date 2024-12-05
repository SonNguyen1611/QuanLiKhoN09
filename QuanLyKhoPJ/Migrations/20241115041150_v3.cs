using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhoPJ.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_EntryBill_EntryBillId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_EntryBillId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "EntryBillId",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "EntryBillProduct",
                columns: table => new
                {
                    EntryBillsEntryBillId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryBillProduct", x => new { x.EntryBillsEntryBillId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_EntryBillProduct_EntryBill_EntryBillsEntryBillId",
                        column: x => x.EntryBillsEntryBillId,
                        principalTable: "EntryBill",
                        principalColumn: "EntryBillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntryBillProduct_Product_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntryBillProduct_ProductsProductId",
                table: "EntryBillProduct",
                column: "ProductsProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryBillProduct");

            migrationBuilder.AddColumn<int>(
                name: "EntryBillId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_EntryBillId",
                table: "Product",
                column: "EntryBillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_EntryBill_EntryBillId",
                table: "Product",
                column: "EntryBillId",
                principalTable: "EntryBill",
                principalColumn: "EntryBillId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
