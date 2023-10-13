using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Contexts;

public class IdentityContext : IdentityDbContext<ManeroUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {
    }
}
