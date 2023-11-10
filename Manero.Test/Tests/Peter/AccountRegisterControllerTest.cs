using Manero.Controllers;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Text.RegularExpressions;



namespace Manero.Test.Tests.Peter
{
    public class AccountRegisterControllerTest
    {
        [Fact]
        public async Task Register_ValidModel_ReturnsRedirectToActionResult()
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

            authMock.Setup(x => x.UserAlreadyExistsAsync(It.IsAny<Expression<Func<ManeroUser, bool>>>())).ReturnsAsync(false);
            authMock.Setup(x => x.RegisterUserAsync(It.IsAny<UserCreateAccountViewModel>())).ReturnsAsync(true);

            var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

            // Act
            var result = await controller.Register(new UserCreateAccountViewModel());

            // Assert
            Assert.IsType<RedirectToActionResult>(result);
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Created", redirectToActionResult.ActionName);
            Assert.Equal("Account", redirectToActionResult.ControllerName);
        }

        [Fact]
        public async Task Register_EmailAlreadyExists_ReturnsModelError()
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

            authMock.Setup(x => x.UserAlreadyExistsAsync(It.IsAny<Expression<Func<ManeroUser, bool>>>())).ReturnsAsync(true);


            var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

            // Act
            var result = await controller.Register(new UserCreateAccountViewModel { Email = "existing@example.com" });

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.False(viewResult.ViewData.ModelState.IsValid);
            Assert.Equal("An account with this email already exists.", viewResult.ViewData.ModelState[""]!.Errors[0].ErrorMessage);
        }

        [Fact]

        public async Task Register_InvalidEmail_ReturnsViewResult()
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

            authMock.Setup(x => x.UserAlreadyExistsAsync(It.IsAny<Expression<Func<ManeroUser, bool>>>())).ReturnsAsync(false);
            authMock.Setup(x => x.RegisterUserAsync(It.IsAny<UserCreateAccountViewModel>())).ReturnsAsync(false);

            var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

            var invalidModel = new UserCreateAccountViewModel
            {
                Email = "invalid-email",
            };

            // Act
            var result = await controller.Register(invalidModel);

            // Assert
            Assert.IsType<ViewResult>(result);
        }

    }
}
