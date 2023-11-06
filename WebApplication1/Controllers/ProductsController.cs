using Microsoft.AspNetCore.Mvc;
using Manero.Models.Contexts;
using System.Linq;

namespace Manero.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string query)
        {
            var products = _context.Products
                .Where(p => p.Name.Contains(query) || p.Description.Contains(query))
                .ToList();

            return View("SearchResults", products);
        }

    }
}

