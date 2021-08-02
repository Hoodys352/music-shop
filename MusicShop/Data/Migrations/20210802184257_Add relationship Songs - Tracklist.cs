using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicShop.Data.Migrations
{
    public partial class AddrelationshipSongsTracklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Tracklists_TracklistId",
                table: "Songs");

            migrationBuilder.AlterColumn<Guid>(
                name: "TracklistId",
                table: "Songs",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Tracklists_TracklistId",
                table: "Songs",
                column: "TracklistId",
                principalTable: "Tracklists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Tracklists_TracklistId",
                table: "Songs");

            migrationBuilder.AlterColumn<Guid>(
                name: "TracklistId",
                table: "Songs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Tracklists_TracklistId",
                table: "Songs",
                column: "TracklistId",
                principalTable: "Tracklists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
