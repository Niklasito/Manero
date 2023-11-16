using Manero.Models.Contexts;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _context;
        private readonly Models.ViewModels.Cart _cart;

        public CartController(DataContext context, Models.ViewModels.Cart cart)
        {
            _context = context;
            _cart = cart;
        }


        public ActionResult Index()
        {
            ViewData["CartLink"] = "<Partial name=\"/Views/Partials/_Cart.cshtml\" />";
            return View(_cart);
        }

        [HttpPost]
        public ActionResult AddToCart(int productId)
        {
            var product = _context.Products.Find(productId);

            if (product != null)
            {
                _cart.AddItem(product);
                TempData["AddedToCartMessage"] = $"{product.Name} added to cart.";
            }

            return RedirectToAction("Index", "Cart");
        }


        public ActionResult RemoveFromCart(int productId)
        {
            _cart.RemoveItem(productId);
            return RedirectToAction("Index");
        }


    }

}
