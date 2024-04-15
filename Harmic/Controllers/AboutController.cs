using Microsoft.AspNetCore.Mvc;

namespace Harmic.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
