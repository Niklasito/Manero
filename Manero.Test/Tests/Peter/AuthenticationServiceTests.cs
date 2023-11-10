using EntityFrameworkCoreMock;
using Manero.Helpers.Services;
using Manero.Models.Contexts;
using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Manero.Test.Tests.Peter;

public class AuthenticationServiceTests
{
    [Fact]
    public async Task LogInAsync_ValidUser_ReturnsTrue()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new DataContext(options))
        {
            var userManagerMock = new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null!, null!, null!, null!, null!, null!, null!, null!);

            var signInManagerMock = new Mock<SignInManager<ManeroUser>>(
                userManagerMock.Object,
                new HttpContextAccessor(),
                new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
                null!, null!, null!, null!);

            var dbContextMock = new Mock<DataContext>(options);


            var authService = new AuthenticationService(userManagerMock.Object, signInManagerMock.Object, dbContextMock.Object);


            var user = new ManeroUser { Email = "mail@domain.com", UserName = "mail@domain.com" };
            await userManagerMock.Object.CreateAsync(user, "BytMig123!");
            userManagerMock.Setup(u => u.FindByEmailAsync(It.IsAny<string>())).ReturnsAsync(user);

            var viewModel = new UserLoginViewModel
            {
                Email = "mail@domain.com",
                Password = "BytMig123!",
                RememberMe = false,
                ReturnUrl = "/Account"
            };

            // Act
            await authService.LogInAsync(viewModel);

            // Assert
            signInManagerMock.Verify(
                mock => mock.PasswordSignInAsync(It.IsAny<ManeroUser>(), viewModel.Password, viewModel.RememberMe, false),
                Times.Once);
        }
    }

    [Fact]
    public async Task LogInAsync_InvalidUser_ReturnsFalse()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new DataContext(options))
        {
            var userManagerMock = new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null!, null!, null!, null!, null!, null!, null!, null!);

            var signInManagerMock = new Mock<SignInManager<ManeroUser>>(
                userManagerMock.Object,
                new HttpContextAccessor(),
                new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
                null!, null!, null!, null!);

            var dbContextMock = new Mock<DataContext>(options);


            var authService = new AuthenticationService(userManagerMock.Object, signInManagerMock.Object, dbContextMock.Object);

            userManagerMock.Setup(u => u.FindByEmailAsync(It.IsAny<string>())).ReturnsAsync((ManeroUser)null!);

            var viewModel = new UserLoginViewModel
            {
                Email = "invalid@mail.com", 
                Password = "InvalidPassword",
                RememberMe = false,
                ReturnUrl = "/Account"
            };

            // Act
            var result = await authService.LogInAsync(viewModel);

            // Assert
            signInManagerMock.Verify(
                mock => mock.PasswordSignInAsync(It.IsAny<ManeroUser>(), It.IsAny<string>(), It.IsAny<bool>(), It.IsAny<bool>()),
                Times.Never);

            Assert.False(result);
        }
    }

}