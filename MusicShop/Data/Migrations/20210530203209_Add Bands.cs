using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicShop.Data.Migrations
{
    public partial class AddBands : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BandId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bands",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BandId",
                table: "Products",
                column: "BandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Bands_BandId",
                table: "Products",
                column: "BandId",
                principalTable: "Bands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Bands_BandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bands");
        }
    }
}
