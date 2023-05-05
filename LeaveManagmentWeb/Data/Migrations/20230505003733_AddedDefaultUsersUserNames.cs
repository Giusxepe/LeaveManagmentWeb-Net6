using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddedDefaultUsersUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                column: "ConcurrencyStamp",
                value: "34e1ff9b-777d-4b58-b2d0-955cec5ef418");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                column: "ConcurrencyStamp",
                value: "fad00d22-2e96-4a56-a195-079dc1a05039");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a31af3f-d4c7-4bab-9305-ba3c1cba988d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a2e948d5-8aa7-4f71-8a2b-909afd9d7f3f", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJgRnZkyBaQzxVk7+DqqS6cQG64HhAs6+BGFyGPdnkcWXoroy9oDwKNMviluziZQKw==", "ad722626-6ccb-4f12-a289-217a50eb81ba", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b1f9fb78-b61b-4923-b0ad-e3c2919f0f08", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBwKa4wtRNkfu1L9m6rTzsVaek2Y+hoKP0R//oRfPlEHLp6+jNLbMZMx9t9hNzK34Q==", "6dd7640f-eb35-4475-9c6e-4478e49aa85b", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                column: "ConcurrencyStamp",
                value: "9e530070-8a29-4947-8613-13b027a62fa2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                column: "ConcurrencyStamp",
                value: "650fa375-0581-43b0-8cc8-b0a98d77c674");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a31af3f-d4c7-4bab-9305-ba3c1cba988d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "10eeb554-c02c-4f3b-bb66-970f3f44f68d", false, null, "AQAAAAEAACcQAAAAEJkSpTZlY/+nW+1E8U3ZZcW/kRc8COCFKc+0t1PFipWhMma9mjybzDpxVwTKraXjvw==", "3faf69d8-6523-4b3e-bf8e-50ea80cec1c1", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "31726f95-5d9b-46e1-8f89-622baebed02e", false, null, "AQAAAAEAACcQAAAAENy7FrzrRYfG0nm5tqXPQnSQ+acSQIX1K8jFnMbQfN/X8AaPLI1oBt+5rwq9FncVDA==", "4d6dd00b-93ef-436c-bfe4-1365376e7271", null });
        }
    }
}
