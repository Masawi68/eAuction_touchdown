using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eAuction_touchdown.Migrations
{
    public partial class AddedBidEndTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BidEndTime",
                table: "Vehicles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BidEndTime",
                table: "Vehicles");
        }
    }
}
