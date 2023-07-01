using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_Category_CategoryId",
                table: "Food");

            migrationBuilder.DropForeignKey(
                name: "FK_Food_Category_CategoryId1",
                table: "Food");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.RenameColumn(
                name: "CategoryId1",
                table: "Food",
                newName: "FoodCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Food_CategoryId1",
                table: "Food",
                newName: "IX_Food_FoodCategoryId");

            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Uuid = table.Column<string>(type: "varchar(60)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food",
                column: "CategoryId",
                principalTable: "FoodCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_FoodCategory_FoodCategoryId",
                table: "Food",
                column: "FoodCategoryId",
                principalTable: "FoodCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food");

            migrationBuilder.DropForeignKey(
                name: "FK_Food_FoodCategory_FoodCategoryId",
                table: "Food");

            migrationBuilder.DropTable(
                name: "FoodCategory");

            migrationBuilder.RenameColumn(
                name: "FoodCategoryId",
                table: "Food",
                newName: "CategoryId1");

            migrationBuilder.RenameIndex(
                name: "IX_Food_FoodCategoryId",
                table: "Food",
                newName: "IX_Food_CategoryId1");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enable = table.Column<sbyte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Uuid = table.Column<string>(type: "varchar(60)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Category_CategoryId",
                table: "Food",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_Category_CategoryId1",
                table: "Food",
                column: "CategoryId1",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
