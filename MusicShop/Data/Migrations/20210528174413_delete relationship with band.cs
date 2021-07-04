using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicShop.Data.Migrations
{
    public partial class deleterelationshipwithband : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BandId",
                table: "Products",
                type: "uniqueidentifier",
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
    }
}
