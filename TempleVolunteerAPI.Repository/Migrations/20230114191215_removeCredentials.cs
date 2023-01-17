using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class removeCredentials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPR",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "FirstAid",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Kriyaban",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "LessonStudent",
                table: "Staff");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Committees",
                keyColumn: "CommitteeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Credentials",
                keyColumn: "CredentialId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "EventTask",
                keyColumn: "EventTaskId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8285), new DateTime(2023, 1, 15, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8279), new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8299), new DateTime(2023, 1, 15, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8298), new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8309), new DateTime(2023, 1, 15, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8308), new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8318), new DateTime(2023, 1, 15, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8317), new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8328), new DateTime(2023, 1, 15, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8327), new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 724, DateTimeKind.Utc).AddTicks(5313), "afOH0t40hQ9PSlBMe+OQgPVF4Z8Toz42MqcetmoYCkY=", "GMqy3wF1l+n8c26JxL5C/gStQF7B7HzAgDqxyn0n/Wk=", new DateTime(2023, 1, 14, 19, 12, 13, 651, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 801, DateTimeKind.Utc).AddTicks(2835), "JQcYEkFfhVolNSVi0TquYXzjzCYS7Fc+q9LSq4Kle2U=", "za5R2l4MbeGdeBvAG/5Jm0FEZcscJvaHquWYSo21kcA=", new DateTime(2023, 1, 14, 19, 12, 13, 724, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(7657), "YZUJoP16w1aE9i/BJh/j8qRqewnOozu9VfdOVZYhVis=", "TENutiEfoNnihSU0kfKx3g3KGMJIBvifRz9nUb8LpuI=", new DateTime(2023, 1, 14, 19, 12, 13, 801, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "SupplyItems",
                keyColumn: "SupplyItemId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 14, 19, 12, 13, 879, DateTimeKind.Utc).AddTicks(8598));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CPR",
                table: "Staff",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FirstAid",
                table: "Staff",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Kriyaban",
                table: "Staff",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LessonStudent",
                table: "Staff",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CPR", "CreatedDate", "FirstAid", "Kriyaban", "LessonStudent", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { true, new DateTime(2023, 1, 2, 18, 7, 30, 620, DateTimeKind.Utc).AddTicks(6016), true, true, true, "lx0b7oUnFPcrC3luIU4PDFSgqAyNBrljwJD+8V33MjQ=", "f1HV9drOvjZbHgPI4TC+8gplZUlpcdz8UU7zdSsnFQ8=", new DateTime(2023, 1, 2, 18, 7, 30, 540, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                columns: new[] { "CPR", "CreatedDate", "FirstAid", "Kriyaban", "LessonStudent", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { true, new DateTime(2023, 1, 2, 18, 7, 30, 711, DateTimeKind.Utc).AddTicks(538), true, true, true, "Dz0uXLaNARnVQYAmalSecKlTzN+VXZJffpuzOa7OPCs=", "KTzF/H8J6Ol39GvP40zCUNJW36NmfDobOMldEKs2uME=", new DateTime(2023, 1, 2, 18, 7, 30, 620, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3,
                columns: new[] { "CPR", "CreatedDate", "FirstAid", "Kriyaban", "LessonStudent", "Password", "PasswordSalt", "VerifiedDate" },
                values: new object[] { true, new DateTime(2023, 1, 2, 18, 7, 30, 789, DateTimeKind.Utc).AddTicks(1650), true, true, true, "2WG4SIXniW1/+UcfHiJK+UlcNjhBmqLmdDlRlkGi14s=", "+XM5CIbBCO6KfYC1yZ8kesURTRXcScY+nuOJyvbHQdY=", new DateTime(2023, 1, 2, 18, 7, 30, 711, DateTimeKind.Utc).AddTicks(558) });

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
    }
}
