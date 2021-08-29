using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b53b71b-c1e1-475c-8cd5-2cf13682c369",
                column: "ConcurrencyStamp",
                value: "e632d21d-061f-4ac8-b1e9-291af7c7f08c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f028f710-a0a6-49eb-aae7-361f5e244c48",
                column: "ConcurrencyStamp",
                value: "36ad3aad-9c5e-4bbe-9199-0f858c10d7e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1270567d-8d14-4686-b941-25643494bd5b", "AQAAAAEAACcQAAAAEO5/ZqArtbKtvt4clB2fbPseLZZRlrfQC6swC/kqAbaLQ4PkIxPt8sakTg1gloBzcQ==", "0e5b0a86-e0ba-4a5e-be78-0fc3c01cd77a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f096080c-4822-4d47-9cc0-b32a01afc375",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78088bc1-eda8-43ad-a883-4c69db6f210a", "AQAAAAEAACcQAAAAEDLGmalcoidiIDobKyNBHD4aWvzKJHySnK9QX3jxllhJ60t4CfoTh2NQl3xKwBkQRA==", "bfc5aab7-de64-4fa0-aa6f-6a8d86ac5176" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 798, DateTimeKind.Local).AddTicks(205), new DateTime(2021, 8, 29, 16, 55, 12, 800, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 800, DateTimeKind.Local).AddTicks(1798), new DateTime(2021, 8, 29, 16, 55, 12, 800, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(3248), new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(3613), new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(6954), new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(7317), new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(7330), new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(7334), new DateTime(2021, 8, 29, 16, 55, 12, 801, DateTimeKind.Local).AddTicks(7337) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b53b71b-c1e1-475c-8cd5-2cf13682c369",
                column: "ConcurrencyStamp",
                value: "c4485159-f6c4-4cc1-a7a9-ad20e0630aa7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f028f710-a0a6-49eb-aae7-361f5e244c48",
                column: "ConcurrencyStamp",
                value: "7ccbbacc-bc71-4874-bb8b-f8a35735add0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62585b97-83c0-4e81-b705-5be73a165222", "AQAAAAEAACcQAAAAELSFljIBBKhJTVfaxGMPVFbJ1IZuSjEREEeh0KIcc/DAly6c921mSSTENvcBMRk6Gw==", "53d37d5e-b939-4561-a68f-b855a96d1f5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f096080c-4822-4d47-9cc0-b32a01afc375",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "358cab9a-81fa-4e51-bfa7-829e8f8f6a8f", "AQAAAAEAACcQAAAAECsNzXNoijMY1WRnYE6tNk5kYvHVArVpmYTlNZJQDGsXfZhK3aIgyK6OOSw3sN1wlw==", "80776e6d-e043-4d52-83d0-44a10b4b73de" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 257, DateTimeKind.Local).AddTicks(5591), new DateTime(2021, 8, 29, 16, 26, 56, 259, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 259, DateTimeKind.Local).AddTicks(4983), new DateTime(2021, 8, 29, 16, 26, 56, 259, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(5458), new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(5877), new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(8847), new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(9168), new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(9180), new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(9185), new DateTime(2021, 8, 29, 16, 26, 56, 260, DateTimeKind.Local).AddTicks(9187) });
        }
    }
}
