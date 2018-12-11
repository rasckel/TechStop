using Microsoft.EntityFrameworkCore.Migrations;

namespace Release_Candidate_Ervin_Hostetler.Migrations
{
    public partial class woo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketNumber",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "TicketNumber",
                table: "Quote",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketNumber",
                table: "Quote");

            migrationBuilder.AddColumn<string>(
                name: "TicketNumber",
                table: "Customer",
                nullable: true);
        }
    }
}
