using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Manero.Test.Tests.Peter.javascript;

public class PasswordValidationTests : IClassFixture<ChromeDriverFixture>
{
    private readonly IWebDriver _driver;

    public PasswordValidationTests(ChromeDriverFixture fixture)
    {
        _driver = fixture.Driver;
    }

    [Fact]
    public void TestInvalidPassword()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account/register");

        IWebElement passwordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));
        passwordInput.SendKeys("weakpassword");

        System.Threading.Thread.Sleep(3000);

        IWebElement validationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='Password']"));
        Assert.Equal("Password is invalid", validationMessage.Text);
    }

    [Fact]
    public void TestValidPassword()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account/register");

        IWebElement passwordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));
        IWebElement confirmPasswordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='ConfirmPassword']"));

        passwordInput.SendKeys("Password123!");

        System.Threading.Thread.Sleep(3000);

        IWebElement validationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='ConfirmPassword']"));
        Assert.True(string.IsNullOrEmpty(validationMessage.Text) || !validationMessage.Displayed);
    }

    [Fact]
    public void TestMatchingPasswords()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account/register");

        IWebElement passwordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));
        IWebElement confirmPasswordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='ConfirmPassword']"));

        passwordInput.SendKeys("Password123!");
        confirmPasswordInput.SendKeys("Password123!");

        System.Threading.Thread.Sleep(3000);

        IWebElement validationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='ConfirmPassword']"));
        Assert.True(string.IsNullOrEmpty(validationMessage.Text) || !validationMessage.Displayed);
    }

    [Fact]
    public void TestNonMatchingPasswords()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account/register");

        IWebElement passwordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));
        IWebElement confirmPasswordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='ConfirmPassword']"));

        passwordInput.SendKeys("Password123!");
        confirmPasswordInput.SendKeys("Password234!");

        System.Threading.Thread.Sleep(3000);

        IWebElement validationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='ConfirmPassword']"));
        Assert.Equal("Passwords do not match", validationMessage.Text);
    }

    
}

