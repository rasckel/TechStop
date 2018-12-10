using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Release_Candidate_Ervin_Hostetler.Migrations
{
    public partial class Taco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmazonPurchase");

            migrationBuilder.AlterColumn<double>(
                name: "ShippingCost",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "PurchasePrice",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "AmazonPurchase",
                table: "Purchase",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "LaborCost",
                table: "Labor",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    QuoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TicketNumber = table.Column<int>(nullable: false),
                    LaborQuantity = table.Column<int>(nullable: false),
                    LaborDescription = table.Column<string>(nullable: true),
                    LaborCost = table.Column<double>(nullable: false),
                    PurchaseQuantity = table.Column<int>(nullable: false),
                    PurchaseDescription = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<double>(nullable: false),
                    PurchaseURL = table.Column<string>(nullable: true),
                    PurchaseShippingCost = table.Column<double>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    ShippingCost = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    SubTotal = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.QuoteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quote");

            migrationBuilder.DropColumn(
                name: "AmazonPurchase",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "ShippingCost",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "PurchasePrice",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "LaborCost",
                table: "Labor",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.CreateTable(
                name: "AmazonPurchase",
                columns: table => new
                {
                    AmazonPurchaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ShippingCost = table.Column<int>(nullable: false),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmazonPurchase", x => x.AmazonPurchaseId);
                });
        }
    }
}
