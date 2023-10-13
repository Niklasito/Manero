using Manero.Models.Contexts;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Manero.Helpers.Services;

public class UserService
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
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == Email);
        return user;
    }
}
