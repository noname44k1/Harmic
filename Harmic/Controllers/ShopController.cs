﻿using Microsoft.AspNetCore.Mvc;

namespace Harmic.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
