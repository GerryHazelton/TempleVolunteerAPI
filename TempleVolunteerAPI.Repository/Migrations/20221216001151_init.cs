﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TempleVolunteerAPI.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorLog",
                columns: table => new
                {
                    ErrorLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FunctionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StackTrace = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Environment = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLog", x => x.ErrorLogId);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    City = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SupplyItemsAllowed = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                    table.ForeignKey(
                        name: "FK_Areas_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Committees",
                columns: table => new
                {
                    CommitteeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Committees", x => x.CommitteeId);
                    table.ForeignKey(
                        name: "FK_Committees_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    CredentialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.CredentialId);
                    table.ForeignKey(
                        name: "FK_Credentials_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DocumentFileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DocumentImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventTask",
                columns: table => new
                {
                    EventTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTask", x => x.EventTaskId);
                    table.ForeignKey(
                        name: "FK_EventTask_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    EventTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.EventTypeId);
                    table.ForeignKey(
                        name: "FK_EventTypes_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    To = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    MessageSent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstAid = table.Column<bool>(type: "bit", nullable: false),
                    CPR = table.Column<bool>(type: "bit", nullable: false),
                    LessonStudent = table.Column<bool>(type: "bit", nullable: false),
                    Kriyaban = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CanSendMessages = table.Column<bool>(type: "bit", nullable: false),
                    CanViewDocuments = table.Column<bool>(type: "bit", nullable: false),
                    StaffFileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    StaffImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AcceptTerms = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    RememberMe = table.Column<bool>(type: "bit", nullable: false),
                    IsLockedOut = table.Column<bool>(type: "bit", nullable: false),
                    LoginAttempts = table.Column<int>(type: "int", nullable: false),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    PasswordReset = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staff_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Indefinite = table.Column<bool>(type: "bit", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId");
                    table.ForeignKey(
                        name: "FK_Events_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyItems",
                columns: table => new
                {
                    SupplyItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BinNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SupplyItemFileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SupplyItemImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyItems", x => x.SupplyItemId);
                    table.ForeignKey(
                        name: "FK_SupplyItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyItems_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaCommittees",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    CommitteeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaCommittees", x => new { x.AreaId, x.CommitteeId });
                    table.ForeignKey(
                        name: "FK_AreaCommittees_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaCommittees_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "CommitteeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaEventTasks",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EventTaskId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaEventTasks", x => new { x.AreaId, x.EventTaskId });
                    table.ForeignKey(
                        name: "FK_AreaEventTasks_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaEventTasks_EventTask_EventTaskId",
                        column: x => x.EventTaskId,
                        principalTable: "EventTask",
                        principalColumn: "EventTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventTypeAreas",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypeAreas", x => new { x.EventTypeId, x.AreaId });
                    table.ForeignKey(
                        name: "FK_EventTypeAreas_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTypeAreas_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommitteeStaff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    CommitteeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommitteeStaff", x => new { x.CommitteeId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_CommitteeStaff_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "CommitteeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommitteeStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyStaff",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStaff", x => new { x.PropertyId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_PropertyStaff_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    RefreshTokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TokenHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TokenSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RefreshTokenId);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "StaffCredentials",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    CredentialId = table.Column<int>(type: "int", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffCredentials", x => new { x.CredentialId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_StaffCredentials_Credentials_CredentialId",
                        column: x => x.CredentialId,
                        principalTable: "Credentials",
                        principalColumn: "CredentialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffCredentials_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffRoles",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRoles", x => new { x.RoleId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_StaffRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffRoles_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventEventTypes",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventEventTypes", x => new { x.EventId, x.EventTypeId });
                    table.ForeignKey(
                        name: "FK_EventEventTypes_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventEventTypes_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaSupplyItems",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    SupplyItemId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaSupplyItems", x => new { x.AreaId, x.SupplyItemId });
                    table.ForeignKey(
                        name: "FK_AreaSupplyItems_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaSupplyItems_SupplyItems_SupplyItemId",
                        column: x => x.SupplyItemId,
                        principalTable: "SupplyItems",
                        principalColumn: "SupplyItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffRefreshTokens",
                columns: table => new
                {
                    RefreshTokenId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRefreshTokens", x => new { x.RefreshTokenId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_StaffRefreshTokens_RefreshTokens_RefreshTokenId",
                        column: x => x.RefreshTokenId,
                        principalTable: "RefreshTokens",
                        principalColumn: "RefreshTokenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffRefreshTokens_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Address2", "City", "Country", "CreatedBy", "CreatedDate", "EmailAddress", "FaxNumber", "IsActive", "IsHidden", "Name", "Note", "PhoneNumber", "PostalCode", "State", "UpdatedBy", "UpdatedDate", "Website" },
                values: new object[,]
                {
                    { 1, "123 Main Street", "Suite 45", "Glendale", "US", "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1547), "Glendale@Srf.com", "333-333-3333", true, false, "Glendale Temple", "Currently, there are no notes", "222-222-2222", "91001", "CA", null, null, "https://www.glendaletemple.org" },
                    { 2, "456 Main Street", "Suite 65", "Encinitas", "US", "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1554), "Encinitas@Srf.com", "666-666-6666", true, false, "Encinitas Temple", "Currently, there are no notes", "555-555-5555", "92026", "CA", null, null, "https://www.encinitastemple.org" },
                    { 3, "789 Main Street", "Suite 22", "Fullerton", "US", "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1555), "Fullerton@Srf.com", "666-666-6666", true, false, "Fullterton Temple", "Currently, there are no notes", "555-555-5555", "92026", "CA", null, null, "https://www.fullertontemple.org" },
                    { 4, "222 South Street", "Suite 11", "San Diego", "US", "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1557), "SanDiego@Srf.com", "666-666-6666", true, false, "San Diego Temple", "Currently, there are no notes", "555-555-5555", "92026", "CA", null, null, "https://www.sandiegotemple.org" },
                    { 5, "444 South Street", "Suite 33", "Hollywood Diego", "US", "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1560), "Hollywood@Srf.com", "666-666-6666", true, false, "Hollywood Temple", "Currently, there are no notes", "555-555-5555", "92026", "CA", null, null, "https://www.hollywoodtemple.org" }
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "SupplyItemsAllowed", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6908), "This is the main temple area", true, false, "Main Temple", "There are no notes", 1, true, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6945), "This is the kitchen area", true, false, "Kitchen", "There are no notes", 1, true, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6964), "This is the bathroom area", true, false, "Bathroom", "There are no notes", 1, true, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6987), "This is the sunday school room area", true, false, "Sunday School Room", "There are no notes", 1, true, null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7011), "This is the parking lot area", true, false, "Parking Lot", "There are no notes", 1, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7041), "This is a garden tool category", true, false, "Garden Tool", "There are no notes", 1, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7061), "This is cleaning liquid category", true, false, "Cleaning Liquid", "There are no notes", 1, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7087), "This is gas powered tool category", true, false, "Gas Powered Tool", "There are no notes", 1, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7104), "This is literature category", true, false, "Literature", "There are no notes", 1, null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7120), "This is cleaning appliance category", true, false, "Cleaning Appliance", "There are no notes", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Committees",
                columns: new[] { "CommitteeId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7144), "Flowers Committee", true, false, "Flowers", "There are no notes", 1, null, null });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7173), "CRP Certification", true, false, "CPR", "There are no notes", 1, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7219), "First Aid Certification", true, false, "First Aid", "There are no notes", 1, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7251), "Drivers License", true, false, "Drivers License", "There are no notes", 1, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7268), "Drivers License", true, false, "Passport", "There are no notes", 1, null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7284), "Fork Lift Certification", true, false, "Fork Lift Certification", "There are no notes", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocumentId", "CreatedBy", "CreatedDate", "Description", "DocumentFileName", "DocumentImage", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7312), "A list of events for the year", null, null, true, false, "Annual Event List", "There are no notes", 1, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7333), "India Night event announcement", null, null, true, false, "India Night Announcement", "There are no notes", 1, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7480), "Masters Birthday event announcement", null, null, true, false, "Masters Birthday Announcement", "There are no notes", 1, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7497), "All Day Meditation event announcement", null, null, true, false, "All Day Meditation Announcement", "There are no notes", 1, null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7513), "All Day Christmas Meditation event announcement", null, null, true, false, "All Day Christmas Meditation Announcement", "There are no notes", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "EventTask",
                columns: new[] { "EventTaskId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7922), "Setting up tables", true, false, "Table setup", "There are no notes", 1, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7940), "Setting up chairs", true, false, "Chairs setup", "There are no notes", 1, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7956), "Cleaning toilets", true, false, "Toilets", "There are no notes", 1, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7973), "Mopping floors", true, false, "Mop Floors", "There are no notes", 1, null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7988), "Cleaning windows", true, false, "Clean Windows", "There are no notes", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "EventTypeId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7663), "Comemerative Service event", true, false, "Comemerative Service", "There are no notes", 1, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7813), "Birthday Service event", true, false, "Birthday", "There are no notes", 1, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7867), "Memorial Service event", true, false, "Memorial Service", "There are no notes", 1, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7884), "Wedding Service event", true, false, "Wedding Service", "There are no notes", 1, null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7900), "Christening Service event", true, false, "Christening Service", "There are no notes", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "AreaId", "CreatedBy", "CreatedDate", "Description", "EndDate", "Indefinite", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "StartDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7547), "Master's birthday celebration", new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7538), false, true, false, "Master's Birthday", "There are no notes", 1, new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7537), null, null },
                    { 2, null, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7577), "Krishna's birthday celebration", new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7568), false, true, false, "Krisha's Birthday", "There are no notes", 1, new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7568), null, null },
                    { 3, null, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7599), "Sri Yukteswar's birthday celebration", new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7598), false, true, false, "Sri Yukteswar's Birthday", "There are no notes", 1, new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7597), null, null },
                    { 4, null, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7618), "Mahavatar's birthday celebration", new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7617), false, true, false, "Mahatar Babaji's Birthday", "There are no notes", 1, new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7616), null, null },
                    { 5, null, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7637), "Jesus' birthday celebration", new DateTime(2022, 12, 17, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7636), false, true, false, "Jesus' Birthday", "There are no notes", 1, new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(7634), null, null }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "CreatedBy", "CreatedDate", "From", "IsActive", "IsHidden", "MessageSent", "PropertyId", "StaffId", "Subject", "To", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8013), "gerryhazelton@gmail.com", true, false, "This is my message to Jane Doe", 1, 1, "Hello Jane", "janedoe@gmail.com", null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8032), "gerryhazelton@gmail.com", true, false, "This is my message to John Doe", 1, 1, "Hello John", "johndoe@gmail.com", null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8048), "gerryhazelton@gmail.com", true, false, "This is my message to Master", 1, 1, "Hello Master", "master@gmail.com", null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8105), "gerryhazelton@gmail.com", true, false, "This is my message to Dolores", 1, 1, "Hello Dolores", "dolores@gmail.com", null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8191), "gerryhazelton@gmail.com", true, false, "This is my message to Seannie", 1, 1, "Hello Seannie", "seannie@gmail.com", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1741), "Admin role has full prviliedges", true, false, "Admin", null, 1, null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1743), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 1, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1744), "Admin role has full prviliedges", true, false, "Admin", null, 2, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1746), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 2, null, null },
                    { 5, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1747), "Admin role has full prviliedges", true, false, "Admin", null, 3, null, null },
                    { 6, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1748), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 3, null, null },
                    { 7, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1749), "Admin role has full prviliedges", true, false, "Admin", null, 4, null, null },
                    { 8, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1750), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 4, null, null },
                    { 9, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1751), "Admin role has full prviliedges", true, false, "Admin", null, 5, null, null },
                    { 10, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1752), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 5, null, null }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "AcceptTerms", "Address", "Address2", "CPR", "CanSendMessages", "CanViewDocuments", "City", "Country", "CreatedBy", "CreatedDate", "EmailAddress", "EmailConfirmed", "FirstAid", "FirstName", "Gender", "IsActive", "IsHidden", "IsLockedOut", "IsVerified", "Kriyaban", "LastName", "LessonStudent", "LoginAttempts", "MiddleName", "Note", "Password", "PasswordReset", "PasswordSalt", "PhoneNumber", "PostalCode", "PropertyId", "RememberMe", "StaffFileName", "StaffImage", "State", "UpdatedBy", "UpdatedDate", "VerifiedDate" },
                values: new object[,]
                {
                    { 1, true, "2141 Levante Street", "", true, true, false, "Carlsbad", "US", "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 49, 927, DateTimeKind.Utc).AddTicks(9087), "gerryhazelton@gmail.com", true, true, "Gerry", "Male", true, false, false, true, true, "Hazelton", true, 0, "Aloysius", null, "MPqhD4papxI6oWyw2QtYenj9c6oKmu9gcC2vY4ZKTNE=", null, "Fe7O+loKvHTHzzoxsnQzy3tSt7YtzOjdfjkjEULIctY=", "760-670-8026", "92009", 1, true, null, null, "CA", null, null, new DateTime(2022, 12, 16, 0, 11, 49, 833, DateTimeKind.Utc).AddTicks(1781) },
                    { 2, true, "2141 Leavnte Street", "", true, true, false, "Carlsbad", "US", "doloreshazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 22, DateTimeKind.Utc).AddTicks(5848), "doloreshazelton@gmail.com", true, true, "Dolores", "Female", true, false, false, true, true, "Hazelton", true, 0, "", null, "QmMUFV4PYEGM+T1Z+O4a7/Z0CfMUj3fNK87/TYArq1w=", null, "smuLnBO/HBB+4U99mMvKlB1MiX0HFWw5GlvSZi/A2mc=", "714-403-2333", "92009", 1, true, null, null, "CA", null, null, new DateTime(2022, 12, 16, 0, 11, 49, 927, DateTimeKind.Utc).AddTicks(9101) },
                    { 3, true, "924 Elyria Drive", "", true, true, false, "Los Angeles", "US", "seanniegibson@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(6351), "seanniegibson@gmail.com", true, true, "Seannie", "Female", true, false, false, true, true, "Gibson", true, 0, "", null, "r2S3yHanfEMxjUw+mwlZHwXKj0gBb4BZE61WgcdtzbY=", null, "ajhT+ByW73wxyMLPxm+bOyJuZ42OE0pT/3n8wmhY3zg=", "323-394-5332", "90065", 1, true, null, null, "CA", null, null, new DateTime(2022, 12, 16, 0, 11, 50, 22, DateTimeKind.Utc).AddTicks(6034) }
                });

            migrationBuilder.InsertData(
                table: "StaffRoles",
                columns: new[] { "RoleId", "StaffId", "PropertyId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 3, 1 },
                    { 4, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "SupplyItems",
                columns: new[] { "SupplyItemId", "BinNumber", "CategoryId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "Quantity", "SupplyItemFileName", "SupplyItemImage", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "23A", 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8224), "Flathead shovel", true, false, "Shovel", "No notes", 1, 5, null, null, null, null },
                    { 2, "24A", 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8245), "Flimsy rake", true, false, "Rake", "No notes", 1, 2, null, null, null, null },
                    { 3, "10C", 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8263), "Gas driven", true, false, "Lawn Mower", "No notes", 1, 1, null, null, null, null },
                    { 4, "13C", 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8280), "Pick", true, false, "Pick", "No notes", 1, 1, null, null, null, null },
                    { 5, "16B", 1, "gerryhazelton@gmail.com", new DateTime(2022, 12, 16, 0, 11, 50, 128, DateTimeKind.Utc).AddTicks(8297), "Gas driven", true, false, "Leaf Blower", "No notes", 1, 1, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaCommittees_CommitteeId",
                table: "AreaCommittees",
                column: "CommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaEventTasks_EventTaskId",
                table: "AreaEventTasks",
                column: "EventTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_PropertyId",
                table: "Areas",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaSupplyItems_SupplyItemId",
                table: "AreaSupplyItems",
                column: "SupplyItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PropertyId",
                table: "Categories",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Committees_PropertyId",
                table: "Committees",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_CommitteeStaff_StaffId",
                table: "CommitteeStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_PropertyId",
                table: "Credentials",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PropertyId",
                table: "Documents",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventEventTypes_EventTypeId",
                table: "EventEventTypes",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AreaId",
                table: "Events",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PropertyId",
                table: "Events",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTask_PropertyId",
                table: "EventTask",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypeAreas_AreaId",
                table: "EventTypeAreas",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_PropertyId",
                table: "EventTypes",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_PropertyId",
                table: "Messages",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyStaff_StaffId",
                table: "PropertyStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_PropertyId",
                table: "RefreshTokens",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_StaffId",
                table: "RefreshTokens",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_PropertyId",
                table: "Roles",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PropertyId",
                table: "Staff",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffCredentials_StaffId",
                table: "StaffCredentials",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffRefreshTokens_StaffId",
                table: "StaffRefreshTokens",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffRoles_StaffId",
                table: "StaffRoles",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyItems_CategoryId",
                table: "SupplyItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyItems_PropertyId",
                table: "SupplyItems",
                column: "PropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaCommittees");

            migrationBuilder.DropTable(
                name: "AreaEventTasks");

            migrationBuilder.DropTable(
                name: "AreaSupplyItems");

            migrationBuilder.DropTable(
                name: "CommitteeStaff");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ErrorLog");

            migrationBuilder.DropTable(
                name: "EventEventTypes");

            migrationBuilder.DropTable(
                name: "EventTypeAreas");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PropertyStaff");

            migrationBuilder.DropTable(
                name: "StaffCredentials");

            migrationBuilder.DropTable(
                name: "StaffRefreshTokens");

            migrationBuilder.DropTable(
                name: "StaffRoles");

            migrationBuilder.DropTable(
                name: "EventTask");

            migrationBuilder.DropTable(
                name: "SupplyItems");

            migrationBuilder.DropTable(
                name: "Committees");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}