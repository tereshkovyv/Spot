using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spot.Data.Migrations
{
    public partial class EditedUserAndSocialObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "presenter",
                table: "SocialObject",
                newName: "Presenter");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "SocialObject",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SocialObject",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "shirtDescgription",
                table: "SocialObject",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "reciever",
                table: "SocialObject",
                newName: "ShirtDescription");

            migrationBuilder.RenameColumn(
                name: "img",
                table: "SocialObject",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "fullDescrtption",
                table: "SocialObject",
                newName: "OtherInformation");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "SocialObject",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullDescription",
                table: "SocialObject",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganisationName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganisationType",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherContacts",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherInformation",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "SocialObject");

            migrationBuilder.DropColumn(
                name: "FullDescription",
                table: "SocialObject");

            migrationBuilder.DropColumn(
                name: "ContactPersonName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrganisationName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrganisationType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OtherContacts",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OtherInformation",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Presenter",
                table: "SocialObject",
                newName: "presenter");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SocialObject",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SocialObject",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "SocialObject",
                newName: "shirtDescgription");

            migrationBuilder.RenameColumn(
                name: "ShirtDescription",
                table: "SocialObject",
                newName: "reciever");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "SocialObject",
                newName: "img");

            migrationBuilder.RenameColumn(
                name: "OtherInformation",
                table: "SocialObject",
                newName: "fullDescrtption");
        }
    }
}
