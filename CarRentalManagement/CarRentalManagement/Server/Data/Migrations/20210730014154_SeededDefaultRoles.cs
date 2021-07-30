using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b53b71b-c1e1-475c-8cd5-2cf13682c369", "f14e2882-3072-4b86-8ec6-7907f8e7a604", "User", "USER" },
                    { "f028f710-a0a6-49eb-aae7-361f5e244c48", "b4eb600d-1937-4d4b-b60a-29c0085002a4", "Administrator", "ADMINISTATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 961, DateTimeKind.Local).AddTicks(8926), new DateTime(2021, 7, 30, 13, 41, 53, 963, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 963, DateTimeKind.Local).AddTicks(5329), new DateTime(2021, 7, 30, 13, 41, 53, 963, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(3893), new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(4173), new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6665), new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6952), new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6962), new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6967), new DateTime(2021, 7, 30, 13, 41, 53, 964, DateTimeKind.Local).AddTicks(6969) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b53b71b-c1e1-475c-8cd5-2cf13682c369");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f028f710-a0a6-49eb-aae7-361f5e244c48");

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 918, DateTimeKind.Local).AddTicks(9277), new DateTime(2021, 7, 30, 13, 37, 39, 920, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 920, DateTimeKind.Local).AddTicks(6492), new DateTime(2021, 7, 30, 13, 37, 39, 920, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b53b71b-c1e1-475c-8cd5-2cf13682c369", "User", "USER" },
                    { "f028f710-a0a6-49eb-aae7-361f5e244c48", "Administrator", "ADMINISTATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(5227), new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(5516), new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8123), new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8413), new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8423), new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8427), new DateTime(2021, 7, 30, 13, 37, 39, 921, DateTimeKind.Local).AddTicks(8429) });
        }
    }
}
