using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class newRegistrationApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NewRegistrationApproved",
                table: "Staff",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewRegistrationApproved",
                table: "Staff");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 1, 20, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3774), new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3797), new DateTime(2023, 1, 20, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3793), new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3807), new DateTime(2023, 1, 20, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3806), new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3816), new DateTime(2023, 1, 20, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3815), new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3826), new DateTime(2023, 1, 20, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3824), new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 370, DateTimeKind.Utc).AddTicks(7038), new DateTime(2023, 1, 19, 0, 4, 53, 293, DateTimeKind.Utc).AddTicks(7989), "NflwrzI4E8dqfi1YN/k9l2Vj4LHksKh0pNdUGeRTrl4=", "PnwRQLcmjndevj2n/TUkZ8Dm2OX95VEhnSZQRtQomyk=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 448, DateTimeKind.Utc).AddTicks(9828), new DateTime(2023, 1, 19, 0, 4, 53, 370, DateTimeKind.Utc).AddTicks(7049), "GjELTavMUbgMLTCOvqP1aoPBF2e7pn+6LreSu2lFuMQ=", "451Wk1ShndEENZt0UMMNcLU4bfsOETW6eOua8LaHs8U=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(2992), new DateTime(2023, 1, 19, 0, 4, 53, 448, DateTimeKind.Utc).AddTicks(9846), "NC8BraIRZJhMTNPIw43R+91GF0wOzWIEa7V+gNBpw50=", "araw2zv7GsE9QSaqxcCAt/psuNE3ccftfVdP903bJFU=" });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 19, 0, 4, 53, 526, DateTimeKind.Utc).AddTicks(4207));
        }
    }
}
