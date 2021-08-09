using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portofolio.Migrations
{
    public partial class CreateAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "userroles",
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
                    table.PrimaryKey("PK_userroles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(320)", maxLength: 320, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagePath = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
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
                        principalTable: "users",
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
                        principalTable: "users",
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
                        principalTable: "userroles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.InsertData(
                table: "contactstatuses",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 230, DateTimeKind.Local).AddTicks(6048), "Pending", new DateTime(2021, 8, 9, 17, 30, 30, 230, DateTimeKind.Local).AddTicks(6340) },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 230, DateTimeKind.Local).AddTicks(6604), "Viewed", new DateTime(2021, 8, 9, 17, 30, 30, 230, DateTimeKind.Local).AddTicks(6614) },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 230, DateTimeKind.Local).AddTicks(6622), "Completed", new DateTime(2021, 8, 9, 17, 30, 30, 230, DateTimeKind.Local).AddTicks(6623) }
                });

            migrationBuilder.InsertData(
                table: "imagetypes",
                columns: new[] { "Id", "CreatedAt", "ImgType", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 286, DateTimeKind.Local).AddTicks(5397), "Thumbnail", new DateTime(2021, 8, 9, 17, 30, 30, 286, DateTimeKind.Local).AddTicks(5752) },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 286, DateTimeKind.Local).AddTicks(6085), "Other", new DateTime(2021, 8, 9, 17, 30, 30, 286, DateTimeKind.Local).AddTicks(6099) }
                });

            migrationBuilder.InsertData(
                table: "linktypes",
                columns: new[] { "Id", "CreatedAt", "LinkType", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(667), "Url", new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(924) },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(1192), "Github", new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(1201) },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(1211), "LinkedIn", new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(1212) },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(1214), "Facebook", new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(1215) }
                });

            migrationBuilder.InsertData(
                table: "projecttypes",
                columns: new[] { "Id", "CreatedAt", "ProjectType", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(4756), "Desktop Application", new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(4998) },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(5245), "Mobile Application", new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(5254) },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(5263), "Web Application", new DateTime(2021, 8, 9, 17, 30, 30, 287, DateTimeKind.Local).AddTicks(5264) }
                });

            migrationBuilder.InsertData(
                table: "userroles",
                columns: new[] { "Id", "CreatedAt", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(7307), "Front End Developer", new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(7318) },
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(6786), "Back End Developer", new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(7050) },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(7330), "Mobile Developer", new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(7331) },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(7328), "Team Leader", new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(7329) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "CreatedAt", "Email", "ImagePath", "Password", "Phone", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 8, 9, 17, 30, 30, 320, DateTimeKind.Local).AddTicks(2444), "edison.goodwin@bradtke.biz", "Unde quod et ut quia voluptatem recusandae.", "133-75-5486", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 320, DateTimeKind.Local).AddTicks(2451), "Prof. Ole Kyleigh Blanda Sr." },
                    { 32, new DateTime(2021, 8, 9, 17, 30, 30, 328, DateTimeKind.Local).AddTicks(6187), "ashleigh.swift@roobreichert.ca", "Rem possimus et deserunt eum. Eius qui atque dolorum esse temporibus qui sunt corrupti.", "562-84-4517", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 328, DateTimeKind.Local).AddTicks(6189), "Morgan O'Reilly" },
                    { 33, new DateTime(2021, 8, 9, 17, 30, 30, 328, DateTimeKind.Local).AddTicks(9631), "ernestine@flatleyreichel.us", "Iste voluptate qui ea inventore unde sint hic minus eaque. Vel eum est fugiat a dolor consequatur.", "526-70-9739", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 328, DateTimeKind.Local).AddTicks(9634), "Katrina Will" },
                    { 34, new DateTime(2021, 8, 9, 17, 30, 30, 329, DateTimeKind.Local).AddTicks(2701), "talon.schiller@effertz.uk", "Provident consectetur ab quo. Aut et repellendus quos magnam sunt.", "133-44-5160", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 329, DateTimeKind.Local).AddTicks(2704), "Sherman Oberbrunner" },
                    { 35, new DateTime(2021, 8, 9, 17, 30, 30, 329, DateTimeKind.Local).AddTicks(5463), "luther_hyatt@blick.name", "Nobis est ut sint tempora sequi eveniet velit eaque. Delectus eveniet magni sequi commodi omnis at.", "149-41-5633", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 329, DateTimeKind.Local).AddTicks(5465), "Charles Altenwerth" },
                    { 36, new DateTime(2021, 8, 9, 17, 30, 30, 329, DateTimeKind.Local).AddTicks(9125), "eva_skiles@gutmann.info", "Facere odio quo repudiandae velit aut est. Aut vero nulla dignissimos totam. Consequatur labore voluptas laboriosam qui libero atque fugit cumque. Dolorum reiciendis repellendus odit hic ex eaque eum.", "259-97-9664", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 329, DateTimeKind.Local).AddTicks(9127), "Ms. Fay Abernathy II" },
                    { 37, new DateTime(2021, 8, 9, 17, 30, 30, 330, DateTimeKind.Local).AddTicks(2784), "yoshiko@andersonmante.ca", "Libero doloribus ut distinctio. Est quo voluptatem veniam et. Occaecati eum quibusdam dolores excepturi laborum numquam excepturi. Et facere non consequatur.", "562-61-2266", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 330, DateTimeKind.Local).AddTicks(2786), "Prof. Reba Marilie Feil" },
                    { 38, new DateTime(2021, 8, 9, 17, 30, 30, 330, DateTimeKind.Local).AddTicks(6067), "pedro_franecki@prosacco.com", "Iste necessitatibus tenetur autem quos magnam in perspiciatis voluptas.", "273-14-0811", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 330, DateTimeKind.Local).AddTicks(6070), "Miss Sally Coralie Jast PhD" },
                    { 39, new DateTime(2021, 8, 9, 17, 30, 30, 330, DateTimeKind.Local).AddTicks(9122), "geovany_abernathy@ortiz.us", "Quasi fuga quaerat consectetur exercitationem incidunt eaque ea impedit voluptate. Molestias mollitia inventore commodi esse aut.", "588-67-6277", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 330, DateTimeKind.Local).AddTicks(9138), "Kenyon Jakubowski" },
                    { 40, new DateTime(2021, 8, 9, 17, 30, 30, 331, DateTimeKind.Local).AddTicks(3740), "aaron_flatley@cartwright.info", "Nihil possimus praesentium aut saepe eos maiores. Vero qui reiciendis ea. Enim recusandae aliquam at sit dolores perspiciatis dignissimos optio. Est quo itaque ipsam voluptatibus et saepe sit nulla.", "128-16-0373", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 331, DateTimeKind.Local).AddTicks(3747), "Ms. Ted Mosciski" },
                    { 41, new DateTime(2021, 8, 9, 17, 30, 30, 331, DateTimeKind.Local).AddTicks(9887), "christiana.osinski@abernathy.name", "Qui praesentium delectus sunt labore sapiente est esse quas quis. Laborum non voluptas officiis aut dolorem nemo. Nulla consequatur dignissimos quaerat ut reiciendis. Quos accusantium neque aut et alias.", "151-58-2130", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 331, DateTimeKind.Local).AddTicks(9895), "Miss Margarette Dasia Satterfield PhD" },
                    { 42, new DateTime(2021, 8, 9, 17, 30, 30, 332, DateTimeKind.Local).AddTicks(2821), "wilford@mertz.info", "Qui eum vel dolorem sunt deleniti a. Ut consectetur hic incidunt totam ut eligendi ut voluptas perferendis.", "395-01-6953", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 332, DateTimeKind.Local).AddTicks(2824), "Clarissa Hamill" },
                    { 43, new DateTime(2021, 8, 9, 17, 30, 30, 332, DateTimeKind.Local).AddTicks(5906), "rosella@gleichnernader.ca", "Quia in et qui harum. Maxime accusantium odit eius accusamus.", "385-29-1793", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 332, DateTimeKind.Local).AddTicks(5909), "Prof. Cleo Katlynn Feest" },
                    { 44, new DateTime(2021, 8, 9, 17, 30, 30, 332, DateTimeKind.Local).AddTicks(8504), "sterling@dubuquewisozk.us", "Qui labore illo minima aut corrupti corrupti voluptatem. Qui ea enim omnis saepe eos.", "610-10-7078", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 332, DateTimeKind.Local).AddTicks(8507), "Dr. Taya Bailey" },
                    { 45, new DateTime(2021, 8, 9, 17, 30, 30, 333, DateTimeKind.Local).AddTicks(2517), "chesley@trantoweichmann.ca", "Quia ut voluptas sed non ut. Excepturi et ipsa molestiae. Libero rem reiciendis corporis excepturi recusandae natus temporibus. Et excepturi magnam ipsam voluptatum deserunt molestiae deleniti sed neque.", "537-73-6602", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 333, DateTimeKind.Local).AddTicks(2521), "Cynthia Davis" },
                    { 46, new DateTime(2021, 8, 9, 17, 30, 30, 333, DateTimeKind.Local).AddTicks(6597), "sydnee@zieme.us", "Aut distinctio eveniet optio quo reiciendis amet culpa voluptatum praesentium. Veniam est quibusdam sit. Debitis laboriosam consequuntur sunt provident voluptatem et soluta quidem quam. Aut tenetur eius quia tempore incidunt.", "442-41-7518", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 333, DateTimeKind.Local).AddTicks(6602), "Susie Prohaska" },
                    { 47, new DateTime(2021, 8, 9, 17, 30, 30, 334, DateTimeKind.Local).AddTicks(603), "taryn@volkman.com", "Maiores est et magni officiis nostrum veritatis. Est sapiente eligendi laboriosam. Quo id quibusdam aut dignissimos perferendis quaerat.", "590-75-0187", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 334, DateTimeKind.Local).AddTicks(607), "Dr. Luciano Corene Langworth" },
                    { 48, new DateTime(2021, 8, 9, 17, 30, 30, 334, DateTimeKind.Local).AddTicks(4980), "matt_anderson@gottlieb.ca", "Ex et deserunt perspiciatis esse provident vel.", "427-99-4514", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 334, DateTimeKind.Local).AddTicks(4986), "Cameron Brandyn Altenwerth MD" },
                    { 49, new DateTime(2021, 8, 9, 17, 30, 30, 334, DateTimeKind.Local).AddTicks(9096), "brenda@zieme.co.uk", "Vero officia consequatur autem et vel eius nihil distinctio. Labore voluptas consequatur ipsum suscipit.", "002-93-3905", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 334, DateTimeKind.Local).AddTicks(9102), "Mrs. Russ Odie Stehr V" },
                    { 50, new DateTime(2021, 8, 9, 17, 30, 30, 335, DateTimeKind.Local).AddTicks(4845), "retta@grady.name", "Optio excepturi amet et et officiis. Incidunt qui officiis qui eligendi voluptas et exercitationem autem. Numquam blanditiis distinctio eveniet placeat quo. Et odio sint libero.", "418-86-4415", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 335, DateTimeKind.Local).AddTicks(4852), "Maryjane Rempel" },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 319, DateTimeKind.Local).AddTicks(1658), "andrew@rempelbode.us", "Est saepe consequuntur sed aut fugit neque ducimus est. Est voluptates repellendus debitis aliquid dicta libero explicabo animi. Consequatur qui mollitia quisquam quia quisquam voluptas tempora nihil.", "218-42-1052", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 319, DateTimeKind.Local).AddTicks(1674), "Ms. Maritza White MD" },
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 318, DateTimeKind.Local).AddTicks(6988), "nicolas.ankunding@dibbert.biz", "Exercitationem sunt neque quas facilis quae deserunt quia odit doloribus. Sunt voluptates dolorem sequi porro numquam et omnis at. Quisquam adipisci aut excepturi qui sapiente repudiandae quibusdam.", "425-85-9589", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 318, DateTimeKind.Local).AddTicks(7326), "Johathan Borer" },
                    { 31, new DateTime(2021, 8, 9, 17, 30, 30, 328, DateTimeKind.Local).AddTicks(2018), "aida_bauch@streich.com", "Nesciunt itaque sunt totam consequuntur saepe. Temporibus nemo ea consequatur.", "320-39-5621", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 328, DateTimeKind.Local).AddTicks(2021), "Mrs. Joshua Bartell V" },
                    { 30, new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(9256), "spencer@senger.com", "Aut velit quia qui eveniet est exercitationem. Culpa voluptas qui soluta ut.", "500-49-8235", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(9258), "Marilou Padberg" },
                    { 29, new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(6435), "erik.beier@windler.us", "Minus nostrum consequuntur optio. Est vel cupiditate qui autem nam vitae. Et ipsam quis laudantium tenetur.", "288-92-1845", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(6437), "Miss Sasha Colin Paucek V" },
                    { 28, new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(2682), "jeffery@koelpinmayer.ca", "Laudantium quia unde molestiae porro.", "389-57-6665", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(2689), "Madaline Stracke" },
                    { 6, new DateTime(2021, 8, 9, 17, 30, 30, 320, DateTimeKind.Local).AddTicks(6079), "brook@flatley.com", "Fuga nulla debitis quidem voluptate saepe saepe nihil harum.", "338-53-4977", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 320, DateTimeKind.Local).AddTicks(6085), "Gregorio Harvey" },
                    { 7, new DateTime(2021, 8, 9, 17, 30, 30, 320, DateTimeKind.Local).AddTicks(8649), "jordyn_romaguera@gutkowski.uk", "Assumenda maxime voluptatem mollitia. Quo sint animi aut odit sunt.", "091-35-4629", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 320, DateTimeKind.Local).AddTicks(8651), "Abdul Ziemann" },
                    { 8, new DateTime(2021, 8, 9, 17, 30, 30, 321, DateTimeKind.Local).AddTicks(1661), "kelton_wisoky@botsford.ca", "Necessitatibus dolor voluptatem cumque vel enim esse. Rerum sunt accusamus ea.", "166-85-0998", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 321, DateTimeKind.Local).AddTicks(1663), "Oswald Bayer" },
                    { 9, new DateTime(2021, 8, 9, 17, 30, 30, 321, DateTimeKind.Local).AddTicks(4336), "newton@mante.info", "A qui architecto autem ut impedit placeat qui nesciunt.", "520-22-1827", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 321, DateTimeKind.Local).AddTicks(4339), "Domenic Metz" },
                    { 10, new DateTime(2021, 8, 9, 17, 30, 30, 321, DateTimeKind.Local).AddTicks(6962), "jalyn.auer@gaylord.us", "Atque libero officiis ut magni.", "353-60-5799", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 321, DateTimeKind.Local).AddTicks(6964), "George Casper" },
                    { 11, new DateTime(2021, 8, 9, 17, 30, 30, 322, DateTimeKind.Local).AddTicks(1127), "shaniya@champlin.us", "Qui non est sed repudiandae placeat est. Unde animi perferendis consequatur autem voluptatem quia iure consequatur. Eligendi qui qui repellat saepe ut quibusdam quasi unde praesentium. Odio aspernatur libero vitae odio mollitia vel voluptatem molestias.", "379-51-8056", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 322, DateTimeKind.Local).AddTicks(1132), "Erich Abernathy" },
                    { 12, new DateTime(2021, 8, 9, 17, 30, 30, 322, DateTimeKind.Local).AddTicks(3220), "cathryn@kessler.name", "Reprehenderit sunt ducimus tenetur.", "023-13-3198", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 322, DateTimeKind.Local).AddTicks(3223), "Miss Everett Grady IV" },
                    { 13, new DateTime(2021, 8, 9, 17, 30, 30, 322, DateTimeKind.Local).AddTicks(6666), "roderick.hoeger@kertzmann.us", "Quibusdam molestiae libero eius qui consequuntur quo. Et amet tempore dolorum aliquam omnis eum aut. Adipisci fugit possimus deleniti dolore veritatis aspernatur repellendus praesentium quaerat. Illo molestiae beatae necessitatibus.", "413-86-3957", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 322, DateTimeKind.Local).AddTicks(6669), "Brown Weissnat" },
                    { 14, new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(201), "floy@murazik.co.uk", "Ullam suscipit similique ea autem aperiam iste ut modi beatae. Sint veniam et molestiae aperiam. Explicabo tenetur a est corrupti suscipit sunt occaecati pariatur. Quos voluptas qui commodi nesciunt et est.", "446-11-3409", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(206), "Carlie Roob" },
                    { 15, new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(2501), "april.jakubowski@collier.info", "Ipsum voluptatem sequi quia nisi optio eum.", "004-95-4677", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(2504), "Yadira Williamson" },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 319, DateTimeKind.Local).AddTicks(7906), "deondre@tromp.name", "Dolorum voluptatem ipsum animi odio.", "153-93-1400", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 319, DateTimeKind.Local).AddTicks(7914), "Osbaldo Bauch" },
                    { 16, new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(5195), "agustin.ebert@zulaufraynor.co.uk", "Totam nisi explicabo distinctio nostrum. Maiores amet odit cum libero non et.", "441-80-9888", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(5197), "Gladys King" },
                    { 18, new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(1888), "sunny_bruen@herzog.uk", "Dolor perferendis non corporis qui voluptas quo quis. Ex dolor qui qui ut atque doloremque ab quam illum.", "380-05-6072", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(1890), "Tressie Runolfsdottir MD" },
                    { 19, new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(5277), "damaris@gibsonkonopelski.com", "Magni accusamus qui et. Ut ad explicabo soluta modi asperiores in beatae et. Aut voluptas consequatur est temporibus aut est maiores. Rerum quam nihil placeat non sunt voluptas nam.", "147-43-9544", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(5279), "Hank Corkery" },
                    { 20, new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(7483), "sophie@douglas.biz", "Quia doloribus facilis ab. Deserunt asperiores nisi ut consectetur.", "543-10-9100", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(7485), "Edd Ullrich" },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 319, DateTimeKind.Local).AddTicks(4855), "ines_auer@schmidtmclaughlin.info", "Exercitationem placeat cupiditate qui ea voluptate. Vel laboriosam et suscipit.", "010-97-4113", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 319, DateTimeKind.Local).AddTicks(4871), "Christophe Swaniawski" },
                    { 22, new DateTime(2021, 8, 9, 17, 30, 30, 325, DateTimeKind.Local).AddTicks(2166), "harold@pfeffer.info", "Exercitationem aut soluta ab necessitatibus. Rerum qui temporibus non.", "288-01-2027", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 325, DateTimeKind.Local).AddTicks(2168), "Myrna Hyatt" },
                    { 23, new DateTime(2021, 8, 9, 17, 30, 30, 325, DateTimeKind.Local).AddTicks(4751), "stacy@wunsch.info", "Commodi fuga voluptatem sequi et impedit officiis aut eum. Vitae expedita nam qui quasi.", "532-46-7772", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 325, DateTimeKind.Local).AddTicks(4759), "Enola Stanton" },
                    { 24, new DateTime(2021, 8, 9, 17, 30, 30, 325, DateTimeKind.Local).AddTicks(8253), "keira_ohara@kuhic.uk", "Repudiandae et unde in quia maxime placeat fugiat voluptatem vero. Et et architecto nesciunt facilis qui molestiae veritatis placeat non. Iste officiis ratione eius aliquam maiores earum eius accusantium dignissimos.", "372-75-6414", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 325, DateTimeKind.Local).AddTicks(8256), "Reina Welch" },
                    { 25, new DateTime(2021, 8, 9, 17, 30, 30, 326, DateTimeKind.Local).AddTicks(1726), "carlee@stracke.co.uk", "Quaerat repellat voluptatem velit vero accusamus dolore.", "309-80-0953", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 326, DateTimeKind.Local).AddTicks(1733), "Kyleigh Lockman" },
                    { 26, new DateTime(2021, 8, 9, 17, 30, 30, 326, DateTimeKind.Local).AddTicks(5978), "juanita_vandervort@weberhyatt.biz", "Et nemo quasi quo est et dolor adipisci quisquam.", "559-31-6177", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 326, DateTimeKind.Local).AddTicks(5983), "Miss Pink Daphney Kuhlman PhD" },
                    { 27, new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(40), "elisha_hegmann@luettgenabshire.name", "Quibusdam a ex quos et velit ipsum.", "362-10-8775", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 327, DateTimeKind.Local).AddTicks(49), "Prof. General Lesley Okuneva DVM" },
                    { 17, new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(8872), "arely.kris@graham.name", "Tempora alias ut beatae. Tempore deleniti reiciendis explicabo accusantium in repellat commodi harum aliquid. Quo quisquam veritatis est enim nihil non natus in.", "446-04-9181", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 323, DateTimeKind.Local).AddTicks(8879), "Toy Pfannerstill" },
                    { 21, new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(9943), "newell_oconner@hegmannmosciski.info", "Rerum dolor sed deserunt perferendis impedit incidunt dolores.", "107-62-3647", "+201206784139", new DateTime(2021, 8, 9, 17, 30, 30, 324, DateTimeKind.Local).AddTicks(9945), "Jany Bernhard PhD" }
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "Id", "ContactName", "CreatedAt", "Email", "Message", "Phone", "StatusId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Isidro Koepp", new DateTime(2021, 8, 9, 17, 30, 30, 251, DateTimeKind.Local).AddTicks(356), "kianna@corkery.us", "Et velit quos sint dolores fugit veritatis iusto. Autem illo vero dolores aut. Aut et eum dolorem maxime beatae quod ut minus sapiente. Soluta omnis ipsam esse quidem quisquam dolor temporibus ut.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 251, DateTimeKind.Local).AddTicks(701) },
                    { 28, "Mrs. Nils Murazik", new DateTime(2021, 8, 9, 17, 30, 30, 268, DateTimeKind.Local).AddTicks(4034), "marlee.gorczany@weimanncollins.com", "At saepe et esse ullam vitae rerum eos. Autem excepturi aut vero quaerat ducimus autem. Repudiandae adipisci veniam ab explicabo nulla. Sed quae molestiae et animi.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 268, DateTimeKind.Local).AddTicks(4041) },
                    { 29, "Susie Kiel Tromp II", new DateTime(2021, 8, 9, 17, 30, 30, 269, DateTimeKind.Local).AddTicks(6261), "malcolm.ledner@lang.ca", "Odio doloribus a error et. Tempore quisquam id perspiciatis sapiente ducimus. Doloremque necessitatibus autem consequatur architecto rem molestias voluptate voluptas occaecati. Autem in excepturi maxime dolorem dicta. Tempore eveniet inventore incidunt totam.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 269, DateTimeKind.Local).AddTicks(6275) },
                    { 30, "Miss Marianna Alicia Boyer Jr.", new DateTime(2021, 8, 9, 17, 30, 30, 270, DateTimeKind.Local).AddTicks(4787), "kim@mann.ca", "Modi dolor est fuga vel ut. Magnam et quidem laborum et commodi maxime necessitatibus sit. Architecto ut nam quisquam. Doloremque itaque illo mollitia iste. Eos quaerat in vel.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 270, DateTimeKind.Local).AddTicks(4794) },
                    { 31, "Dr. Breanne Yvonne Kuphal", new DateTime(2021, 8, 9, 17, 30, 30, 271, DateTimeKind.Local).AddTicks(2601), "al_mckenzie@carternolan.name", "Perspiciatis est dolores doloremque. Molestias numquam qui error rerum. Magni adipisci et molestias.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 271, DateTimeKind.Local).AddTicks(2607) },
                    { 32, "Ms. Wilton Owen Leannon", new DateTime(2021, 8, 9, 17, 30, 30, 272, DateTimeKind.Local).AddTicks(1972), "sally@hermiston.ca", "Ipsa alias dolor nulla nisi amet nostrum. Ab ea reprehenderit perferendis aut debitis consequatur ut. Fugiat quidem et non dolor vel et facilis dolores. Rem quibusdam nihil aut asperiores consectetur quaerat.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 272, DateTimeKind.Local).AddTicks(1978) },
                    { 33, "Mrs. Stefan Green Rohan IV", new DateTime(2021, 8, 9, 17, 30, 30, 273, DateTimeKind.Local).AddTicks(1728), "geovany.gottlieb@roberts.com", "Totam perferendis labore quibusdam et. Sint ipsam eos et facere quia provident. Tempore veritatis nobis repellendus amet nemo. Corrupti autem ex iure autem. Nemo perferendis sunt placeat est qui nihil.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 273, DateTimeKind.Local).AddTicks(1735) },
                    { 34, "Stacey Langworth", new DateTime(2021, 8, 9, 17, 30, 30, 274, DateTimeKind.Local).AddTicks(176), "louie@toy.co.uk", "Sit omnis ducimus deleniti veniam non dolor. Reiciendis tenetur nihil ipsa molestias voluptatem rerum soluta voluptatem aut. Numquam reprehenderit eaque dignissimos voluptates unde fuga. Facilis necessitatibus tempore distinctio facere similique.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 274, DateTimeKind.Local).AddTicks(183) },
                    { 35, "Ernie Tillman", new DateTime(2021, 8, 9, 17, 30, 30, 274, DateTimeKind.Local).AddTicks(6790), "meaghan@huel.name", "Sint officiis culpa corrupti. Consequatur in minus deleniti voluptatem eveniet corrupti ut. Non deleniti nihil et minima ut.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 274, DateTimeKind.Local).AddTicks(6795) },
                    { 36, "Jade Nienow", new DateTime(2021, 8, 9, 17, 30, 30, 275, DateTimeKind.Local).AddTicks(7107), "gregoria.abshire@zboncakrowe.uk", "Tempore laborum officiis et laborum voluptas ea qui assumenda reprehenderit. Voluptatum qui laboriosam debitis laudantium quis enim iusto maiores. Culpa quo natus vel dolorum minus voluptatem et. Dolores et perspiciatis quasi sapiente voluptatem in id. Qui facere blanditiis aut consequatur vel aut assumenda omnis ut.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 275, DateTimeKind.Local).AddTicks(7112) },
                    { 37, "Jacinto Heller", new DateTime(2021, 8, 9, 17, 30, 30, 276, DateTimeKind.Local).AddTicks(4621), "eula@okeefe.biz", "Quae ratione molestias minus. Nobis ratione quam illum ipsa eos enim. Perferendis illo possimus aliquam nihil distinctio et. Itaque nam aut repellendus corrupti nemo et facilis assumenda debitis.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 276, DateTimeKind.Local).AddTicks(4626) },
                    { 27, "Prof. Hiram Pouros", new DateTime(2021, 8, 9, 17, 30, 30, 267, DateTimeKind.Local).AddTicks(8733), "estevan.reinger@carrollpadberg.com", "Earum et et nihil. In occaecati ea enim rem. Ut et tempora laboriosam necessitatibus excepturi et perferendis ab.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 267, DateTimeKind.Local).AddTicks(8739) },
                    { 39, "Forest Lemke", new DateTime(2021, 8, 9, 17, 30, 30, 278, DateTimeKind.Local).AddTicks(1263), "melany@schowalterrempel.biz", "Id debitis accusantium dicta exercitationem tempore ipsum quo aut. Velit veniam est voluptatibus in velit expedita non qui animi. Sapiente facilis ad aut at molestiae debitis eligendi repellat aut. Repellendus quo ut nobis autem corrupti sint. Nobis ad repellat incidunt fugit temporibus quas ea porro ex.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 278, DateTimeKind.Local).AddTicks(1267) },
                    { 41, "Dee Dare", new DateTime(2021, 8, 9, 17, 30, 30, 282, DateTimeKind.Local).AddTicks(4600), "hans@upton.biz", "Fuga sit non ipsa odio assumenda qui. Quasi libero debitis tempore minima. Non in omnis non voluptatibus suscipit deserunt eveniet cupiditate.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 282, DateTimeKind.Local).AddTicks(4607) },
                    { 42, "Dr. Stefanie Fahey IV", new DateTime(2021, 8, 9, 17, 30, 30, 283, DateTimeKind.Local).AddTicks(92), "ofelia.grant@trantow.biz", "Quas ut nulla nemo blanditiis id qui dolorem explicabo est. Et recusandae dignissimos est blanditiis est accusantium voluptatem minima. Commodi illum a consequatur non doloribus porro quisquam neque deleniti. Ut laborum a eos repellendus unde architecto sit corporis. Voluptas consequatur incidunt magnam et voluptatem.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 283, DateTimeKind.Local).AddTicks(117) },
                    { 43, "Beryl Maggio", new DateTime(2021, 8, 9, 17, 30, 30, 283, DateTimeKind.Local).AddTicks(3657), "godfrey@oreilly.com", "Optio in eos maiores distinctio veritatis et fugit aspernatur. Perferendis officiis voluptates impedit qui cum. Cupiditate dolores minus placeat hic delectus ab sed.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 283, DateTimeKind.Local).AddTicks(3661) },
                    { 44, "Macey Kilback", new DateTime(2021, 8, 9, 17, 30, 30, 283, DateTimeKind.Local).AddTicks(7803), "xander@beer.us", "Nesciunt voluptatem et ea eveniet nobis vero non natus. Natus odit sunt sed ut cum sit. Placeat in id ut. Maiores quam vitae eos id tenetur aut eius quo impedit. Est ut quibusdam repellat reprehenderit aut neque.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 283, DateTimeKind.Local).AddTicks(7806) },
                    { 45, "Urban Stark", new DateTime(2021, 8, 9, 17, 30, 30, 284, DateTimeKind.Local).AddTicks(850), "filiberto.schroeder@shields.com", "Omnis tenetur tempore quos fugit repellat libero. Velit dolores consectetur est quis. Porro nisi aut qui tenetur quasi enim sit.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 284, DateTimeKind.Local).AddTicks(851) },
                    { 46, "Makenzie Jones", new DateTime(2021, 8, 9, 17, 30, 30, 284, DateTimeKind.Local).AddTicks(4264), "lina@mclaughlin.us", "Et nisi et culpa et. Qui eum deleniti maiores iusto quia ut. Id quo nulla expedita doloremque est enim aliquid. Nemo itaque ut facilis.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 284, DateTimeKind.Local).AddTicks(4266) },
                    { 47, "Lyla McKenzie", new DateTime(2021, 8, 9, 17, 30, 30, 284, DateTimeKind.Local).AddTicks(7240), "oren.stokes@gutkowskikozey.us", "Provident sint delectus laborum saepe qui omnis ducimus. Sint id sed itaque consequatur molestias esse enim natus.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 284, DateTimeKind.Local).AddTicks(7242) },
                    { 48, "Kadin O'Kon", new DateTime(2021, 8, 9, 17, 30, 30, 285, DateTimeKind.Local).AddTicks(636), "verna@hagenes.info", "Eos placeat amet quam. Earum sit voluptatum qui vitae numquam sit ut magnam. Optio amet quidem nemo eveniet. Dolorem dolor inventore dolores et veritatis et non.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 285, DateTimeKind.Local).AddTicks(638) },
                    { 49, "Dr. Tommie Cecile Hickle", new DateTime(2021, 8, 9, 17, 30, 30, 285, DateTimeKind.Local).AddTicks(4901), "vida@orn.biz", "Ut voluptatum illum eos aliquam atque nobis vero. Dolorem qui eos neque officiis consequatur ipsam vitae rerum nesciunt. Reprehenderit expedita illo et.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 285, DateTimeKind.Local).AddTicks(4914) },
                    { 50, "Edgar Sipes", new DateTime(2021, 8, 9, 17, 30, 30, 285, DateTimeKind.Local).AddTicks(9283), "adriana_hettinger@price.name", "Aut tempora eaque voluptatem. Quas autem voluptatem in quae. Totam quia recusandae laborum rem.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 285, DateTimeKind.Local).AddTicks(9290) },
                    { 40, "Laura Walker", new DateTime(2021, 8, 9, 17, 30, 30, 282, DateTimeKind.Local).AddTicks(965), "malvina_marquardt@ondricka.co.uk", "Delectus rerum ut ea. Fugiat tenetur voluptates ut veniam iste maxime. Voluptas ducimus pariatur error dolor consequatur dolor. In occaecati harum quasi et laudantium sunt.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 282, DateTimeKind.Local).AddTicks(999) },
                    { 26, "Katelynn Kirlin", new DateTime(2021, 8, 9, 17, 30, 30, 267, DateTimeKind.Local).AddTicks(3852), "cecil_rice@turcotte.us", "Qui fugit illo qui non quae illum labore dolorum. Ut eos omnis minus est eos. Nihil ipsum ut et similique eos tempora. Facilis illo vel sint sed quia in sed.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 267, DateTimeKind.Local).AddTicks(3857) },
                    { 38, "Ms. Izabella Shanahan", new DateTime(2021, 8, 9, 17, 30, 30, 277, DateTimeKind.Local).AddTicks(1136), "flavio@watsica.us", "Aliquam dignissimos sapiente deleniti aperiam vel asperiores hic tempora. Consequuntur culpa quidem quia vitae est ut.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 277, DateTimeKind.Local).AddTicks(1141) },
                    { 24, "Mr. Edmund Cassandre Schaden", new DateTime(2021, 8, 9, 17, 30, 30, 266, DateTimeKind.Local).AddTicks(4816), "queenie@hilll.us", "Illum voluptatibus molestias aut repudiandae illum est qui. Voluptatem est assumenda ullam iure sint aperiam maiores rerum. Provident explicabo dolorum at. Hic molestiae voluptatem quibusdam magnam ipsum et harum ducimus aliquid.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 266, DateTimeKind.Local).AddTicks(4823) },
                    { 25, "Kitty Lebsack", new DateTime(2021, 8, 9, 17, 30, 30, 266, DateTimeKind.Local).AddTicks(8709), "efrain@kertzmannmedhurst.biz", "Adipisci temporibus blanditiis ipsam culpa quia voluptas et. Facere iusto voluptates praesentium a sit cum quia.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 266, DateTimeKind.Local).AddTicks(8712) },
                    { 2, "Joaquin Ondricka", new DateTime(2021, 8, 9, 17, 30, 30, 251, DateTimeKind.Local).AddTicks(9080), "wilmer.mcdermott@heidenreicharmstrong.com", "Laboriosam rerum et expedita cupiditate neque magnam in. Voluptas dolor est soluta asperiores et ducimus porro in voluptate.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 251, DateTimeKind.Local).AddTicks(9117) },
                    { 3, "Dortha West", new DateTime(2021, 8, 9, 17, 30, 30, 252, DateTimeKind.Local).AddTicks(6004), "sabina@hilllrath.us", "Qui animi modi provident dicta doloribus cupiditate aut. Aliquid blanditiis provident incidunt rerum dolorem. Blanditiis deleniti aut aut adipisci perspiciatis ratione earum ipsa.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 252, DateTimeKind.Local).AddTicks(6017) },
                    { 4, "Arianna Satterfield II", new DateTime(2021, 8, 9, 17, 30, 30, 253, DateTimeKind.Local).AddTicks(4605), "emerald@wisozk.biz", "Eaque magni maxime doloremque eligendi. Doloremque alias velit vel. Inventore delectus eaque officiis. Iure accusamus ipsum nobis eos. Corporis laborum est est.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 253, DateTimeKind.Local).AddTicks(4615) },
                    { 5, "Mrs. Willy Molly Marquardt V", new DateTime(2021, 8, 9, 17, 30, 30, 254, DateTimeKind.Local).AddTicks(5607), "cassandre@langeichmann.name", "Voluptates minima aut consequatur iure. Corrupti qui distinctio nam voluptas illo. Id et est esse est vel voluptatem animi labore quisquam. Odit libero praesentium voluptatem magni et.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 254, DateTimeKind.Local).AddTicks(5616) },
                    { 6, "Shanie Collier", new DateTime(2021, 8, 9, 17, 30, 30, 255, DateTimeKind.Local).AddTicks(4700), "hortense_cormier@feest.uk", "Consequuntur est sunt nam distinctio velit. Eius quam debitis unde laudantium deserunt qui. Rerum non quis quia non quis molestias cupiditate. Maxime qui ipsa itaque harum accusantium nemo architecto itaque. Odit suscipit in nulla animi ipsam et.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 255, DateTimeKind.Local).AddTicks(4706) },
                    { 7, "Coty Berge", new DateTime(2021, 8, 9, 17, 30, 30, 256, DateTimeKind.Local).AddTicks(1594), "ewald@gloverturner.name", "Adipisci quam ut ut autem doloremque consequatur. Nesciunt voluptas officiis sed. Nesciunt cumque illum est velit consequatur.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 256, DateTimeKind.Local).AddTicks(1605) },
                    { 9, "Prof. Corene Lisette Block", new DateTime(2021, 8, 9, 17, 30, 30, 257, DateTimeKind.Local).AddTicks(8532), "kitty_schroeder@bernierstamm.co.uk", "Pariatur aperiam eaque eligendi ut. Minus distinctio odit ut excepturi qui. Tempore aut nihil possimus modi beatae nemo culpa ducimus. Dolorum eligendi dolorem praesentium odio eius ipsum qui ipsa repellat. Ut nostrum in dolores quia.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 257, DateTimeKind.Local).AddTicks(8540) },
                    { 10, "Theodore Reynolds", new DateTime(2021, 8, 9, 17, 30, 30, 258, DateTimeKind.Local).AddTicks(4692), "wendell@collier.biz", "Tempora occaecati nisi non qui quia voluptatem eveniet a qui. Qui magnam et pariatur magni non amet. Dolores veniam quam quis nemo.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 258, DateTimeKind.Local).AddTicks(4699) },
                    { 11, "William Kuhic", new DateTime(2021, 8, 9, 17, 30, 30, 258, DateTimeKind.Local).AddTicks(9554), "alfredo@yost.uk", "Tempore consequuntur ad qui temporibus ipsa. Dolorem aspernatur necessitatibus quia voluptatem qui voluptas omnis illum. Facilis veritatis nihil consequatur harum non ipsum explicabo.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 258, DateTimeKind.Local).AddTicks(9558) },
                    { 12, "Josiah Moen", new DateTime(2021, 8, 9, 17, 30, 30, 259, DateTimeKind.Local).AddTicks(3513), "duane_turcotte@wehner.name", "Quaerat autem modi officiis aliquam aut explicabo. Repudiandae necessitatibus dolorem repellendus.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 259, DateTimeKind.Local).AddTicks(3517) },
                    { 8, "Ronaldo Bernier Jr.", new DateTime(2021, 8, 9, 17, 30, 30, 256, DateTimeKind.Local).AddTicks(8620), "alize_schuster@runolfsson.biz", "Blanditiis nostrum omnis magnam eum. Optio nostrum error aspernatur et qui ad.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 256, DateTimeKind.Local).AddTicks(8630) },
                    { 22, "Justine Corwin", new DateTime(2021, 8, 9, 17, 30, 30, 265, DateTimeKind.Local).AddTicks(1421), "marjory@larson.info", "Maxime ut totam enim quibusdam libero sapiente minima dolore quis. Aut ipsum repellendus magni velit aut est qui. Dignissimos consequatur ut cumque vero. Quidem saepe magnam molestiae nisi quia itaque vitae nostrum voluptatem. Voluptatem aut non tempora dolorem.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 265, DateTimeKind.Local).AddTicks(1432) },
                    { 14, "Mrs. Ryley Fadel", new DateTime(2021, 8, 9, 17, 30, 30, 260, DateTimeKind.Local).AddTicks(6878), "jaleel.harber@millsfarrell.biz", "Voluptatem ut molestias quod dolor aut iusto. Et sint tenetur ipsa molestiae assumenda dicta corporis nisi. Numquam tempore maiores ab sed similique sit quae optio. Dolorem qui velit ut sit non. Reprehenderit voluptas et dolor sunt nam.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 260, DateTimeKind.Local).AddTicks(6892) },
                    { 15, "Mrs. Neva Alysa Roberts Jr.", new DateTime(2021, 8, 9, 17, 30, 30, 261, DateTimeKind.Local).AddTicks(3607), "eryn_smitham@rodriguez.ca", "Assumenda odio facilis quibusdam eligendi odio ut. Voluptatem vitae omnis distinctio ut provident aliquam.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 261, DateTimeKind.Local).AddTicks(3614) },
                    { 16, "Bradley Abernathy", new DateTime(2021, 8, 9, 17, 30, 30, 261, DateTimeKind.Local).AddTicks(8069), "hattie@lubowitzklocko.ca", "Placeat possimus odit dicta. Vitae assumenda ratione id non esse. Ipsam eveniet recusandae itaque unde.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 261, DateTimeKind.Local).AddTicks(8073) },
                    { 17, "Chelsea Mertz", new DateTime(2021, 8, 9, 17, 30, 30, 262, DateTimeKind.Local).AddTicks(2303), "dorcas@von.us", "Ipsa atque labore vitae. Aut deserunt dicta exercitationem porro. Provident soluta nobis autem omnis occaecati optio quos minus. Aut reprehenderit commodi dolor.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 262, DateTimeKind.Local).AddTicks(2306) },
                    { 18, "Lavon Kilback", new DateTime(2021, 8, 9, 17, 30, 30, 262, DateTimeKind.Local).AddTicks(8238), "douglas@spencer.com", "Voluptatem laborum deserunt veritatis architecto voluptatem. Odit aliquam mollitia est nisi laudantium cum. Eos et vero est numquam eos repellendus eligendi assumenda. Quis enim optio dignissimos pariatur ut mollitia et. Et itaque corrupti culpa rem qui blanditiis eos deserunt est.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 262, DateTimeKind.Local).AddTicks(8242) },
                    { 19, "Miss Pierre Mosciski", new DateTime(2021, 8, 9, 17, 30, 30, 263, DateTimeKind.Local).AddTicks(3726), "domenic.little@russel.info", "Soluta dicta ut corporis culpa occaecati. Cumque non maiores qui sit. Provident et excepturi maiores. Tenetur aut ut culpa expedita iusto et officia suscipit autem.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 263, DateTimeKind.Local).AddTicks(3729) },
                    { 20, "Cydney Jaskolski", new DateTime(2021, 8, 9, 17, 30, 30, 263, DateTimeKind.Local).AddTicks(7803), "keegan@grantwaters.com", "Hic commodi eligendi accusamus. Neque omnis rem sequi deserunt quae modi omnis. Ex occaecati consequatur omnis maiores.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 263, DateTimeKind.Local).AddTicks(7807) },
                    { 21, "Ms. Mallie Cheyenne Haley MD", new DateTime(2021, 8, 9, 17, 30, 30, 264, DateTimeKind.Local).AddTicks(4873), "bridie_bogan@hayes.us", "Tempora nihil et voluptatem laboriosam doloribus saepe rerum assumenda debitis. Pariatur nam aut at et aut et dolorem autem vero. Quo rerum laboriosam perspiciatis qui quia. Sint repudiandae incidunt dolorem. Qui quidem quasi veritatis et eum reiciendis ipsa.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 264, DateTimeKind.Local).AddTicks(4877) },
                    { 13, "Dr. Garland Smitham", new DateTime(2021, 8, 9, 17, 30, 30, 259, DateTimeKind.Local).AddTicks(9147), "ulises_herman@muller.biz", "Et rerum voluptas saepe non ipsam. Et fugiat et distinctio modi enim. Reprehenderit animi quo et ratione natus quia iure sed. Eos facilis ea unde qui cumque.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 259, DateTimeKind.Local).AddTicks(9152) },
                    { 23, "Miss Viva McCullough", new DateTime(2021, 8, 9, 17, 30, 30, 265, DateTimeKind.Local).AddTicks(8005), "javon.murray@willarmstrong.info", "Neque voluptatem et cum eos. Tempora libero quasi omnis velit reprehenderit facilis nobis quos incidunt. Voluptate blanditiis officiis eaque ut. Nulla nihil provident molestiae occaecati quae.", "+201206784139", 1, new DateTime(2021, 8, 9, 17, 30, 30, 265, DateTimeKind.Local).AddTicks(8014) }
                });

            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(1147), "Eos nihil doloremque accusamus ut qui ut ut saepe consequatur. Voluptatem quae sunt reiciendis libero et facere. Voluptatem porro omnis nihil explicabo culpa reprehenderit similique ab totam. Et totam non aut et ut laudantium. Aut aut incidunt hic sint et aut veniam.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(1149) },
                    { 6, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(8785), "Ratione ullam similique reiciendis consequatur quas dicta. Reiciendis aut incidunt totam. Nihil nulla nihil alias totam.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(8787) },
                    { 5, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(7830), "Similique ut omnis corporis occaecati inventore odit beatae. Dolores ut ratione quisquam.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(7833) },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(7097), "Voluptatem exercitationem facere tenetur. Accusantium ut magnam quam. Sit aut sit dolorum rerum consequuntur ut molestiae.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(7099) },
                    { 41, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(5377), "Quidem accusamus et est qui voluptas. Exercitationem et consectetur nihil neque minus. Necessitatibus et voluptatem quis ad iusto repellendus rem. Optio et rem similique voluptas. Perferendis veritatis ex quibusdam sequi adipisci.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(5382) },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(4258), "Id voluptatem provident occaecati. Aliquid placeat quod eos qui consectetur.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(4270) },
                    { 50, new DateTime(2021, 8, 9, 17, 30, 30, 296, DateTimeKind.Local).AddTicks(3374), "Ab minima debitis rerum ullam. Totam iure vitae consectetur enim quas laborum.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 296, DateTimeKind.Local).AddTicks(3377) },
                    { 42, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(6581), "Eos assumenda omnis iusto dolorem mollitia perspiciatis dolore cumque. Repudiandae sunt nam dolores non ullam et ut. Ut a qui aut.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(6583) },
                    { 8, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(2848), "Dolore consequuntur placeat dolor sit id delectus. Vero voluptatibus mollitia quidem optio sed eum fuga nihil. Voluptatem qui aut ut ipsa facilis. Atque vero ut officiis nesciunt a culpa maxime.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(2851) },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(6175), "Occaecati quia rerum dolores illo autem. Est ut est sit delectus. Quis veniam omnis accusamus odio dolores at. Nobis nihil itaque tenetur dolor consequatur. Illo dolores ad reiciendis consequatur accusamus quis sunt consequuntur.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(6177) },
                    { 10, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(5669), "Consequatur impedit assumenda omnis sed optio doloribus. Libero tenetur ab amet minima qui vero et laborum. Enim blanditiis inventore qui natus iure dolorem esse dolore sint. Facere quo qui perspiciatis quia.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(5671) },
                    { 49, new DateTime(2021, 8, 9, 17, 30, 30, 296, DateTimeKind.Local).AddTicks(2317), "Iste dolorem ducimus sed in repellat quia. Consectetur tenetur voluptates amet omnis beatae velit. Cum dolor distinctio et voluptatem.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 296, DateTimeKind.Local).AddTicks(2319) },
                    { 16, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(2808), "Laudantium sunt est suscipit libero iure ipsum enim expedita sit. Eos nihil aut officiis quaerat error et labore.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(2810) },
                    { 24, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(6120), "Modi eos consequatur et. Ducimus perspiciatis aut illum ratione. Quo reiciendis rerum aspernatur eos ullam est eos quia.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(6125) },
                    { 26, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(656), "Ut dicta ullam at iusto. Dicta laudantium animi et sint consequatur. Facilis adipisci iure possimus perferendis explicabo exercitationem.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(663) },
                    { 29, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(7090), "Eveniet voluptatem nesciunt ab. Impedit amet suscipit quaerat nobis minus dolorem ducimus. Eveniet quaerat reiciendis quasi et eius. Nihil ut inventore in quo ea vitae.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(7094) },
                    { 31, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(575), "Similique voluptas provident quia excepturi sint voluptas consequatur incidunt. Corporis distinctio quisquam qui ut aut beatae iste. Ut quasi eum vero vero voluptas quia quaerat debitis. Facere eum unde et perferendis.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(577) },
                    { 32, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(2432), "Sed debitis doloribus debitis mollitia reiciendis nulla quae enim vel. Omnis expedita incidunt omnis quos ut. Eos aliquam omnis magni rerum nesciunt voluptates. Neque culpa nostrum quia enim autem totam et eum adipisci.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(2433) },
                    { 36, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(8133), "Voluptates tenetur velit commodi consequatur. Temporibus dolorem consectetur omnis accusantium odio. Eum voluptatum facilis nulla et qui inventore. Beatae a et et vitae autem cum ut recusandae et.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(8135) },
                    { 38, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(1035), "In nostrum aperiam nisi et occaecati magni. Debitis quibusdam sit beatae quo autem. Qui ut dolores aut ipsa soluta delectus cupiditate dignissimos. Error repudiandae et rem exercitationem.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(1037) },
                    { 44, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(1133), "Est porro eligendi reprehenderit veritatis neque. Animi expedita ut quia consequuntur officia qui odit. Perspiciatis quae voluptates eum aliquam qui tempore sed. Quidem fuga cupiditate et voluptatem et est.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(1137) },
                    { 48, new DateTime(2021, 8, 9, 17, 30, 30, 296, DateTimeKind.Local).AddTicks(748), "Velit blanditiis non corporis nemo quibusdam qui. Et vitae autem omnis et. Autem sint aut deserunt perferendis eum omnis vitae impedit omnis. Quae deleniti dolorem qui quia animi quod dolor. Soluta deserunt sit vel sunt.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 296, DateTimeKind.Local).AddTicks(752) },
                    { 40, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(3568), "Optio ut itaque vel amet. Ex consequatur quas in velit dolor atque eligendi qui commodi.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(3570) },
                    { 14, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(276), "Recusandae et aperiam voluptatem commodi nobis fugit deleniti reprehenderit. Quisquam est architecto distinctio est.", "alias", 3, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(278) },
                    { 39, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(2716), "Sint rerum totam autem est consequatur. Quas officiis velit nesciunt qui quam dolores commodi quia. Accusamus ea quia molestias iusto. Eos quis sit vel. Ratione ex facilis omnis voluptate.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(2718) },
                    { 37, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(9483), "Quae tempora delectus in velit recusandae excepturi est. Voluptas qui maxime dolores doloribus dolor. Error vero et consectetur consequatur ut eos cupiditate explicabo explicabo.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(9484) },
                    { 35, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(6591), "Repudiandae corporis excepturi repudiandae necessitatibus vel autem culpa ut. Aut qui ullam cupiditate omnis aut quia id tempore dolor. Quia eligendi numquam aut et ad ea sequi iure molestiae. Labore corrupti in ut tenetur illum eius enim.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(6593) },
                    { 11, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(6538), "Quisquam ex eum officia voluptatem nesciunt voluptas sit. A debitis praesentium praesentium eum sed non.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(6540) },
                    { 13, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(9383), "Officiis deleniti non occaecati. Distinctio autem error maiores aliquid rem beatae laboriosam dolores vitae. Et similique velit excepturi quia. In rem harum optio praesentium porro quisquam. Cum omnis eligendi quae.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(9384) },
                    { 17, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(4401), "Autem placeat eveniet facilis nesciunt soluta. Est aspernatur itaque vero et. Sint magnam accusantium nobis. Deleniti repellat quas voluptas vero eveniet tempore et impedit est.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(4406) },
                    { 20, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(8921), "Similique eveniet at porro qui perferendis. Maxime enim mollitia earum quia. Rem ex in animi optio quas officia voluptas.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(8923) },
                    { 21, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(699), "Labore nemo omnis possimus. Corrupti cum similique mollitia ipsa et est repellat sed fugit. Rem adipisci possimus sit architecto. Consequatur architecto est suscipit neque deleniti quaerat.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(704) },
                    { 22, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(2801), "Laboriosam accusantium quos similique. Quas magni aut velit. Quo ullam pariatur recusandae qui labore ad dolores sunt veniam. Vel vel tenetur quo. Et ut deleniti illo vitae cupiditate.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(2806) },
                    { 23, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(4491), "Non deserunt minus officia ut. Necessitatibus perferendis esse quod maiores consequuntur fugiat nemo id. Et ut aperiam et quisquam.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(4502) },
                    { 43, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(8388), "Quis hic laboriosam quaerat. Et asperiores itaque eius consequuntur sint dicta. In necessitatibus distinctio nihil libero et. Vitae sint et corporis placeat vel nesciunt voluptatem.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 294, DateTimeKind.Local).AddTicks(8394) },
                    { 45, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(2400), "Aperiam consectetur veniam ducimus. Error voluptatem tempore sint. Modi cupiditate tenetur repellendus recusandae itaque. Commodi fugit mollitia hic.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(2402) },
                    { 46, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(4491), "Soluta et officiis adipisci officia at ratione voluptatem. Architecto doloremque repudiandae magni aliquam maiores sed officiis. Doloribus est unde eius aut et temporibus.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(4496) },
                    { 47, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(7894), "Voluptatem voluptatum voluptatum voluptas aut aut officia corporis. Facere at quis sed est ut eos. Assumenda aspernatur sunt harum alias quo aut quasi. Ullam ea aspernatur at veritatis sed placeat modi odit iure.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 295, DateTimeKind.Local).AddTicks(7898) },
                    { 9, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(3930), "Accusantium ratione odit est sequi amet reprehenderit quos sapiente. Totam dignissimos cupiditate perspiciatis et. Sapiente dignissimos et iure.", "alias", 1, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(3932) },
                    { 12, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(7636), "Est ut ipsa nesciunt. Vero aliquam odio molestiae in. Quae voluptas enim asperiores totam ea nihil autem qui nam.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 289, DateTimeKind.Local).AddTicks(7637) },
                    { 15, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(1744), "Eos nesciunt ipsum aspernatur quo ea a fugit quam. Quas enim vel reiciendis optio ullam adipisci nesciunt et excepturi. Rerum soluta amet praesentium non dignissimos voluptatem.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(1746) },
                    { 18, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(6107), "Inventore ducimus consectetur odit aut sed perspiciatis reprehenderit pariatur. Sunt ipsum aut eum. Est minima voluptate modi voluptas facilis. Consequatur vitae autem cum sunt voluptas aut.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(6111) },
                    { 19, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(7700), "Molestiae id molestiae occaecati iste dolore sit. Voluptatem odio labore tenetur ipsa natus provident sed repellendus deleniti. Et quasi odio voluptatem totam tempore magni ut.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 290, DateTimeKind.Local).AddTicks(7705) },
                    { 25, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(8978), "Rem numquam et nesciunt provident voluptatem temporibus ut. Ab veniam aut blanditiis voluptas culpa ratione. Voluptates impedit quidem qui. Est esse eius dolorem velit blanditiis ea delectus. Repellendus reprehenderit distinctio fuga inventore.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 291, DateTimeKind.Local).AddTicks(8987) },
                    { 27, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(3405), "Consequatur aut mollitia non dolore ea vitae. Ea facere suscipit iste quam recusandae fugiat est tempora esse. Nesciunt vitae placeat aut deserunt voluptatem. Aut tenetur consequatur ad id necessitatibus enim occaecati atque.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(3414) },
                    { 28, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(5221), "Sit culpa modi illum ipsam. Molestias quam quo ducimus porro. Qui est et qui perferendis molestiae. Ratione nemo et esse.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(5226) },
                    { 30, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(8851), "Aliquid aliquam deleniti ut. Aut et qui qui doloribus accusantium omnis unde. Harum quia ipsum at laudantium ab voluptatem eaque unde molestiae. Minus sint magnam qui qui autem ullam nostrum atque numquam.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 292, DateTimeKind.Local).AddTicks(8852) },
                    { 33, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(3546), "Distinctio rerum accusantium beatae voluptas laboriosam corporis accusamus expedita ad. Deleniti voluptas dolore ex. Ea tempora quia ut et ipsam.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(3548) },
                    { 34, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(4570), "Autem hic quasi laborum et soluta sit pariatur. Et omnis commodi nisi molestias iure et aliquam nobis corporis.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 293, DateTimeKind.Local).AddTicks(4571) },
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(3010), "Quos non voluptas rerum et velit nobis voluptatem sint aut. Qui autem atque nemo tenetur quis facilis dolores quasi. Non rerum quae voluptatem nesciunt ipsam ea. Voluptatem optio quas excepturi ratione dolorem placeat quam.", "alias", 2, new DateTime(2021, 8, 9, 17, 30, 30, 288, DateTimeKind.Local).AddTicks(3301) }
                });

            migrationBuilder.InsertData(
                table: "userlinks",
                columns: new[] { "Id", "CreatedAt", "Link", "TypeId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 35, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8467), "http://www.monahan.uk/guide/index.gem", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8468), 35 },
                    { 34, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8321), "http://www.wuckert.us/reviews/template.htm", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8322), 34 },
                    { 33, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8171), "http://www.wolf.us/shop/books/form.aspx", 2, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8172), 33 },
                    { 32, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7815), "http://www.kreiger.biz/films/root.asp", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7817), 32 },
                    { 27, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6758), "http://www.schamberger.co.uk/facts/template.htm", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6759), 27 },
                    { 30, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7306), "http://www.langworth.name/films/resource.jsp", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7307), 30 },
                    { 29, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7163), "http://www.gutkowski.co.uk/guide/template.gem", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7164), 29 },
                    { 28, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7014), "http://www.doylemann.us/home/template.jsp", 2, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7015), 28 },
                    { 36, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8824), "http://www.gutmann.info/shop/resource.asp", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(8825), 36 },
                    { 31, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7453), "http://www.stoltenberg.uk/catalog/form.html", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(7454), 31 },
                    { 37, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9013), "http://www.homenick.co.uk/shop/resource.aspx", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9014), 37 },
                    { 42, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(318), "http://www.mertz.biz/shop/food/template.lsp", 2, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(319), 42 },
                    { 39, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9632), "http://www.lind.info/reviews/page.aspx", 2, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9633), 39 },
                    { 40, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9805), "http://www.haag.info/shop/films/index.gem", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9806), 40 },
                    { 41, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(166), "http://www.muller.name/shop/form.aspx", 4, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(167), 41 },
                    { 43, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(459), "http://www.flatley.ca/articles/page.rsx", 3, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(460), 43 },
                    { 44, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(820), "http://www.cruickshank.biz/shop/books/root.asp", 2, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(821), 44 },
                    { 45, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(1183), "http://www.roob.us/films/template.asp", 1, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(1184), 45 },
                    { 46, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(1330), "http://www.carroll.us/shop/food/root.gem", 1, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(1331), 46 },
                    { 47, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(1615), "http://www.wunschlueilwitz.uk/shop/books/template.gem", 4, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(1617), 47 },
                    { 48, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(2009), "http://www.macejkovic.info/shop/books/resource.res", 2, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(2011), 48 },
                    { 26, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6611), "http://www.crooks.ca/shop/books/template.aspx", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6612), 26 },
                    { 38, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9274), "http://www.hermannbogan.com/shop/food/template.asp", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(9275), 38 },
                    { 25, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6468), "http://www.spencerherman.co.uk/shop/films/template.jsp", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6469), 25 },
                    { 13, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3502), "http://www.considine.co.uk/reviews/index.res", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3503), 13 },
                    { 23, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5956), "http://www.sauertowne.co.uk/catalog/applet.jsp", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5958), 23 },
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(1948), "http://www.towne.co.uk/articles/applet.aspx", 2, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(2246), 1 },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(3229), "http://www.howellbailey.us/reviews/resource.res", 3, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(3249), 2 },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(3579), "http://www.toy.info/articles/page.asp", 1, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(3581), 3 },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(4022), "http://www.grimeszboncak.co.uk/shop/films/root.rsx", 3, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(4024), 4 },
                    { 5, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(4568), "http://www.barrowsrutherford.ca/catalog/page.aspx", 2, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(4571), 5 },
                    { 6, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(5064), "http://www.schuster.info/articles/template.jsp", 4, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(5072), 6 },
                    { 7, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(5360), "http://www.kerluke.com/guide/root.html", 3, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(5362), 7 },
                    { 8, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(5613), "http://www.weber.info/films/template.asp", 1, new DateTime(2021, 8, 9, 17, 30, 30, 336, DateTimeKind.Local).AddTicks(5614), 8 },
                    { 9, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(2011), "http://www.satterfield.info/facts/page.rsx", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(2017), 9 },
                    { 10, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(2455), "http://www.windler.name/shop/template.lsp", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(2457), 10 },
                    { 24, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6209), "http://www.kuphalkuhn.name/facts/applet.aspx", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(6211), 24 },
                    { 11, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(2841), "http://www.damore.info/shop/applet.gem", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(2842), 11 },
                    { 49, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(2157), "http://www.kutch.name/reviews/index.rsx", 1, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(2158), 49 },
                    { 14, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3761), "http://www.hermistongerhold.us/films/index.asp", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3762), 14 },
                    { 15, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3915), "http://www.quigley.com/films/template.res", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3916), 15 },
                    { 16, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(4170), "http://www.larsongulgowski.ca/catalog/resource.aspx", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(4171), 16 },
                    { 17, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(4536), "http://www.koch.info/interviews/template.res", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(4537), 17 },
                    { 18, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(4901), "http://www.johns.info/shop/books/index.gem", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(4902), 18 },
                    { 19, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5049), "http://www.rempel.name/shop/books/form.rsx", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5050), 19 },
                    { 20, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5307), "http://www.hauckaltenwerth.uk/facts/template.jsp", 4, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5308), 20 },
                    { 21, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5560), "http://www.willmsullrich.com/home/template.res", 3, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5561), 21 },
                    { 22, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5704), "http://www.nolan.com/catalog/resource.rsx", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(5705), 22 },
                    { 12, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3136), "http://www.jewessheller.biz/shop/films/form.lsp", 1, new DateTime(2021, 8, 9, 17, 30, 30, 337, DateTimeKind.Local).AddTicks(3136), 12 },
                    { 50, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(2302), "http://www.berge.name/interviews/resource.gem", 3, new DateTime(2021, 8, 9, 17, 30, 30, 338, DateTimeKind.Local).AddTicks(2303), 50 }
                });

            migrationBuilder.InsertData(
                table: "projectfeedbacks",
                columns: new[] { "Id", "CreatedAt", "Feedback", "ProjectId" },
                values: new object[,]
                {
                    { 36, new DateTime(2021, 8, 9, 17, 30, 30, 303, DateTimeKind.Local).AddTicks(3435), "Quam ullam sed ea consequatur. Rerum consectetur hic impedit asperiores aut omnis non sapiente.", 9 },
                    { 45, new DateTime(2021, 8, 9, 17, 30, 30, 304, DateTimeKind.Local).AddTicks(9042), "Ad non similique et. Deserunt expedita dolores et voluptates qui aspernatur ut. Explicabo voluptatem id autem sit dolorem ea assumenda vero.", 32 },
                    { 29, new DateTime(2021, 8, 9, 17, 30, 30, 301, DateTimeKind.Local).AddTicks(3124), "Reprehenderit amet blanditiis doloremque. Eos voluptas perferendis minima accusantium eos. Molestiae ut enim non expedita impedit ratione.", 27 },
                    { 31, new DateTime(2021, 8, 9, 17, 30, 30, 302, DateTimeKind.Local).AddTicks(391), "Impedit aut provident aut porro est iste velit aliquid. Inventore tenetur reprehenderit ullam nihil expedita quo praesentium voluptatem. Atque eveniet aut accusamus aut vero cum quasi.", 6 },
                    { 9, new DateTime(2021, 8, 9, 17, 30, 30, 298, DateTimeKind.Local).AddTicks(5205), "In cupiditate illo ex. Voluptatem qui maxime atque et sequi veniam. Quod molestiae quaerat labore et quia id laboriosam labore. Quidem voluptatum ut rerum.", 32 },
                    { 26, new DateTime(2021, 8, 9, 17, 30, 30, 300, DateTimeKind.Local).AddTicks(7577), "Delectus quia debitis placeat alias et quidem pariatur. Nostrum perspiciatis corporis magni deleniti aut deleniti. Voluptatibus aperiam qui autem et dolorem. Aut id doloremque est omnis quasi.", 45 },
                    { 46, new DateTime(2021, 8, 9, 17, 30, 30, 305, DateTimeKind.Local).AddTicks(113), "Tempore reiciendis non velit sint totam. Vitae deserunt eum temporibus illum velit distinctio repudiandae et culpa. Blanditiis doloribus ipsam cumque.", 35 },
                    { 32, new DateTime(2021, 8, 9, 17, 30, 30, 302, DateTimeKind.Local).AddTicks(4245), "Earum incidunt eum et repellendus ut esse quia. Iusto amet ut a atque. Sint iure ipsam magni blanditiis est quo laboriosam quibusdam repudiandae. Et debitis placeat amet est.", 46 },
                    { 17, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(5359), "Provident ipsa ea nihil. Qui vero molestiae aut eligendi.", 47 },
                    { 30, new DateTime(2021, 8, 9, 17, 30, 30, 301, DateTimeKind.Local).AddTicks(6064), "Voluptas amet unde ratione qui dolor. Atque voluptatum eos suscipit autem officiis fugiat. Quisquam odio eos dolor dicta sed fuga eum. Repellendus dolores non sit dicta et laborum. Ut reprehenderit temporibus ut et illo quasi sequi temporibus.", 34 },
                    { 27, new DateTime(2021, 8, 9, 17, 30, 30, 300, DateTimeKind.Local).AddTicks(9548), "Aliquid voluptates eos similique quas quaerat possimus. At optio commodi repellendus eius fuga ea enim cupiditate. Perspiciatis est quia ea. Sed non adipisci incidunt. Accusantium aut saepe et.", 34 },
                    { 6, new DateTime(2021, 8, 9, 17, 30, 30, 298, DateTimeKind.Local).AddTicks(903), "Iusto eligendi vitae iusto id aut et sapiente aliquam distinctio. Maxime repudiandae aut nobis exercitationem eligendi omnis dolor dolore id. Dolore ipsam perspiciatis alias eius sed nulla ut.", 29 },
                    { 23, new DateTime(2021, 8, 9, 17, 30, 30, 300, DateTimeKind.Local).AddTicks(2904), "Nulla aliquid asperiores magni nisi voluptatibus aut esse. Temporibus rerum similique quasi ab rerum sit sapiente exercitationem sunt. Omnis similique autem neque sed qui molestias et libero.", 8 },
                    { 15, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(3932), "Quo ut sed soluta nemo. A quae qui quis sunt officiis. Eaque non repellendus ut. Reiciendis ex dolore voluptate illo voluptates illum consequatur. Nam repudiandae deserunt cumque sit quia facere laudantium sequi nihil.", 33 },
                    { 12, new DateTime(2021, 8, 9, 17, 30, 30, 298, DateTimeKind.Local).AddTicks(8845), "Maiores est rerum architecto et dolor accusamus omnis. Commodi alias modi quam perferendis praesentium id tenetur in dolorum.", 33 },
                    { 33, new DateTime(2021, 8, 9, 17, 30, 30, 302, DateTimeKind.Local).AddTicks(7362), "Voluptatem animi a est enim enim maiores et. Quia delectus odit quas est. Dolor mollitia amet fugiat consequuntur sed consequuntur. Optio veniam repellat mollitia. Doloribus mollitia pariatur deleniti omnis omnis blanditiis aut tempora.", 26 },
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 297, DateTimeKind.Local).AddTicks(1551), "Magni qui nobis consequatur. Rerum quo possimus aut tempora quia porro. Dolore id nesciunt quasi est qui odit error.", 15 },
                    { 24, new DateTime(2021, 8, 9, 17, 30, 30, 300, DateTimeKind.Local).AddTicks(4852), "Rerum eos consequuntur fugiat voluptate quia dolores aut sunt qui. Molestiae non quae nihil iure tempore autem omnis possimus. Tempore sed suscipit et aperiam fugiat ducimus voluptate. Ut in itaque voluptatem. Earum ut et voluptatibus.", 8 },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 297, DateTimeKind.Local).AddTicks(5675), "Deserunt ea sed qui autem ipsam qui a. Et ipsum omnis voluptate. Aut et asperiores aliquam aut ipsam.", 18 },
                    { 40, new DateTime(2021, 8, 9, 17, 30, 30, 303, DateTimeKind.Local).AddTicks(8843), "Quasi corporis quia dolor qui dolor non et. Aspernatur impedit doloribus occaecati. Laborum quas qui rerum ut iste porro dolorum.", 28 },
                    { 37, new DateTime(2021, 8, 9, 17, 30, 30, 303, DateTimeKind.Local).AddTicks(5156), "Mollitia est nulla numquam odit. Doloribus pariatur aliquam et et vel dolorem veniam. Consequatur vero et repellendus molestiae commodi omnis. Aspernatur debitis debitis cum. In vitae quis minus quod quibusdam.", 28 },
                    { 21, new DateTime(2021, 8, 9, 17, 30, 30, 300, DateTimeKind.Local).AddTicks(888), "Quia dolore sed ratione nihil quia sed doloremque consectetur mollitia. Nihil sed nihil delectus provident ut vel nulla vel sit. Nostrum sit ratione odio alias voluptatem non sint magni vitae.", 19 },
                    { 8, new DateTime(2021, 8, 9, 17, 30, 30, 298, DateTimeKind.Local).AddTicks(3875), "Dicta iusto non qui omnis hic. Rerum voluptatem incidunt molestiae. Officiis quod molestias quia molestiae quia sint. Modi ad nisi et totam nihil odit. Impedit labore provident itaque qui et magnam vel voluptatem dolorem.", 10 },
                    { 34, new DateTime(2021, 8, 9, 17, 30, 30, 302, DateTimeKind.Local).AddTicks(8970), "Accusantium rerum debitis dolores occaecati asperiores rerum ut et labore. Vel hic animi velit quae ullam id voluptatem.", 16 },
                    { 38, new DateTime(2021, 8, 9, 17, 30, 30, 303, DateTimeKind.Local).AddTicks(6108), "Qui ut consequatur quas ducimus. Et quis quia qui eos nam soluta. Recusandae est aut commodi adipisci nisi.", 25 },
                    { 49, new DateTime(2021, 8, 9, 17, 30, 30, 305, DateTimeKind.Local).AddTicks(4492), "Blanditiis autem animi porro voluptatum. Dolorem sint possimus quia dolorem eos.", 27 },
                    { 39, new DateTime(2021, 8, 9, 17, 30, 30, 303, DateTimeKind.Local).AddTicks(7798), "Ut sit distinctio explicabo dolor officia reprehenderit minus. Perferendis sed iste sequi repellat nostrum. Maiores sed ullam sit repellendus dolorem vel veniam minus rerum. Et sed et et perspiciatis accusantium facilis hic.", 37 },
                    { 11, new DateTime(2021, 8, 9, 17, 30, 30, 298, DateTimeKind.Local).AddTicks(7851), "Molestiae magni expedita autem eos quam sed voluptatum aut. Et voluptatum quis qui ut. Placeat dignissimos porro ea hic. Modi minima quia veritatis voluptatem deserunt facilis est et. Quo at deserunt rerum qui a porro animi vero.", 6 },
                    { 44, new DateTime(2021, 8, 9, 17, 30, 30, 304, DateTimeKind.Local).AddTicks(7295), "Ut suscipit vel et est ab consectetur officiis ipsam cum. Excepturi nemo quisquam et explicabo veniam et quisquam. Placeat quisquam qui adipisci numquam tempore doloribus repellat omnis autem. Modi voluptatem quos sed. Vitae suscipit error consequuntur voluptatum animi.", 43 },
                    { 10, new DateTime(2021, 8, 9, 17, 30, 30, 298, DateTimeKind.Local).AddTicks(5797), "Aut minus id eos. Itaque itaque dicta eveniet aliquam autem occaecati.", 22 },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 297, DateTimeKind.Local).AddTicks(4230), "Sequi dolore suscipit accusantium voluptas nulla iure ut molestiae. Doloremque tenetur voluptas saepe blanditiis blanditiis corporis qui possimus dolorum. Deleniti voluptas molestiae quia repellat adipisci. Velit maxime minima exercitationem.", 42 },
                    { 18, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(7053), "Pariatur rem vel architecto corrupti provident eum et iste. Libero maxime adipisci blanditiis molestias aliquid quae exercitationem. Ut et occaecati nihil non veniam eaque vitae. Repellendus incidunt qui nobis.", 42 },
                    { 20, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(9231), "Possimus ut nesciunt nobis porro a sunt accusamus velit autem. Eaque molestiae odit aspernatur beatae vitae eius earum.", 44 },
                    { 16, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(4825), "Sapiente et nihil similique minima voluptatem sint. Quaerat est ea incidunt nemo inventore necessitatibus eum sint explicabo.", 17 },
                    { 19, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(8227), "Laudantium qui dicta excepturi asperiores accusamus molestiae est magni. Autem perspiciatis sit quisquam nemo ratione voluptatem ducimus eaque. Et ratione sint eum.", 5 },
                    { 50, new DateTime(2021, 8, 9, 17, 30, 30, 305, DateTimeKind.Local).AddTicks(5949), "Ut sint ut doloribus qui. Recusandae non officia magni vel neque soluta. Sit sunt voluptas voluptatem et.", 13 },
                    { 48, new DateTime(2021, 8, 9, 17, 30, 30, 305, DateTimeKind.Local).AddTicks(3571), "Et corporis minima est nulla error. Reprehenderit nihil et velit qui necessitatibus a.", 48 },
                    { 25, new DateTime(2021, 8, 9, 17, 30, 30, 300, DateTimeKind.Local).AddTicks(6025), "Explicabo perspiciatis ut autem unde repudiandae esse ea numquam et. Alias provident in voluptatum. Doloremque laborum ratione eius corrupti ullam tempore.", 4 },
                    { 28, new DateTime(2021, 8, 9, 17, 30, 30, 301, DateTimeKind.Local).AddTicks(1307), "Eligendi quos mollitia id vel fuga occaecati. Nesciunt voluptas sit laboriosam quidem. Cumque ducimus fugiat aut vel esse ut.", 39 },
                    { 41, new DateTime(2021, 8, 9, 17, 30, 30, 303, DateTimeKind.Local).AddTicks(9680), "Ut eos laboriosam sit quia rerum aperiam optio sunt. Dicta quasi itaque cumque dolor aperiam.", 5 },
                    { 43, new DateTime(2021, 8, 9, 17, 30, 30, 304, DateTimeKind.Local).AddTicks(3672), "Deserunt modi non eos ipsum expedita rem. Voluptatem ea cumque dolor. Voluptas non autem quis ut placeat.", 49 },
                    { 47, new DateTime(2021, 8, 9, 17, 30, 30, 305, DateTimeKind.Local).AddTicks(2416), "Inventore voluptas unde et atque nulla est omnis molestiae reiciendis. Reprehenderit quod enim placeat ipsam ut ut voluptates voluptatem. Sint qui iste est quae. Aut iure ut consectetur quam aut ut et eum. Ab dolore vitae doloremque fugit qui voluptatem quas porro.", 49 },
                    { 14, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(2109), "Aliquid quos dolor cupiditate eum nisi. Accusantium dolor ipsa autem. Expedita velit praesentium repellat quam ut est veritatis id hic. Occaecati dignissimos ut distinctio laboriosam perferendis et.", 38 },
                    { 35, new DateTime(2021, 8, 9, 17, 30, 30, 303, DateTimeKind.Local).AddTicks(2321), "Quis voluptatibus id et vel architecto facilis officia. Repudiandae repudiandae nihil eius unde natus blanditiis. Enim est molestias nihil natus nobis mollitia non asperiores fugit. Omnis provident nulla nesciunt sed autem ut. Alias qui alias iste reiciendis.", 13 },
                    { 42, new DateTime(2021, 8, 9, 17, 30, 30, 304, DateTimeKind.Local).AddTicks(2370), "Minima suscipit rerum accusantium aspernatur facilis ut. Molestias ut voluptate recusandae dignissimos quia autem consequatur dolores. Aut minima eos voluptas possimus ex perspiciatis eveniet. Eum non qui consequatur. Ex ut magni maxime et ut ut velit.", 21 },
                    { 7, new DateTime(2021, 8, 9, 17, 30, 30, 298, DateTimeKind.Local).AddTicks(1550), "Praesentium ducimus rem enim omnis ad dolores consequuntur. Atque aut eos omnis.", 6 },
                    { 13, new DateTime(2021, 8, 9, 17, 30, 30, 299, DateTimeKind.Local).AddTicks(633), "Harum et id eos quia est aperiam et unde qui. Hic sed nobis ut et sit. Exercitationem et et in saepe dolorem cupiditate ex numquam. Animi nihil sequi omnis magnam est.", 4 },
                    { 22, new DateTime(2021, 8, 9, 17, 30, 30, 300, DateTimeKind.Local).AddTicks(1444), "Quibusdam repellendus id fugit et. Quod magnam error similique voluptas.", 13 },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 297, DateTimeKind.Local).AddTicks(7154), "Omnis omnis odio dolorum repellat distinctio asperiores dolor recusandae. Repellat dolores enim molestiae eos voluptatum officia consequatur quod.", 49 },
                    { 5, new DateTime(2021, 8, 9, 17, 30, 30, 297, DateTimeKind.Local).AddTicks(9188), "Omnis ab laudantium at sit delectus in debitis quia. Nisi ab quo dolorem. Libero sint voluptatem dolores natus et consequatur perferendis assumenda. Harum aut dolorem voluptas et incidunt. Ea et cumque eos rerum et et ipsam voluptates.", 42 }
                });

            migrationBuilder.InsertData(
                table: "projectimages",
                columns: new[] { "Id", "CreatedAt", "ImagePath", "ProjectId", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 42, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(2414), "Sint culpa commodi nostrum sint ducimus voluptates ipsam.", 42, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(2416) },
                    { 27, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(7080), "Ducimus adipisci veniam fugiat cupiditate rerum incidunt facilis repellendus. Nostrum exercitationem eos est similique eveniet deleniti est enim.", 27, 1, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(7083) },
                    { 50, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(75), "Omnis culpa rerum saepe velit ratione rem mollitia. Fugiat nam accusamus voluptates itaque dolores.", 50, 1, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(77) },
                    { 28, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(8341), "Ab aut hic quod at earum quis est soluta. Natus dolores ullam voluptatibus voluptas laboriosam quis a culpa et. Est iste corrupti facilis et.", 28, 1, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(8343) },
                    { 30, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(985), "Aut quidem minus ea a architecto dolor quia. Vel est corrupti facilis eius reiciendis perferendis minima pariatur. Corporis quia autem dolores quis porro dignissimos modi eius ut.", 30, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(986) },
                    { 33, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(3262), "Sed quia et rerum non et aliquam tenetur et beatae. Maiores veniam ipsum occaecati deleniti. Ut voluptatibus est voluptas consequatur accusantium. Fugiat aspernatur quas voluptatem atque cumque id.", 33, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(3263) },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(6407), "Sunt aperiam quos optio quas veniam doloremque nihil est. Qui voluptatibus quo aut deserunt et.", 4, 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(6410) },
                    { 34, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(4252), "Maiores impedit molestiae est et ab est quasi perspiciatis tenetur. Quis eveniet sint sit cumque. Quia commodi sit sunt.", 34, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(4254) },
                    { 7, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(9106), "Eum quisquam est maxime iure dolore fugit facilis non dolorem. Ipsam at minima at ipsam ut voluptatem et necessitatibus autem. Corrupti ratione voluptates consequatur aliquam temporibus alias repudiandae. Aut voluptatem consequatur alias est consectetur pariatur.", 7, 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(9107) },
                    { 41, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(1962), "Adipisci excepturi debitis veniam sequi.", 41, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(1963) },
                    { 35, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(5575), "Sunt voluptates ipsam est tempore ex inventore nisi perferendis. Expedita enim voluptas non autem eaque tenetur possimus deleniti voluptatem. Sunt eos rerum aspernatur ea.", 35, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(5577) },
                    { 6, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(7283), "Aut non ipsum ducimus est ut rerum.", 6, 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(7284) },
                    { 5, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(6903), "Animi ab esse qui ea velit id eos suscipit.", 5, 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(6904) },
                    { 40, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(1680), "Nihil voluptatibus possimus vitae quia et rem beatae doloribus modi. Reiciendis velit commodi ad. Ut blanditiis praesentium nulla. Tenetur vitae minus et omnis adipisci repudiandae in natus.", 40, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(1684) },
                    { 39, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(9988), "Laborum earum voluptatem incidunt. Laudantium nostrum magnam cum consequatur delectus nesciunt unde quia.", 39, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(9991) },
                    { 37, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(8220), "Iure facere dolorum assumenda maiores voluptas architecto dolores minima culpa. Id exercitationem corporis ipsum. Et ea et rerum fuga quaerat earum et error.", 37, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(8224) },
                    { 8, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(72), "Enim adipisci autem itaque. Repellat ea fuga aut et. Animi ipsam consequatur soluta sequi reiciendis amet.", 8, 1, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(74) },
                    { 10, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(2378), "In aperiam optio eius enim eos aliquam. Perspiciatis id sit sint voluptas odit saepe.", 10, 1, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(2380) },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(4833), "Rerum aut atque consequatur dolores. Omnis expedita quod architecto nihil est magnam autem exercitationem consequatur. Eos officiis ab neque sit cupiditate cum in assumenda nam. Iure eos voluptate praesentium architecto eum culpa.", 2, 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(4845) },
                    { 14, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(1826), "Harum neque modi tenetur enim officiis eius. Vitae accusantium quis ea ab nisi. Ratione ipsa assumenda vel ad iste.", 14, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(1834) },
                    { 45, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(6718), "Itaque sunt quidem dolor eum. Qui consectetur ut molestiae. Suscipit tenetur blanditiis ducimus velit quia a unde modi architecto.", 45, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(6719) },
                    { 32, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(1777), "Autem omnis sed asperiores eos et rerum culpa est.", 32, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(1779) },
                    { 23, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(112), "Illum eaque voluptas iure qui inventore et voluptatibus totam.", 23, 1, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(115) },
                    { 22, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(9512), "Adipisci et consequatur neque. Omnis necessitatibus ea aut facilis delectus. Alias consequuntur dicta nobis incidunt aspernatur saepe incidunt.", 22, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(9513) },
                    { 36, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(6913), "Ut est sequi tempora praesentium debitis culpa. Consequuntur quidem quibusdam pariatur et. Eum est vel itaque. Voluptas minus nihil aut sed ratione veniam voluptatem.", 36, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(6917) },
                    { 21, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(8559), "Enim corporis et quis id eum ad iste voluptate. Id vitae natus quas ipsam ipsum corrupti error laudantium. Rerum soluta iusto asperiores fugiat reiciendis cumque numquam blanditiis animi. Quo reiciendis et possimus.", 21, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(8560) },
                    { 20, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(6766), "Impedit inventore at distinctio quia facilis similique. Voluptatem dolorum delectus eos laborum ut iusto voluptatem quisquam. Et ab sequi deserunt.", 20, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(6767) },
                    { 38, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(9205), "Ipsa autem accusantium atque sequi quos unde distinctio inventore reiciendis. Nobis nesciunt laudantium autem aut ipsa.", 38, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(9208) },
                    { 17, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(4751), "Iste unde vel magni quae unde voluptate velit pariatur. Sit sint nobis consequatur dolores hic. Temporibus non est sit quo commodi sequi laudantium ipsum voluptatem.", 17, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(4752) },
                    { 44, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(5659), "Aut a excepturi consequatur ut ipsum et. Nemo sit possimus et. In sint vel libero quos doloribus. Enim velit corrupti velit voluptatem.", 44, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(5661) },
                    { 13, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(100), "Illo omnis fugit qui perspiciatis repellat. Numquam autem vero natus nemo enim facilis dolores praesentium laboriosam. Reprehenderit reprehenderit earum quaerat. Est ut ut ullam ut distinctio.", 13, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(123) },
                    { 48, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(8646), "In harum eum est quo cumque architecto.", 48, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(8647) },
                    { 11, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(2855), "Ipsum voluptatem vel blanditiis doloribus rerum.", 11, 1, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(2856) },
                    { 49, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(9305), "Facilis deserunt qui nisi harum neque. Qui sit aut qui sit et.", 49, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(9306) },
                    { 9, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(1132), "Culpa cum consequatur vel nihil sed. Corrupti corporis voluptates rerum. Eum voluptas maxime dolores expedita dicta.", 9, 1, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(1136) },
                    { 31, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(1308), "Fugit est provident at nemo ipsum.", 31, 1, new DateTime(2021, 8, 9, 17, 30, 30, 312, DateTimeKind.Local).AddTicks(1309) },
                    { 46, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(7489), "Odio natus ducimus vel ut id iusto repellendus natus. Commodi ut repellendus suscipit consequatur.", 46, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(7491) },
                    { 43, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(4431), "Est amet velit aut nihil voluptas blanditiis eveniet quaerat. Rem et qui quia eum mollitia qui nihil ipsum qui. Eum dicta voluptatem mollitia necessitatibus enim illo et cumque. Nisi dolore at repellat et explicabo.", 43, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(4435) },
                    { 47, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(8274), "Soluta blanditiis perspiciatis voluptatem quam et voluptatem facilis inventore veniam. Sit magni tempore distinctio.", 47, 1, new DateTime(2021, 8, 9, 17, 30, 30, 313, DateTimeKind.Local).AddTicks(8276) },
                    { 18, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(5071), "Iusto inventore et eius tempora velit.", 18, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(5072) },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(5552), "Facilis maiores reiciendis sunt et. Maiores optio qui corrupti debitis deleniti et quia.", 3, 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(5553) },
                    { 15, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(2767), "Ducimus ipsum officiis in. Blanditiis recusandae at ad autem ipsam veniam.", 15, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(2771) },
                    { 12, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(5049), "Error officia quisquam modi distinctio natus. Temporibus dolor sapiente eius a quo. Est possimus quasi cupiditate. Quod inventore ratione illo praesentium aspernatur laborum omnis alias.", 12, 1, new DateTime(2021, 8, 9, 17, 30, 30, 307, DateTimeKind.Local).AddTicks(5052) },
                    { 26, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(5988), "Sapiente impedit ad tempore. Temporibus eius magni voluptatem nisi eum magnam sit autem. Et et est explicabo hic numquam.", 26, 1, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(5994) },
                    { 24, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(1929), "Dolor illo odit est ea eius cumque. Perferendis asperiores enim et maxime et ipsum. Sed inventore dolor deleniti dolorem vel minima consequatur eos quia.", 24, 1, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(1934) },
                    { 16, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(3422), "Corrupti error qui assumenda repudiandae et. Dicta maiores blanditiis sed laborum.", 16, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(3424) },
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(1992), "Quia quae qui non. Earum nihil provident exercitationem excepturi iure aspernatur quo et accusamus.", 1, 1, new DateTime(2021, 8, 9, 17, 30, 30, 306, DateTimeKind.Local).AddTicks(2261) },
                    { 25, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(4417), "Voluptate quia eveniet laborum. Quibusdam molestiae voluptas est magni quis non temporibus rerum sed. Qui est sed earum dolorum et. Voluptatem explicabo perferendis velit distinctio.", 25, 1, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(4428) },
                    { 29, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(9549), "Quia adipisci consequuntur temporibus fugiat eius. Ex placeat rerum aperiam iure vel quos enim voluptatem. Modi aut provident iste ut ab qui illum.", 29, 1, new DateTime(2021, 8, 9, 17, 30, 30, 311, DateTimeKind.Local).AddTicks(9550) },
                    { 19, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(5706), "In ut qui sed. Odio expedita saepe reiciendis pariatur ullam voluptates accusantium.", 19, 1, new DateTime(2021, 8, 9, 17, 30, 30, 310, DateTimeKind.Local).AddTicks(5707) }
                });

            migrationBuilder.InsertData(
                table: "projectlinks",
                columns: new[] { "Id", "CreatedAt", "Link", "ProjectId", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 48, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(346), "http://www.welch.us/facts/page.asp", 48, 2, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(347) },
                    { 14, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1765), "http://www.simonis.info/home/index.html", 14, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1766) },
                    { 3, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(8386), "http://www.faheybeahan.ca/shop/films/root.rsx", 3, 1, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(8389) },
                    { 44, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9545), "http://www.hessel.name/shop/books/index.aspx", 44, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9546) },
                    { 4, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(8988), "http://www.emmerich.uk/catalog/applet.gem", 4, 2, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(8990) },
                    { 24, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(4542), "http://www.erdman.name/films/root.res", 24, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(4543) },
                    { 38, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(7902), "http://www.stroman.com/reviews/applet.gem", 38, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(7904) },
                    { 29, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5907), "http://www.oreilly.co.uk/interviews/root.asp", 29, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5909) },
                    { 36, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(7240), "http://www.weissnathauck.name/reviews/applet.asp", 36, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(7242) },
                    { 5, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(9230), "http://www.schumm.info/shop/form.rsx", 5, 1, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(9233) },
                    { 32, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6340), "http://www.schulist.ca/shop/page.aspx", 32, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6341) },
                    { 26, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5046), "http://www.torphartmann.uk/shop/form.htm", 26, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5047) },
                    { 10, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(797), "http://www.mcglynn.co.uk/interviews/template.html", 10, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(798) },
                    { 7, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(9912), "http://www.swift.ca/interviews/root.htm", 7, 1, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(9915) },
                    { 6, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(9462), "http://www.johns.info/films/resource.gem", 6, 1, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(9465) },
                    { 31, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6196), "http://www.berge.name/shop/food/form.htm", 31, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6197) },
                    { 8, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(181), "http://www.lehnerwelch.name/catalog/index.htm", 8, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(182) },
                    { 16, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(2063), "http://www.swift.co.uk/facts/applet.asp", 16, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(2064) },
                    { 39, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(8269), "http://www.mills.ca/shop/food/template.aspx", 39, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(8271) },
                    { 50, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(1110), "http://www.hermann.info/catalog/root.asp", 50, 2, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(1111) },
                    { 47, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(199), "http://www.haag.info/facts/page.aspx", 47, 1, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(202) },
                    { 21, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3785), "http://www.gleasonwilkinson.info/catalog/root.html", 21, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3787) },
                    { 33, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6482), "http://www.rolfson.biz/shop/books/resource.gem", 33, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6483) },
                    { 30, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6055), "http://www.sawayn.us/home/applet.htm", 30, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6056) },
                    { 28, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5759), "http://www.ferry.us/guide/resource.gem", 28, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5761) },
                    { 27, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5401), "http://www.mayert.com/facts/index.lsp", 27, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(5402) },
                    { 22, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3930), "http://www.lynch.uk/interviews/resource.htm", 22, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3931) },
                    { 23, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(4184), "http://www.rosenbaumwuckert.com/shop/food/form.aspx", 23, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(4185) },
                    { 25, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(4796), "http://www.huelspinka.com/interviews/template.jsp", 25, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(4797) },
                    { 43, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9172), "http://www.morar.co.uk/shop/root.jsp", 43, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9173) },
                    { 19, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3177), "http://www.strosin.com/shop/films/index.res", 19, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3179) },
                    { 18, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(2788), "http://www.moen.info/facts/template.lsp", 18, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(2789) },
                    { 2, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(7920), "http://www.bartell.co.uk/shop/books/index.res", 2, 2, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(7957) },
                    { 45, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9690), "http://www.botsford.us/films/resource.jsp", 45, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9691) },
                    { 15, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1915), "http://www.bradtke.us/facts/applet.rsx", 15, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1916) },
                    { 12, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1360), "http://www.weimann.ca/guide/form.asp", 12, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1362) },
                    { 1, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(6805), "http://www.glover.info/shop/films/form.gem", 1, 2, new DateTime(2021, 8, 9, 17, 30, 30, 314, DateTimeKind.Local).AddTicks(7121) },
                    { 34, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6741), "http://www.pfannerstillweimann.com/reviews/page.html", 34, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6742) },
                    { 20, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3533), "http://www.blanda.co.uk/reviews/applet.gem", 20, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(3534) },
                    { 46, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9840), "http://www.towne.co.uk/shop/books/root.html", 46, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9841) },
                    { 42, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9032), "http://www.luettgen.info/shop/applet.res", 42, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(9033) },
                    { 35, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6916), "http://www.reichert.co.uk/guide/applet.jsp", 35, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(6918) },
                    { 17, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(2426), "http://www.prosacco.biz/home/root.lsp", 17, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(2427) },
                    { 37, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(7497), "http://www.vandervortdamore.biz/shop/books/applet.htm", 37, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(7498) },
                    { 49, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(717), "http://www.willms.co.uk/catalog/template.htm", 49, 1, new DateTime(2021, 8, 9, 17, 30, 30, 316, DateTimeKind.Local).AddTicks(718) },
                    { 9, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(439), "http://www.welchdeckow.biz/shop/books/template.jsp", 9, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(440) },
                    { 41, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(8879), "http://www.corkery.name/interviews/applet.rsx", 41, 1, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(8880) },
                    { 11, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1164), "http://www.cole.biz/guide/index.rsx", 11, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1165) },
                    { 13, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1618), "http://www.windlergerlach.name/shop/books/resource.html", 13, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(1619) },
                    { 40, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(8523), "http://www.gloverwelch.com/shop/food/form.lsp", 40, 2, new DateTime(2021, 8, 9, 17, 30, 30, 315, DateTimeKind.Local).AddTicks(8524) }
                });

            migrationBuilder.InsertData(
                table: "usersinprojects",
                columns: new[] { "Id", "ProjectId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 41, 9, 3, 23 },
                    { 4, 9, 3, 43 },
                    { 29, 9, 4, 18 },
                    { 34, 45, 3, 18 },
                    { 43, 29, 3, 24 },
                    { 22, 29, 2, 8 },
                    { 36, 9, 2, 6 },
                    { 17, 17, 1, 15 },
                    { 35, 23, 1, 3 },
                    { 49, 11, 3, 28 },
                    { 13, 32, 3, 9 },
                    { 9, 13, 2, 24 },
                    { 38, 13, 4, 32 },
                    { 26, 38, 2, 27 },
                    { 31, 32, 4, 34 },
                    { 10, 36, 1, 39 },
                    { 48, 36, 3, 44 },
                    { 15, 31, 1, 6 },
                    { 27, 20, 1, 16 },
                    { 1, 16, 2, 43 },
                    { 39, 26, 2, 41 },
                    { 40, 42, 2, 43 },
                    { 2, 3, 3, 17 },
                    { 3, 3, 4, 13 },
                    { 18, 3, 1, 2 },
                    { 28, 42, 4, 31 },
                    { 25, 41, 1, 38 },
                    { 8, 41, 1, 35 },
                    { 20, 40, 3, 38 },
                    { 14, 39, 4, 17 },
                    { 21, 5, 4, 22 },
                    { 42, 5, 3, 10 },
                    { 30, 35, 1, 23 },
                    { 12, 35, 1, 8 },
                    { 44, 6, 1, 49 },
                    { 45, 33, 4, 42 },
                    { 5, 7, 4, 9 },
                    { 24, 7, 1, 34 },
                    { 37, 7, 3, 21 },
                    { 32, 30, 4, 11 },
                    { 46, 25, 4, 16 },
                    { 33, 25, 2, 4 },
                    { 19, 10, 4, 13 },
                    { 23, 19, 4, 20 },
                    { 6, 14, 2, 38 },
                    { 7, 18, 3, 26 },
                    { 47, 15, 1, 31 },
                    { 50, 1, 2, 33 },
                    { 11, 47, 3, 42 },
                    { 16, 49, 1, 23 }
                });

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
                name: "ProjectType",
                table: "projecttypes",
                column: "ProjectType",
                unique: true);

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
                name: "contacts");

            migrationBuilder.DropTable(
                name: "projectfeedbacks");

            migrationBuilder.DropTable(
                name: "projectimages");

            migrationBuilder.DropTable(
                name: "projectlinks");

            migrationBuilder.DropTable(
                name: "userlinks");

            migrationBuilder.DropTable(
                name: "usersinprojects");

            migrationBuilder.DropTable(
                name: "contactstatuses");

            migrationBuilder.DropTable(
                name: "imagetypes");

            migrationBuilder.DropTable(
                name: "linktypes");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "userroles");

            migrationBuilder.DropTable(
                name: "projecttypes");
        }
    }
}
