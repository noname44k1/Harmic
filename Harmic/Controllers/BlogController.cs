using Microsoft.AspNetCore.Mvc;

namespace Harmic.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
