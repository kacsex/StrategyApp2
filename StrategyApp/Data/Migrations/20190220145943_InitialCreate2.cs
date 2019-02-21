using Microsoft.EntityFrameworkCore.Migrations;

namespace StrategyApp.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "GoldAmount", "Name", "Point", "PopulationNumber", "PotatoAmount" },
                values: new object[] { 1, 2, "asda", 1, 2, 50 });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "RoundsToFinish", "Type" },
                values: new object[,]
                {
                    { 1, 15, 0 },
                    { 2, 15, 1 },
                    { 3, 15, 2 },
                    { 4, 15, 3 },
                    { 5, 15, 4 },
                    { 6, 15, 5 },
                    { 7, 5, 6 },
                    { 8, 5, 7 }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "AttackPower", "DefensePower", "Name", "PotatoRequirement", "Price", "Salary" },
                values: new object[,]
                {
                    { 1, 6, 2, "Rider", 1, 50, 1 },
                    { 2, 6, 2, "Rider", 1, 50, 1 },
                    { 3, 2, 6, "Archer", 1, 50, 1 },
                    { 4, 5, 5, "Elite", 2, 100, 3 }
                });

            migrationBuilder.InsertData(
                table: "CountryUnit",
                columns: new[] { "Id", "CountryId", "UnitId", "UnitNumber" },
                values: new object[] { 1, 1, 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CountryUnit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
