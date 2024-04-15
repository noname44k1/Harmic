using Microsoft.AspNetCore.Mvc;

namespace Harmic.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
