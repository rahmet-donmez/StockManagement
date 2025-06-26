using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagement.Migrations
{
    public partial class seedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "InventoryStatement",
                newName: "StockBalance");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionDate",
                table: "InventoryStatement",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<decimal>(
                name: "InboundQuantity",
                table: "InventoryStatement",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OutboundQuantity",
                table: "InventoryStatement",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 8,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 13,
                column: "TransactionType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 14,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 15,
                column: "TransactionType",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InboundQuantity",
                table: "InventoryStatement");

            migrationBuilder.DropColumn(
                name: "OutboundQuantity",
                table: "InventoryStatement");

            migrationBuilder.RenameColumn(
                name: "StockBalance",
                table: "InventoryStatement",
                newName: "Quantity");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransactionDate",
                table: "InventoryStatement",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 8,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "TransactionType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "TransactionType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 13,
                column: "TransactionType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 14,
                column: "TransactionType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "InventoryTransactions",
                keyColumn: "Id",
                keyValue: 15,
                column: "TransactionType",
                value: 1);
        }
    }
}
