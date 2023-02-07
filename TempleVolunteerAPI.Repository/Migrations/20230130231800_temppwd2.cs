using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class temppwd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemporaryPassword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryPassword", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(408), new DateTime(2023, 1, 31, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(421), new DateTime(2023, 1, 31, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(420), new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(430), new DateTime(2023, 1, 31, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(429), new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(439), new DateTime(2023, 1, 31, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(438), new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(447), new DateTime(2023, 1, 31, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(446), new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 59, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 144, DateTimeKind.Utc).AddTicks(7811), new DateTime(2023, 1, 30, 15, 17, 58, 144, DateTimeKind.Local).AddTicks(7820), "elx2ESy5B4ncGVH19V/3NRZJT5Ux8mTr3EPt2Hre51c=", "ecy706BxvNHNmxMjlfJ4Dal7q20fAM2SV4EZtmGyB4Y=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 236, DateTimeKind.Utc).AddTicks(6242), new DateTime(2023, 1, 30, 15, 17, 58, 236, DateTimeKind.Local).AddTicks(6248), "ynuz8rkPdw1nSqyqrN8wnYt1W4woZvGmg4UNTPlBrhc=", "5sfkuccLi8i3knBs19616QToCdmUY2oMm+oapa0K8oA=" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EmailConfirmedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 1, 30, 23, 17, 58, 330, DateTimeKind.Utc).AddTicks(9694), new DateTime(2023, 1, 30, 15, 17, 58, 236, DateTimeKind.Local).AddTicks(6399), "pEdvuTFmJj7ndAtcXEoJBsDJy2xODMfjJFiqKQ6mRTM=", "+1Og8ZtQljDJz2ERvrUgE7+v2cuUlyf0ZDHs7BUadQw=" });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 30, 23, 17, 58, 331, DateTimeKind.Utc).AddTicks(645));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemporaryPassword");

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
    }
}
