using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class temppwd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1977), new DateTime(2023, 1, 31, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1967), new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1998), new DateTime(2023, 1, 31, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1996), new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2012), new DateTime(2023, 1, 31, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2011), new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2027), new DateTime(2023, 1, 31, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2025), new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2040), new DateTime(2023, 1, 31, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2039), new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 37, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 125, DateTimeKind.Utc).AddTicks(5854), new DateTime(2023, 1, 30, 15, 13, 40, 125, DateTimeKind.Local).AddTicks(5863), "ANldKn8hpjTyCdECfuJ6ajb2aDPoJ96ntL49/+WDAA4=", "UQ1W5ze2bGDiiqX//34zjfeh0TPRIvvdmTpaCU1f2z4=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 233, DateTimeKind.Utc).AddTicks(4958), new DateTime(2023, 1, 30, 15, 13, 40, 233, DateTimeKind.Local).AddTicks(4969), "P9LIU4fXmtqp9C2zeZNEjsND5IQeuhN1+yK1D2corzY=", "A+IS3/N0AfCIq5KHFDSysoW9h2SHH3GcFGyAKlz3iLY=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(950), new DateTime(2023, 1, 30, 15, 13, 40, 233, DateTimeKind.Local).AddTicks(5034), "NP7qobk9wstOtWFefHpgqr6uIb9qnOfs6X2S/egku7o=", "moVULuPZbtx77Vp5h0BrHAXH0RYZ3nIMOjQNceZYQd4=" });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 13, 40, 341, DateTimeKind.Utc).AddTicks(2547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5693), new DateTime(2023, 1, 23, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5685), new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5706), new DateTime(2023, 1, 23, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5704), new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5714), new DateTime(2023, 1, 23, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5713), new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5723), new DateTime(2023, 1, 23, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5722), new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5732), new DateTime(2023, 1, 23, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5731), new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 230, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 310, DateTimeKind.Utc).AddTicks(3252), new DateTime(2023, 1, 22, 6, 50, 5, 310, DateTimeKind.Local).AddTicks(3261), "Sqx98K8fnk0RFjJusMVIKvbn2YtbJ5DPbNd5iFl/95s=", "Y+GfC/XoFroldIj8so+bZtOSe/Qfi0ycfc8MTwRxAbk=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 389, DateTimeKind.Utc).AddTicks(6805), new DateTime(2023, 1, 22, 6, 50, 5, 389, DateTimeKind.Local).AddTicks(6815), "v/5xLF4G6kio4eaj2S3NeW8//G1nN1yZtHmCk0Cwucs=", "eFULwlavdpMt0K5Uz/fZiURSvc/LLzNDZ2+zhbFaSFE=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(4846), new DateTime(2023, 1, 22, 6, 50, 5, 389, DateTimeKind.Local).AddTicks(6882), "JWRxeODHacJDa2AY6Ijela+XgsO9SS5D+vv//ft6/AI=", "kRUxFyw3w1EofKawFTKto6QLSxV0IjEFekC/Qsl+bvQ=" });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 22, 14, 50, 5, 468, DateTimeKind.Utc).AddTicks(6225));
        }
    }
}
