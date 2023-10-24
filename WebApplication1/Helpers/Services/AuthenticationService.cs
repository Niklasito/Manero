using Manero.Models.Entities;
using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Manero.Helpers.Services;

public interface InterfaceAuthenticationService
{
    Task<bool> UserAlreadyExistsAsync(Expression<Func<ManeroUser, bool>> expression);
    Task<bool> RegisterUserAsync(UserCreateAccountViewModel viewModel);
    Task<bool> LogInAsync(UserLoginViewModel viewModel);
}

public class AuthenticationService : InterfaceAuthenticationService
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
        try
        {
            return await _userManager.Users.AnyAsync(expression);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public async Task<bool> RegisterUserAsync(UserCreateAccountViewModel viewModel)
    {
        ManeroUser maneroUser = viewModel;
        try
        {
            var result = await _userManager.CreateAsync(maneroUser, viewModel.Password);
            if (result.Succeeded)
                return true;
            return false;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public async Task<bool> LogInAsync(UserLoginViewModel viewModel)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(viewModel.Email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;
            }
            return false;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}
