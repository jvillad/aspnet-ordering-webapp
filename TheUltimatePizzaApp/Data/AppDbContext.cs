using Microsoft.EntityFrameworkCore;
using TheUltimatePizzaApp.Model;

namespace TheUltimatePizzaApp.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		public DbSet<Pizza> Pizzas { get; set; }
		public DbSet<Pizza> Products { get; set; }
	}
}
