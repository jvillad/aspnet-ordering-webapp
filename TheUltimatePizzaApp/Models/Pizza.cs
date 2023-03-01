using System.ComponentModel.DataAnnotations;

namespace TheUltimatePizzaApp.Model
{
	public class Pizza
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string ImageTitle { get; set; }
		[Required]
		public string PizzaName { get; set; }
		[Required]
		public double BasePrice { get; set; }


		public Pizza()
		{
		}
	}
}
