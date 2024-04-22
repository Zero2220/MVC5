using Eterna.Data;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Features = _context.Features.ToList(),
                Slides = _context.Slides.ToList()
            };
            return View(homeVM);
        }
    }
}
