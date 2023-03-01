using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheUltimatePizzaApp.Migrations
{
	/// <inheritdoc />
	public partial class AddPizzaToDb : Migration
	{
		/// <inheritdoc />	
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Pizzas",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
					PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					BasePrice = table.Column<double>(type: "float", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Pizzas", x => x.Id);
				});
		}
		/// <inheritdoc />
		/// Down method - rolling back that changes if something fails
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Pizzas");
		}
	}
}
