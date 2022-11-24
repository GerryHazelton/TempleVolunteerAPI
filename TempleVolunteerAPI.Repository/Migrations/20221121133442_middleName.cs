using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class middleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Staff",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2340), new DateTime(2022, 11, 22, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2338), new DateTime(2022, 11, 21, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2358), new DateTime(2022, 11, 22, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2355), new DateTime(2022, 11, 21, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2371), new DateTime(2022, 11, 22, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2369), new DateTime(2022, 11, 21, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2383), new DateTime(2022, 11, 22, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2381), new DateTime(2022, 11, 21, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2396), new DateTime(2022, 11, 22, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2394), new DateTime(2022, 11, 21, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2014), new DateTime(2022, 11, 21, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2021), new DateTime(2022, 11, 21, 5, 34, 40, 529, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 21, 13, 34, 40, 529, DateTimeKind.Utc).AddTicks(2637));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Staff");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8853), new DateTime(2022, 11, 8, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8851), new DateTime(2022, 11, 7, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8870), new DateTime(2022, 11, 8, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8868), new DateTime(2022, 11, 7, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8930), new DateTime(2022, 11, 8, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8927), new DateTime(2022, 11, 7, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8947), new DateTime(2022, 11, 8, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8945), new DateTime(2022, 11, 7, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8961), new DateTime(2022, 11, 8, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8959), new DateTime(2022, 11, 7, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8423), new DateTime(2022, 11, 7, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(8432), new DateTime(2022, 11, 7, 5, 9, 37, 396, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 13, 9, 37, 396, DateTimeKind.Utc).AddTicks(9641));
        }
    }
}
