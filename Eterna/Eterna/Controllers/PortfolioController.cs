using Eterna.Data;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PortfolioViewModel vm = new PortfolioViewModel
            {
                Categories = _context.Categories.ToList(),
                Projects = _context.Projects.Include(x=>x.Category).Include(x=>x.ProjectImages).ToList(),
            };

            return View(vm);
        }
    }
}
