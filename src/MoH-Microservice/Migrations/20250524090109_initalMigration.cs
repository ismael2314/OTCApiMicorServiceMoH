﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoH_Microservice.Migrations
{
    /// <inheritdoc />
    public partial class initalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hospital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegisteredBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganiztionalUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeePhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AssignedHospital = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UploadedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UploadedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganiztionalUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organiztions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organiztions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientAccedents",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MRN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accedentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accedentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    policeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    policePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    certificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAccedents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PatientAddress",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MRN = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    REFMRN = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Woreda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isNextOfKin = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAddress", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PatientRequestedServices",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MRN = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    service = table.Column<int>(type: "int", nullable: true),
                    purpose = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    isPaid = table.Column<int>(type: "int", nullable: true),
                    isComplete = table.Column<int>(type: "int", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRequestedServices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MRN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    motherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placeofbirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    multiplebirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    appointment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phonenumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    iscreadituser = table.Column<int>(type: "int", nullable: true),
                    iscbhiuser = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployementID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    educationlevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spouseFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spouselastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    visitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentChannels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Channel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentChannels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentCollections",
                columns: table => new
                {
                    CollectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollecterID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollectedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Casher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCollections", x => x.CollectionId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentCollectors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeePhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AssignedLocation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AssignedAs = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactMethod = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCollectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPurposes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MRN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    HospitalName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Channel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PaymentVerifingID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PatientWorkID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CBHIID = table.Column<long>(type: "bigint", maxLength: 100, nullable: true),
                    AccedentID = table.Column<long>(type: "bigint", maxLength: 100, nullable: true),
                    groupId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createdby = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsCollected = table.Column<int>(type: "int", nullable: true),
                    CollectionID = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provider = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    service = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvidersMapPatient",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provider = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    service = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MRN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kebele = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Goth = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IDNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReferalNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    letterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Examination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidersMapPatient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Departement", "Email", "EmailConfirmed", "Hospital", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "07077844-7aa8-49ba-8a0e-49fe3f851ec1", 0, "af08d136-f748-4700-a180-33b6a5dff438", "Tsedey Bank", "dereje.hmariam@tsedeybank.com.et", true, "", false, null, "DEREJE.HMARIAM@TSEDEYBANK.COM.ET", "DEREJEH", "AQAAAAIAAYagAAAAEI+w7Y2X3Ih+95WliGsPpuoA2D5aywlrZ75iPUQIGppw20WWH1g7AEi7S3r5sL8rOw==", "+251912657147", true, "de6e89fd-5ff0-4b0c-b95a-416c92e8c59e", false, "DerejeH", "Admin" });

            migrationBuilder.InsertData(
                table: "PaymentChannels",
                columns: new[] { "Id", "Channel", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "TeleBirr", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(445), null, null },
                    { 2, "CBE Mobile Banking", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(450), null, null },
                    { 3, "Awash Bank", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(454), null, null },
                    { 4, "Bank of Abyssinia", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(468), null, null },
                    { 5, "Amhara Bank", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(492), null, null },
                    { 6, "Tsedey Bank", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(495), null, null },
                    { 7, "Other", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(498), null, null },
                    { 8, "Chapa", "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(500), null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentPurposes",
                columns: new[] { "Id", "Amount", "CreatedBy", "CreatedOn", "Purpose", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(339), "Card/ካርድ", null, null },
                    { 2, null, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(342), "Medicne/መድሃኒት", null, null },
                    { 3, null, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(345), "Laboratory/ላብራቶሪ", null, null },
                    { 4, null, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(349), "Rag/X-RAY/ራጅ፣አልትራሳውንድ", null, null },
                    { 5, null, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(352), "Others/ሌሎች", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "type" },
                values: new object[,]
                {
                    { 1, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(193), null, null, "ALL" },
                    { 2, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(197), null, null, "CASH" },
                    { 3, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(200), null, null, "CBHI" },
                    { 4, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(202), null, null, "Credit" },
                    { 5, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(204), null, null, "Free of Charge" },
                    { 6, "SYS", new DateTime(2025, 5, 24, 12, 1, 7, 977, DateTimeKind.Local).AddTicks(212), null, null, "Digital" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "07077844-7aa8-49ba-8a0e-49fe3f851ec1" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_MRN",
                table: "PatientAddress",
                column: "MRN");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAddress_REFMRN",
                table: "PatientAddress",
                column: "REFMRN");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRequestedServices_groupId",
                table: "PatientRequestedServices",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRequestedServices_isComplete",
                table: "PatientRequestedServices",
                column: "isComplete");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRequestedServices_isPaid",
                table: "PatientRequestedServices",
                column: "isPaid");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRequestedServices_MRN",
                table: "PatientRequestedServices",
                column: "MRN");

            migrationBuilder.CreateIndex(
                name: "IX_PatientRequestedServices_purpose",
                table: "PatientRequestedServices",
                column: "purpose");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_firstName",
                table: "Patients",
                column: "firstName");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_lastName",
                table: "Patients",
                column: "lastName");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_middleName",
                table: "Patients",
                column: "middleName");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MRN",
                table: "Patients",
                column: "MRN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_phonenumber",
                table: "Patients",
                column: "phonenumber");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Createdby",
                table: "Payments",
                column: "Createdby");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_RefNo",
                table: "Payments",
                column: "RefNo");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_RefNo_Createdby",
                table: "Payments",
                columns: new[] { "RefNo", "Createdby" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "OrganiztionalUsers");

            migrationBuilder.DropTable(
                name: "Organiztions");

            migrationBuilder.DropTable(
                name: "PatientAccedents");

            migrationBuilder.DropTable(
                name: "PatientAddress");

            migrationBuilder.DropTable(
                name: "PatientRequestedServices");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PaymentChannels");

            migrationBuilder.DropTable(
                name: "PaymentCollections");

            migrationBuilder.DropTable(
                name: "PaymentCollectors");

            migrationBuilder.DropTable(
                name: "PaymentPurposes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "ProvidersMapPatient");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
