using Manero.Controllers;
using Manero.Helpers.Dtos;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Manero.Test.Tests.Peter;

public class AccountControllerEditProfileTest
{
    [Fact]
    public async Task EditProfile_ValidModel_ReturnsRedirectToActionResult()
    {
        // Arrange
        var authMock = new Mock<InterfaceAuthenticationService>();
        var editMock = new Mock<InterfaceEdietProfileService>();
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
            new Mock<IUserStore<ManeroUser>>().Object,
            null!, null!, null!, null!, null!, null!, null!, null!
        );
        var signInManagerMock = new Mock<SignInManager<ManeroUser>>(
            userManagerMock.Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
            null!, null!, null!, null!
        );

        editMock.Setup(x => x.UpdateUserAsync(It.IsAny<EditProfileModel>())).ReturnsAsync(true);

        var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

        // Act
        var result = await controller.EditProfile(new EditProfileModel());

        // Assert
        Assert.IsType<RedirectToActionResult>(result);
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
        Assert.Equal("Account", redirectToActionResult.ControllerName);
        signInManagerMock.Verify(x => x.SignOutAsync(), Times.Once);
        signInManagerMock.Verify(x => x.SignInAsync(
            It.IsAny<ManeroUser>(),
            It.IsAny<bool>(),
            It.IsAny<string>()),
            Times.Once);
    }
}
