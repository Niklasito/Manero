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

    public class ChangePassword
{

    [Fact]

    public void LogIn_User_To_Change_Password()
    {
        //Arrange

        var _signInManagerMock = new Mock<SignInManager<ManeroUser>>(
                new Mock<UserManager<ManeroUser>>(
                    new Mock<IUserStore<ManeroUser>>().Object,
                    null!, null!, null!, null!, null!, null!, null!, null!
                ).Object,
                new HttpContextAccessor(),
                new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
                null!, null!, null!, null!
            );

        var _authServiceMock = new Mock<AuthenticationService>();

        _signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object);

        //Act
        var result = controller.ChangePassword() as ViewResult;

        //assert
        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("ChangePassword", viewResult.ViewName);
        var ChangePasswordLink = viewResult.ViewData["ChangePasswordLink"] as string;
        var expectedLink = "<a asp-controller=\"account\" asp-action=\"changepassword\">";
        Assert.Equal(expectedLink, ChangePasswordLink);



    }



}
