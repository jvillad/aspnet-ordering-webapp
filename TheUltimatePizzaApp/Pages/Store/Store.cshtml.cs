using Microsoft.AspNetCore.Mvc.RazorPages;


namespace TheUltimatePizzaApp.Pages.Store
{
	public class StoresModel : PageModel
	{
		public List<Model.Store> Store = new List<Model.Store>()
		{
			new Model.Store() { Name = "ULTIMATE PIZZA Hornsby", Phone = "02 9988 7766", Email = "hornsby@ultimate.com" },
			new Model.Store() { Name = "ULTIMATE PIZZA Waitara", Phone = "02 9988 1234", Email = "waitara@ultimate.com" },
			new Model.Store() { Name = "ULTIMATE PIZZA Chatswood", Phone = "02 9988 5432", Email = " chatswood@ultimate.com" }
		};

		public void OnGet()
		{

		}
	}
}
