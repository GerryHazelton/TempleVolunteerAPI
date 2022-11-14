using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "CredentialFileName",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "CredentialImage",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Credentials");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "StaffCredentials",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "StaffCredentials",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "StaffCredentials");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "StaffCredentials");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "Credentials",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CredentialFileName",
                table: "Credentials",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CredentialImage",
                table: "Credentials",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "Credentials",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3271), new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3314), new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3326), new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3413), new DateTime(2022, 11, 4, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3430), new DateTime(2022, 11, 4, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3428), new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3446), new DateTime(2022, 11, 4, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3444), new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3461), new DateTime(2022, 11, 4, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3459), new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3476), new DateTime(2022, 11, 4, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3474), new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3065), new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3074), new DateTime(2022, 11, 3, 16, 20, 2, 568, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 3, 23, 20, 2, 568, DateTimeKind.Utc).AddTicks(3738));
        }
    }
}
