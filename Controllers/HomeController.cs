using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestStart.DAL;
using NestStart.Models;
using NestStart.ViewModel;

namespace NestStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM vm = new HomeVM()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.Where(x=>x.IsDeleted==false).ToListAsync(),
                Products = await _context.Products
                .Include(x=>x.Category).Include(x=>x.ProductImages)
                .Where(x=>x.IsDeleted==false).ToListAsync(),
                ProductImages = await _context.ProductImages.ToListAsync()
            };
            return View(vm);
        }
    }
}

