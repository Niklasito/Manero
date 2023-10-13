using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserCreateAccountViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");


        }

    }
}
