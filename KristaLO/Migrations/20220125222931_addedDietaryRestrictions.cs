using Microsoft.EntityFrameworkCore.Migrations;

namespace KristaLO.Migrations
{
    public partial class addedDietaryRestrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealID",
                table: "Meal");

            migrationBuilder.AddColumn<string>(
                name: "DietaryRestrictions",
                table: "Meal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DietaryRestrictions",
                table: "Meal");

            migrationBuilder.AddColumn<int>(
                name: "MealID",
                table: "Meal",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
