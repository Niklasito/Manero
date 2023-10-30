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
        public async Task LogOut_When_User_Is_Signed_In_Returns_Redirect_To_Home_Page()
        {
            // Arrange
            var authenticationServiceMock = new Mock<AuthenticationService>();
            var signInManagerMock = new Mock<SignInManager<ManeroUser>>(
                new Mock<UserManager<ManeroUser>>(
                    new Mock<IUserStore<ManeroUser>>().Object,
                    null!, null!, null!, null!, null!, null!, null!, null!
                ).Object,
                new HttpContextAccessor(),
                new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
                null!, null!, null!, null!
            );
        
            var controller = new AccountController(authenticationServiceMock.Object, signInManagerMock.Object);
            
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
