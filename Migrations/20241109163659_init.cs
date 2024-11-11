using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbAkijFood",
                columns: table => new
                {
                    intColdDrinksld = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strColdDrinksName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numQuantity = table.Column<double>(type: "float", nullable: false),
                    numUnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbAkijFood", x => x.intColdDrinksld);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbAkijFood");
        }
    }
}
