using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZestMonitor.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProposalPayments",
                columns : table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                        CreatedAt = table.Column<DateTime>(nullable: false),
                        UpdatedAt = table.Column<DateTime>(nullable: false),
                        Hash = table.Column<string>(nullable: false),
                        ShortDescription = table.Column<string>(nullable: true),
                        Amount = table.Column<int>(nullable: false),
                        ExpectedPayment = table.Column<int>(nullable: false)
                },
                constraints : table =>
                {
                    table.PrimaryKey("PK_ProposalPayments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProposalPayments");
        }
    }
}