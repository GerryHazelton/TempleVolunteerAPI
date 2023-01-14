using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class general2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "MissingImage",
                table: "General",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "General",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MissingImageFileName",
                table: "General",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2173), new DateTime(2023, 1, 3, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 1, 3, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 1, 3, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 1, 3, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2212), new DateTime(2023, 1, 3, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2211), new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 620, DateTimeKind.Utc).AddTicks(6016), "lx0b7oUnFPcrC3luIU4PDFSgqAyNBrljwJD+8V33MjQ=", "f1HV9drOvjZbHgPI4TC+8gplZUlpcdz8UU7zdSsnFQ8=", new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 711, DateTimeKind.Utc).AddTicks(538), "Dz0uXLaNARnVQYAmalSecKlTzN+VXZJffpuzOa7OPCs=", "KTzF/H8J6Ol39GvP40zCUNJW36NmfDobOMldEKs2uME=", new DateTime(2023, 1, 2, 18, 7, 30, 620, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1650), "2WG4SIXniW1/+UcfHiJK+UlcNjhBmqLmdDlRlkGi14s=", "+XM5CIbBCO6KfYC1yZ8kesURTRXcScY+nuOJyvbHQdY=", new DateTime(2023, 1, 2, 18, 7, 30, 711, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(2420));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissingImageFileName",
                table: "General");

            migrationBuilder.AlterColumn<byte[]>(
                name: "MissingImage",
                table: "General",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "General",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
