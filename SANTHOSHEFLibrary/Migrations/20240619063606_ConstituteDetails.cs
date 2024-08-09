using Microsoft.EntityFrameworkCore.Migrations;

namespace SANTHOSHEFLibrary.Migrations
{
    public partial class ConstituteDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConstituteDetailsEF",
                columns: table => new
                {
                    ConstituteID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstitueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalNumberOfVoters = table.Column<long>(type: "bigint", nullable: false),
                    TotalNoOfMaleVoters = table.Column<long>(type: "bigint", nullable: false),
                    TotalNoOfFemaleVoters = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstituteDetailsEF", x => x.ConstituteID);
                });

            migrationBuilder.CreateTable(
                name: "DistrictsEF",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Districtname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstituteDetailsConstituteID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictsEF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistrictsEF_ConstituteDetailsEF_ConstituteDetailsConstituteID",
                        column: x => x.ConstituteDetailsConstituteID,
                        principalTable: "ConstituteDetailsEF",
                        principalColumn: "ConstituteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistrictsEF_ConstituteDetailsConstituteID",
                table: "DistrictsEF",
                column: "ConstituteDetailsConstituteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistrictsEF");

            migrationBuilder.DropTable(
                name: "ConstituteDetailsEF");
        }
    }
}
