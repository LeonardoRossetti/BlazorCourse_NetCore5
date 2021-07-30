using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f096080c-4822-4d47-9cc0-b32a01afc375", 0, "a96c530a-18b1-4f5e-aca2-ce80161dde74", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJZJpsLANl6VK6Mx0xOB/34+sooHJUgNFt4UFvd8mwKVE1lQkOp3Xibm3MbBnVKp8A==", null, false, "506a835a-66d4-4b38-9da2-76748e953059", false, "admin@localhost.com" },
                    { "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a", 0, "8f60ed4f-25df-4f66-80d6-d6ff79d33fce", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBJOW7vLsFR35ZdAQy0zpC67ia98M/GMRzYp5kpjqbuWILx/mVgP9hsKJXCcW5HDCQ==", null, false, "2f5b843a-7a5b-4ab5-865a-e4cd51380918", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f028f710-a0a6-49eb-aae7-361f5e244c48", "f096080c-4822-4d47-9cc0-b32a01afc375" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8b53b71b-c1e1-475c-8cd5-2cf13682c369", "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b53b71b-c1e1-475c-8cd5-2cf13682c369", "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f028f710-a0a6-49eb-aae7-361f5e244c48", "f096080c-4822-4d47-9cc0-b32a01afc375" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71e49c5-ce9b-41cd-96b4-5dd02e41b07a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f096080c-4822-4d47-9cc0-b32a01afc375");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b53b71b-c1e1-475c-8cd5-2cf13682c369",
                column: "ConcurrencyStamp",
                value: "f14e2882-3072-4b86-8ec6-7907f8e7a604");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f028f710-a0a6-49eb-aae7-361f5e244c48",
                column: "ConcurrencyStamp",
                value: "b4eb600d-1937-4d4b-b60a-29c0085002a4");

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
    }
}
