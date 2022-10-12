using System;
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
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
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
                    StaffImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Properties_PropertyId",
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Credentials",
                columns: table => new
                {
                    CredentialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CredentialFileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CredentialImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Credentials_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "PropertiesStaff",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertiesStaff", x => new { x.PropertyId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_PropertiesStaff_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertiesStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyStaff",
                columns: table => new
                {
                    PropertiesPropertyId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStaff", x => new { x.PropertiesPropertyId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_PropertyStaff_Properties_PropertiesPropertyId",
                        column: x => x.PropertiesPropertyId,
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
                    StaffId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Roles_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId");
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                name: "AreasEventTasks",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EventTaskId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasEventTasks", x => new { x.AreaId, x.EventTaskId });
                    table.ForeignKey(
                        name: "FK_AreasEventTasks_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreasEventTasks_EventTask_EventTaskId",
                        column: x => x.EventTaskId,
                        principalTable: "EventTask",
                        principalColumn: "EventTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreasEventTypes",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasEventTypes", x => new { x.AreaId, x.EventTypeId });
                    table.ForeignKey(
                        name: "FK_AreasEventTypes_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreasEventTypes_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventsEventTypes",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsEventTypes", x => new { x.EventId, x.EventTypeId });
                    table.ForeignKey(
                        name: "FK_EventsEventTypes_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventsEventTypes_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CredentialsStaff",
                columns: table => new
                {
                    CredentialId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialsStaff", x => new { x.CredentialId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_CredentialsStaff_Credentials_CredentialId",
                        column: x => x.CredentialId,
                        principalTable: "Credentials",
                        principalColumn: "CredentialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CredentialsStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokensStaff",
                columns: table => new
                {
                    RefreshTokenId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokensStaff", x => new { x.RefreshTokenId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_RefreshTokensStaff_RefreshTokens_RefreshTokenId",
                        column: x => x.RefreshTokenId,
                        principalTable: "RefreshTokens",
                        principalColumn: "RefreshTokenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefreshTokensStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolesStaff",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesStaff", x => new { x.RoleId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_RolesStaff_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreasSupplyItems",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    SupplyItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasSupplyItems", x => new { x.AreaId, x.SupplyItemId });
                    table.ForeignKey(
                        name: "FK_AreasSupplyItems_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreasSupplyItems_SupplyItems_SupplyItemId",
                        column: x => x.SupplyItemId,
                        principalTable: "SupplyItems",
                        principalColumn: "SupplyItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Address2", "City", "Country", "CreatedBy", "CreatedDate", "EmailAddress", "FaxNumber", "IsActive", "IsHidden", "Name", "Note", "PhoneNumber", "PostalCode", "State", "UpdatedBy", "UpdatedDate", "Website" },
                values: new object[,]
                {
                    { 1, "123 Main Street", "Suite 45", "Glendale", "US", "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3213), "Glendale@Srf.com", "333-333-3333", true, false, "Glendale Temple", "Currently, there are no notes", "222-222-2222", "91001", "CA", null, null, "https://www.glendaletemple.org" },
                    { 2, "456 Main Street", "Suite 65", "Encinitas", "US", "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3218), "Encinitas@Srf.com", "666-666-6666", true, false, "Encinitas Temple", "Currently, there are no notes", "555-555-5555", "92026", "CA", null, null, "https://www.encinitastemple.org" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "AcceptTerms", "Address", "Address2", "CPR", "CanSendMessages", "CanViewDocuments", "City", "Country", "CreatedBy", "CreatedDate", "EmailAddress", "EmailConfirmed", "FirstAid", "FirstName", "Gender", "IsActive", "IsHidden", "IsLockedOut", "IsVerified", "Kriyaban", "LastName", "LessonStudent", "LoginAttempts", "Note", "Password", "PasswordReset", "PasswordSalt", "PhoneNumber", "PostalCode", "PropertyId", "RememberMe", "StaffFileName", "StaffImage", "State", "UpdatedBy", "UpdatedDate", "VerifiedDate" },
                values: new object[,]
                {
                    { 1, true, "123 Main Street", "Apt. B", true, true, false, "Carlsbad", "US", "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3419), "gerryhazelton@gmail.com", true, true, "Gerry", "Male", true, false, false, true, true, "Hazelton", true, 0, null, "OLpa5mnXgMZyfwlSkiHI2/enbMo4iTQkPpE9+xYHMEI=", null, "371952==", "760-444-4444", "92009", 1, true, null, null, "CA", null, null, new DateTime(2022, 10, 11, 5, 25, 4, 828, DateTimeKind.Local).AddTicks(3415) },
                    { 2, true, "123 Main Street", "Apt. B", true, true, false, "Carlsbad", "US", "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3428), "gerryhazelton@gmail.com", false, true, "Gerry", "Male", true, false, false, true, true, "Hazelton", true, 0, null, "OLpa5mnXgMZyfwlSkiHI2/enbMo4iTQkPpE9+xYHMEI=", null, "371952==", "760-444-4444", "92009", 2, true, null, null, "CA", null, null, new DateTime(2022, 10, 11, 5, 25, 4, 828, DateTimeKind.Local).AddTicks(3425) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3470), "This is a garden tool category", true, false, "Garden Tool", "There are no notes", 1, null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "StaffId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3372), "Admin role has full prviliedges", true, false, "Admin", null, 1, null, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3376), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 1, null, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3379), "Admin role has full prviliedges", true, false, "Admin", null, 2, null, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3383), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "SupplyItems",
                columns: new[] { "SupplyItemId", "BinNumber", "CategoryId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "Quantity", "SupplyItemFileName", "SupplyItemImage", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "23A", 1, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3492), "Flathead shovel", true, false, "Shovel", "No notes", 1, 5, null, null, null, null },
                    { 2, "24A", 1, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3509), "Flimsy rake", true, false, "Rake", "No notes", 1, 2, null, null, null, null },
                    { 3, "10C", 1, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3524), "Gas driven", true, false, "Lawn Mower", "No notes", 1, 1, null, null, null, null },
                    { 4, "13C", 1, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3537), "Pick", true, false, "Pick", "No notes", 1, 1, null, null, null, null },
                    { 5, "16B", 1, "gerryhazelton@gmail.com", new DateTime(2022, 10, 11, 12, 25, 4, 828, DateTimeKind.Utc).AddTicks(3550), "Gas driven", true, false, "Leaf Blower", "No notes", 1, 1, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_PropertyId",
                table: "Areas",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasEventTasks_EventTaskId",
                table: "AreasEventTasks",
                column: "EventTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasEventTypes_EventTypeId",
                table: "AreasEventTypes",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AreasSupplyItems_SupplyItemId",
                table: "AreasSupplyItems",
                column: "SupplyItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PropertyId",
                table: "Categories",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_PropertyId",
                table: "Credentials",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_StaffId",
                table: "Credentials",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_CredentialsStaff_StaffId",
                table: "CredentialsStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PropertyId",
                table: "Documents",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PropertyId",
                table: "Events",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventsEventTypes_EventTypeId",
                table: "EventsEventTypes",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTask_PropertyId",
                table: "EventTask",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_PropertyId",
                table: "EventTypes",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_PropertyId",
                table: "Messages",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesStaff_StaffId",
                table: "PropertiesStaff",
                column: "StaffId");

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
                name: "IX_RefreshTokensStaff_StaffId",
                table: "RefreshTokensStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_PropertyId",
                table: "Roles",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_StaffId",
                table: "Roles",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesStaff_StaffId",
                table: "RolesStaff",
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
                name: "AreasEventTasks");

            migrationBuilder.DropTable(
                name: "AreasEventTypes");

            migrationBuilder.DropTable(
                name: "AreasSupplyItems");

            migrationBuilder.DropTable(
                name: "CredentialsStaff");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ErrorLog");

            migrationBuilder.DropTable(
                name: "EventsEventTypes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PropertiesStaff");

            migrationBuilder.DropTable(
                name: "PropertyStaff");

            migrationBuilder.DropTable(
                name: "RefreshTokensStaff");

            migrationBuilder.DropTable(
                name: "RolesStaff");

            migrationBuilder.DropTable(
                name: "EventTask");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "SupplyItems");

            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
