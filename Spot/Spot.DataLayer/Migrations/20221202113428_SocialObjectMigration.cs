using Microsoft.EntityFrameworkCore.Migrations;

namespace Spot.Data.Migrations
{
    public partial class SocialObjectMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialObject",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    shirtDescgription = table.Column<string>(type: "TEXT", nullable: true),
                    fullDescrtption = table.Column<string>(type: "TEXT", nullable: true),
                    presenter = table.Column<string>(type: "TEXT", nullable: true),
                    reciever = table.Column<string>(type: "TEXT", nullable: true),
                    img = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialObject", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialObject");
        }
    }
}
