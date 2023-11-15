using Manero.Models.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class WishlistController : Controller
    {
        private readonly DataContext _context;

        public WishlistController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Wishlist"] = "<Partial name=\"/Views/Partials/_Wishlist.cshtml\" />";
            return View();
        }

    }
}
