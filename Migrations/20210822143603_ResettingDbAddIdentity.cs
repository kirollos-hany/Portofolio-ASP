using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portofolio.Migrations
{
    public partial class ResettingDbAddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "contactstatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactstatuses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "imagetypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImgType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagetypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "linktypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LinkType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linktypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "projecttypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projecttypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServiceName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceDescription = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceImage = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "userrolesinproject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Role = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userrolesinproject", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(320)", maxLength: 320, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Message = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                    table.ForeignKey(
                        name: "contacts_ibfk_1",
                        column: x => x.StatusId,
                        principalTable: "contactstatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "userlinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userlinks", x => x.Id);
                    table.ForeignKey(
                        name: "userlinks_ibfk_1",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "userlinks_ibfk_2",
                        column: x => x.TypeId,
                        principalTable: "linktypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Id);
                    table.ForeignKey(
                        name: "projects_ibfk_1",
                        column: x => x.TypeId,
                        principalTable: "projecttypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "RequestedServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestedServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestedServices_contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestedServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "projectfeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectfeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "projectfeedbacks_ibfk_1",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "projectimages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectimages", x => x.Id);
                    table.ForeignKey(
                        name: "projectimages_ibfk_1",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "projectimages_ibfk_2",
                        column: x => x.TypeId,
                        principalTable: "imagetypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "projectlinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectlinks", x => x.Id);
                    table.ForeignKey(
                        name: "projectlinks_ibfk_1",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "projectlinks_ibfk_2",
                        column: x => x.TypeId,
                        principalTable: "linktypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ProjectTools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ToolUsed = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTools_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "usersinprojects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usersinprojects", x => x.Id);
                    table.ForeignKey(
                        name: "usersinprojects_ibfk_1",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "usersinprojects_ibfk_2",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "usersinprojects_ibfk_3",
                        column: x => x.RoleId,
                        principalTable: "userrolesinproject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "ImagePath", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 20, 0, "72f591d8-afeb-4524-9b2d-84bd30c96a6d", new DateTime(2021, 8, 22, 16, 36, 2, 316, DateTimeKind.Local).AddTicks(6869), "jade_bergnaum@kuhic.uk", false, "Illo molestiae totam hic sint sed qui iure quaerat possimus.", false, null, null, null, "287-83-6563", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 316, DateTimeKind.Local).AddTicks(6872), "Prof. Grover Dare Sr." },
                    { 14, 0, "82d164bc-2dee-4b34-b05d-251ba4377070", new DateTime(2021, 8, 22, 16, 36, 2, 314, DateTimeKind.Local).AddTicks(3231), "amiya@rath.info", false, "Dolorum adipisci qui sunt ad magnam rem.", false, null, null, null, "321-16-2876", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 314, DateTimeKind.Local).AddTicks(3240), "Mrs. Everardo Ryan Sawayn" },
                    { 15, 0, "573ab7f9-0877-4a79-bd8f-277e4653e919", new DateTime(2021, 8, 22, 16, 36, 2, 314, DateTimeKind.Local).AddTicks(8074), "jerome@rempel.ca", false, "Sed perferendis quos corrupti velit. Molestiae corporis quaerat expedita. Aspernatur voluptatem sed et est aut quo molestiae omnis illum.", false, null, null, null, "325-75-5121", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 314, DateTimeKind.Local).AddTicks(8082), "Garland Kozey" },
                    { 16, 0, "f92e8583-1bbf-4890-ad6e-ecc40d53a505", new DateTime(2021, 8, 22, 16, 36, 2, 315, DateTimeKind.Local).AddTicks(3962), "jeff_kozey@schimmel.info", false, "Soluta sed sed eius corrupti qui expedita quas laborum qui. Voluptas nostrum assumenda necessitatibus alias et. Optio fugit vel suscipit modi laboriosam perspiciatis aut.", false, null, null, null, "505-06-1537", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 315, DateTimeKind.Local).AddTicks(3982), "Mr. Ashley Marlin Sporer" },
                    { 17, 0, "c8a5f52d-14b8-418e-b603-2a7d88475bfa", new DateTime(2021, 8, 22, 16, 36, 2, 315, DateTimeKind.Local).AddTicks(6513), "justice@funkschultz.us", false, "Qui maxime doloribus dolores illum facilis itaque et nemo saepe.", false, null, null, null, "128-58-2084", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 315, DateTimeKind.Local).AddTicks(6517), "Fae Volkman" },
                    { 18, 0, "94e7b51a-5418-4113-ac80-9f6d3941bf2d", new DateTime(2021, 8, 22, 16, 36, 2, 316, DateTimeKind.Local).AddTicks(692), "maybell_mckenzie@kirlin.info", false, "Voluptate quaerat rerum et dolor iste et aliquid. Odit nemo eos sapiente sunt unde aut consequatur soluta enim. Doloribus aut aperiam voluptas autem natus molestiae laborum. Qui qui voluptatem iste velit nobis vitae quia consequatur numquam.", false, null, null, null, "245-04-1120", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 316, DateTimeKind.Local).AddTicks(697), "Lindsey Kozey" },
                    { 19, 0, "a19ecb2c-62d2-42cb-b96b-d905d1a70262", new DateTime(2021, 8, 22, 16, 36, 2, 316, DateTimeKind.Local).AddTicks(4050), "shanny@mann.com", false, "Praesentium odio eum ratione voluptate. Dolorem sapiente explicabo labore voluptatem quisquam. Dolore eaque temporibus quisquam. Fugiat qui et ex occaecati.", false, null, null, null, "177-79-5551", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 316, DateTimeKind.Local).AddTicks(4053), "Mrs. Lauren Bins" },
                    { 39, 0, "9aa440c7-5095-414d-8036-41f9f4ed68ad", new DateTime(2021, 8, 22, 16, 36, 2, 324, DateTimeKind.Local).AddTicks(2585), "jovanny.murazik@roobkub.ca", false, "Fugiat qui voluptatem eligendi ut qui natus ab. Aut est amet et id dolor fugiat. Placeat atque iure asperiores soluta mollitia et nobis magni quod. Laboriosam et voluptas omnis.", false, null, null, null, "390-57-4944", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 324, DateTimeKind.Local).AddTicks(2589), "Haskell Konopelski" },
                    { 21, 0, "09079ab0-1e2c-4757-b4d8-faa90deb41d0", new DateTime(2021, 8, 22, 16, 36, 2, 317, DateTimeKind.Local).AddTicks(141), "claudine.towne@cartwrightlang.co.uk", false, "Consequatur illo iure neque minus corrupti et consequatur ex. Qui rerum non quo nesciunt vel dignissimos hic debitis. Sunt consequatur ex rem.", false, null, null, null, "554-71-4394", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 317, DateTimeKind.Local).AddTicks(149), "Prof. Damaris Waelchi" },
                    { 22, 0, "43f52cb2-24de-4b78-a773-7988079a7523", new DateTime(2021, 8, 22, 16, 36, 2, 317, DateTimeKind.Local).AddTicks(3097), "lorena_mayer@swaniawskiroberts.us", false, "Ut officiis distinctio placeat officia laudantium sequi est occaecati similique. Qui et repellendus cumque voluptas.", false, null, null, null, "574-46-2988", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 317, DateTimeKind.Local).AddTicks(3104), "Ms. Kaylin Ledner" },
                    { 23, 0, "8257acef-d271-4bca-a7ca-5c7f9c351ea8", new DateTime(2021, 8, 22, 16, 36, 2, 317, DateTimeKind.Local).AddTicks(6743), "ara@parkerdaugherty.name", false, "Numquam a est occaecati totam dolores voluptatem modi totam odio. Laborum totam accusamus ex molestiae. Eum illum dolorem quia consequatur et et rem dignissimos ea. Ea sint unde eos corporis.", false, null, null, null, "405-06-7223", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 317, DateTimeKind.Local).AddTicks(6747), "Osborne Botsford II" },
                    { 24, 0, "8f78378f-d877-466c-996c-7040c858aeff", new DateTime(2021, 8, 22, 16, 36, 2, 318, DateTimeKind.Local).AddTicks(629), "kayden@reichert.com", false, "Ea quisquam saepe provident amet voluptatem. Sit et non aut tempora. Officiis eos vel repellat reiciendis quibusdam quis qui facilis. Sed iure unde consectetur sunt voluptatem consectetur consequatur quasi consequatur.", false, null, null, null, "505-32-9865", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 318, DateTimeKind.Local).AddTicks(640), "Magdalen Pollich" },
                    { 25, 0, "76b07fff-253d-4988-b588-6d8709ab6449", new DateTime(2021, 8, 22, 16, 36, 2, 318, DateTimeKind.Local).AddTicks(5631), "christine_bernhard@hesselbogisich.name", false, "Est temporibus quaerat vitae ex suscipit quaerat. Quaerat molestiae quis numquam non et laboriosam. Quas ipsa autem ut et incidunt et quia ut fugiat.", false, null, null, null, "180-06-3164", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 318, DateTimeKind.Local).AddTicks(5638), "Cortez Yundt" },
                    { 26, 0, "2a201f8e-076d-46ab-bc41-b3cd6cb98f6d", new DateTime(2021, 8, 22, 16, 36, 2, 319, DateTimeKind.Local).AddTicks(6967), "hilda_sawayn@beierluettgen.biz", false, "Temporibus quisquam expedita modi repellat aliquam animi aut pariatur. Quibusdam facere dolores illo culpa praesentium mollitia ratione. Nisi nobis itaque et.", false, null, null, null, "385-59-8746", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 319, DateTimeKind.Local).AddTicks(6988), "Liam Schultz" },
                    { 27, 0, "09e604fb-be6b-4e37-9540-b974bb25fbaa", new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(162), "loyce.turner@nikolauswilderman.info", false, "Consequatur ea inventore libero.", false, null, null, null, "592-31-9186", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(168), "Uriel Nader" },
                    { 28, 0, "b9adfd0e-c77b-4414-b64e-f1dda4223df5", new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(4484), "minnie_parker@wehner.us", false, "Nisi sint sunt omnis nam dolores qui quae velit. Accusamus at sed et culpa sit voluptatem expedita provident exercitationem.", false, null, null, null, "333-82-9345", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(4492), "Corene Prosacco" },
                    { 29, 0, "7450a5d6-6ab8-470c-8528-8dc9f0f8ca93", new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(6952), "larue@schultzmosciski.info", false, "Quas eum qui quod sunt sit hic voluptas quidem.", false, null, null, null, "096-84-8530", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(6955), "Montana Kemmer" },
                    { 30, 0, "965f11b3-c88e-417d-a284-3c75389a3666", new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(9882), "dolores_koelpin@lindgren.ca", false, "Quia sit officia consequatur illum quasi. Maxime aut aliquid omnis quod eveniet ipsa doloremque illum.", false, null, null, null, "462-55-8590", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 320, DateTimeKind.Local).AddTicks(9885), "Jimmy Streich" },
                    { 31, 0, "992dd423-43ab-45ca-bd4d-c4615044cdd3", new DateTime(2021, 8, 22, 16, 36, 2, 321, DateTimeKind.Local).AddTicks(3672), "trevion.dubuque@walter.name", false, "Qui a culpa aliquid. At dicta ut rerum aut delectus sit enim. Quo totam a sapiente.", false, null, null, null, "237-84-3084", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 321, DateTimeKind.Local).AddTicks(3675), "Dr. Laurie Casper Reilly" },
                    { 32, 0, "eed5424d-bfcd-4fd0-a8b3-05d9d8d902fe", new DateTime(2021, 8, 22, 16, 36, 2, 321, DateTimeKind.Local).AddTicks(6293), "elton@veum.uk", false, "Molestiae minima ea est ad voluptatibus commodi amet recusandae qui. Consequatur aspernatur sit quaerat non.", false, null, null, null, "563-30-5987", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 321, DateTimeKind.Local).AddTicks(6306), "Albert Barton" },
                    { 33, 0, "e77ff185-93f7-4f55-84ee-7ed3a5d09092", new DateTime(2021, 8, 22, 16, 36, 2, 321, DateTimeKind.Local).AddTicks(9880), "michale_raynor@corkery.ca", false, "Ipsam pariatur at et rerum ea reiciendis aliquid harum. Vitae officiis voluptatem voluptatibus et natus blanditiis minima quibusdam occaecati. Sunt accusamus autem est.", false, null, null, null, "393-92-8412", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 321, DateTimeKind.Local).AddTicks(9894), "Ms. Nigel Abshire" },
                    { 34, 0, "edd53445-576d-408d-b695-4f9d66963659", new DateTime(2021, 8, 22, 16, 36, 2, 322, DateTimeKind.Local).AddTicks(5439), "christopher@hahn.name", false, "Impedit accusantium libero perferendis est. In error provident voluptatem sed. Nihil laborum dolorem in quia reiciendis adipisci ipsa et.", false, null, null, null, "493-80-7704", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 322, DateTimeKind.Local).AddTicks(5447), "Miss Noe Jewell Jerde" },
                    { 35, 0, "5816bd68-e1f5-42c5-9372-36e8a42d6d05", new DateTime(2021, 8, 22, 16, 36, 2, 322, DateTimeKind.Local).AddTicks(8987), "hassan@mraz.com", false, "Est fugit magnam est assumenda corporis at fugit voluptate aliquam. Aut repellat at quo at molestiae similique.", false, null, null, null, "081-11-1219", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 322, DateTimeKind.Local).AddTicks(8995), "Mr. Gayle Marvin" },
                    { 36, 0, "6c589a23-9357-4aa6-b350-69b3fcbdedc3", new DateTime(2021, 8, 22, 16, 36, 2, 323, DateTimeKind.Local).AddTicks(2811), "mariela@bins.ca", false, "Commodi quae sint eum pariatur recusandae rerum ut quo. Ipsa pariatur tempora laboriosam eos consequatur. Asperiores itaque dolores modi repellat tempora optio in. Consequuntur consectetur repellendus maxime ea nostrum.", false, null, null, null, "052-97-1955", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 323, DateTimeKind.Local).AddTicks(2816), "John Greenholt III" },
                    { 13, 0, "9335a3cf-2496-4f13-a3e7-00d92879712c", new DateTime(2021, 8, 22, 16, 36, 2, 313, DateTimeKind.Local).AddTicks(8866), "freddy@gibsonnienow.biz", false, "Qui maiores et consequuntur neque impedit non aliquid. Minus necessitatibus laboriosam illo aperiam reprehenderit earum. Expedita ut tempore libero in consequatur quisquam quis molestiae. Quidem aut minus impedit consequatur.", false, null, null, null, "535-27-1679", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 313, DateTimeKind.Local).AddTicks(8876), "Laverne Ryan II" },
                    { 37, 0, "524b4b23-918c-415f-ae42-c7730b174cc2", new DateTime(2021, 8, 22, 16, 36, 2, 323, DateTimeKind.Local).AddTicks(6077), "gracie@greenfelderlesch.com", false, "Ipsa dolorum earum in quibusdam inventore ipsum aperiam. Unde quo non enim velit. Voluptatem ut veniam eius officiis.", false, null, null, null, "509-58-2689", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 323, DateTimeKind.Local).AddTicks(6085), "Gabe McKenzie Sr." },
                    { 12, 0, "2caaf083-aa74-4d43-8c2d-f8a9a8b828d9", new DateTime(2021, 8, 22, 16, 36, 2, 313, DateTimeKind.Local).AddTicks(3448), "javon@heathcotecorwin.uk", false, "Ipsum quia minus rerum nesciunt impedit beatae. Illum rerum aut ipsam ut consequuntur id. Repellat facilis molestiae quam libero possimus cumque dolores dolorem perferendis. Praesentium non quia placeat rem quod quod.", false, null, null, null, "639-31-0281", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 313, DateTimeKind.Local).AddTicks(3458), "Prof. Keely O'Hara" },
                    { 10, 0, "36183867-8bbc-4a33-8865-5d99bb50172b", new DateTime(2021, 8, 22, 16, 36, 2, 312, DateTimeKind.Local).AddTicks(3134), "hilma_kerluke@bosco.name", false, "Vel esse aspernatur ut autem reiciendis asperiores soluta corporis vel. Expedita et et rem eveniet provident.", false, null, null, null, "071-14-5860", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 312, DateTimeKind.Local).AddTicks(3145), "Marion Bethany Carter V" },
                    { 50, 0, "1b19016e-1279-4206-b0b4-78d4b1f2dc85", new DateTime(2021, 8, 22, 16, 36, 2, 328, DateTimeKind.Local).AddTicks(2684), "heidi_thiel@ernser.com", false, "Qui dolor et perferendis.", false, null, null, null, "297-19-3740", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 328, DateTimeKind.Local).AddTicks(2688), "Herta Towne" },
                    { 49, 0, "969dfb5e-5959-46e7-a65f-03863cf85da8", new DateTime(2021, 8, 22, 16, 36, 2, 328, DateTimeKind.Local).AddTicks(412), "eugenia@kub.com", false, "Sapiente id repudiandae adipisci est nesciunt molestiae eius et. Nulla odio iusto et. Nihil sed qui autem voluptas perspiciatis.", false, null, null, null, "550-95-5329", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 328, DateTimeKind.Local).AddTicks(419), "Lee Reinger" },
                    { 48, 0, "df17e5fe-1e95-42d6-9f90-97ef017c7297", new DateTime(2021, 8, 22, 16, 36, 2, 327, DateTimeKind.Local).AddTicks(6920), "efrain@gulgowski.biz", false, "Accusamus est sapiente voluptatem sint blanditiis error provident perferendis. Qui provident earum tenetur.", false, null, null, null, "458-42-7229", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 327, DateTimeKind.Local).AddTicks(6927), "Abbey Verner Schultz DVM" },
                    { 47, 0, "18a59e6a-74ad-44f8-b4a9-3477cbec6f41", new DateTime(2021, 8, 22, 16, 36, 2, 327, DateTimeKind.Local).AddTicks(3130), "evert@collier.co.uk", false, "Molestias cum soluta aut voluptatem nulla qui delectus. Quas ullam aut vel repudiandae optio.", false, null, null, null, "334-73-6669", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 327, DateTimeKind.Local).AddTicks(3139), "Adonis Hyatt PhD" },
                    { 46, 0, "b20fa2c2-49c9-458d-84e2-a66e9551591b", new DateTime(2021, 8, 22, 16, 36, 2, 327, DateTimeKind.Local).AddTicks(111), "rolando_zemlak@boehm.co.uk", false, "Ea doloremque necessitatibus dolor nihil odio et odio. Sint cum fugit voluptate voluptas. Aut non porro labore. Et inventore sed culpa.", false, null, null, null, "518-18-3353", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 327, DateTimeKind.Local).AddTicks(113), "Eulah Moen" },
                    { 45, 0, "98bc9612-588c-47b2-bf84-b92de31c05e6", new DateTime(2021, 8, 22, 16, 36, 2, 326, DateTimeKind.Local).AddTicks(6993), "stanford_oconner@nienow.us", false, "Voluptatem dolores ut veritatis commodi exercitationem.", false, null, null, null, "444-37-9403", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 326, DateTimeKind.Local).AddTicks(6997), "Bryce Lockman" },
                    { 44, 0, "52595577-277f-46ac-8406-9b35b37de82d", new DateTime(2021, 8, 22, 16, 36, 2, 326, DateTimeKind.Local).AddTicks(4310), "jerome@gloverfisher.co.uk", false, "Corrupti est quia quod voluptatem est qui sed autem eum. Dolor quia quo dolorum. Et voluptas quibusdam quae beatae. Necessitatibus vitae accusantium voluptatibus eum quas.", false, null, null, null, "603-95-1713", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 326, DateTimeKind.Local).AddTicks(4319), "Lonny Lavon Collier DVM" },
                    { 43, 0, "2e03f7ec-15c1-4900-9d2c-d32b27297abf", new DateTime(2021, 8, 22, 16, 36, 2, 325, DateTimeKind.Local).AddTicks(9460), "lindsey.lockman@swift.us", false, "Quaerat dolorem dolor magni. Voluptates et aut nihil. Et magni et saepe sunt magnam illum et.", false, null, null, null, "376-45-5648", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 325, DateTimeKind.Local).AddTicks(9467), "Amani Samson Rowe IV" },
                    { 42, 0, "c6175c5f-8152-4570-9c5d-aa7ccb23af2e", new DateTime(2021, 8, 22, 16, 36, 2, 325, DateTimeKind.Local).AddTicks(5100), "delores_okeefe@wuckertnikolaus.biz", false, "Id aut et sint velit ex dicta occaecati aliquam necessitatibus. Distinctio et commodi omnis aperiam. Laboriosam ratione quia repudiandae nesciunt repellendus exercitationem.", false, null, null, null, "544-51-8911", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 325, DateTimeKind.Local).AddTicks(5114), "Mr. Eula Welch" },
                    { 41, 0, "ff58e2f1-abc7-4e0b-af5d-082c9d8e980c", new DateTime(2021, 8, 22, 16, 36, 2, 325, DateTimeKind.Local).AddTicks(237), "orville@reinger.com", false, "Eius vitae et accusantium dolorem quaerat facere blanditiis repudiandae.", false, null, null, null, "270-70-1845", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 325, DateTimeKind.Local).AddTicks(246), "Dorothy Stehr" },
                    { 40, 0, "e4b3b268-fae8-4688-984d-13ac27504a19", new DateTime(2021, 8, 22, 16, 36, 2, 324, DateTimeKind.Local).AddTicks(6697), "bret.mayert@haag.us", false, "Et est et sint consectetur non molestiae fuga sequi. Suscipit occaecati ipsa amet. Ducimus quibusdam sint ut.", false, null, null, null, "086-11-7941", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 324, DateTimeKind.Local).AddTicks(6704), "Mr. Austin Fisher" },
                    { 38, 0, "2f2b8023-3ba2-4ad3-90ad-85a5f481d044", new DateTime(2021, 8, 22, 16, 36, 2, 323, DateTimeKind.Local).AddTicks(8959), "jalyn@bergnaum.co.uk", false, "Eaque natus aperiam iste. Ducimus dignissimos distinctio rerum est molestiae provident illum dolores.", false, null, null, null, "374-88-8097", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 323, DateTimeKind.Local).AddTicks(8964), "Jewel Paucek" },
                    { 1, 0, "39af88e4-a9d6-4fd3-aa51-ac2c43b61dfa", new DateTime(2021, 8, 22, 16, 36, 2, 308, DateTimeKind.Local).AddTicks(7099), "hosea@howe.us", false, "Ut perspiciatis voluptatibus ipsam quis illo. Exercitationem illum eum veniam voluptates rem rerum error animi. Sit dolorem qui a tempora veniam perspiciatis aut at. Sunt expedita voluptatem quas praesentium.", false, null, null, null, "128-88-0788", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 308, DateTimeKind.Local).AddTicks(7486), "Johathan Bessie Zulauf I" },
                    { 2, 0, "e66e64e1-04cc-4264-adaf-9e8407ab0b9f", new DateTime(2021, 8, 22, 16, 36, 2, 309, DateTimeKind.Local).AddTicks(3393), "maiya@reichert.biz", false, "Aut earum repudiandae eos facilis in aut quam est eum. Consequatur reiciendis eius beatae alias ut est et harum. Sed aut explicabo eos doloribus et qui quae ut.", false, null, null, null, "200-56-8122", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 309, DateTimeKind.Local).AddTicks(3434), "Velva Senger" },
                    { 3, 0, "5bbc6884-3179-403b-abfb-7e5a69417b79", new DateTime(2021, 8, 22, 16, 36, 2, 309, DateTimeKind.Local).AddTicks(8778), "kasandra@sipes.us", false, "Nobis consequatur voluptatum ipsum ipsa ab nihil. Reiciendis aliquid et adipisci similique et et. Deserunt et delectus non et enim sapiente laborum consequatur unde.", false, null, null, null, "123-12-5553", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 309, DateTimeKind.Local).AddTicks(8789), "Nyasia Roberts" },
                    { 4, 0, "c4430738-5010-405e-8993-166e621f4a31", new DateTime(2021, 8, 22, 16, 36, 2, 310, DateTimeKind.Local).AddTicks(3544), "stuart_tromp@tillman.biz", false, "Ut voluptatem distinctio atque qui nam.", false, null, null, null, "015-82-5990", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 310, DateTimeKind.Local).AddTicks(3553), "Ms. Velma Hudson Simonis II" },
                    { 5, 0, "37a19d8e-51f4-4c2e-97fa-e586c5d2a07f", new DateTime(2021, 8, 22, 16, 36, 2, 310, DateTimeKind.Local).AddTicks(6832), "zetta_farrell@hirthe.co.uk", false, "Voluptas consequatur iste illum consequatur ratione magnam.", false, null, null, null, "609-54-4838", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 310, DateTimeKind.Local).AddTicks(6838), "Ms. Curt Norwood Heller PhD" },
                    { 6, 0, "b65761b9-0615-4a45-9cd4-59c0f217845d", new DateTime(2021, 8, 22, 16, 36, 2, 310, DateTimeKind.Local).AddTicks(9400), "orlando_auer@wisozk.uk", false, "Modi commodi aut aliquam eligendi qui culpa.", false, null, null, null, "541-27-8445", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 310, DateTimeKind.Local).AddTicks(9404), "Dorothy Nitzsche" },
                    { 7, 0, "6476e473-51c0-4b8a-94c2-a219e58603e3", new DateTime(2021, 8, 22, 16, 36, 2, 311, DateTimeKind.Local).AddTicks(2460), "aubrey@wittingbraun.us", false, "Error eum quia voluptate reprehenderit in itaque. Et eum adipisci quae temporibus voluptates. Amet at voluptatum quia sapiente commodi impedit officia cumque.", false, null, null, null, "170-66-6940", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 311, DateTimeKind.Local).AddTicks(2463), "Caesar Rice" },
                    { 8, 0, "d841a553-77c1-404d-99a7-8cff7852c794", new DateTime(2021, 8, 22, 16, 36, 2, 311, DateTimeKind.Local).AddTicks(5511), "jazmyne_hammes@kuhnlebsack.info", false, "Ut pariatur et vitae ut pariatur. Quia corporis eligendi ducimus voluptatem vel molestiae similique. Quo voluptatem molestiae unde maiores.", false, null, null, null, "454-58-8087", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 311, DateTimeKind.Local).AddTicks(5514), "Norval Champlin" },
                    { 9, 0, "a121da4f-3a83-47da-b08a-e8f2a54044af", new DateTime(2021, 8, 22, 16, 36, 2, 311, DateTimeKind.Local).AddTicks(9078), "buster@dooley.uk", false, "Laudantium odio quia provident qui ut voluptas esse et unde. Provident laudantium aut quas ut repellendus. Rerum sit sunt et.", false, null, null, null, "371-82-1894", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 311, DateTimeKind.Local).AddTicks(9082), "Mr. Rosalia Carley Lueilwitz PhD" },
                    { 11, 0, "afdf6807-1af4-412e-b8c5-efd1246c554b", new DateTime(2021, 8, 22, 16, 36, 2, 312, DateTimeKind.Local).AddTicks(7703), "alberta_sawayn@quitzon.info", false, "Odio ut ut sunt odio earum. Sit a illo nulla enim. Inventore tempora culpa quisquam. Aspernatur facere nesciunt quam cum et.", false, null, null, null, "638-83-6055", "+201206784139", false, null, false, new DateTime(2021, 8, 22, 16, 36, 2, 312, DateTimeKind.Local).AddTicks(7722), "Mrs. Garnet Sister Zieme IV" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "ServiceDescription", "ServiceImage", "ServiceName" },
                values: new object[,]
                {
                    { 2, "Iste non itaque sit ad velit tenetur quia repudiandae. Voluptatibus perferendis aut rerum asperiores facilis fugiat eos quibusdam repellat. Harum minus et in asperiores voluptatem perferendis. Sapiente quibusdam sunt dicta porro vero rerum. Odio voluptates non officia iusto dignissimos exercitationem velit tenetur. Adipisci vero error id sit modi.", "Aspernatur officiis impedit debitis sunt.", "Desktop Application Service" },
                    { 3, "Est voluptas qui ex saepe voluptatem et doloremque reiciendis cum. Recusandae quod sit laudantium maiores assumenda occaecati id. Consequuntur omnis sunt nemo fuga. Assumenda quaerat dolorum labore debitis suscipit.", "Officia provident id dolorum aperiam ut perferendis ea. Reiciendis ea perferendis occaecati velit omnis.", "Mobile Application Service" },
                    { 1, "Praesentium ut laborum veritatis aut eum doloremque quidem voluptas quia. Adipisci omnis vel nisi ullam quia illo qui libero iusto. Nemo ipsum eum illo quo.", "Occaecati qui autem et aliquam vel. Dolore qui possimus vero occaecati. Expedita ut corporis necessitatibus minima aut. Et cum porro consequatur et velit maiores esse porro eum.", "Web Application Service" }
                });

            migrationBuilder.InsertData(
                table: "contactstatuses",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 216, DateTimeKind.Local).AddTicks(8576), "Pending", new DateTime(2021, 8, 22, 16, 36, 2, 216, DateTimeKind.Local).AddTicks(8918) },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 216, DateTimeKind.Local).AddTicks(9277), "Completed", new DateTime(2021, 8, 22, 16, 36, 2, 216, DateTimeKind.Local).AddTicks(9278) },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 216, DateTimeKind.Local).AddTicks(9248), "Viewed", new DateTime(2021, 8, 22, 16, 36, 2, 216, DateTimeKind.Local).AddTicks(9263) }
                });

            migrationBuilder.InsertData(
                table: "imagetypes",
                columns: new[] { "Id", "CreatedAt", "ImgType", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(1693), "Other", new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(1706) },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(875), "Thumbnail", new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(1284) }
                });

            migrationBuilder.InsertData(
                table: "linktypes",
                columns: new[] { "Id", "CreatedAt", "LinkType", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(9785), "Facebook", new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(9786) },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(9781), "LinkedIn", new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(9782) },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(9747), "Github", new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(9766) },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(8981), "Url", new DateTime(2021, 8, 22, 16, 36, 2, 269, DateTimeKind.Local).AddTicks(9350) }
                });

            migrationBuilder.InsertData(
                table: "projecttypes",
                columns: new[] { "Id", "CreatedAt", "ProjectType", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 270, DateTimeKind.Local).AddTicks(5882), "Web Application", new DateTime(2021, 8, 22, 16, 36, 2, 270, DateTimeKind.Local).AddTicks(5883) },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 270, DateTimeKind.Local).AddTicks(5854), "Mobile Application", new DateTime(2021, 8, 22, 16, 36, 2, 270, DateTimeKind.Local).AddTicks(5870) },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 270, DateTimeKind.Local).AddTicks(5081), "Desktop Application", new DateTime(2021, 8, 22, 16, 36, 2, 270, DateTimeKind.Local).AddTicks(5471) }
                });

            migrationBuilder.InsertData(
                table: "userrolesinproject",
                columns: new[] { "Id", "CreatedAt", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(3262), "Back End Developer", new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(3643) },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(4074), "Front End Developer", new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(4087) },
                    { 4, new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(4107), "Mobile Developer", new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(4108) },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(4103), "Team Leader", new DateTime(2021, 8, 22, 16, 36, 2, 331, DateTimeKind.Local).AddTicks(4105) }
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "Id", "ContactName", "CreatedAt", "Email", "Message", "Phone", "StatusId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Nadia Thiel", new DateTime(2021, 8, 22, 16, 36, 2, 230, DateTimeKind.Local).AddTicks(4308), "jon@heller.biz", "Pariatur fugiat dolorum eos et ipsum aut expedita soluta. Saepe quia aut nesciunt ipsam perspiciatis omnis commodi reiciendis. Nostrum amet doloremque recusandae impedit. Et quidem asperiores a qui incidunt velit.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 230, DateTimeKind.Local).AddTicks(4651) },
                    { 28, "Mrs. Greg Hessel", new DateTime(2021, 8, 22, 16, 36, 2, 250, DateTimeKind.Local).AddTicks(7859), "sarah.runolfsdottir@jerde.name", "Nostrum ex sint est dignissimos quia reprehenderit. Maxime nesciunt delectus voluptatibus magnam sit.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 250, DateTimeKind.Local).AddTicks(7864) },
                    { 29, "Kelli Hamill", new DateTime(2021, 8, 22, 16, 36, 2, 251, DateTimeKind.Local).AddTicks(2469), "harvey.schroeder@luettgenmohr.com", "Est expedita nihil dolores perferendis voluptatum temporibus tempore. Laborum est quo fuga et.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 251, DateTimeKind.Local).AddTicks(2477) },
                    { 30, "Miss Ashton Carter", new DateTime(2021, 8, 22, 16, 36, 2, 252, DateTimeKind.Local).AddTicks(1222), "sabryna@boehm.uk", "Et eum inventore vitae debitis magni vel. Qui assumenda aperiam magnam saepe magni et necessitatibus sit. Occaecati aut quam aut ratione vero.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 252, DateTimeKind.Local).AddTicks(1242) },
                    { 31, "Jaeden Spinka", new DateTime(2021, 8, 22, 16, 36, 2, 252, DateTimeKind.Local).AddTicks(9966), "cale@kuhicbrown.info", "Possimus repellat et voluptatem incidunt exercitationem velit nulla quas. Nihil iusto aut voluptatum facere rerum nesciunt enim. Consequatur earum rerum aut. Esse eos iusto fugit voluptatem quisquam dolore est cumque. Unde ullam natus labore nostrum.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 252, DateTimeKind.Local).AddTicks(9981) },
                    { 32, "Miss Alan Billy Sanford", new DateTime(2021, 8, 22, 16, 36, 2, 258, DateTimeKind.Local).AddTicks(1075), "mattie.oreilly@sauer.us", "Suscipit eum alias neque tenetur voluptatem quas omnis. Odit cum asperiores quia.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 258, DateTimeKind.Local).AddTicks(1104) },
                    { 33, "Chet Wuckert", new DateTime(2021, 8, 22, 16, 36, 2, 258, DateTimeKind.Local).AddTicks(7699), "carey@steuber.name", "Perferendis laudantium reiciendis beatae aut recusandae perspiciatis suscipit dolorum distinctio. Quis rerum ab et quam tempora eos enim quasi nemo. Quisquam veniam ut fuga aut eligendi ex voluptatibus. Fugit ex hic provident soluta. Facilis veniam et asperiores voluptas fugit enim optio.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 258, DateTimeKind.Local).AddTicks(7737) },
                    { 34, "Kayli Goldner I", new DateTime(2021, 8, 22, 16, 36, 2, 259, DateTimeKind.Local).AddTicks(4011), "isaac.runolfsson@mosciski.us", "Iste sit consectetur aut aliquid in laudantium illo explicabo quidem. Non quo voluptatem occaecati non nostrum at tempore. Beatae in ut praesentium qui ipsam. Velit corrupti eaque natus beatae maxime quia earum a.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 259, DateTimeKind.Local).AddTicks(4026) },
                    { 35, "Torey Rippin", new DateTime(2021, 8, 22, 16, 36, 2, 259, DateTimeKind.Local).AddTicks(7861), "mozell.dietrich@steuber.us", "Nobis voluptatibus est delectus dolorem. Sunt ea fugiat vel vitae qui.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 259, DateTimeKind.Local).AddTicks(7879) },
                    { 36, "Diego Javonte Fahey V", new DateTime(2021, 8, 22, 16, 36, 2, 260, DateTimeKind.Local).AddTicks(2964), "sadie@braun.ca", "Non dolor voluptatem doloribus doloribus quam et et esse est. Necessitatibus est ut maiores facilis.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 260, DateTimeKind.Local).AddTicks(2976) },
                    { 37, "Brent Jewess", new DateTime(2021, 8, 22, 16, 36, 2, 260, DateTimeKind.Local).AddTicks(9183), "kasey@kulas.com", "Dolorum debitis accusamus aut quis. Et repellat esse ut optio et quia. Ducimus porro et illum commodi. Tempore doloribus neque quisquam et ducimus occaecati ut. Voluptate magni aliquid doloremque consequatur qui fugit sed ut.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 260, DateTimeKind.Local).AddTicks(9202) },
                    { 27, "Tobin Mosciski", new DateTime(2021, 8, 22, 16, 36, 2, 250, DateTimeKind.Local).AddTicks(2322), "ebba_conroy@waterskohler.us", "Dolores id reprehenderit est omnis qui blanditiis dolor ex id. Aspernatur quo repellendus maxime ut pariatur ut voluptatem vitae corrupti. Blanditiis optio assumenda est hic similique. Recusandae expedita eum dicta laudantium neque harum dolor asperiores. Veritatis necessitatibus ea fugit aut facere aliquam suscipit.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 250, DateTimeKind.Local).AddTicks(2334) },
                    { 39, "Mrs. Ramon Lydia Pfeffer III", new DateTime(2021, 8, 22, 16, 36, 2, 262, DateTimeKind.Local).AddTicks(1663), "matt@lehner.info", "Mollitia et tempora sed facere dicta omnis laborum tempore sed. Qui quia sed distinctio ipsum suscipit dolore minus sunt eum. Magni possimus eum rem autem possimus. Similique impedit eum velit ut natus sint delectus aut laudantium.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 262, DateTimeKind.Local).AddTicks(1674) },
                    { 41, "George Kiehn", new DateTime(2021, 8, 22, 16, 36, 2, 263, DateTimeKind.Local).AddTicks(3174), "presley.fahey@marvin.info", "Inventore perspiciatis quia officiis. Quam possimus laudantium illo enim et consequatur dolorem. Quisquam voluptatibus quidem quidem repudiandae. Deleniti corrupti molestias qui veritatis inventore optio quia deserunt est. Et dolor est ut eaque quis.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 263, DateTimeKind.Local).AddTicks(3183) },
                    { 42, "Kaelyn Padberg", new DateTime(2021, 8, 22, 16, 36, 2, 263, DateTimeKind.Local).AddTicks(7844), "isaac@weissnat.uk", "Sit iste quo porro in quisquam fugit dolorum molestiae. Possimus dolores optio libero est rem. Consequuntur in voluptas et et nemo ipsum.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 263, DateTimeKind.Local).AddTicks(7851) },
                    { 43, "Verner Strosin", new DateTime(2021, 8, 22, 16, 36, 2, 264, DateTimeKind.Local).AddTicks(2341), "wilford.kub@sporer.co.uk", "Sed harum quis facere. Ab adipisci eum corporis. Aut consectetur et quod voluptatem hic reprehenderit ratione eaque velit.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 264, DateTimeKind.Local).AddTicks(2349) },
                    { 44, "Mrs. Lee O'Reilly", new DateTime(2021, 8, 22, 16, 36, 2, 264, DateTimeKind.Local).AddTicks(7504), "myah.langosh@dibbert.co.uk", "Rerum sequi quisquam modi impedit et rerum sunt. Ut qui consectetur similique voluptas sequi.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 264, DateTimeKind.Local).AddTicks(7515) },
                    { 45, "Mrs. Maryjane Guillermo Goyette", new DateTime(2021, 8, 22, 16, 36, 2, 265, DateTimeKind.Local).AddTicks(3460), "della.hane@mertzkozey.name", "Et excepturi minus doloribus suscipit non assumenda. Quod quis deleniti totam ducimus et molestias est quam. Aut est illum rem autem.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 265, DateTimeKind.Local).AddTicks(3472) },
                    { 46, "Miss Lysanne Marion Berge", new DateTime(2021, 8, 22, 16, 36, 2, 265, DateTimeKind.Local).AddTicks(8335), "river_conroy@kossgislason.info", "Voluptas laudantium ducimus recusandae quae. Quis repellat numquam veniam.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 265, DateTimeKind.Local).AddTicks(8342) },
                    { 47, "Francis Lowe", new DateTime(2021, 8, 22, 16, 36, 2, 266, DateTimeKind.Local).AddTicks(2758), "luciano@parker.us", "Quis veritatis harum voluptate fuga. Sed quo ipsam et voluptas non est itaque.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 266, DateTimeKind.Local).AddTicks(2766) },
                    { 48, "Vidal Windler", new DateTime(2021, 8, 22, 16, 36, 2, 267, DateTimeKind.Local).AddTicks(135), "eryn.grant@vonrueden.co.uk", "Ratione eveniet ipsum pariatur incidunt rerum. Et amet sit itaque eaque dolore error laborum quidem. Consectetur iste ea temporibus sapiente ea dolores suscipit perferendis. Nihil quia doloremque alias.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 267, DateTimeKind.Local).AddTicks(146) },
                    { 49, "Dee Gibson V", new DateTime(2021, 8, 22, 16, 36, 2, 267, DateTimeKind.Local).AddTicks(5806), "lee_quigley@bartoletti.com", "Commodi qui et sequi corporis quae officiis sit reiciendis. Voluptatibus libero voluptas non mollitia.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 267, DateTimeKind.Local).AddTicks(5818) },
                    { 50, "Dudley Friesen", new DateTime(2021, 8, 22, 16, 36, 2, 268, DateTimeKind.Local).AddTicks(3651), "elenor@hessel.ca", "Quia voluptatem voluptatem quia. Incidunt voluptas nisi doloribus. Voluptas officiis distinctio in molestiae. Dignissimos ut doloribus dolor maxime ullam. Cumque quis impedit autem eum.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 268, DateTimeKind.Local).AddTicks(3666) },
                    { 40, "Daniella Godfrey Schmitt I", new DateTime(2021, 8, 22, 16, 36, 2, 262, DateTimeKind.Local).AddTicks(7168), "annamae_berge@walter.uk", "Reprehenderit et repudiandae ipsam fugiat est rerum. Aperiam quis inventore cum aliquam tempora quam id non.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 262, DateTimeKind.Local).AddTicks(7177) },
                    { 26, "Corine Wintheiser", new DateTime(2021, 8, 22, 16, 36, 2, 249, DateTimeKind.Local).AddTicks(3240), "adolf@howe.name", "Explicabo alias officiis beatae ipsum dolor harum. Officiis et repellat mollitia perferendis corrupti quis molestiae ipsa aut. Error omnis et delectus dolorum.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 249, DateTimeKind.Local).AddTicks(3254) },
                    { 38, "Jaclyn Upton", new DateTime(2021, 8, 22, 16, 36, 2, 261, DateTimeKind.Local).AddTicks(4307), "else_von@jast.co.uk", "Officia necessitatibus qui eveniet. Quia dolorum rerum error qui. Recusandae delectus sed sit accusantium id.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 261, DateTimeKind.Local).AddTicks(4317) },
                    { 24, "Cornell Schmeler", new DateTime(2021, 8, 22, 16, 36, 2, 248, DateTimeKind.Local).AddTicks(565), "destinee@barton.co.uk", "Fugit quam quaerat vel cumque facilis atque. Sequi earum ab architecto et modi tempore aut mollitia est. Excepturi at cum nihil earum eaque. Odit nihil atque magni reiciendis et alias est. Enim atque dignissimos id ad quo debitis.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 248, DateTimeKind.Local).AddTicks(583) },
                    { 25, "Miss Ernesto Kovacek", new DateTime(2021, 8, 22, 16, 36, 2, 248, DateTimeKind.Local).AddTicks(6948), "lincoln.brown@larsonhahn.us", "Ut sint perspiciatis labore. Voluptatum iusto veniam id qui sed illo. Quia qui facere omnis.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 248, DateTimeKind.Local).AddTicks(6960) },
                    { 2, "Reva Wilkinson", new DateTime(2021, 8, 22, 16, 36, 2, 231, DateTimeKind.Local).AddTicks(2079), "carlotta.weimann@handmorissette.com", "Error minus ullam assumenda repellendus qui explicabo. Animi nisi ab quisquam animi eius est et ut perspiciatis. Quis praesentium autem enim explicabo.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 231, DateTimeKind.Local).AddTicks(2093) },
                    { 3, "Porter Marvin", new DateTime(2021, 8, 22, 16, 36, 2, 232, DateTimeKind.Local).AddTicks(3358), "stanford.torp@cummerata.com", "Tempora aliquid soluta alias qui itaque. A enim debitis nulla dolores inventore. Deserunt minus numquam minima asperiores aliquam non dolores iusto. Ratione dolor eum et. Veniam commodi ea molestias eos impedit dicta omnis.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 232, DateTimeKind.Local).AddTicks(3386) },
                    { 4, "Dr. Dino Maxie Reichert DVM", new DateTime(2021, 8, 22, 16, 36, 2, 233, DateTimeKind.Local).AddTicks(3322), "lia@schinner.info", "Qui quia reiciendis quis. Voluptas blanditiis voluptas incidunt ea magnam adipisci amet.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 233, DateTimeKind.Local).AddTicks(3343) },
                    { 5, "Monica Ruecker", new DateTime(2021, 8, 22, 16, 36, 2, 233, DateTimeKind.Local).AddTicks(9265), "elenor_waelchi@macejkovicstehr.com", "Aperiam vel voluptates rerum molestiae rem consequatur autem occaecati. Cumque et a optio ex voluptates non. Facere deleniti eos assumenda accusamus et voluptatem voluptates. Est nemo voluptate et aliquid voluptas. Voluptas totam eum sunt nostrum.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 233, DateTimeKind.Local).AddTicks(9273) },
                    { 6, "Brooke Torphy", new DateTime(2021, 8, 22, 16, 36, 2, 234, DateTimeKind.Local).AddTicks(4855), "bryana@romaguera.ca", "Nostrum modi repudiandae dolorum. Voluptas omnis enim et occaecati et. Nam illum cupiditate sapiente. Qui aspernatur suscipit aut sit expedita repudiandae rem eos.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 234, DateTimeKind.Local).AddTicks(4866) },
                    { 7, "Mr. Freda Camden Reichel", new DateTime(2021, 8, 22, 16, 36, 2, 235, DateTimeKind.Local).AddTicks(806), "kristy_mohr@stehr.us", "Aut eos aut porro asperiores culpa natus. Nam nihil quas dolores.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 235, DateTimeKind.Local).AddTicks(819) },
                    { 9, "Elmo Bridgette Bode Jr.", new DateTime(2021, 8, 22, 16, 36, 2, 236, DateTimeKind.Local).AddTicks(3312), "laurianne_ritchie@kris.co.uk", "Quis sit et rerum tempora ab hic sunt omnis. Voluptas voluptates iste ut voluptates sed quasi omnis.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 236, DateTimeKind.Local).AddTicks(3327) },
                    { 10, "Leland McKenzie", new DateTime(2021, 8, 22, 16, 36, 2, 236, DateTimeKind.Local).AddTicks(9176), "ismael.jacobs@littleleuschke.name", "Ea enim tempora quia corporis. Repellat vel et repellendus nesciunt ut dolore velit veritatis. Et nulla quo eligendi minima earum qui velit animi. Maxime aut distinctio sapiente. Inventore qui veritatis quia laudantium commodi eius qui.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 236, DateTimeKind.Local).AddTicks(9187) },
                    { 11, "Dr. Luisa Reba Rutherford DVM", new DateTime(2021, 8, 22, 16, 36, 2, 237, DateTimeKind.Local).AddTicks(6743), "myrtle_frami@cartwright.biz", "Sunt cum voluptatem aut neque quo deserunt itaque et quasi. Delectus illum ratione a. Repellendus aut recusandae omnis ut consequatur. Quas neque dolor qui rerum a molestiae facere. Maiores pariatur dicta ut maiores delectus nam qui aut nihil.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 237, DateTimeKind.Local).AddTicks(6758) },
                    { 12, "Junius Cruickshank", new DateTime(2021, 8, 22, 16, 36, 2, 238, DateTimeKind.Local).AddTicks(9937), "name_predovic@lubowitzroob.co.uk", "Omnis incidunt dignissimos assumenda doloremque qui autem sint adipisci. Itaque occaecati omnis tempore. Sed accusantium quidem qui placeat ut dolorem quisquam. Repellat ut est dicta nostrum nihil aut et repudiandae harum. Qui iure commodi itaque non alias perspiciatis nesciunt.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 238, DateTimeKind.Local).AddTicks(9969) },
                    { 8, "Forrest Ryan", new DateTime(2021, 8, 22, 16, 36, 2, 235, DateTimeKind.Local).AddTicks(6749), "pinkie_gulgowski@oreilly.co.uk", "Cupiditate voluptas exercitationem quasi corrupti sunt. Eos sit exercitationem aut velit cum dolorum debitis aut repellat. Et voluptas ullam ipsum vel id vel. Accusamus iusto in aliquam eum. Voluptas deleniti voluptas consequuntur quam occaecati quisquam et qui sint.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 235, DateTimeKind.Local).AddTicks(6757) },
                    { 22, "Ms. Violet Tremblay Sr.", new DateTime(2021, 8, 22, 16, 36, 2, 246, DateTimeKind.Local).AddTicks(1798), "jocelyn_bogisich@lindgren.info", "Molestias eius repudiandae consequatur quae non. Consequuntur nihil quisquam quibusdam non sit.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 246, DateTimeKind.Local).AddTicks(1814) },
                    { 14, "Oceane Dooley", new DateTime(2021, 8, 22, 16, 36, 2, 240, DateTimeKind.Local).AddTicks(6115), "dario_glover@schmidt.us", "Aut minima mollitia amet molestiae at consequuntur modi velit et. Error commodi esse non et. Esse voluptatibus et at quos. Temporibus assumenda quasi qui doloribus ab non optio sed esse.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 240, DateTimeKind.Local).AddTicks(6127) },
                    { 15, "Mina Mante", new DateTime(2021, 8, 22, 16, 36, 2, 241, DateTimeKind.Local).AddTicks(3210), "joshuah@wizatillman.com", "Voluptas distinctio ullam quae dolor in. Voluptas totam et sint culpa iste eos dolore quis praesentium. Voluptatem aliquid corrupti debitis. Sed fugiat delectus rerum quidem sit soluta. Ea sed dolorem voluptatem unde enim in ex.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 241, DateTimeKind.Local).AddTicks(3223) },
                    { 16, "Jade Braun", new DateTime(2021, 8, 22, 16, 36, 2, 242, DateTimeKind.Local).AddTicks(589), "loyce_connelly@kiehncollins.name", "Ut delectus autem dignissimos reiciendis. Omnis maxime ut dignissimos fugit inventore molestiae sed omnis sint. Error ut optio quia numquam omnis. Accusamus ab eaque et blanditiis aut nihil nihil incidunt.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 242, DateTimeKind.Local).AddTicks(613) },
                    { 17, "Aletha Tillman", new DateTime(2021, 8, 22, 16, 36, 2, 242, DateTimeKind.Local).AddTicks(6696), "jennie_mcclure@wisozk.co.uk", "Totam in ut eum non voluptas animi. Eum voluptates provident vitae mollitia sit esse.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 242, DateTimeKind.Local).AddTicks(6712) },
                    { 18, "Larissa Schroeder", new DateTime(2021, 8, 22, 16, 36, 2, 243, DateTimeKind.Local).AddTicks(3202), "marilie_davis@beer.com", "Eius sunt eos ipsam similique expedita ut odit est. Est asperiores itaque et voluptatum consectetur ut qui voluptatem. Delectus eos eum sit assumenda dolor officiis ut fugit. Architecto labore veniam voluptatem fugiat facilis ut quae necessitatibus provident.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 243, DateTimeKind.Local).AddTicks(3210) },
                    { 19, "Frederick Sauer", new DateTime(2021, 8, 22, 16, 36, 2, 243, DateTimeKind.Local).AddTicks(8486), "juvenal@gutkowskichristiansen.biz", "Doloribus ducimus omnis repellat est sit. Dolorem totam omnis tempore laborum accusantium minima et. Voluptatum ut delectus magni tempore nemo nobis sed ut rerum.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 243, DateTimeKind.Local).AddTicks(8491) },
                    { 20, "Jany Kovacek", new DateTime(2021, 8, 22, 16, 36, 2, 244, DateTimeKind.Local).AddTicks(5538), "leila@muller.us", "Cum debitis ipsa accusantium aliquam velit maiores. Eveniet dignissimos qui sapiente recusandae veniam in ut.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 244, DateTimeKind.Local).AddTicks(5556) },
                    { 21, "Candida Haag IV", new DateTime(2021, 8, 22, 16, 36, 2, 245, DateTimeKind.Local).AddTicks(4615), "arjun@corkerypacocha.com", "Nostrum consectetur ea qui facere. Repellat non in quas.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 245, DateTimeKind.Local).AddTicks(4639) },
                    { 13, "Dr. Israel Melvin Little", new DateTime(2021, 8, 22, 16, 36, 2, 239, DateTimeKind.Local).AddTicks(9966), "franco@paucekjast.us", "Voluptates molestiae sit aut illo aperiam est animi est omnis. Quos ex minima qui. Perferendis ut dolorem facilis fugit dolor eveniet nisi reprehenderit vel. Velit dolore dolorem tenetur repellendus voluptatem asperiores pariatur ad.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 239, DateTimeKind.Local).AddTicks(9983) },
                    { 23, "Deven Goodwin", new DateTime(2021, 8, 22, 16, 36, 2, 247, DateTimeKind.Local).AddTicks(2869), "alexie@macejkovic.ca", "Et iure occaecati enim architecto quos doloremque adipisci animi modi. Nobis repellat libero molestiae deserunt mollitia ea et at. Voluptas consequatur voluptate libero qui qui asperiores qui nihil. Incidunt voluptas nulla sit voluptatibus omnis laborum. Expedita neque enim ut.", "+201206784139", 1, new DateTime(2021, 8, 22, 16, 36, 2, 247, DateTimeKind.Local).AddTicks(2878) }
                });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 18, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(1515), "Autem similique labore placeat sed necessitatibus nostrum itaque quam est. Nesciunt consequuntur voluptatem molestiae quis. Accusantium et iure nesciunt rem mollitia molestias. Est et et eos laborum. Nulla necessitatibus explicabo sunt ea laboriosam voluptatem assumenda autem.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(1526) },
                    { 16, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(7151), "Deleniti voluptatum inventore quisquam incidunt. Fugiat debitis laborum et. Aut et voluptates eos. Sed eius qui totam minus aperiam et repellat minima pariatur. Asperiores a et explicabo qui et.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(7154) },
                    { 15, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(5128), "Ut incidunt voluptatem necessitatibus nostrum dignissimos corrupti corporis eligendi enim. Beatae aliquid placeat accusamus repellendus expedita velit dicta.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(5131) },
                    { 13, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(2513), "Officiis ipsa rerum delectus velit qui quos facilis. Inventore voluptatem nisi quibusdam. Deleniti quo quia aut quo incidunt voluptas praesentium sit aut.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(2516) },
                    { 44, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(6600), "Quam eum dolores similique. Corporis at esse dolor. Architecto occaecati quis ex adipisci et blanditiis. Neque eius quia accusamus.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(6609) },
                    { 6, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(2597), "Tenetur nostrum libero quis in. Dolorem et nesciunt dolor.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(2599) },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 271, DateTimeKind.Local).AddTicks(7969), "Sed aut consequatur praesentium qui aliquam et sunt. Velit doloremque numquam consequatur. Ea rem exercitationem animi voluptatem adipisci dolore et et omnis. Ad quia tempore et molestiae.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 271, DateTimeKind.Local).AddTicks(7975) },
                    { 50, new DateTime(2021, 8, 22, 16, 36, 2, 281, DateTimeKind.Local).AddTicks(1608), "Atque aut quia blanditiis minus et et sit. Aperiam laudantium omnis vero temporibus numquam harum reiciendis. Laborum totam minus alias est id voluptates. Voluptas sint voluptatem quibusdam delectus est ea impedit. Harum ut architecto doloribus animi illum.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 281, DateTimeKind.Local).AddTicks(1613) },
                    { 19, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(2938), "Saepe doloribus provident dolorem nulla quis illum. Consequuntur incidunt sit velit. Non debitis et quas vitae omnis autem et laboriosam totam.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(2942) },
                    { 10, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(8581), "Eum quis et illo eligendi aut nemo. Saepe dignissimos sit saepe non sunt adipisci reprehenderit maxime earum. Qui quae recusandae et magni.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(8583) },
                    { 20, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(4014), "Architecto sed et sit quasi exercitationem repudiandae expedita dolorem. Rem tenetur aut fuga eveniet et atque quia.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(4017) },
                    { 48, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(5544), "Voluptatem rerum aperiam tenetur ut. Nihil possimus rem consequatur ut voluptatem molestiae est.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(5549) },
                    { 24, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(2090), "Nesciunt recusandae iste in veniam quia non a. Consectetur iure dolor ducimus veritatis. Expedita voluptates expedita voluptates cupiditate.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(2092) },
                    { 26, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(5963), "Animi consequatur debitis vel ipsa harum maxime voluptatem nam qui. Sit necessitatibus dolorem laborum et eligendi a suscipit ad. Recusandae facere nisi esse officiis sed quasi.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(5966) },
                    { 28, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(8568), "Est quos optio ab molestiae ea soluta et nisi voluptatum. Temporibus culpa expedita ea quia nesciunt.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(8571) },
                    { 31, new DateTime(2021, 8, 22, 16, 36, 2, 276, DateTimeKind.Local).AddTicks(6956), "Reprehenderit rerum eligendi voluptas explicabo recusandae omnis velit animi. In sint illo deserunt rerum. Et adipisci ex culpa cupiditate cum beatae qui vel hic. Laborum vel non exercitationem doloribus.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 276, DateTimeKind.Local).AddTicks(6962) },
                    { 35, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(7076), "Ut veniam quia molestiae autem. Assumenda labore facilis veniam ad consectetur et similique. Iste error minus assumenda. Sit explicabo voluptates ipsam provident reprehenderit corrupti ipsam.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(7080) },
                    { 36, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(9043), "Quod repellat illum quaerat officia in accusantium quaerat. Veniam optio et voluptatum dolore est molestiae. Sapiente commodi omnis quia alias pariatur aut sit non assumenda.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(9046) },
                    { 42, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(265), "Repellat sunt ut et. Et vitae sed nam ipsa. Impedit sunt est non praesentium voluptas.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(269) },
                    { 45, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(9271), "Expedita voluptatem asperiores voluptate nam sed autem quia. Laborum et deleniti nostrum vel quo. Omnis laboriosam possimus optio earum assumenda placeat. Consequatur quia provident iure recusandae soluta. Omnis iure molestias in sit eos.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(9277) },
                    { 46, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(1879), "Voluptatem repellendus itaque ex necessitatibus impedit quia earum totam repellat. Corporis dolor sit sit est aut id quis. Aperiam iure illum illum non et libero. Voluptas ex harum vel ea omnis sit rerum.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(1882) },
                    { 47, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(3952), "Ut molestias doloremque ut. Quae a eum voluptatum dignissimos tempore amet sed. Impedit voluptatem quod reprehenderit ut vel quia adipisci. Voluptatem est eveniet repellat magnam autem.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(3956) },
                    { 43, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(4488), "Aut beatae nisi deserunt impedit repudiandae quod nesciunt. Iste fugiat est aut molestiae quia dolore odit. Suscipit ipsa et voluptate reiciendis sed eum et nisi vero. Eos assumenda nam sed ad nisi autem quia.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 279, DateTimeKind.Local).AddTicks(4494) },
                    { 21, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(6420), "Qui ab et at non illo blanditiis. Optio corrupti et consequuntur et quis sunt in consequatur. Quidem ad vel officiis. Delectus eum ea voluptas facilis dolor eum aperiam et rerum.", "alias", 3, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(6430) },
                    { 39, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(4978), "Enim voluptatibus enim dolores saepe ut dolor neque laborum perspiciatis. Sunt doloribus id dolores similique nisi recusandae ipsum et. Quaerat voluptatem magnam quibusdam. Iste adipisci provident cum et eligendi doloribus quia.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(4981) },
                    { 34, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(5088), "Adipisci mollitia quo voluptas. Totam officia earum magni. Beatae laborum aut expedita maxime beatae. Neque assumenda minima temporibus quo omnis. Sapiente alias eaque aliquid.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(5093) },
                    { 33, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(2846), "Aut consectetur autem assumenda. Quos fuga illum sed aliquam. Tempore officia est odio perferendis blanditiis sit veniam tenetur in.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(2849) },
                    { 4, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(482), "Et explicabo rerum atque dolorum deserunt. Magni et odio nobis voluptatem ad temporibus quis id. Voluptatem culpa est ut voluptas modi. Quis dolores eveniet mollitia velit. Modi quo magnam aut et aut quaerat quis.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(488) },
                    { 7, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(4823), "At necessitatibus qui qui ab magni et labore tempore sit. Assumenda ut ut neque. Quo temporibus recusandae saepe occaecati enim doloribus officiis voluptatibus. Officia harum qui excepturi nobis recusandae nostrum perferendis quo sunt. Sit aut perferendis quia velit blanditiis ea.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(4825) },
                    { 8, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(6131), "Aut eligendi beatae et et aliquam similique sint dolore. Aut nisi aliquam amet eum quis doloribus dicta unde pariatur. Et voluptas architecto exercitationem.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(6132) },
                    { 9, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(7273), "Ut nulla veritatis voluptas. Non corporis in qui culpa commodi est non optio. Nihil natus blanditiis dolorem et praesentium hic.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(7275) },
                    { 12, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(1174), "Suscipit explicabo consequatur voluptas recusandae. Dolorem impedit vel sit dolore sit. Autem deleniti minima et qui nihil error temporibus. Voluptatem quis et numquam omnis vero perferendis.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(1176) },
                    { 30, new DateTime(2021, 8, 22, 16, 36, 2, 276, DateTimeKind.Local).AddTicks(3858), "Temporibus doloribus repellat provident esse iste consectetur ipsum dicta similique. Voluptatum quaerat saepe harum. Sint repellat est nostrum ipsum dicta blanditiis deleniti illum quis. Ex suscipit aut consequatur ea. Quaerat et incidunt cumque qui distinctio quasi alias ab.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 276, DateTimeKind.Local).AddTicks(3862) },
                    { 32, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(608), "Quasi corporis aut illo qui quasi. Facilis et aut ducimus molestiae architecto ducimus nesciunt omnis. Ut quaerat tenetur cupiditate sapiente. Sint officiis nemo distinctio voluptas. Necessitatibus libero voluptates perferendis.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 277, DateTimeKind.Local).AddTicks(620) },
                    { 37, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(542), "Laudantium tempora numquam enim. Numquam tempore tempore et consectetur mollitia. Ad at et ad quia animi debitis architecto deserunt.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(545) },
                    { 38, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(2631), "Et odit sapiente sit nisi. In laboriosam voluptatem impedit deserunt dolorem aut distinctio molestias. Ipsa occaecati nihil consequatur consectetur ut unde et non. Cumque delectus est et.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(2635) },
                    { 40, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(6096), "Mollitia aperiam ex magni molestiae adipisci rerum nisi. Illo commodi architecto incidunt qui minus.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(6099) },
                    { 41, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(8396), "Officia vero reiciendis enim. Ut tempora ab at voluptatum perferendis aspernatur. Ex et cupiditate omnis eveniet voluptatum autem sit dolor. Distinctio non eum dolor maiores suscipit.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 278, DateTimeKind.Local).AddTicks(8401) },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 271, DateTimeKind.Local).AddTicks(6225), "Nam maxime alias sit sunt voluptatem facere. Tenetur voluptatum quod et repellat.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 271, DateTimeKind.Local).AddTicks(6255) },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 271, DateTimeKind.Local).AddTicks(4864), "Sed ut sapiente tenetur dolores eaque quasi voluptatem. Ea sequi recusandae eveniet temporibus ut vitae aliquam asperiores inventore. Doloribus eos esse ducimus et exercitationem ad rerum natus.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 271, DateTimeKind.Local).AddTicks(5138) },
                    { 5, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(2013), "Sed ipsum suscipit aliquam aspernatur. Praesentium facere nostrum aut sit error soluta omnis occaecati aut. Dolores ut hic neque nesciunt excepturi ab fuga ea ducimus.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(2016) },
                    { 11, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(9632), "Aliquid possimus dolores ex architecto repellat harum vel sit. Velit quasi ipsa aliquam est fuga culpa sit.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 272, DateTimeKind.Local).AddTicks(9634) },
                    { 14, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(4078), "Sapiente aut molestiae quod et provident est. Cum illo voluptas molestiae aut. Dolore voluptatem nam atque. Ducimus vitae quidem temporibus quam. Corporis id vitae est et voluptatum.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(4082) },
                    { 17, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(8536), "Saepe corporis odit aliquid consequatur odit minima accusantium. Cum voluptatum placeat nihil voluptas dolores.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 273, DateTimeKind.Local).AddTicks(8538) },
                    { 22, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(8078), "Eum maiores quam mollitia ratione qui animi fugit accusantium magni. Aspernatur ut qui et. Eos a alias sit voluptas.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 274, DateTimeKind.Local).AddTicks(8084) },
                    { 23, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(655), "Consectetur magni maxime nihil et. Corrupti aut ratione ex facilis quas. Nihil libero est qui blanditiis. Aliquid vero nulla consequatur qui est. Culpa inventore pariatur voluptatum magnam ullam qui fugiat impedit quia.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(657) },
                    { 25, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(3890), "Eius qui et voluptas cumque. Odit sit facilis soluta deleniti vel placeat qui pariatur. Voluptates libero nesciunt asperiores sit deserunt omnis labore.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(3893) },
                    { 27, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(7266), "Exercitationem sit magni totam consequatur modi numquam rem sint explicabo. Ad qui dolorum voluptatum animi facere.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 275, DateTimeKind.Local).AddTicks(7269) },
                    { 29, new DateTime(2021, 8, 22, 16, 36, 2, 276, DateTimeKind.Local).AddTicks(984), "Illum voluptas impedit quo qui ipsa modi tempora tenetur neque. Nesciunt tempore ut dolor enim. Maiores voluptatem possimus sint. Sint quaerat vel vel. Itaque quisquam veniam dolores et iste impedit tempora id.", "alias", 2, new DateTime(2021, 8, 22, 16, 36, 2, 276, DateTimeKind.Local).AddTicks(988) },
                    { 49, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(8817), "Aliquam mollitia eius omnis. Ex libero in ducimus et. Autem porro nulla suscipit. Harum iure omnis corrupti maxime sequi. Debitis nemo aspernatur qui necessitatibus velit eos dolorum velit maiores.", "alias", 1, new DateTime(2021, 8, 22, 16, 36, 2, 280, DateTimeKind.Local).AddTicks(8821) }
                });

            migrationBuilder.InsertData(
                table: "userlinks",
                columns: new[] { "Id", "CreatedAt", "Link", "TypeId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 35, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2128), "http://www.jast.name/articles/form.jsp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2129), 35 },
                    { 34, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(1738), "http://www.hilpert.info/films/page.rsx", 2, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(1740), 34 },
                    { 33, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(1356), "http://www.trantow.us/reviews/form.res", 2, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(1358), 33 },
                    { 32, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(975), "http://www.johns.info/catalog/template.asp", 1, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(976), 32 },
                    { 27, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9708), "http://www.jonesmorar.name/interviews/resource.lsp", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9709), 27 },
                    { 30, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(309), "http://www.ferry.us/reviews/resource.res", 1, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(311), 30 },
                    { 29, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(120), "http://www.moengreenholt.uk/catalog/index.gem", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(122), 29 },
                    { 28, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9860), "http://www.dietrich.com/articles/form.aspx", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9861), 28 },
                    { 36, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2279), "http://www.kreiger.com/films/index.asp", 2, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2280), 36 },
                    { 31, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(599), "http://www.kozeyankunding.name/facts/root.asp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(601), 31 },
                    { 37, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2660), "http://www.heller.com/guide/index.htm", 1, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2662), 37 },
                    { 42, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3923), "http://www.fadel.name/facts/resource.asp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3925), 42 },
                    { 39, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3090), "http://www.stammcollier.name/articles/applet.html", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3091), 39 },
                    { 40, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3473), "http://www.yundthomenick.info/films/page.jsp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3476), 40 },
                    { 41, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3695), "http://www.kling.ca/catalog/resource.rsx", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(3698), 41 },
                    { 43, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(4545), "http://www.haag.com/reviews/resource.htm", 2, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(4549), 43 },
                    { 44, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(4967), "http://www.jerdegulgowski.ca/shop/food/page.aspx", 3, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(4972), 44 },
                    { 45, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(5196), "http://www.spencer.uk/catalog/index.lsp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(5198), 45 },
                    { 46, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(5575), "http://www.hickleeffertz.uk/films/root.htm", 3, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(5578), 46 },
                    { 47, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(6020), "http://www.raugislason.info/shop/books/form.html", 3, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(6027), 47 },
                    { 48, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(6291), "http://www.dickinson.name/shop/books/root.asp", 1, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(6294), 48 },
                    { 26, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9422), "http://www.weissnatrenner.uk/reviews/index.html", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9423), 26 },
                    { 38, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2814), "http://www.boehm.biz/interviews/root.jsp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(2815), 38 },
                    { 25, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9161), "http://www.hartmann.biz/guide/template.aspx", 3, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(9162), 25 },
                    { 13, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(5495), "http://www.robel.biz/interviews/applet.rsx", 4, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(5497), 13 },
                    { 23, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(8633), "http://www.hintzrenner.co.uk/shop/food/root.aspx", 1, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(8634), 23 },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 328, DateTimeKind.Local).AddTicks(9400), "http://www.rutherford.ca/films/index.htm", 1, new DateTime(2021, 8, 22, 16, 36, 2, 328, DateTimeKind.Local).AddTicks(9786), 1 },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(559), "http://www.baumbach.us/interviews/root.res", 3, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(581), 2 },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(1029), "http://www.starkcremin.ca/articles/resource.lsp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(1033), 3 },
                    { 4, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(1441), "http://www.mckenziebernhard.biz/articles/template.res", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(1445), 4 },
                    { 5, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(2255), "http://www.corkery.name/shop/films/resource.rsx", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(2260), 5 },
                    { 6, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(2809), "http://www.ziemerowe.uk/shop/food/applet.jsp", 3, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(2813), 6 },
                    { 7, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(3056), "http://www.abshire.com/interviews/root.rsx", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(3059), 7 },
                    { 8, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(3466), "http://www.bauchgutmann.uk/articles/template.gem", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(3470), 8 },
                    { 9, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4064), "http://www.kulas.co.uk/interviews/applet.asp", 4, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4066), 9 },
                    { 10, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4445), "http://www.quitzonrenner.co.uk/shop/books/applet.gem", 1, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4447), 10 },
                    { 24, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(8786), "http://www.schumm.com/films/page.aspx", 1, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(8787), 24 },
                    { 11, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4666), "http://www.pfannerstill.name/catalog/form.html", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4669), 11 },
                    { 49, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(6869), "http://www.roob.name/guide/form.gem", 4, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(6873), 49 },
                    { 14, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(5742), "http://www.lueilwitz.uk/films/resource.aspx", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(5744), 14 },
                    { 15, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(5996), "http://www.mccullough.us/shop/form.asp", 1, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(5998), 15 },
                    { 16, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(6425), "http://www.faheyschowalter.name/facts/form.html", 4, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(6427), 16 },
                    { 17, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(6668), "http://www.mclaughlin.com/interviews/template.html", 4, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(6670), 17 },
                    { 18, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(6888), "http://www.quitzon.com/shop/films/root.html", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(6890), 18 },
                    { 19, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(7481), "http://www.thielcrist.uk/shop/food/template.gem", 1, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(7483), 19 },
                    { 20, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(7710), "http://www.kuphal.co.uk/films/form.htm", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(7712), 20 },
                    { 21, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(7993), "http://www.davisthompson.us/facts/template.res", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(7994), 21 },
                    { 22, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(8370), "http://www.okon.biz/guide/applet.gem", 2, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(8371), 22 },
                    { 12, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4899), "http://www.okuneva.info/reviews/page.asp", 1, new DateTime(2021, 8, 22, 16, 36, 2, 329, DateTimeKind.Local).AddTicks(4901), 12 },
                    { 50, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(7272), "http://www.legrosroob.com/home/page.res", 3, new DateTime(2021, 8, 22, 16, 36, 2, 330, DateTimeKind.Local).AddTicks(7275), 50 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTools",
                columns: new[] { "Id", "ProjectId", "ToolUsed" },
                values: new object[,]
                {
                    { 49, 49, "Laravel PHP" },
                    { 30, 30, "Laravel PHP" },
                    { 18, 18, "ASP.NET CORE C#" },
                    { 32, 32, "Laravel PHP" },
                    { 27, 27, "Laravel PHP" },
                    { 6, 6, "ASP.NET CORE C#" },
                    { 37, 37, "Laravel PHP" },
                    { 25, 25, "ASP.NET CORE C#" },
                    { 23, 23, "ASP.NET CORE C#" },
                    { 10, 10, "ASP.NET CORE C#" },
                    { 24, 24, "ASP.NET CORE C#" },
                    { 38, 38, "Laravel PHP" },
                    { 28, 28, "Laravel PHP" },
                    { 22, 22, "ASP.NET CORE C#" },
                    { 21, 21, "ASP.NET CORE C#" },
                    { 17, 17, "ASP.NET CORE C#" },
                    { 40, 40, "Laravel PHP" },
                    { 15, 15, "ASP.NET CORE C#" },
                    { 41, 41, "Laravel PHP" },
                    { 14, 14, "ASP.NET CORE C#" },
                    { 16, 16, "ASP.NET CORE C#" },
                    { 20, 20, "ASP.NET CORE C#" },
                    { 1, 1, "ASP.NET CORE C#" },
                    { 11, 11, "ASP.NET CORE C#" },
                    { 19, 19, "ASP.NET CORE C#" },
                    { 13, 13, "ASP.NET CORE C#" },
                    { 31, 31, "Laravel PHP" },
                    { 26, 26, "Laravel PHP" },
                    { 3, 3, "ASP.NET CORE C#" },
                    { 43, 43, "Laravel PHP" },
                    { 48, 48, "Laravel PHP" },
                    { 39, 39, "Laravel PHP" },
                    { 2, 2, "ASP.NET CORE C#" },
                    { 34, 34, "Laravel PHP" },
                    { 47, 47, "Laravel PHP" },
                    { 44, 44, "Laravel PHP" },
                    { 4, 4, "ASP.NET CORE C#" },
                    { 46, 46, "Laravel PHP" },
                    { 45, 45, "Laravel PHP" },
                    { 12, 12, "ASP.NET CORE C#" },
                    { 7, 7, "ASP.NET CORE C#" },
                    { 33, 33, "Laravel PHP" },
                    { 50, 50, "Laravel PHP" },
                    { 5, 5, "ASP.NET CORE C#" },
                    { 35, 35, "Laravel PHP" },
                    { 42, 42, "Laravel PHP" },
                    { 8, 8, "ASP.NET CORE C#" },
                    { 36, 36, "Laravel PHP" },
                    { 9, 9, "ASP.NET CORE C#" },
                    { 29, 29, "Laravel PHP" }
                });

            migrationBuilder.InsertData(
                table: "projectfeedbacks",
                columns: new[] { "Id", "CreatedAt", "Feedback", "ProjectId" },
                values: new object[,]
                {
                    { 29, new DateTime(2021, 8, 22, 16, 36, 2, 289, DateTimeKind.Local).AddTicks(6240), "Dolorem voluptatum ipsum quos doloremque alias. Ut nobis voluptatem qui velit veritatis quisquam.", 25 },
                    { 15, new DateTime(2021, 8, 22, 16, 36, 2, 285, DateTimeKind.Local).AddTicks(8365), "Repudiandae reiciendis dolorum omnis unde. Aspernatur quas fugiat maxime. Pariatur illo doloribus sunt quod in ad velit consequuntur cum. Voluptates tempora non recusandae sit neque.", 6 },
                    { 37, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(2399), "Magnam et alias in natus. Nulla rerum distinctio delectus.", 18 },
                    { 46, new DateTime(2021, 8, 22, 16, 36, 2, 296, DateTimeKind.Local).AddTicks(6197), "Et voluptas eaque ut iste voluptates consequatur iusto. Non sed deserunt saepe rem debitis delectus assumenda eligendi sed. In eligendi blanditiis iure consectetur laudantium officia soluta et.", 29 },
                    { 21, new DateTime(2021, 8, 22, 16, 36, 2, 287, DateTimeKind.Local).AddTicks(2705), "Aut deserunt non enim vel non beatae. Quia animi possimus iusto aut sint et vero earum quo. Placeat quos et illo eaque omnis dignissimos cum excepturi.", 18 },
                    { 27, new DateTime(2021, 8, 22, 16, 36, 2, 289, DateTimeKind.Local).AddTicks(2943), "Ut mollitia sed et nisi reiciendis nisi. Dolorem minus nesciunt maxime.", 14 },
                    { 17, new DateTime(2021, 8, 22, 16, 36, 2, 286, DateTimeKind.Local).AddTicks(3831), "Sunt odit error odit qui non. Veniam ipsa eius voluptate explicabo aliquid non reprehenderit. Incidunt explicabo alias excepturi omnis voluptatum. Nihil laborum adipisci autem minima quo iure necessitatibus labore.", 18 },
                    { 24, new DateTime(2021, 8, 22, 16, 36, 2, 288, DateTimeKind.Local).AddTicks(3965), "Et tenetur est quasi voluptatem totam corporis iure magnam quis. Est nostrum est necessitatibus atque consequatur aut. Vitae esse incidunt maiores eveniet quam qui. Velit quae dolor rerum dolor.", 44 },
                    { 13, new DateTime(2021, 8, 22, 16, 36, 2, 285, DateTimeKind.Local).AddTicks(3834), "Atque quidem dignissimos veritatis adipisci ut facilis aut. Quis fugiat consequatur qui. Vitae aut repellat excepturi libero consequuntur ea sed. Doloremque eos magnam est atque ad id commodi. Beatae harum quia quibusdam.", 17 },
                    { 30, new DateTime(2021, 8, 22, 16, 36, 2, 294, DateTimeKind.Local).AddTicks(4204), "Tempora ab molestiae qui delectus nisi iusto vel nulla aut. Tempore et dolor voluptas. Omnis suscipit vero laboriosam aut architecto optio labore qui in. Sapiente error expedita corporis non sunt.", 29 },
                    { 18, new DateTime(2021, 8, 22, 16, 36, 2, 286, DateTimeKind.Local).AddTicks(6452), "Odit at repellendus quisquam. Eum ut qui doloribus at nihil sit. Voluptatibus ipsa quia qui voluptas facilis. Quo quos suscipit consequatur voluptatem voluptatibus. Impedit ratione quia culpa ratione quam et.", 25 },
                    { 49, new DateTime(2021, 8, 22, 16, 36, 2, 297, DateTimeKind.Local).AddTicks(2238), "Maiores aliquam a earum dolores. Sed provident nulla cum eius consequatur debitis blanditiis. Quo eos quibusdam quas reprehenderit beatae. Et quo quo nesciunt. Ipsa voluptates non voluptas in cupiditate autem.", 33 },
                    { 41, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(7611), "Numquam sunt eligendi aperiam. Beatae accusantium at et occaecati occaecati.", 3 },
                    { 7, new DateTime(2021, 8, 22, 16, 36, 2, 283, DateTimeKind.Local).AddTicks(7637), "Ea qui sequi culpa vel doloremque. Et sed reprehenderit deserunt maxime velit sequi adipisci occaecati id.", 15 },
                    { 19, new DateTime(2021, 8, 22, 16, 36, 2, 286, DateTimeKind.Local).AddTicks(9319), "Nihil et dicta placeat non vero voluptatum et laboriosam. Amet at aut occaecati sequi ut eaque eos odio. Ducimus aut in atque nihil suscipit quis ut cumque asperiores. Minus cum voluptates nobis nam et.", 50 },
                    { 8, new DateTime(2021, 8, 22, 16, 36, 2, 284, DateTimeKind.Local).AddTicks(1318), "Deserunt dicta aliquam unde. Esse sed ea voluptas ut modi non. Sequi ducimus ex qui esse magni necessitatibus tempore. Omnis laborum qui repellat eaque sed laudantium excepturi. Nesciunt exercitationem libero ut.", 34 },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 282, DateTimeKind.Local).AddTicks(1385), "Voluptatem adipisci sint est velit sunt doloremque sit earum. Pariatur provident ut ea sit inventore aperiam consequatur reiciendis expedita. Expedita quia sed quibusdam sit sed nostrum.", 13 },
                    { 5, new DateTime(2021, 8, 22, 16, 36, 2, 283, DateTimeKind.Local).AddTicks(4865), "Nemo deleniti voluptatem blanditiis qui cumque. Nemo sed quia minus. Quia officiis enim qui.", 10 },
                    { 39, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(5368), "Quo aut veniam aut dolorem quis dolore molestiae. Id aperiam adipisci ipsum quasi eaque sit quidem dolores.", 44 },
                    { 42, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(9825), "Et mollitia molestiae voluptatum rerum sint quam tenetur eligendi. Sit omnis incidunt aut quam. Veritatis accusantium atque velit non omnis voluptate harum. Quibusdam iste repudiandae autem qui eos tenetur quasi a. Assumenda ea neque unde ut consectetur aut mollitia.", 13 },
                    { 4, new DateTime(2021, 8, 22, 16, 36, 2, 283, DateTimeKind.Local).AddTicks(3302), "Sunt ullam accusamus reprehenderit architecto explicabo distinctio et. Et modi ipsa dolorum atque nulla veritatis similique explicabo. Repellat odio quia nihil fugiat sed sint aut. Consequuntur temporibus quos explicabo quibusdam dicta accusamus nihil facere. Expedita a perferendis est dolorem.", 2 },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 283, DateTimeKind.Local).AddTicks(43), "Ut autem totam autem qui omnis ut quia qui. Odit explicabo vel minus. Ullam et sequi error et. Ut at similique quo sit molestias. Sed tenetur quasi dolorum laborum non rerum delectus est sed.", 38 },
                    { 36, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(1841), "Cupiditate quis ab id voluptatem. Accusamus quia reprehenderit adipisci dolorum in.", 38 },
                    { 35, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(1164), "Id ut vero officia provident quam. Aut asperiores illo quis excepturi. Eaque id reprehenderit voluptatum ut quae quo quia temporibus. Nihil suscipit quia minus doloribus dolore impedit odio enim. Dolor eveniet voluptatem explicabo dolor iste qui voluptatem.", 38 },
                    { 34, new DateTime(2021, 8, 22, 16, 36, 2, 294, DateTimeKind.Local).AddTicks(9185), "Omnis dolores minima officia blanditiis repellat omnis sed consectetur. Voluptatem magnam tempora aliquid.", 38 },
                    { 47, new DateTime(2021, 8, 22, 16, 36, 2, 296, DateTimeKind.Local).AddTicks(8319), "Sint blanditiis ratione modi facere iusto sit veniam. Expedita quaerat modi laborum neque velit. Temporibus officiis nemo impedit. Consequuntur non consequatur laborum est aut eius nostrum mollitia. Qui qui omnis iusto qui velit molestias dolor sed.", 11 },
                    { 14, new DateTime(2021, 8, 22, 16, 36, 2, 285, DateTimeKind.Local).AddTicks(6524), "Deleniti est vel possimus magni unde nam fugiat. Hic quisquam labore nisi et et impedit et. Eos distinctio blanditiis voluptate ab qui rerum ipsam architecto. Aut odio qui enim deserunt dolores.", 26 },
                    { 16, new DateTime(2021, 8, 22, 16, 36, 2, 286, DateTimeKind.Local).AddTicks(1379), "Provident autem tempora laborum fugiat sunt. Soluta perferendis tenetur tenetur et est rerum sint magnam. Qui animi sequi ut sint omnis. Sed possimus at recusandae est maxime rem sit.", 26 },
                    { 43, new DateTime(2021, 8, 22, 16, 36, 2, 296, DateTimeKind.Local).AddTicks(2172), "Perferendis accusamus molestiae assumenda quam ea nam. Error id id cum qui reiciendis rerum. Iusto magnam rerum ex ea enim architecto illo sed. Quae odit est quis rem quis magnam eligendi magni. Veniam molestiae quis quam dolorem.", 38 },
                    { 9, new DateTime(2021, 8, 22, 16, 36, 2, 284, DateTimeKind.Local).AddTicks(5086), "Voluptate neque quos fuga. Ut nisi minus id voluptatem fuga quos commodi. Sit aspernatur in explicabo qui dolor ut quo et eligendi. Vero sint nesciunt rerum necessitatibus molestiae ipsum explicabo quis est.", 28 },
                    { 44, new DateTime(2021, 8, 22, 16, 36, 2, 296, DateTimeKind.Local).AddTicks(2895), "Totam molestiae rerum excepturi. Quo est incidunt accusantium sit quia eum est.", 45 },
                    { 45, new DateTime(2021, 8, 22, 16, 36, 2, 296, DateTimeKind.Local).AddTicks(4005), "Voluptates sapiente natus et accusantium voluptas aut et non. In autem vero voluptatem rerum quis unde. Doloribus nam possimus quos.", 8 },
                    { 48, new DateTime(2021, 8, 22, 16, 36, 2, 297, DateTimeKind.Local).AddTicks(548), "Consequatur sed ut et illum assumenda quibusdam quia voluptas. At qui qui nihil. Rerum deleniti eum eum sapiente ullam molestias. Ratione voluptas qui minima quos aperiam quaerat. Placeat natus animi cum sint quae corporis dignissimos eius.", 4 },
                    { 32, new DateTime(2021, 8, 22, 16, 36, 2, 294, DateTimeKind.Local).AddTicks(7768), "Sit fuga quae ducimus esse. Sed officiis tenetur eaque facilis odit qui doloribus.", 4 },
                    { 50, new DateTime(2021, 8, 22, 16, 36, 2, 297, DateTimeKind.Local).AddTicks(2857), "Est cupiditate est quibusdam. Suscipit quo adipisci numquam non sapiente voluptas.", 48 },
                    { 33, new DateTime(2021, 8, 22, 16, 36, 2, 294, DateTimeKind.Local).AddTicks(8469), "Molestiae deserunt sint quam perferendis ut accusantium hic. Ab blanditiis et eos quo.", 2 },
                    { 31, new DateTime(2021, 8, 22, 16, 36, 2, 294, DateTimeKind.Local).AddTicks(7050), "Sed est quis qui minus ea qui quam dolore. Excepturi dolorum aliquam animi ratione quas. Sed aliquid voluptas quis reiciendis vero rem voluptatum non natus. Voluptatem earum aspernatur ut. Officiis illum est et qui.", 36 },
                    { 25, new DateTime(2021, 8, 22, 16, 36, 2, 288, DateTimeKind.Local).AddTicks(8647), "A aut enim corrupti. Assumenda dolorem aut reprehenderit distinctio amet quis. Dignissimos neque voluptatem qui quisquam ipsam ipsa quas quaerat alias.", 24 },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 282, DateTimeKind.Local).AddTicks(5573), "Laborum sequi vel aut aut minus aliquam. Totam laborum saepe laborum magnam odit quis temporibus nihil. Et non nesciunt et iusto aut consequatur nesciunt minima. Sint aut mollitia est fuga ut sunt. Iure dignissimos optio velit totam eos.", 43 },
                    { 10, new DateTime(2021, 8, 22, 16, 36, 2, 284, DateTimeKind.Local).AddTicks(6874), "Sed sit eum ut et soluta. Aperiam praesentium modi possimus est. Eaque quia quia mollitia accusamus pariatur consequatur et. Voluptatum saepe quasi magnam amet harum quod. Eveniet unde quaerat consequatur dolores tenetur laudantium.", 24 },
                    { 40, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(7034), "Nemo culpa optio libero ad. Enim explicabo temporibus consequatur voluptatem nihil est. Saepe eum ea est fugit velit. Doloremque voluptatem dicta maiores porro voluptas id necessitatibus et.", 5 },
                    { 11, new DateTime(2021, 8, 22, 16, 36, 2, 284, DateTimeKind.Local).AddTicks(8377), "Laborum quasi asperiores eos eveniet praesentium. Dolorem adipisci voluptatum aut aperiam officia dolorum doloremque rerum. Eos est perspiciatis amet quis magnam molestiae.", 5 },
                    { 23, new DateTime(2021, 8, 22, 16, 36, 2, 287, DateTimeKind.Local).AddTicks(7591), "Aspernatur et voluptatem corporis ab repellendus earum. Consequatur ut quibusdam et consequatur corrupti quis officia. Dolorem autem eum perferendis quo nobis nostrum exercitationem. Qui et ducimus pariatur voluptates aut sed.", 20 },
                    { 26, new DateTime(2021, 8, 22, 16, 36, 2, 289, DateTimeKind.Local).AddTicks(2058), "Ipsa eveniet placeat provident cupiditate. Labore et odio doloribus asperiores commodi at. Et odit natus molestiae accusantium blanditiis. Quia culpa corrupti libero perferendis.", 43 },
                    { 22, new DateTime(2021, 8, 22, 16, 36, 2, 287, DateTimeKind.Local).AddTicks(3810), "Consectetur illum voluptatem exercitationem repellendus reprehenderit aut nisi eos. Commodi nostrum modi dolores.", 49 },
                    { 28, new DateTime(2021, 8, 22, 16, 36, 2, 289, DateTimeKind.Local).AddTicks(5019), "Voluptatem explicabo qui suscipit. Possimus dolor ab repudiandae ut rerum. Dolorem totam dignissimos nulla incidunt enim sunt est.", 21 },
                    { 12, new DateTime(2021, 8, 22, 16, 36, 2, 285, DateTimeKind.Local).AddTicks(767), "Similique labore possimus corporis commodi assumenda doloribus et ex est. Facilis corporis natus magni asperiores. Fugiat nihil ipsam cupiditate placeat est placeat accusamus praesentium nulla. Nam et tempore cum. Qui sit cupiditate nobis.", 21 },
                    { 6, new DateTime(2021, 8, 22, 16, 36, 2, 283, DateTimeKind.Local).AddTicks(6063), "Delectus soluta omnis et autem aut. Magni porro veritatis quia facilis tempora illo temporibus dolorum.", 40 },
                    { 20, new DateTime(2021, 8, 22, 16, 36, 2, 287, DateTimeKind.Local).AddTicks(581), "Voluptas illo sint praesentium praesentium magnam laborum excepturi. Iste possimus saepe ea. Nostrum eum ipsa est.", 40 },
                    { 38, new DateTime(2021, 8, 22, 16, 36, 2, 295, DateTimeKind.Local).AddTicks(4390), "Ut qui quis adipisci voluptatem voluptatem. Quos voluptates laboriosam voluptatem omnis illum excepturi. Sed consequatur dolorem quas vel tenetur vel. Illum aut aliquid quia. Voluptatem ut similique quisquam veniam voluptas aperiam expedita aut.", 21 }
                });

            migrationBuilder.InsertData(
                table: "projectimages",
                columns: new[] { "Id", "CreatedAt", "ImagePath", "ProjectId", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(8079), "Deserunt ut eligendi corporis et. Eum molestiae nobis consequatur.", 10, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(8081) },
                    { 18, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(6641), "Eaque corporis voluptatem voluptas esse mollitia explicabo. Illum dolores molestias saepe perferendis quae quae sequi.", 18, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(6644) },
                    { 48, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(2606), "Iste doloremque illo non itaque deserunt delectus dolor accusamus. Eos ipsam maiores dicta alias sunt magni excepturi. Quam ut eos rem voluptates porro aperiam. Qui aut earum quaerat reiciendis molestias ab dolores dolor.", 48, 1, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(2608) },
                    { 24, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(7702), "Reiciendis aut sint eligendi. Dolore quos voluptatem aut quia cupiditate ipsa. Est eius velit debitis ab veritatis eum aliquid veniam. Sint praesentium id consequatur ut necessitatibus eos qui.", 24, 1, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(7707) },
                    { 44, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(7681), "Deserunt molestiae iusto est.", 44, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(7682) },
                    { 47, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(669), "Voluptas ad blanditiis ut unde. Velit provident eos veritatis fugit commodi quis ut modi. In ipsam quibusdam fugit aut et.", 47, 1, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(671) },
                    { 46, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(9433), "Rerum autem ea laboriosam. Debitis illo doloribus qui ea natus.", 46, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(9440) },
                    { 45, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(8618), "Expedita iure pariatur asperiores. Quibusdam aut nesciunt nihil hic provident qui odio vero. Voluptatem voluptatem iste in.", 45, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(8622) },
                    { 50, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(5136), "Minima et veritatis dolore. Eum pariatur voluptas sit inventore repellat amet assumenda expedita et. Veniam ut voluptate ipsum. Necessitatibus ullam adipisci numquam officiis.", 50, 1, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(5138) },
                    { 20, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(9324), "Rerum nemo sit quia. Est quia optio architecto voluptatem amet.", 20, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(9328) },
                    { 21, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(2025), "Dolor non architecto sunt facere est. Quis laboriosam illo voluptatem consequatur ipsum ex velit rerum voluptas. Et explicabo sint error sed et molestiae. Laboriosam id praesentium sit autem et modi eum exercitationem.", 21, 1, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(2031) },
                    { 36, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(2396), "Dolorum architecto provident aut voluptatem voluptatum ea consectetur aut dicta. Minus omnis a quam et architecto. Eum sit incidunt quo dolorum commodi quaerat enim voluptatem.", 36, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(2399) },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(722), "Quam et eum beatae aliquid aperiam eos sunt. Quibusdam ratione ratione voluptatem.", 3, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(724) },
                    { 13, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(67), "Quam voluptas ipsam sint est at.", 13, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(68) },
                    { 35, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(1030), "Sed est reiciendis soluta quia repellat labore. Occaecati error vel voluptas beatae distinctio ut recusandae ab placeat. Tempore quo nemo consequatur omnis dicta.", 35, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(1032) },
                    { 31, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(6815), "Cupiditate rerum nisi aliquam animi quia cum. Incidunt modi autem earum autem libero dolor doloribus. Reprehenderit velit magni illo dolore maiores amet sit numquam. Fugiat quia quos ratione et quis architecto sit explicabo impedit.", 31, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(6817) },
                    { 28, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(1690), "Dolorem voluptates eveniet maxime. Vitae iure id qui ratione quia maxime aut enim.", 28, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(1691) },
                    { 15, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(2106), "Voluptates adipisci ratione enim ad distinctio error optio. Nihil rerum sapiente nesciunt veniam veniam cum molestiae. Dignissimos excepturi eum id exercitationem accusantium.", 15, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(2108) },
                    { 26, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(397), "Amet voluptas repellendus enim non quas fugiat eum nulla. Quis aut accusamus ullam autem.", 26, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(400) },
                    { 6, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(4329), "Laboriosam eius perferendis nihil aut laboriosam debitis dolorum nihil non. Dolore quae suscipit in quaerat illum quia eius ut.", 6, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(4330) },
                    { 16, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(3790), "Adipisci officia enim facilis veritatis suscipit sunt consequatur quia. Fugit provident eligendi officiis quasi quia occaecati reiciendis sunt. Aut vel quia voluptas omnis sunt optio. Doloremque non quasi consequatur et.", 16, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(3792) },
                    { 42, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(7093), "Unde velit voluptate rem.", 42, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(7094) },
                    { 19, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(8410), "Perferendis qui accusantium aliquid nihil ea ex tempore ipsam ducimus. Quibusdam totam quidem corporis quia aut.", 19, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(8429) },
                    { 43, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(7442), "Et optio cupiditate tenetur vel voluptate.", 43, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(7443) },
                    { 49, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(3833), "Facere facilis quis reiciendis aut et iusto quam. Ipsum aut quo ut. Aliquam nihil doloribus dolorum cupiditate quam velit ad odio ducimus.", 49, 1, new DateTime(2021, 8, 22, 16, 36, 2, 303, DateTimeKind.Local).AddTicks(3835) },
                    { 4, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(2267), "Vitae veritatis totam voluptatem voluptas minus molestias aut. Cupiditate error esse aperiam similique. Unde voluptas quisquam incidunt repellat est. Voluptatem quo omnis porro vero ab repellat eligendi amet.", 4, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(2270) },
                    { 25, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(9223), "Molestiae aliquid corrupti aut sed reprehenderit id deserunt temporibus. Qui nihil perferendis doloribus voluptas. Officiis ut dolor consequatur.", 25, 1, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(9228) },
                    { 23, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(5515), "Illum voluptas ducimus labore impedit odit molestias provident et magnam. Illum deleniti impedit sit reiciendis est laboriosam. Sunt et quis sunt.", 23, 1, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(5520) },
                    { 9, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(7570), "Est quam eveniet doloremque est laudantium aut quidem voluptates quia. Et sed impedit enim voluptatibus atque doloribus.", 9, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(7572) },
                    { 22, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(3678), "Reprehenderit ducimus nihil quasi non aut molestiae soluta aperiam eum. Nisi dolores magni ut ut quo quae laborum sed.", 22, 1, new DateTime(2021, 8, 22, 16, 36, 2, 300, DateTimeKind.Local).AddTicks(3684) },
                    { 30, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(4882), "Beatae quia rerum voluptatem. Perspiciatis porro debitis esse. Unde consequatur porro necessitatibus dolor blanditiis minus enim esse. Molestiae molestiae omnis non laboriosam rerum voluptas iure.", 30, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(4883) },
                    { 14, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(837), "Nobis aliquam eos ducimus quidem sapiente neque commodi quam possimus. Magnam unde consequatur doloremque.", 14, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(840) },
                    { 27, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(996), "Voluptatum exercitationem ut laudantium. Possimus culpa pariatur hic qui natus tempora.", 27, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(998) },
                    { 11, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(8809), "Saepe eveniet recusandae vel. Aliquam ut sint ullam vitae pariatur facere necessitatibus est.", 11, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(8811) },
                    { 5, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(3286), "Et explicabo praesentium aspernatur nesciunt accusamus quia facere nam. Assumenda autem aut dicta reprehenderit officiis qui assumenda dicta qui.", 5, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(3288) },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 297, DateTimeKind.Local).AddTicks(8514), "Est debitis dolore molestiae natus eos nemo eligendi ipsum corporis. Et nisi unde ea consequatur quod.", 1, 1, new DateTime(2021, 8, 22, 16, 36, 2, 297, DateTimeKind.Local).AddTicks(8788) },
                    { 8, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(6563), "Maxime hic et repudiandae cupiditate voluptatem pariatur aut qui explicabo. Magni iusto quia sed molestias. Beatae similique exercitationem amet et esse sit assumenda.", 8, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(6567) },
                    { 32, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(7480), "Omnis earum voluptatum consequatur nisi ab dolor. Et dolor aut in.", 32, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(7483) },
                    { 41, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(6864), "Error hic doloremque perspiciatis error vero. Iusto qui soluta beatae quia omnis facere facilis ut consectetur.", 41, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(6866) },
                    { 40, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(5922), "Consequatur tempora aspernatur tenetur repellendus nesciunt. Sapiente necessitatibus consequatur quos et.", 40, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(5923) },
                    { 38, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(4074), "Eos veniam et aut qui est ad quis illum. Ut nemo eius ipsa atque.", 38, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(4076) },
                    { 7, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(5282), "Commodi perferendis doloremque dolores. Facere nihil nam aliquam. Dolores facere distinctio commodi voluptas provident aperiam velit est.", 7, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(5284) },
                    { 29, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(3481), "Quod quia qui earum vitae facere. Nobis id at accusamus magnam voluptates voluptatem recusandae non. Ut fuga quia distinctio repellendus. Libero minima natus natus pariatur id quo sit consequatur.", 29, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(3483) },
                    { 17, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(5791), "Cum dolores qui non qui accusamus eligendi. Eveniet dicta occaecati similique molestiae incidunt aut architecto molestiae. Molestiae voluptatem neque quos aut molestiae aut recusandae. Cum vel voluptas error qui provident perspiciatis quia quasi aut.", 17, 1, new DateTime(2021, 8, 22, 16, 36, 2, 299, DateTimeKind.Local).AddTicks(5794) },
                    { 37, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(3270), "Quia eveniet consectetur corrupti aut blanditiis non autem tenetur nesciunt. Natus dicta dignissimos et dignissimos.", 37, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(3272) },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(44), "Delectus labore ab in voluptatem enim et repudiandae et illum. Ab in voluptates quia omnis.", 2, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(57) },
                    { 34, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(9732), "Tenetur et voluptate voluptatem veritatis asperiores cumque. Sit ratione enim labore temporibus.", 34, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(9733) },
                    { 12, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(9734), "Ipsam ut corrupti sunt tenetur est optio dolorem. Natus voluptatibus sint hic omnis corrupti consectetur voluptas vero.", 12, 1, new DateTime(2021, 8, 22, 16, 36, 2, 298, DateTimeKind.Local).AddTicks(9735) },
                    { 39, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(5302), "Aut quam sequi eum. Cum illo nisi cupiditate porro vel placeat earum. Quis totam qui dolore eveniet est autem omnis dignissimos exercitationem.", 39, 1, new DateTime(2021, 8, 22, 16, 36, 2, 302, DateTimeKind.Local).AddTicks(5303) },
                    { 33, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(9034), "Consequatur corporis eius nemo nihil aliquid dolorum nihil non impedit. At dolor corrupti exercitationem quas enim vitae iste. Qui iusto consectetur dolore officia saepe et harum quaerat blanditiis.", 33, 1, new DateTime(2021, 8, 22, 16, 36, 2, 301, DateTimeKind.Local).AddTicks(9036) }
                });

            migrationBuilder.InsertData(
                table: "projectlinks",
                columns: new[] { "Id", "CreatedAt", "Link", "ProjectId", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 24, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3672), "http://www.stiedemann.ca/articles/index.htm", 24, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3675) },
                    { 48, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1581), "http://www.okuneva.us/films/resource.res", 48, 2, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1582) },
                    { 5, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(6127), "http://www.miller.biz/guide/applet.aspx", 5, 1, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(6132) },
                    { 19, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(2062), "http://www.sporer.uk/films/root.jsp", 19, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(2065) },
                    { 34, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(7631), "http://www.kshlerin.com/reviews/template.lsp", 34, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(7636) },
                    { 45, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(496), "http://www.considine.ca/catalog/resource.aspx", 45, 2, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(498) },
                    { 1, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(3279), "http://www.eichmann.info/films/page.lsp", 1, 1, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(3677) },
                    { 44, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(345), "http://www.dibbert.uk/shop/food/resource.res", 44, 1, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(347) },
                    { 20, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(2304), "http://www.ondricka.info/shop/films/form.htm", 20, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(2307) },
                    { 49, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1727), "http://www.padberg.biz/shop/food/index.asp", 49, 2, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1729) },
                    { 7, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(6914), "http://www.padberg.info/articles/resource.aspx", 7, 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(6917) },
                    { 26, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(4334), "http://www.heidenreichconn.biz/facts/form.jsp", 26, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(4337) },
                    { 30, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(6178), "http://www.koeppkeebler.com/reviews/resource.htm", 30, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(6181) },
                    { 41, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9565), "http://www.leuschke.name/shop/books/index.rsx", 41, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9566) },
                    { 39, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9268), "http://www.roobbotsford.info/shop/films/resource.lsp", 39, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9269) },
                    { 40, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9415), "http://www.mohr.ca/facts/template.gem", 40, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9416) },
                    { 21, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(2906), "http://www.reichert.uk/shop/root.lsp", 21, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(2909) },
                    { 43, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(200), "http://www.kunzehaag.name/shop/food/root.res", 43, 1, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(202) },
                    { 8, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(7272), "http://www.prosaccozulauf.name/facts/index.gem", 8, 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(7274) },
                    { 42, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9945), "http://www.aufderhar.uk/reviews/root.rsx", 42, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9946) },
                    { 38, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9007), "http://www.oreilly.info/shop/food/index.aspx", 38, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(9009) },
                    { 32, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(6832), "http://www.mann.co.uk/reviews/template.asp", 32, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(6834) },
                    { 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(4998), "http://www.wuckerttoy.uk/shop/books/page.res", 2, 1, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(5016) },
                    { 18, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(1824), "http://www.jaskolski.us/shop/books/root.html", 18, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(1826) },
                    { 11, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(8660), "http://www.fisherprohaska.biz/shop/films/applet.jsp", 11, 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(8664) },
                    { 27, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(4921), "http://www.johnson.co.uk/shop/films/template.gem", 27, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(4926) },
                    { 6, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(6362), "http://www.veum.com/shop/books/index.rsx", 6, 1, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(6364) },
                    { 31, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(6602), "http://www.huelsstanton.name/guide/applet.jsp", 31, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(6604) },
                    { 47, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1217), "http://www.eichmann.com/shop/food/form.res", 47, 1, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1218) },
                    { 25, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3910), "http://www.rippin.biz/catalog/template.html", 25, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3912) },
                    { 33, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(7070), "http://www.ondricka.us/interviews/index.asp", 33, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(7073) },
                    { 10, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(7922), "http://www.schimmel.ca/shop/books/form.res", 10, 1, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(7924) },
                    { 23, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3384), "http://www.dooley.com/shop/food/template.asp", 23, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3387) },
                    { 50, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1877), "http://www.hessel.biz/articles/applet.html", 50, 1, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(1878) },
                    { 4, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(5534), "http://www.treutel.info/facts/index.res", 4, 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(5536) },
                    { 36, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(8304), "http://www.bechtelar.info/shop/films/template.aspx", 36, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(8306) },
                    { 29, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(5753), "http://www.paucek.us/shop/form.res", 29, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(5757) },
                    { 13, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(9717), "http://www.baumbach.name/guide/root.lsp", 13, 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(9720) },
                    { 17, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(1230), "http://www.lang.uk/shop/films/root.lsp", 17, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(1233) },
                    { 15, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(745), "http://www.ankundingrolfson.us/shop/index.rsx", 15, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(747) },
                    { 37, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(8543), "http://www.fay.ca/home/form.gem", 37, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(8545) },
                    { 16, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(994), "http://www.erdman.co.uk/shop/films/root.aspx", 16, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(997) },
                    { 14, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(311), "http://www.stokes.us/guide/resource.jsp", 14, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(316) },
                    { 12, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(9134), "http://www.yundtsmith.name/films/form.aspx", 12, 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(9138) },
                    { 46, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(854), "http://www.schulist.biz/home/resource.lsp", 46, 1, new DateTime(2021, 8, 22, 16, 36, 2, 306, DateTimeKind.Local).AddTicks(856) },
                    { 35, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(8058), "http://www.mantecrist.biz/interviews/root.rsx", 35, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(8061) },
                    { 9, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(7668), "http://www.bergedietrich.ca/reviews/index.jsp", 9, 1, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(7672) },
                    { 28, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(5177), "http://www.carroll.ca/reviews/applet.asp", 28, 2, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(5180) },
                    { 22, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3143), "http://www.jacobson.us/interviews/template.gem", 22, 1, new DateTime(2021, 8, 22, 16, 36, 2, 305, DateTimeKind.Local).AddTicks(3146) },
                    { 3, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(5291), "http://www.bednar.com/interviews/index.htm", 3, 2, new DateTime(2021, 8, 22, 16, 36, 2, 304, DateTimeKind.Local).AddTicks(5294) }
                });

            migrationBuilder.InsertData(
                table: "usersinprojects",
                columns: new[] { "Id", "ProjectId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 46, 36, 3, 33 },
                    { 49, 4, 1, 45 },
                    { 6, 8, 3, 28 },
                    { 27, 42, 2, 23 },
                    { 36, 45, 2, 18 },
                    { 45, 45, 4, 48 },
                    { 16, 4, 4, 21 },
                    { 32, 46, 4, 43 },
                    { 41, 46, 4, 30 },
                    { 13, 47, 2, 43 },
                    { 38, 47, 1, 41 },
                    { 40, 47, 3, 9 },
                    { 31, 2, 3, 22 },
                    { 7, 48, 2, 43 },
                    { 50, 36, 1, 35 },
                    { 29, 9, 4, 14 },
                    { 8, 48, 1, 39 },
                    { 18, 35, 3, 49 },
                    { 19, 39, 2, 35 },
                    { 30, 34, 1, 35 },
                    { 14, 44, 4, 9 },
                    { 22, 44, 1, 23 },
                    { 33, 44, 3, 10 },
                    { 37, 44, 2, 16 },
                    { 34, 33, 4, 24 },
                    { 26, 29, 3, 40 },
                    { 21, 6, 3, 15 },
                    { 25, 6, 3, 11 },
                    { 4, 22, 1, 17 },
                    { 2, 22, 1, 49 },
                    { 17, 14, 3, 32 },
                    { 47, 16, 4, 41 },
                    { 35, 35, 4, 33 },
                    { 48, 16, 2, 46 },
                    { 1, 11, 4, 44 },
                    { 12, 18, 2, 39 },
                    { 20, 18, 3, 34 },
                    { 24, 19, 2, 10 },
                    { 10, 20, 3, 11 },
                    { 11, 20, 1, 8 },
                    { 23, 39, 2, 48 },
                    { 28, 38, 1, 7 },
                    { 3, 38, 1, 28 },
                    { 44, 24, 4, 1 },
                    { 5, 37, 4, 35 },
                    { 15, 28, 1, 33 },
                    { 43, 12, 1, 32 },
                    { 39, 12, 1, 27 },
                    { 9, 11, 3, 34 },
                    { 42, 48, 4, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "StatusId",
                table: "contacts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "Status",
                table: "contactstatuses",
                column: "Status",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ImgType",
                table: "imagetypes",
                column: "ImgType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "LinkType",
                table: "linktypes",
                column: "LinkType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ProjectId",
                table: "projectfeedbacks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "ProjectId1",
                table: "projectimages",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "TypeId1",
                table: "projectimages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "ProjectId2",
                table: "projectlinks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "TypeId2",
                table: "projectlinks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "TypeId",
                table: "projects",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTools_ProjectId",
                table: "ProjectTools",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "ProjectType",
                table: "projecttypes",
                column: "ProjectType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestedServices_ContactId",
                table: "RequestedServices",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestedServices_ServiceId",
                table: "RequestedServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "TypeId3",
                table: "userlinks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "UserId",
                table: "userlinks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "ProjectId3",
                table: "usersinprojects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "RoleId",
                table: "usersinprojects",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UserId1",
                table: "usersinprojects",
                column: "UserId");
        }

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
                name: "projectfeedbacks");

            migrationBuilder.DropTable(
                name: "projectimages");

            migrationBuilder.DropTable(
                name: "projectlinks");

            migrationBuilder.DropTable(
                name: "ProjectTools");

            migrationBuilder.DropTable(
                name: "RequestedServices");

            migrationBuilder.DropTable(
                name: "userlinks");

            migrationBuilder.DropTable(
                name: "usersinprojects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "imagetypes");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "linktypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "userrolesinproject");

            migrationBuilder.DropTable(
                name: "contactstatuses");

            migrationBuilder.DropTable(
                name: "projecttypes");
        }
    }
}
