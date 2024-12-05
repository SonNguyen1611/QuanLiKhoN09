using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhoPJ.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryBillProduct");

            migrationBuilder.CreateTable(
                name: "EntryBillProduc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryBillId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuantityAddLast = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryBillProduc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntryBillProduc_EntryBill_EntryBillId",
                        column: x => x.EntryBillId,
                        principalTable: "EntryBill",
                        principalColumn: "EntryBillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntryBillProduc_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntryBillProduc_EntryBillId",
                table: "EntryBillProduc",
                column: "EntryBillId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryBillProduc_ProductId",
                table: "EntryBillProduc",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryBillProduc");

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
    }
}
