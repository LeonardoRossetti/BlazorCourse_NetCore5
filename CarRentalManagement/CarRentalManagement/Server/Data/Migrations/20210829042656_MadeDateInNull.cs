using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b53b71b-c1e1-475c-8cd5-2cf13682c369",
                column: "ConcurrencyStamp",
                value: "7ff3ccaf-e2e0-4f95-9f7a-73f366004461");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f028f710-a0a6-49eb-aae7-361f5e244c48",
                column: "ConcurrencyStamp",
                value: "a94958fa-0b56-4480-8a22-8335f95eb51d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f60ed4f-25df-4f66-80d6-d6ff79d33fce", "AQAAAAEAACcQAAAAEBJOW7vLsFR35ZdAQy0zpC67ia98M/GMRzYp5kpjqbuWILx/mVgP9hsKJXCcW5HDCQ==", "2f5b843a-7a5b-4ab5-865a-e4cd51380918" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f096080c-4822-4d47-9cc0-b32a01afc375",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a96c530a-18b1-4f5e-aca2-ce80161dde74", "AQAAAAEAACcQAAAAEJZJpsLANl6VK6Mx0xOB/34+sooHJUgNFt4UFvd8mwKVE1lQkOp3Xibm3MbBnVKp8A==", "506a835a-66d4-4b38-9da2-76748e953059" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 365, DateTimeKind.Local).AddTicks(4381), new DateTime(2021, 7, 30, 14, 0, 59, 367, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 367, DateTimeKind.Local).AddTicks(7316), new DateTime(2021, 7, 30, 14, 0, 59, 367, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 368, DateTimeKind.Local).AddTicks(9766), new DateTime(2021, 7, 30, 14, 0, 59, 368, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(61), new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(2911), new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(3199), new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(3209), new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(3213), new DateTime(2021, 7, 30, 14, 0, 59, 369, DateTimeKind.Local).AddTicks(3215) });
        }
    }
}
