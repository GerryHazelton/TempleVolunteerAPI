using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class removecredential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7577), new DateTime(2022, 11, 23, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 11, 22, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7592), new DateTime(2022, 11, 23, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 11, 22, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7604), new DateTime(2022, 11, 23, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7602), new DateTime(2022, 11, 22, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7615), new DateTime(2022, 11, 23, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 11, 22, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7627), new DateTime(2022, 11, 23, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7625), new DateTime(2022, 11, 22, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7334), new DateTime(2022, 11, 22, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7341), new DateTime(2022, 11, 22, 5, 45, 41, 359, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 13, 45, 41, 359, DateTimeKind.Utc).AddTicks(7816));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
