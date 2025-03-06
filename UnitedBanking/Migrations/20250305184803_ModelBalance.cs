using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitedBanking.Migrations
{
    /// <inheritdoc />
    public partial class ModelBalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balance",
                columns: table => new
                {
                    BalanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BalanceAmount = table.Column<int>(type: "int", nullable: false),
                    TransactionAmount = table.Column<int>(type: "int", nullable: false),
                    TransactionName = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balance", x => x.BalanceId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balance");
        }
    }
}
