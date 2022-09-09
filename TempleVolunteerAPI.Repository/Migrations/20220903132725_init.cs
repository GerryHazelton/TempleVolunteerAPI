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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                name: "ErrorLog",
                columns: table => new
                {
                    ErrorLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FunctionName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StackTrace = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Environment = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLog", x => x.ErrorLogId);
                    table.ForeignKey(
                        name: "FK_ErrorLog_Properties_PropertyId",
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                name: "EventTasks",
                columns: table => new
                {
                    EventTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTasks", x => x.EventTaskId);
                    table.ForeignKey(
                        name: "FK_EventTasks_Properties_PropertyId",
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RefreshTokenId);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId");
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
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
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
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
                name: "CredentialStaff",
                columns: table => new
                {
                    CredentialId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredentialStaff", x => new { x.CredentialId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_CredentialStaff_Credentials_CredentialId",
                        column: x => x.CredentialId,
                        principalTable: "Credentials",
                        principalColumn: "CredentialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CredentialStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaEvenTask",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EventTaskId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaEvenTask", x => new { x.AreaId, x.EventTaskId });
                    table.ForeignKey(
                        name: "FK_AreaEvenTask_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaEvenTask_EventTasks_EventTaskId",
                        column: x => x.EventTaskId,
                        principalTable: "EventTasks",
                        principalColumn: "EventTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaEvenType",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaEvenType", x => new { x.AreaId, x.EventTypeId });
                    table.ForeignKey(
                        name: "FK_AreaEvenType_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaEvenType_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventEventType",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventEventType", x => new { x.EventId, x.EventTypeId });
                    table.ForeignKey(
                        name: "FK_EventEventType_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventEventType_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleStaff",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleStaff", x => new { x.RoleId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_RoleStaff_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaSupplyItem",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    SupplyItemId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaSupplyItem", x => new { x.AreaId, x.SupplyItemId });
                    table.ForeignKey(
                        name: "FK_AreaSupplyItem_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaSupplyItem_SupplyItems_SupplyItemId",
                        column: x => x.SupplyItemId,
                        principalTable: "SupplyItems",
                        principalColumn: "SupplyItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Address2", "City", "Country", "CreatedBy", "CreatedDate", "EmailAddress", "FaxNumber", "IsActive", "IsHidden", "Name", "Note", "PhoneNumber", "PostalCode", "State", "UpdatedBy", "UpdatedDate", "Website" },
                values: new object[] { 1, "123 Main Street", "Suite 45", "Glendale", "US", "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7033), "Glendale@Srf.com", "333-333-3333", true, false, "Glendale Temple", "Currently, there are no notes", "222-222-2222", "91001", "CA", null, null, "https://www.glendaletemple.org" });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "Address2", "City", "Country", "CreatedBy", "CreatedDate", "EmailAddress", "FaxNumber", "IsActive", "IsHidden", "Name", "Note", "PhoneNumber", "PostalCode", "State", "UpdatedBy", "UpdatedDate", "Website" },
                values: new object[] { 2, "456 Main Street", "Suite 65", "Encinitas", "US", "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7070), "Encinitas@Srf.com", "666-666-6666", true, false, "Encinitas Temple", "Currently, there are no notes", "555-555-5555", "92026", "CA", null, null, "https://www.encinitastemple.org" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "AcceptTerms", "Address", "Address2", "CPR", "CanSendMessages", "CanViewDocuments", "City", "Country", "CreatedBy", "CreatedDate", "EmailAddress", "EmailConfirmed", "FirstAid", "FirstName", "Gender", "IsActive", "IsHidden", "IsLockedOut", "IsVerified", "Kriyaban", "LastName", "LessonStudent", "LoginAttempts", "Note", "Password", "PasswordReset", "PasswordSalt", "PhoneNumber", "PostalCode", "RememberMe", "StaffFileName", "StaffImage", "State", "UpdatedBy", "UpdatedDate", "VerifiedDate" },
                values: new object[] { 1, true, "123 Main Street", "Apt. B", true, true, false, "Carlsbad", "US", "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7301), "gerryhazelton@gmail.com", false, true, "Gerry", "Male", true, false, false, true, true, "Hazelton", true, 0, null, "OLpa5mnXgMZyfwlSkiHI2/enbMo4iTQkPpE9+xYHMEI=", null, "371952==", "760-444-4444", "92009", true, null, null, "CA", null, null, new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "SupplyItemsAllowed", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7329), "This is the main temple area", true, false, "Main Temple", "There are no notes", 1, true, null, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7346), "This is a garden tool category", true, false, "Garden Tool", "There are no notes", 1, null, null });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "CredentialId", "CompletedDate", "CreatedBy", "CreatedDate", "CredentialFileName", "CredentialImage", "Description", "ExpireDate", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7361), "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7364), null, null, "CRP Certification", null, true, false, "CPR", "There are no notes", 1, null, null });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocumentId", "CreatedBy", "CreatedDate", "Description", "DocumentFileName", "DocumentImage", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7380), "A list of events for the year", null, null, true, false, "Annual Event List", "There are no notes", 1, null, null });

            migrationBuilder.InsertData(
                table: "EventTasks",
                columns: new[] { "EventTaskId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7415), "Setting up tables", true, false, "Table setup", "There are no notes", 1, null, null });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "EventTypeId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7430), "Birthday event", true, false, "Birthday", "There are no notes", 1, null, null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "CreatedBy", "CreatedDate", "Description", "EndDate", "Indefinite", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "StartDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7400), "Master's birthday celebration", new DateTime(2022, 9, 4, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7397), false, true, false, "Master's Birthday", "There are no notes", 1, new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7395), null, null });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "CreatedBy", "CreatedDate", "From", "IsActive", "IsHidden", "MessageSent", "PropertyId", "StaffId", "Subject", "To", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7445), "gerryhazelton@gmail.com", true, false, "This is my message", 1, 1, "Hello", "janedoe@gmail.com", null, null });

            migrationBuilder.InsertData(
                table: "PropertyStaff",
                columns: new[] { "PropertyId", "StaffId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7250), "Admin role has full prviliedges", true, false, "Admin", null, 1, null, null },
                    { 2, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7254), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 1, null, null },
                    { 3, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7257), "Admin role has full prviliedges", true, false, "Admin", null, 2, null, null },
                    { 4, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7259), "Volunteer has limited prviliedges", true, false, "Volunteer", null, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "AreaEvenTask",
                columns: new[] { "AreaId", "EventTaskId", "PropertyId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "AreaEvenType",
                columns: new[] { "AreaId", "EventTypeId", "PropertyId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "CredentialStaff",
                columns: new[] { "CredentialId", "StaffId", "PropertyId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "EventEventType",
                columns: new[] { "EventId", "EventTypeId", "PropertyId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "RoleStaff",
                columns: new[] { "RoleId", "StaffId", "PropertyId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "SupplyItems",
                columns: new[] { "SupplyItemId", "BinNumber", "CategoryId", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsHidden", "Name", "Note", "PropertyId", "Quantity", "SupplyItemFileName", "SupplyItemImage", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "23A", 1, "gerryhazelton@gmail.com", new DateTime(2022, 9, 3, 6, 27, 24, 693, DateTimeKind.Local).AddTicks(7464), "Flathead shovel", true, false, "Shovel", null, 1, 5, null, null, null, null });

            migrationBuilder.InsertData(
                table: "AreaSupplyItem",
                columns: new[] { "AreaId", "SupplyItemId", "PropertyId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AreaEvenTask_EventTaskId",
                table: "AreaEvenTask",
                column: "EventTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaEvenType_EventTypeId",
                table: "AreaEvenType",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_PropertyId",
                table: "Areas",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaSupplyItem_SupplyItemId",
                table: "AreaSupplyItem",
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
                name: "IX_CredentialStaff_StaffId",
                table: "CredentialStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PropertyId",
                table: "Documents",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ErrorLog_PropertyId",
                table: "ErrorLog",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventEventType_EventTypeId",
                table: "EventEventType",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PropertyId",
                table: "Events",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTasks_PropertyId",
                table: "EventTasks",
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
                name: "IX_RoleStaff_StaffId",
                table: "RoleStaff",
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
                name: "AreaEvenTask");

            migrationBuilder.DropTable(
                name: "AreaEvenType");

            migrationBuilder.DropTable(
                name: "AreaSupplyItem");

            migrationBuilder.DropTable(
                name: "CredentialStaff");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ErrorLog");

            migrationBuilder.DropTable(
                name: "EventEventType");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PropertyStaff");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "RoleStaff");

            migrationBuilder.DropTable(
                name: "EventTasks");

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
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
