using Manero.Models.Contexts;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Manero.Helpers.Services;

public interface InterfaceUserService
{
    Task<ManeroUser> GetUserInfoAsync(string Email);
}

public class UserService : InterfaceUserService
{
    private readonly UserManager<ManeroUser> _userManager;
    private readonly DataContext _context;

    public UserService(UserManager<ManeroUser> userManager, DataContext context)
    {
        _userManager = userManager;
        _context = context;
    }

    public async Task<ManeroUser> GetUserInfoAsync(string Email)
    {
        try
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == Email);
            if (user != null) 
                return user;
            return null!;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null!;
        }
    }
}
