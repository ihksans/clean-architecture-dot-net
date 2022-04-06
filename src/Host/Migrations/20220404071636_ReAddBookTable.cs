using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garuda.Host.Migrations
{
    public partial class ReAddBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 195, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 167, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 167, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 167, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 154, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 198, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 198, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 198, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 214, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 214, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 214, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 214, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 214, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 214, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 214, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 248, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 264, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 264, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 264, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 264, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 264, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 264, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 264, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 242, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 242, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 242, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 242, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 16, 31, 242, DateTimeKind.Local).AddTicks(3362));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 762, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 744, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 744, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 744, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 738, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 766, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 766, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 766, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 773, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 773, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 773, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 773, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 773, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 773, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 773, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 782, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 796, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 796, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 796, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 796, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 796, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 796, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 796, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 778, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 778, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 778, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 778, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 4, 4, 14, 15, 1, 778, DateTimeKind.Local).AddTicks(2656));
        }
    }
}
