﻿using Harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Harmic.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly HarmicContext _context;

        public ProductViewComponent(HarmicContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbProducts.Include(m => m.CategoryProduct).Where(m => (bool)m.IsActive).Where(m => m.IsNew).Take(8);
            //if (type > 0)
            //{
            //    items = items.Where(i => i.CategoryProductId == type);
            //}
            return await Task.FromResult<IViewComponentResult>(View(items.OrderByDescending(m => m.ProductId).ToList()));
        }
    }
}
