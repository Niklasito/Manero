using Manero.Controllers;
using Manero.Helpers.Dtos;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Manero.Test.Tests.Peter;

public class NavigateAccountControllerTest
{
    [Fact]

    public void User_Navigate_To_HomePage_From_SignUp()
    {
        //Arrange
        var controller = new HomeController();

        //Act
        var result = controller.Index() as ViewResult;

        //Assert
        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("Index", viewResult.ViewName);
        var backToHomeLink = viewResult.ViewData["BackToHomeLink"] as string;
        var expectedLink = "<a asp-controller=\"home\" asp-action=\"index\"></a>";
        Assert.Equal(expectedLink, backToHomeLink);
    }

    [Fact]

    public void User_Navigate_To_HomePage_From_SignIn()
    {
        //Arrange
        var controller = new HomeController();

        //Act
        var result = controller.Index() as ViewResult;

        //Assert
        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("Index", viewResult.ViewName);
        var backToHomeLink = viewResult.ViewData["BackToHomeLink"] as string;
        var expectedLink = "<a asp-controller=\"home\" asp-action=\"index\"></a>";
        Assert.Equal(expectedLink, backToHomeLink);
    }

    [Fact]

    public void User_Navigaye_To_SignUp_From_SignIn()
    {
        // Arrange
        var editMock = new Mock<InterfaceEdietProfileService>();
        var authMock = new Mock<InterfaceAuthenticationService>();
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

        var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

        //Act
        var result = controller.Register() as ViewResult;

        //Assert
        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("Register", viewResult.ViewName);
        var registerLink = viewResult.ViewData["RegisterLink"] as string;
        var expectedLink = "<a asp-controller=\"account\" asp-action=\"register\">";
        Assert.Equal(expectedLink, registerLink);
    }

    [Fact]

    public void User_Navigaye_To_SignIn_From_SignUp()
    {
        // Arrange
        var editMock = new Mock<InterfaceEdietProfileService>();
        var authMock = new Mock<InterfaceAuthenticationService>();
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

        var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

        //Act
        var result = controller.LogIn() as ViewResult;

        //Assert
        Assert.NotNull(result);
        var viewModel = result!.Model as UserLoginViewModel;

        Assert.NotNull(viewModel);
        Assert.Equal("/", viewModel!.ReturnUrl);
    }

    [Fact]

    public void User_Navigaye_To_EditProfile_From_MyProfile()
    {
        // Arrange
        var editMock = new Mock<InterfaceEdietProfileService>();
        var authMock = new Mock<InterfaceAuthenticationService>();
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

        signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

        //Act
        var result = controller.EditProfile() as ViewResult;

        //Assert
        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("EditProfile", viewResult.ViewName);
        var editProfileLink = viewResult.ViewData["EditProfileLink"] as string;
        var expectedLink = "<a asp-controller=\"account\" asp-action=\"editprofile\">";
        Assert.Equal(expectedLink, editProfileLink);
    }

}
