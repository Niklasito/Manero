using Manero.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Test.Tests.Johnnie
{
    public class NavigateOnboardingControllerTest
    {

        [Fact]

        public void User_Navigate_To_HomePage_From_Onboarding()
        {
            //Arrange
            var controller = new OnboardingController();

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            Assert.IsType<ViewResult>(result);
            var viewResult = (ViewResult)result;
            Assert.Equal("Index", viewResult.ViewName);
            var HomeLink = viewResult.ViewData["HomeLink"] as string;
            var expectedLink = "<a asp-controller=\"home\" asp-action=\"index\"></a>";
            Assert.Equal(expectedLink, HomeLink);
        }









    }
}
