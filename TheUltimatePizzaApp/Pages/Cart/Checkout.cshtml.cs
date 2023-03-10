using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TheUltimatePizzaApp.Pages.Cart
{
	[BindProperties(SupportsGet = true)]

	public class CheckoutModel : PageModel
	{
		public string PizzaName { get; set; }
		public float PizzaPrice { get; set; }
		public string ImageTitle { get; set; }

		public void OnGet()
		{
		}
	}
}
