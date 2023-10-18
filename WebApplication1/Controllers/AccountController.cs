using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthenticationService _auth;
        private readonly SignInManager<ManeroUser> _signInManager;

        public AccountController(AuthenticationService auth, SignInManager<ManeroUser> signInManager)
        {
            _auth = auth;
            _signInManager = signInManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserCreateAccountViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                if(await _auth.UserAlreadyExistsAsync(x => x.Email == viewModel.Email))
                {
                    ModelState.AddModelError("", "An account with this email already exists.");
                }

                if (await _auth.RegisterUserAsync(viewModel))
                    return RedirectToAction("Login", "Account");
            }
            return View();
        }

        public IActionResult LogIn(string ReturnUrl = null!)
        {
            var viewModel = new UserLoginViewModel();

            if (ReturnUrl != null)
                viewModel.ReturnUrl = ReturnUrl;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(UserLoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _auth.LogInAsync(viewModel))
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Incorrect E-mail or Password");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> LogOut()
        {
            if(_signInManager.IsSignedIn(User))
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
