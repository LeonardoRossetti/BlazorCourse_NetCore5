using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 30, 13, 28, 35, 958, DateTimeKind.Local).AddTicks(6244), new DateTime(2021, 7, 30, 13, 28, 35, 960, DateTimeKind.Local).AddTicks(7360), "Black", "System" },
                    { 2, "System", new DateTime(2021, 7, 30, 13, 28, 35, 960, DateTimeKind.Local).AddTicks(8185), new DateTime(2021, 7, 30, 13, 28, 35, 960, DateTimeKind.Local).AddTicks(8197), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 30, 13, 28, 35, 961, DateTimeKind.Local).AddTicks(8513), new DateTime(2021, 7, 30, 13, 28, 35, 961, DateTimeKind.Local).AddTicks(8528), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 7, 30, 13, 28, 35, 961, DateTimeKind.Local).AddTicks(8815), new DateTime(2021, 7, 30, 13, 28, 35, 961, DateTimeKind.Local).AddTicks(8822), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1623), new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1636), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1921), new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1929), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1932), new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1934), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1936), new DateTime(2021, 7, 30, 13, 28, 35, 962, DateTimeKind.Local).AddTicks(1939), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
