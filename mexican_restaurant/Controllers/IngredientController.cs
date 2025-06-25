using mexican_restaurant.Data;
using mexican_restaurant.Models;
using Microsoft.AspNetCore.Mvc;
using TequliasRestaurant.Models;

namespace mexican_restaurant.Controllers
{
    public class IngredientController : Controller
    {
        private Repository<Ingredient> ingredients;

        public IngredientController(ApplicationDbContext context)
        {
            ingredients = new Repository<Ingredient>(context);
        }

        public async Task<IActionResult> Index()
        {
            return View(await ingredients.GetAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await ingredients.GetByIdasync(id, new QueryOptions<Ingredient>() {Includes="ProductIngredients.Product"}));
        }
    }
}
