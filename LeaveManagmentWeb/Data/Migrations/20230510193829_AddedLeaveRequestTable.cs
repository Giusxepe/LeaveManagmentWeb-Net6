using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
