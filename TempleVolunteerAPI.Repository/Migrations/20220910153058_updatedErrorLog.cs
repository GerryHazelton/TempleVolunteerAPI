using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class updatedErrorLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Environment",
                table: "ErrorLog",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9307), new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "EventTasks",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9346), new DateTime(2022, 9, 11, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9343), new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9242), new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 30, 57, 260, DateTimeKind.Local).AddTicks(9410));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Environment",
                table: "ErrorLog",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7361), new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "EventTasks",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7400), new DateTime(2022, 9, 4, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7397), new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7464));
        }
    }
}
