using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garuda.Host.Migrations
{
    public partial class EmptyMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 4, 50, 914, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 4, 50, 955, DateTimeKind.Local).AddTicks(7032));
        }
    }
}
