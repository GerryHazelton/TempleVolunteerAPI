using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class credential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "Credentials",
                type: "datetime2",
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
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7331), new DateTime(2022, 11, 23, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7329), new DateTime(2022, 11, 22, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7346), new DateTime(2022, 11, 23, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7344), new DateTime(2022, 11, 22, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7358), new DateTime(2022, 11, 23, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7356), new DateTime(2022, 11, 22, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7371), new DateTime(2022, 11, 23, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7369), new DateTime(2022, 11, 22, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7383), new DateTime(2022, 11, 23, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7381), new DateTime(2022, 11, 22, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(6975), new DateTime(2022, 11, 22, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7033), new DateTime(2022, 11, 22, 5, 27, 28, 227, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 27, 28, 227, DateTimeKind.Utc).AddTicks(7653));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "Credentials");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Credentials");

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
    }
}
