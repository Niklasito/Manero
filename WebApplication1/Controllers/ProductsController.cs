using Microsoft.AspNetCore.Mvc;
using Manero.Models.Contexts;
using System.Linq;
using Manero.Models.Entities;
using Manero.Helpers.Dtos;

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
                .Select(p => new ProductModel
                {
                    Id = p.Id,
                    ArticleNumber = p.ArticleNumber,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    PrimaryImage = p.ProductImages.FirstOrDefault() != null ? p.ProductImages.FirstOrDefault().ImageEntity : null
                })
                .ToList();

            return View("SearchResults", products);
        }

    }
}

