using Manero.Controllers;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Test.Tests.Eliana;

public class ForegetPassword
{
    [Fact]

    public void LogIn_User_To_Forget_Password()
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

        var _authServiceMock = new Mock<AuthenticationService>();

        signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(authMock.Object, signInManagerMock.Object, editMock.Object, userManagerMock.Object);

        //Act
        var result = controller.ForgetPassword() as ViewResult;

        //assert
        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("ForgetPassword", viewResult.ViewName);
        var ForgetPasswordLink = viewResult.ViewData["ForgetPasswordLink"] as string;
        var expectedLink = "<a asp-controller=\"account\" asp-action=\"forgetpassword\">";
        Assert.Equal(expectedLink, ForgetPasswordLink);



    }
}

   

