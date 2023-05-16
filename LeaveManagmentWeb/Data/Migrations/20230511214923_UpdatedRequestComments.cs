
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                column: "ConcurrencyStamp",
                value: "b86f610d-8be1-4e31-928c-59bdeae51b0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                column: "ConcurrencyStamp",
                value: "2c29b7ec-5049-4952-bfe8-e305253e5baa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a31af3f-d4c7-4bab-9305-ba3c1cba988d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e1081a2-f3dc-4f10-a866-f27c45ae7910", "AQAAAAEAACcQAAAAELmu9t5561WTK6EPQYYLG8koeUMbeIl2+XvrCl5+k+SgIF4QjmlJgvJMaqwHgO34Tg==", "26e67688-52fa-43ec-b098-22b5d9a2c4ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b1b607-6203-4f55-8f32-9bfa51b40a17", "AQAAAAEAACcQAAAAEFNKcJcbvjIlYX5DIjDKrALstQnJgjpeOElUtj6uka53ZXcmVRmFRGArmZ/OjC4iSQ==", "cbe012ed-cf10-41d3-8378-c138edeed35d" });
        }
    }
}
