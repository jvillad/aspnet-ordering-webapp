using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheUltimatePizzaApp.Model;

namespace TheUltimatePizzaApp.Pages.Request;

public class PizzaRequest : PageModel
{
    [BindProperty]
    public Product NewProduct { get; set; }
    public void OnGet()
    {
        
    }
}