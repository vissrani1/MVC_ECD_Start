using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_ECD_Start.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollegesData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FederalSchoolCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageAdmittedSATScores = table.Column<int>(type: "int", nullable: false),
                    CumulativeACTMedianScore = table.Column<int>(type: "int", nullable: false),
                    OverallAdmissionRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InStateTuitionCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutStateTuitionCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrolledSttudentSize = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegesData", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegesData");
        }
    }
}
