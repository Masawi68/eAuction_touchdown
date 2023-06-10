using Microsoft.EntityFrameworkCore.Migrations;

namespace eAuction_touchdown.Migrations
{
    public partial class bidder_bid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BidderAmount",
                table: "Vehicles",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BidderAmount",
                table: "Vehicles");
        }
    }
}
