using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhoPJ.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntryBillProduc_EntryBill_EntryBillId",
                table: "EntryBillProduc");

            migrationBuilder.DropForeignKey(
                name: "FK_EntryBillProduc_Product_ProductId",
                table: "EntryBillProduc");

            migrationBuilder.DropForeignKey(
                name: "FK_ExportBillProduct_ExportBill_ExportBillsExportBillId",
                table: "ExportBillProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ExportBillProduct_Product_ProductsProductId",
                table: "ExportBillProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExportBillProduct",
                table: "ExportBillProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntryBillProduc",
                table: "EntryBillProduc");

            migrationBuilder.RenameTable(
                name: "EntryBillProduc",
                newName: "EntryBillProduct");

            migrationBuilder.RenameColumn(
                name: "ProductsProductId",
                table: "ExportBillProduct",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ExportBillsExportBillId",
                table: "ExportBillProduct",
                newName: "QuantityOutLast");

            migrationBuilder.RenameIndex(
                name: "IX_ExportBillProduct_ProductsProductId",
                table: "ExportBillProduct",
                newName: "IX_ExportBillProduct_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_EntryBillProduc_ProductId",
                table: "EntryBillProduct",
                newName: "IX_EntryBillProduct_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_EntryBillProduc_EntryBillId",
                table: "EntryBillProduct",
                newName: "IX_EntryBillProduct_EntryBillId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ExportBillProduct",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ExportBillId",
                table: "ExportBillProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExportBillProduct",
                table: "ExportBillProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntryBillProduct",
                table: "EntryBillProduct",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBillProduct_ExportBillId",
                table: "ExportBillProduct",
                column: "ExportBillId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntryBillProduct_EntryBill_EntryBillId",
                table: "EntryBillProduct",
                column: "EntryBillId",
                principalTable: "EntryBill",
                principalColumn: "EntryBillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntryBillProduct_Product_ProductId",
                table: "EntryBillProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExportBillProduct_ExportBill_ExportBillId",
                table: "ExportBillProduct",
                column: "ExportBillId",
                principalTable: "ExportBill",
                principalColumn: "ExportBillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExportBillProduct_Product_ProductId",
                table: "ExportBillProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntryBillProduct_EntryBill_EntryBillId",
                table: "EntryBillProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_EntryBillProduct_Product_ProductId",
                table: "EntryBillProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ExportBillProduct_ExportBill_ExportBillId",
                table: "ExportBillProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ExportBillProduct_Product_ProductId",
                table: "ExportBillProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExportBillProduct",
                table: "ExportBillProduct");

            migrationBuilder.DropIndex(
                name: "IX_ExportBillProduct_ExportBillId",
                table: "ExportBillProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntryBillProduct",
                table: "EntryBillProduct");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ExportBillProduct");

            migrationBuilder.DropColumn(
                name: "ExportBillId",
                table: "ExportBillProduct");

            migrationBuilder.RenameTable(
                name: "EntryBillProduct",
                newName: "EntryBillProduc");

            migrationBuilder.RenameColumn(
                name: "QuantityOutLast",
                table: "ExportBillProduct",
                newName: "ExportBillsExportBillId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ExportBillProduct",
                newName: "ProductsProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ExportBillProduct_ProductId",
                table: "ExportBillProduct",
                newName: "IX_ExportBillProduct_ProductsProductId");

            migrationBuilder.RenameIndex(
                name: "IX_EntryBillProduct_ProductId",
                table: "EntryBillProduc",
                newName: "IX_EntryBillProduc_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_EntryBillProduct_EntryBillId",
                table: "EntryBillProduc",
                newName: "IX_EntryBillProduc_EntryBillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExportBillProduct",
                table: "ExportBillProduct",
                columns: new[] { "ExportBillsExportBillId", "ProductsProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntryBillProduc",
                table: "EntryBillProduc",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EntryBillProduc_EntryBill_EntryBillId",
                table: "EntryBillProduc",
                column: "EntryBillId",
                principalTable: "EntryBill",
                principalColumn: "EntryBillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntryBillProduc_Product_ProductId",
                table: "EntryBillProduc",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExportBillProduct_ExportBill_ExportBillsExportBillId",
                table: "ExportBillProduct",
                column: "ExportBillsExportBillId",
                principalTable: "ExportBill",
                principalColumn: "ExportBillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExportBillProduct_Product_ProductsProductId",
                table: "ExportBillProduct",
                column: "ProductsProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
