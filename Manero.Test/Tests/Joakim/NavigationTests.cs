using Manero.Controllers;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Manero.Test.Tests.Joakim;

public class NavigationTests
{
    [Fact]
    public void NavigateToPaymentMethods()
    {
        var editMock = new Mock<InterfaceEdietProfileService>();
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
        new Mock<IUserStore<ManeroUser>>().Object,
        null!, null!, null!, null!, null!, null!, null!, null!
        );
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
        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object, editMock.Object, userManagerMock.Object);
        var result = controller.PaymentMethod() as ViewResult;
        Assert.IsType<ViewResult>(result);

        var viewResult = (ViewResult)result;
        Assert.Equal("PaymentMethod", viewResult.ViewName);

        var paymentMethodLink = viewResult.ViewData["PaymentMethodsLink"] as string;
        var expectedLink = "<a asp-controller=\"account\" asp-action=\"paymentmethod\">";
        Assert.Equal(expectedLink, paymentMethodLink);
    }
    [Fact]
    public void NavigateToAddPaymentMethod()
    {
        var editMock = new Mock<InterfaceEdietProfileService>();
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
        new Mock<IUserStore<ManeroUser>>().Object,
        null!, null!, null!, null!, null!, null!, null!, null!
        );
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
        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object, editMock.Object, userManagerMock.Object);
        var result = controller.AddPaymentMethod() as ViewResult;
        Assert.IsType<ViewResult>(result);

        var viewResult = (ViewResult)result;
        Assert.Equal("PaymentMethodAddCard", viewResult.ViewName);

        var addPaymentMethodLink = viewResult.ViewData["AddPaymentMethodsLink"] as string;
        var expectedLink = "<a asp-controller=\"account\" asp-action=\"addpaymentmethod\">";
        Assert.Equal(expectedLink, addPaymentMethodLink);
    }
}
