using Microsoft.AspNetCore.Mvc;

namespace Mission07_Smith_Ethan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}