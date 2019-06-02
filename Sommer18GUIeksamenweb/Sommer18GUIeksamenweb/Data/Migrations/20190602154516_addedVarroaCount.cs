using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sommer18GUIeksamenweb.Data.Migrations
{
    public partial class addedVarroaCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VarroaCounts",
                columns: table => new
                {
                    BeehiveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    BeeHiveName = table.Column<string>(maxLength: 18, nullable: false),
                    Date = table.Column<string>(nullable: false),
                    AmountOfVarroa = table.Column<int>(nullable: false),
                    ObservedDays = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarroaCounts", x => x.BeehiveId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VarroaCounts");
        }
    }
}
