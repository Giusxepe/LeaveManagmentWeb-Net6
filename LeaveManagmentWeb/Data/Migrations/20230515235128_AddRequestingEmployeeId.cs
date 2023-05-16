using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddRequestingEmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestEmployeeId",
                table: "LeaveRequests",
                newName: "RequestingEmployeeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                column: "ConcurrencyStamp",
                value: "c02ce902-4ea8-4b72-9179-cfabf0c59161");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                column: "ConcurrencyStamp",
                value: "c0bb226c-c339-4eb3-9b9e-dcfa2ce10455");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a31af3f-d4c7-4bab-9305-ba3c1cba988d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2195d78c-2aaf-4ca0-a28d-c5db82df7dbf", "AQAAAAEAACcQAAAAEJkbQBgulgaEoXfDEbSN9QjO4Ti1+2Uofqr7S7XOa1Zn70+1r1Q81UwzAP1G7C0FLg==", "dff26f79-d879-4fe3-b5fb-60eb434ed39b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ae16624-fe3d-45f4-9101-c19f12899406", "AQAAAAEAACcQAAAAEHo7JDTqYc7YKc+Zpu4SXPRC2n7uq9+7JhdJYRYFf+YMhpRCXsMwVXJujyKVyH9KHg==", "adb8d1dd-1c55-49c4-a860-92028ae9d602" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                newName: "RequestEmployeeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                column: "ConcurrencyStamp",
                value: "c5c9b3f0-787a-40e5-9808-683591df6308");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                column: "ConcurrencyStamp",
                value: "b3588cca-dd78-42fd-8020-103cf8c78aa9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a31af3f-d4c7-4bab-9305-ba3c1cba988d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74873682-2732-4401-8222-f7a7e9f9483e", "AQAAAAEAACcQAAAAENBKzshnkqlYsb2CJSPKquOfIeBQhypROHHcG6YBjiO1OvUFtVTRRyC30S3i0FFB4Q==", "bee6498d-065e-497a-9eae-dce8a7f15257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9563279-b804-4330-8885-be933c43de30", "AQAAAAEAACcQAAAAEPTbkLhieK5HKXVH41YHhrGjFUWbZdNh3CZVpb5V3W25UB9/YWJwu9s1O6zG6tQASw==", "fd9cb028-5e2b-4261-8bb8-4054a3314b35" });
        }
    }
}
