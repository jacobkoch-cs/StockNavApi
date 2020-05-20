using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockNavApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(nullable: false),
                    userEmail = table.Column<string>(nullable: true),
                    userPassword = table.Column<string>(nullable: true),
                    creditCard = table.Column<string>(nullable: true),
                    address = table.Column<string>(maxLength: 95, nullable: false),
                    fullName = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    label = table.Column<string>(maxLength: 10, nullable: false),
                    risk = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    reward = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalProfit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    totalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    userID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfolios_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shares",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    currentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    profit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    purchaseDate = table.Column<DateTime>(nullable: false),
                    sold = table.Column<bool>(nullable: false),
                    PortfolioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shares_Portfolios_PortfolioId",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_userID",
                table: "Portfolios",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_Shares_PortfolioId",
                table: "Shares",
                column: "PortfolioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shares");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
