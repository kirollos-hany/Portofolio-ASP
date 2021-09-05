using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portofolio.Migrations
{
    public partial class RemovedImageTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "projectimages_ibfk_2",
                table: "projectimages");

            migrationBuilder.DropTable(
                name: "imagetypes");

            migrationBuilder.DropIndex(
                name: "TypeId1",
                table: "projectimages");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "projectimages");

            migrationBuilder.RenameIndex(
                name: "TypeId3",
                table: "userlinks",
                newName: "TypeId2");

            migrationBuilder.RenameIndex(
                name: "TypeId2",
                table: "projectlinks",
                newName: "TypeId1");

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "projects",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "projects");

            migrationBuilder.RenameIndex(
                name: "TypeId2",
                table: "userlinks",
                newName: "TypeId3");

            migrationBuilder.RenameIndex(
                name: "TypeId1",
                table: "projectlinks",
                newName: "TypeId2");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "projectimages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "imagetypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    ImgType = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagetypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "TypeId1",
                table: "projectimages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "ImgType",
                table: "imagetypes",
                column: "ImgType",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "projectimages_ibfk_2",
                table: "projectimages",
                column: "TypeId",
                principalTable: "imagetypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
