namespace Recipes.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class RecipesController : Controller
    {
        public IActionResult Add()
        {
            return this.View();
        }

        public IActionResult All()
        {
            return this.View();
        }
    }
}
