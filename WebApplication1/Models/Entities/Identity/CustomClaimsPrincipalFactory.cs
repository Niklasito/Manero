using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace Manero.Models.Entities.Identity;

public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<ManeroUser>
{

    private readonly UserManager<ManeroUser> _userManager;
    public CustomClaimsPrincipalFactory(UserManager<ManeroUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    {
        _userManager = userManager;
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ManeroUser user)
    {
        var claimsIdentity = await base.GenerateClaimsAsync(user);

        claimsIdentity.AddClaim(new Claim("DisplayName", $"{user.Name}"));

        return claimsIdentity;
    }
}
