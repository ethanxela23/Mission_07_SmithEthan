using Microsoft.AspNetCore.Mvc;

namespace Mission07_Smith_Ethan.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
