using Manero.Controllers;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace Manero.Test.Tests.Niklas
{
    public class SignOutTest
    {

        [Fact]
        public async Task LogOut_WhenUserIsSignedIn_ReturnsRedirectToHome()
        {
            // Arrange
            var authenticationServiceMock = new Mock<AuthenticationService>();
            var signInManagerMock = new Mock<SignInManager<ManeroUser>>(
                new Mock<UserManager<ManeroUser>>(
                    new Mock<IUserStore<ManeroUser>>().Object,
                    null, null, null, null, null, null, null, null
                ).Object,
                new HttpContextAccessor(),
                new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
                null, null, null, null
            );

          // Replace with a user object representing a signed-in user.
            var claims = new[]
            {
            new Claim(ClaimTypes.Name, "username"), // Replace with the actual username.
            };

            var controller = new AccountController(authenticationServiceMock.Object, signInManagerMock.Object);
            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity(claims, "test"))
                }
            };

            // Mock the IsSignedIn method to return true when called.
            signInManagerMock.Setup(m => m.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

            // Act
            var result = await controller.LogOut();

            // Assert
            Assert.IsType<RedirectToActionResult>(result);
            var redirectResult = (RedirectToActionResult)result;
            Assert.Equal("Index", redirectResult.ActionName);
            Assert.Equal("Home", redirectResult.ControllerName);
        }

    }
}
