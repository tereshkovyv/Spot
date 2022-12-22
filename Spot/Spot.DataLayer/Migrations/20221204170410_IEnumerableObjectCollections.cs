using Microsoft.EntityFrameworkCore.Migrations;

namespace Spot.Data.Migrations
{
    public partial class IEnumerableObjectCollections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Presenter",
                table: "SocialObject",
                newName: "UserId1");

            migrationBuilder.AddColumn<int>(
                name: "PresenterId",
                table: "SocialObject",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "SocialObject",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SocialObject_UserId",
                table: "SocialObject",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialObject_UserId1",
                table: "SocialObject",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialObject_AspNetUsers_UserId",
                table: "SocialObject",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialObject_AspNetUsers_UserId1",
                table: "SocialObject",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialObject_AspNetUsers_UserId",
                table: "SocialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialObject_AspNetUsers_UserId1",
                table: "SocialObject");

            migrationBuilder.DropIndex(
                name: "IX_SocialObject_UserId",
                table: "SocialObject");

            migrationBuilder.DropIndex(
                name: "IX_SocialObject_UserId1",
                table: "SocialObject");

            migrationBuilder.DropColumn(
                name: "PresenterId",
                table: "SocialObject");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SocialObject");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "SocialObject",
                newName: "Presenter");
        }
    }
}
