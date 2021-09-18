using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(20)",
                maxLength: 20,
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
                value: "8ad97014-4d69-42aa-b696-9090fa59e863");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f028f710-a0a6-49eb-aae7-361f5e244c48",
                column: "ConcurrencyStamp",
                value: "7d6d8be5-d550-4784-a932-14e0a2c5dbb2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "888dc86f-317b-440f-88ad-8b5cea631d1b", "AQAAAAEAACcQAAAAEL9eBznaGag2TSt+G+4e7BejEmZIvfLVjOme8vtLmGM5FED5vQGY9cah8pZDmCCORw==", "2322ff4f-0fd4-49ab-ad27-230282ba099e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f096080c-4822-4d47-9cc0-b32a01afc375",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36d5e1ee-77c0-4156-a066-90b669010824", "AQAAAAEAACcQAAAAEJy+CHWAlaMpLS7WZKo/Fn2aVLKofakT7rCEFKr0j+6qHkmwyFMY1Romk91Tw8KANg==", "fa68d2db-7df9-4aad-b4ed-521e9524b5ce" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 72, DateTimeKind.Local).AddTicks(1915), new DateTime(2021, 9, 18, 10, 47, 16, 74, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 74, DateTimeKind.Local).AddTicks(5379), new DateTime(2021, 9, 18, 10, 47, 16, 74, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(5654), new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(5966), new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(8713), new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(9008), new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(9019), new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(9023), new DateTime(2021, 9, 18, 10, 47, 16, 75, DateTimeKind.Local).AddTicks(9025) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

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
    }
}
