using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class general : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MissingImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7724), new DateTime(2023, 1, 3, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7717), new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7739), new DateTime(2023, 1, 3, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7735), new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7748), new DateTime(2023, 1, 3, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7748), new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7758), new DateTime(2023, 1, 3, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7757), new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7769), new DateTime(2023, 1, 3, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7767), new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 22, 998, DateTimeKind.Utc).AddTicks(4704), "m3h8PFxy3pMXVZZvzodedxBYtm91dhICZpNKG2uP3Rc=", "vo+ckKIJF8C87iLFzegROJYrJe9UyARFEiniz3SNLss=", new DateTime(2023, 1, 2, 14, 31, 22, 923, DateTimeKind.Utc).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 23, 77, DateTimeKind.Utc).AddTicks(5041), "AMPWtatT4czAKXG0NgUMKB/siYtUviOU7ottwucpgl0=", "KwWYONxyPPm4LMr7dBVGt24eRIy/dPJGhA3aalYEgMc=", new DateTime(2023, 1, 2, 14, 31, 22, 998, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(6927), "2rtQmiepW1wChlwWixKcoVibucgTNs1iKtTZTfZsKV8=", "vJi9w5/MSD+lLnUj05pZgg+JlomaX5dFf/6+YsMEO8Y=", new DateTime(2023, 1, 2, 14, 31, 23, 77, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 14, 31, 23, 155, DateTimeKind.Utc).AddTicks(8153));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "General");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7547), new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7538), new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7577), new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7568), new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7599), new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7598), new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7618), new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7617), new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7637), new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7636), new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 49, 927, DateTimeKind.Utc).AddTicks(9087), "MPqhD4papxI6oWyw2QtYenj9c6oKmu9gcC2vY4ZKTNE=", "Fe7O+loKvHTHzzoxsnQzy3tSt7YtzOjdfjkjEULIctY=", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 50, 22, DateTimeKind.Utc).AddTicks(5848), "QmMUFV4PYEGM+T1Z+O4a7/Z0CfMUj3fNK87/TYArq1w=", "smuLnBO/HBB+4U99mMvKlB1MiX0HFWw5GlvSZi/A2mc=", new DateTime(2022, 12, 16, 0, 11, 49, 927, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6351), "r2S3yHanfEMxjUw+mwlZHwXKj0gBb4BZE61WgcdtzbY=", "ajhT+ByW73wxyMLPxm+bOyJuZ42OE0pT/3n8wmhY3zg=", new DateTime(2022, 12, 16, 0, 11, 50, 22, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8297));
        }
    }
}
