using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhoPJ.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Suplier",
                columns: table => new
                {
                    SuplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuplierPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    SuplierEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplier", x => x.SuplierId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntryBill",
                columns: table => new
                {
                    EntryBillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    EntryBillPrice = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SuplierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryBill", x => x.EntryBillId);
                    table.ForeignKey(
                        name: "FK_EntryBill_Suplier_SuplierId",
                        column: x => x.SuplierId,
                        principalTable: "Suplier",
                        principalColumn: "SuplierId");
                    table.ForeignKey(
                        name: "FK_EntryBill_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExportBill",
                columns: table => new
                {
                    ExportBillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    ExportBillPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportBill", x => x.ExportBillId);
                    table.ForeignKey(
                        name: "FK_ExportBill_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExportBill_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    EnTryPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExportPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Profit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdateDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CateId = table.Column<int>(type: "int", nullable: true),
                    SuplierId = table.Column<int>(type: "int", nullable: true),
                    EntryBillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CateId",
                        column: x => x.CateId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Product_EntryBill_EntryBillId",
                        column: x => x.EntryBillId,
                        principalTable: "EntryBill",
                        principalColumn: "EntryBillId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Product_Suplier_SuplierId",
                        column: x => x.SuplierId,
                        principalTable: "Suplier",
                        principalColumn: "SuplierId");
                });

            migrationBuilder.CreateTable(
                name: "ExportBillProduct",
                columns: table => new
                {
                    ExportBillsExportBillId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportBillProduct", x => new { x.ExportBillsExportBillId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_ExportBillProduct_ExportBill_ExportBillsExportBillId",
                        column: x => x.ExportBillsExportBillId,
                        principalTable: "ExportBill",
                        principalColumn: "ExportBillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExportBillProduct_Product_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntryBill_SuplierId",
                table: "EntryBill",
                column: "SuplierId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryBill_UserId",
                table: "EntryBill",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBill_CustomerId",
                table: "ExportBill",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBill_UserId",
                table: "ExportBill",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExportBillProduct_ProductsProductId",
                table: "ExportBillProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CateId",
                table: "Product",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_EntryBillId",
                table: "Product",
                column: "EntryBillId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SuplierId",
                table: "Product",
                column: "SuplierId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExportBillProduct");

            migrationBuilder.DropTable(
                name: "ExportBill");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "EntryBill");

            migrationBuilder.DropTable(
                name: "Suplier");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
