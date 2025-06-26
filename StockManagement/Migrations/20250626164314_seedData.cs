using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagement.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Unit", "VatRate" },
                values: new object[] { 1, "Kalem", "P001", "Adet", 8m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Unit", "VatRate" },
                values: new object[] { 2, "Defter", "P002", "Adet", 18m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "ProductCode", "Unit", "VatRate" },
                values: new object[] { 3, "Silgi", "P003", "Adet", 8m });

            migrationBuilder.InsertData(
                table: "InventoryTransactions",
                columns: new[] { "Id", "DocumentNumber", "ProductId", "Quantity", "TransactionDate", "TransactionType" },
                values: new object[,]
                {
                    { 1, "GIR-K001", 1, 100m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "CIK-K001", 1, 20m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "GIR-K002", 1, 50m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "CIK-K002", 1, 30m, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "GIR-K003", 1, 70m, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "GIR-D001", 2, 120m, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "CIK-D001", 2, 25m, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, "GIR-D002", 2, 80m, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "CIK-D002", 2, 40m, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "GIR-D003", 2, 100m, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, "GIR-S001", 3, 90m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, "CIK-S001", 3, 15m, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "GIR-S002", 3, 60m, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "CIK-S002", 3, 25m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "GIR-S003", 3, 110m, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
