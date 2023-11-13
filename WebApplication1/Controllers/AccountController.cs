using Manero.Helpers.Dtos;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Controllers
{
   
    public  class AccountController : Controller
    {

        private readonly InterfaceAuthenticationService _auth;
        private readonly SignInManager<ManeroUser> _signInManager;
        private readonly InterfaceEdietProfileService _editProfile;
        private readonly UserManager<ManeroUser> _userManager;


        public AccountController(InterfaceAuthenticationService auth, SignInManager<ManeroUser> signInManager, InterfaceEdietProfileService editProfile, UserManager<ManeroUser> userManager)
        {
            _auth = auth;
            _signInManager = signInManager;
            _editProfile=editProfile;
            _userManager=userManager;
        }



        [Authorize]
        public IActionResult Index()
        {
            ViewData["BackToAccountLink"] = "<a asp-controller=\"account\" asp-action=\"index\"></a>";
            return View("Index");
        }
        public IActionResult Register()
        {
            ViewData["RegisterLink"] = "<a asp-controller=\"account\" asp-action=\"register\">";
            return View("Register");
        }
        public IActionResult Created()
        {
            return View("Created");
        }

        public IActionResult ForgetPassword()
        {
            ViewData["ForgetPasswordLink"] = "<a asp-controller=\"account\" asp-action=\"forgetpassword\">";
            return View("ForgetPassword");
        }

        public IActionResult ChangePassword()
        {
            ViewData["ChangePasswordLink"] = "<a asp-controller=\"account\" asp-action=\"changepassword\">";
            return View("ChangePassword");
        }

        [Authorize]
        public IActionResult MyAddress()
        {
            ViewData["MyAddressLink"] = "<a asp-controller=\"account\" asp-action=\"myaddress\">";
            return View("MyAddress");
        }

        [Authorize]
        public IActionResult OrderHistory()
        {
            ViewData["OrderHistoryLink"] = "<a asp-controller=\"account\" asp-action=\"orderhistory\">";
            return View("OrderHistory");
        }

        [Authorize]
        public IActionResult EditProfile()
        {
            ViewData["EditProfileLink"] = "<a asp-controller=\"account\" asp-action=\"editprofile\">";
            return View("EditProfile");
        }

        [Authorize]
        public IActionResult MyPromocodes()
        {
            ViewData["MyPromocodesLink"] = "<a asp-controller=\"account\" asp-action=\"mypromocodes\">";
            return View("MyPromocodes");
        }

        [Authorize]
        public IActionResult PaymentMethod()
        {
            return View("PaymentMethod");
        }

        [Authorize]
        public IActionResult AddPaymentMethod()
        {
            return View("PaymentMethodAddCard");
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
                    return RedirectToAction("Created", "Account");
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

        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _editProfile.UpdateUserAsync(model))
                {
                    await _signInManager.SignOutAsync();

                    var user = await _userManager.FindByIdAsync(model.ProfileId);
                    await _signInManager.SignInAsync(user!, isPersistent: false);

                    return RedirectToAction("Index", "Account");
                }

                ModelState.AddModelError("", "Incorrect Name or e-mail");
            }

            return View(model);
        }
    }
}
