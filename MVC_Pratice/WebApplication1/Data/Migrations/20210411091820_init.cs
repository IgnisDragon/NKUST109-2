using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "waterConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    consumptionOfWater = table.Column<int>(type: "int", nullable: false),
                    executingUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    populationServed = table.Column<float>(type: "real", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    theDailyDomesticConsumptionOfWaterPerPerson = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_waterConsumptions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "waterConsumptions");
        }
    }
}
