using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oils.Data;

namespace Oils.ViewComponents
{
    public class DependentDropdownViewComponent: ViewComponent
    {
        private readonly OilsDbContext _context;

        public DependentDropdownViewComponent(OilsDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }
        
    }
}
