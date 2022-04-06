using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garuda.Host.Migrations
{
    public partial class empetyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"));

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ec211d37-2400-4877-8696-62ac17faeecb"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 6, 10, 3, 18, 993, DateTimeKind.Local).AddTicks(7656), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 3, 19, 83, DateTimeKind.Local).AddTicks(1545));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"));

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 6, 10, 0, 53, 437, DateTimeKind.Local).AddTicks(1792), new Guid("00000000-0000-0000-0000-000000000000"), null, "Administrator", new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 6, 10, 0, 53, 437, DateTimeKind.Local).AddTicks(1835), new Guid("00000000-0000-0000-0000-000000000000"), null, "QPB Administrator", new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"), new Guid("81314787-537b-474f-999a-9152c9703bbb"), new DateTime(2022, 4, 6, 10, 0, 53, 437, DateTimeKind.Local).AddTicks(1843), new Guid("00000000-0000-0000-0000-000000000000"), null, "Mine Head", new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 6, 10, 0, 53, 472, DateTimeKind.Local).AddTicks(3037));
        }
    }
}
