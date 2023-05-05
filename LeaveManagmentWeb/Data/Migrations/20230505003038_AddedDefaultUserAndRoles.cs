using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1699e545-7b30-4708-91cd-4d8cfff5bb8d", "9e530070-8a29-4947-8613-13b027a62fa2", "Administrator", "ADMINISTRATOR" },
                    { "d64051cd-d770-42bf-bd0e-b6e020c4b1e9", "650fa375-0581-43b0-8cc8-b0a98d77c674", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a31af3f-d4c7-4bab-9305-ba3c1cba988d", 0, "10eeb554-c02c-4f3b-bb66-970f3f44f68d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJkSpTZlY/+nW+1E8U3ZZcW/kRc8COCFKc+0t1PFipWhMma9mjybzDpxVwTKraXjvw==", null, false, "3faf69d8-6523-4b3e-bf8e-50ea80cec1c1", null, false, null },
                    { "c77cba4b-0748-4efd-b77b-237972f1cfaf", 0, "31726f95-5d9b-46e1-8f89-622baebed02e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAENy7FrzrRYfG0nm5tqXPQnSQ+acSQIX1K8jFnMbQfN/X8AaPLI1oBt+5rwq9FncVDA==", null, false, "4d6dd00b-93ef-436c-bfe4-1365376e7271", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d64051cd-d770-42bf-bd0e-b6e020c4b1e9", "4a31af3f-d4c7-4bab-9305-ba3c1cba988d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1699e545-7b30-4708-91cd-4d8cfff5bb8d", "c77cba4b-0748-4efd-b77b-237972f1cfaf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d64051cd-d770-42bf-bd0e-b6e020c4b1e9", "4a31af3f-d4c7-4bab-9305-ba3c1cba988d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1699e545-7b30-4708-91cd-4d8cfff5bb8d", "c77cba4b-0748-4efd-b77b-237972f1cfaf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1699e545-7b30-4708-91cd-4d8cfff5bb8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64051cd-d770-42bf-bd0e-b6e020c4b1e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a31af3f-d4c7-4bab-9305-ba3c1cba988d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf");
        }
    }
}
