using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garuda.Host.Migrations
{
    public partial class empetyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 0, 53, 437, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 0, 53, 437, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 0, 53, 437, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 0, 53, 472, DateTimeKind.Local).AddTicks(3037));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 9, 59, 40, 102, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 9, 59, 40, 102, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 9, 59, 40, 102, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 9, 59, 40, 166, DateTimeKind.Local).AddTicks(7490));
        }
    }
}
