using Manero.Controllers;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Manero.Test.Tests.Peter;

public class AccountControllerLogInTest
{
    [Fact]
    public async Task LogIn_ValidModel_ReturnsRedirectToActionResult()
    {
        // Arrange
        var authMock = new Mock<InterfaceAuthenticationService>();
        var editMock = new Mock<InterfaceEdietProfileService>();
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
        new Mock<IUserStore<ManeroUser>>().Object,
        null!, null!, null!, null!, null!, null!, null!, null!
        );
        var signInManagerMock = new Mock<SignInManager<ManeroUser>>(
            new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null!, null!, null!, null!, null!, null!, null!, null!
            ).Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
            null!, null!, null!, null!
        );


        authMock.Setup(x => x.LogInAsync(It.IsAny<UserLoginViewModel>())).ReturnsAsync(true);

        var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

        // Act
        var result = await controller.LogIn(new UserLoginViewModel());

        // Assert
        Assert.IsType<RedirectToActionResult>(result);
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        Assert.Equal("Home", redirectToActionResult.ControllerName);
    }
}
