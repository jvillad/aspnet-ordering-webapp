using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheUltimatePizzaApp.Model;

namespace TheUltimatePizzaApp.Pages.Pizzas
{
    public class AllPizzasModel : PageModel
    {
        public List<Pizza> fakePizzaDb = new List<Pizza>()
{
            // creating a new instance of every pizza selection
new Pizza() { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 7.5},
new Pizza() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 6.5 },
new Pizza() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 7,},
new Pizza() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 8 },
new Pizza() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 9 },
new Pizza() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 5.5 },
new Pizza() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 7.5},
new Pizza() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 8.6 },
new Pizza() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 9.5}
};

        public void OnGet()
        {
        }
    }
}
