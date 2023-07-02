using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food",
                column: "CategoryId",
                principalTable: "FoodCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_FoodCategory_CategoryId",
                table: "Food",
                column: "CategoryId",
                principalTable: "FoodCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
