using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Manero.Controllers;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Manero.Test.Tests.Peter.javascript;

public class Register
{
    public class navigationTests : IClassFixture<ChromeDriverFixture>
    {
        private readonly IWebDriver _driver;

        public navigationTests(ChromeDriverFixture fixture)
        {
            _driver = fixture.Driver;
        }



        public string GenerateRandomEmail()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz1234567890";
            var random = new Random();
            var email = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray()) + "@example.com";
            return email;
        }

        [Fact]
        public void TestSignUpAndRedirectToCreatedPage()
        {
            _driver.Navigate().GoToUrl("https://localhost:7003/account/register");

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));

            IWebElement nameInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='text'][name='Name']"));
            IWebElement emailInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='email'][name='Email']"));
            IWebElement passwordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));
            IWebElement confirmPasswordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='ConfirmPassword']"));


            nameInput.SendKeys("John Doe");
            string randomEmail = GenerateRandomEmail();
            emailInput.SendKeys(randomEmail);
            passwordInput.SendKeys("Password123!");
            confirmPasswordInput.SendKeys("Password123!");

            IWebElement signUpButton = _driver.FindElement(By.CssSelector(".sign-up-input[type='submit']"));
            signUpButton.Click();

            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            string currentUrl = _driver.Url;
            Assert.Equal("https://localhost:7003/Account/Created", currentUrl);

            Thread.Sleep(3000);
        }

    }

    public class ChromeDriverFixture : IDisposable
    {
        public IWebDriver Driver { get; }

        public ChromeDriverFixture()
        {
            Driver = new ChromeDriver();
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}