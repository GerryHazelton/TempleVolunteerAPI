using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class updatedErrorLog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ErrorLog_Properties_PropertyId",
                table: "ErrorLog");

            migrationBuilder.DropIndex(
                name: "IX_ErrorLog_PropertyId",
                table: "ErrorLog");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "ErrorLog",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                columns: new[] { "CompletedDate", "CreatedDate" },
                values: new object[] { new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "EventTasks",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7032), new DateTime(2022, 9, 11, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7029), new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "VerifiedDate" },
                values: new object[] { new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6924), new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 8, 53, 39, 883, DateTimeKind.Local).AddTicks(7410));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "ErrorLog",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ErrorLog_PropertyId",
                table: "ErrorLog",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ErrorLog_Properties_PropertyId",
                table: "ErrorLog",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
