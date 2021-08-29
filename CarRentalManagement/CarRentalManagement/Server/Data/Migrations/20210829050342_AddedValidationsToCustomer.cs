using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b53b71b-c1e1-475c-8cd5-2cf13682c369",
                column: "ConcurrencyStamp",
                value: "1dad7ce3-aca2-463a-8ca1-41a940db8582");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f028f710-a0a6-49eb-aae7-361f5e244c48",
                column: "ConcurrencyStamp",
                value: "797a3d42-101b-4490-8ad7-33fd04e23796");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3304e0e-91fd-4220-ab46-0a5c22adb1a2", "AQAAAAEAACcQAAAAEHmFuwF5L0MrizKQ7mchzFk019zfABxqQodEziANNuM1wy+hDT3FnRhStZmIAofqhw==", "a903abe8-e817-4367-9a3f-63c7624956a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f096080c-4822-4d47-9cc0-b32a01afc375",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b72971-7c46-4243-bcb1-8d49cf0ccbfc", "AQAAAAEAACcQAAAAEB+597o9zg6kT3X4BqX9cbPJ+8yVZeoh4TwZQNC7Bw4VCX9n7KM7zebsaR+N5ofF9w==", "67758c69-0098-423d-8574-a48ace99e02b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 126, DateTimeKind.Local).AddTicks(157), new DateTime(2021, 8, 29, 17, 3, 42, 127, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 127, DateTimeKind.Local).AddTicks(9373), new DateTime(2021, 8, 29, 17, 3, 42, 127, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(679), new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(1158), new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(4763), new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(5070), new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(5081), new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(5085), new DateTime(2021, 8, 29, 17, 3, 42, 129, DateTimeKind.Local).AddTicks(5087) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
