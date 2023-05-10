using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1699e545-7b30-4708-91cd-4d8cfff5bb8d",
                column: "ConcurrencyStamp",
                value: "a4354867-1c68-45f1-bdbe-da133c1bbc5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d64051cd-d770-42bf-bd0e-b6e020c4b1e9",
                column: "ConcurrencyStamp",
                value: "3c5bfc7b-5016-462f-8f19-8e319e919e78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a31af3f-d4c7-4bab-9305-ba3c1cba988d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e00b1ea9-b7ff-456f-a6b5-f7d8b052d98c", "AQAAAAEAACcQAAAAEJduq+OhX+6E/QB58ZfgV4EGcc1kbgx56DuuYT25hvAVE5FNBmGF7x+UAqGY0t95NQ==", "90364935-d3b9-43b0-a2f1-55e36497f929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c790329-ce6b-4ff0-8548-917d799cb8db", "AQAAAAEAACcQAAAAEC957NAzH18oTPERnW0kzhTA/HokqiNhvpGr7sSfjzScTsy7H0LFEsjp0pI3RHqSXg==", "45ea779e-c315-4cc6-8678-d18924ea3534" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2e948d5-8aa7-4f71-8a2b-909afd9d7f3f", "AQAAAAEAACcQAAAAEJgRnZkyBaQzxVk7+DqqS6cQG64HhAs6+BGFyGPdnkcWXoroy9oDwKNMviluziZQKw==", "ad722626-6ccb-4f12-a289-217a50eb81ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77cba4b-0748-4efd-b77b-237972f1cfaf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1f9fb78-b61b-4923-b0ad-e3c2919f0f08", "AQAAAAEAACcQAAAAEBwKa4wtRNkfu1L9m6rTzsVaek2Y+hoKP0R//oRfPlEHLp6+jNLbMZMx9t9hNzK34Q==", "6dd7640f-eb35-4475-9c6e-4478e49aa85b" });
        }
    }
}
