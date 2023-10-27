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
using static Manero.Controllers.AccountController;

namespace Manero.Test.Tests.Niklas;

public class ControllerRedirectToActionTests
{

    #region Profile->AddressPage

    [Fact]

    public void Logged_In_User_Navigates_To_Address_Information()
    {
        //arange


        var _signInManagerMock = new Mock<SignInManager<ManeroUser>>(
                new Mock<UserManager<ManeroUser>>(
                    new Mock<IUserStore<ManeroUser>>().Object,
                    null, null, null, null, null, null, null, null
                ).Object,
                new HttpContextAccessor(),
                new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
                null, null, null, null
            );

        var _authServiceMock = new Mock<AuthenticationService>();

        _signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object);


        //act
        var result = controller.MyAddress() as ViewResult;

        //assert

        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("MyAddress", viewResult.ViewName);
        var myAddressLink = viewResult.ViewData["MyAddressLink"] as string;
        var expectedLink = "<a asp-controller=\"account\" asp-action=\"myaddress\">";
        Assert.Equal(expectedLink, myAddressLink);

    }
    
    [Fact]
    
    public void Logged_In_User_Navigates_Back_To_Profile_Page_From_Address_Page()
    {

        //Arrange
        var _signInManagerMock = new Mock<SignInManager<ManeroUser>>(
            new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null, null, null, null, null, null, null, null
            ).Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
            null, null, null, null
        );

        var _authServiceMock = new Mock<AuthenticationService>();

        _signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object);

        //Act
        var result = controller.Index();


        //Assert
        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("Index", viewResult.ViewName);
        
    }

    #endregion

    #region Profile->Promocodes
    [Fact]
    public void Logged_In_User_Navigates_From_My_Profile_Page_To_My_Promocodes_Page()
    {

        //Arrange
        var _signInManagerMock = new Mock<SignInManager<ManeroUser>>(
            new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null, null, null, null, null, null, null, null
            ).Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
            null, null, null, null
        );

        var _authServiceMock = new Mock<AuthenticationService>();

        _signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object);
        //Act

        var result = controller.MyPromocodes();

        //Assert

        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("MyPromocodes", viewResult.ViewName);
    }

    [Fact]

    public void Logged_In_User_Navigates_Back_From_My_Promocodes_Page_To_My_Profile_Page()
    {
        //Arrange
        var _signInManagerMock = new Mock<SignInManager<ManeroUser>>(
            new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null, null, null, null, null, null, null, null
            ).Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
            null, null, null, null
        );

        var _authServiceMock = new Mock<AuthenticationService>();

        _signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object);
        //Act

        var result = controller.Index();

        //Assert

        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("Index", viewResult.ViewName);
    }
    #endregion


    #region Profile->Order History


    [Fact]

    public void Logged_In_User_Navigates_From_My_Profile_Page_To_My_Order_History_Page()
    {
        //Arrange
        var _signInManagerMock = new Mock<SignInManager<ManeroUser>>(
            new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null, null, null, null, null, null, null, null
            ).Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
            null, null, null, null
        );

        var _authServiceMock = new Mock<AuthenticationService>();

        _signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object);
        //Act

        var result = controller.OrderHistory();

        //Assert

        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("OrderHistory", viewResult.ViewName);

    }

    public void Logged_In_User_Navigates_Back_From_Order_History_Page_To_My_Profile_Page()
    {
        //Arrange
        var _signInManagerMock = new Mock<SignInManager<ManeroUser>>(
            new Mock<UserManager<ManeroUser>>(
                new Mock<IUserStore<ManeroUser>>().Object,
                null, null, null, null, null, null, null, null
            ).Object,
            new HttpContextAccessor(),
            new Mock<IUserClaimsPrincipalFactory<ManeroUser>>().Object,
            null, null, null, null
        );

        var _authServiceMock = new Mock<AuthenticationService>();

        _signInManagerMock.Setup(x => x.IsSignedIn(It.IsAny<ClaimsPrincipal>())).Returns(true);

        var controller = new AccountController(_authServiceMock.Object, _signInManagerMock.Object);
        //Act

        var result = controller.Index();

        //Assert

        Assert.IsType<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.Equal("Index", viewResult.ViewName);

    }




    #endregion


}


