using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Manero.Helpers.Services;

public class AuthenticationService
{
    private readonly UserManager<ManeroUser> _userManager;
    private readonly SignInManager<ManeroUser> _signInManager;

    public AuthenticationService(UserManager<ManeroUser> userManager, SignInManager<ManeroUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<bool> UserAlreadyExistsAsync(Expression<Func<ManeroUser, bool>> expression)
    {
        return await _userManager.Users.AnyAsync(expression);
    }

    public async Task<bool> RegisterUserAsync(UserCreateAccountViewModel viewModel)
    {
        ManeroUser maneroUser = viewModel;

        var result = await _userManager.CreateAsync(maneroUser, viewModel.Password);
        if (result.Succeeded)
            return true;
        return false;
    }

    public async Task<bool> LogInAsync(UserLoginViewModel viewModel)
    {
        var user = await _userManager.FindByEmailAsync(viewModel.Email);
        if (user != null)
        {
            var result = await _signInManager.PasswordSignInAsync(user, viewModel.Password, viewModel.RememberMe, false);
            return result.Succeeded;
        }
        return false;
    }
}
