using EntityMigration.Data;
using EntityMigration.Models;
using EntityMigration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityMigration.Controllers
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
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();
            List<Category> categories = await _context.Categories.ToListAsync();
            List<Product> products = await _context.Products
                .Include(m => m.Category)
                .Include(m => m.Images)
                .Take(8)
                .ToListAsync();
            VideoValentine videos = await _context.Videos.FirstOrDefaultAsync();
            Valentine valentines = await _context.Valentines.FirstOrDefaultAsync();
            Experts experts = await _context.Experts.FirstOrDefaultAsync();
            List<Employee> employees = await _context.Employees.ToListAsync();
            Blog blogs = await _context.Blogs.FirstOrDefaultAsync();
            List<BlogCards> blogCards = await _context.BlogCards.ToListAsync();
            List<InstaCarousel> ınstaCarousels = await _context.InstaCarousels.ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail,
                Categories = categories,
                Products = products,
                Valentines = valentines,
                Videos = videos,
                Experts = experts,
                Employees = employees,
                Blogs = blogs,
                BlogCards = blogCards,
                InstaCarousels = ınstaCarousels,

            };
            return View(homeVM);
        }
    }
}

