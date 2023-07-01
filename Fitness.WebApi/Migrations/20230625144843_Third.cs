using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food");

            migrationBuilder.DropForeignKey(
                name: "FK_Food_FoodCategory_FoodCategoryId",
                table: "Food");

            migrationBuilder.DropIndex(
                name: "IX_Food_FoodCategoryId",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "FoodCategoryId",
                table: "Food");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food",
                column: "CategoryId",
                principalTable: "FoodCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food");

            migrationBuilder.AddColumn<int>(
                name: "FoodCategoryId",
                table: "Food",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodCategoryId",
                table: "Food",
                column: "FoodCategoryId");

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
    }
}
