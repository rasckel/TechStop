using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Release_Candidate_Ervin_Hostetler.Migrations
{
    public partial class cheese : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "LaborCost",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "LaborDescription",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "LaborQuantity",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "PurchaseDescription",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "PurchaseQuantity",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "PurchaseShippingCost",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "PurchaseURL",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "ShippingCost",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "TicketNumber",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Quote");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Purchase",
                newName: "PurchaseQuantity");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Purchase",
                newName: "PurchaseDescription");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Labor",
                newName: "LaborQuantity");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Labor",
                newName: "LaborDescription");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LaborId",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Quote",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TicketNumber = table.Column<string>(nullable: true),
                    LaborQuantity = table.Column<int>(nullable: false),
                    LaborDescription = table.Column<string>(nullable: true),
                    LaborCost = table.Column<double>(nullable: false),
                    AmazonPurchase = table.Column<bool>(nullable: false),
                    PurchaseQuantity = table.Column<int>(nullable: false),
                    PurchaseDescription = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<double>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    ShippingCost = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quote_CustomerId",
                table: "Quote",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Quote_LaborId",
                table: "Quote",
                column: "LaborId");

            migrationBuilder.CreateIndex(
                name: "IX_Quote_PurchaseId",
                table: "Quote",
                column: "PurchaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Customer_CustomerId",
                table: "Quote",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Labor_LaborId",
                table: "Quote",
                column: "LaborId",
                principalTable: "Labor",
                principalColumn: "LaborId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Purchase_PurchaseId",
                table: "Quote",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "PurchaseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Customer_CustomerId",
                table: "Quote");

            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Labor_LaborId",
                table: "Quote");

            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Purchase_PurchaseId",
                table: "Quote");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Quote_CustomerId",
                table: "Quote");

            migrationBuilder.DropIndex(
                name: "IX_Quote_LaborId",
                table: "Quote");

            migrationBuilder.DropIndex(
                name: "IX_Quote_PurchaseId",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "LaborId",
                table: "Quote");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Quote");

            migrationBuilder.RenameColumn(
                name: "PurchaseQuantity",
                table: "Purchase",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "PurchaseDescription",
                table: "Purchase",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "LaborQuantity",
                table: "Labor",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "LaborDescription",
                table: "Labor",
                newName: "Description");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Quote",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "LaborCost",
                table: "Quote",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "LaborDescription",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LaborQuantity",
                table: "Quote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseDescription",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PurchasePrice",
                table: "Quote",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseQuantity",
                table: "Quote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PurchaseShippingCost",
                table: "Quote",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseURL",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ShippingCost",
                table: "Quote",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SubTotal",
                table: "Quote",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "Quote",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TicketNumber",
                table: "Quote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Quote",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Quote",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Quote",
                nullable: true);
        }
    }
}
