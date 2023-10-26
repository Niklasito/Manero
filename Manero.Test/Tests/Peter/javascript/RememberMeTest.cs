using OpenQA.Selenium;

namespace Manero.Test.Tests.Peter.javascript;


public class RememberMeTest : IClassFixture<ChromeDriverFixture>
{
    private readonly IWebDriver _driver;

    public RememberMeTest(ChromeDriverFixture fixture)
    {
        _driver = fixture.Driver;
    }

    [Fact]
    public void TestRememberMeFunctionality()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account");

        IWebElement rememberMeCheckbox = _driver.FindElement(By.CssSelector(".sign-in-input-checkbox"));
        IWebElement emailInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='email'][name='Email']"));
        IWebElement passwordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));

        emailInput.SendKeys("test@example.com");
        passwordInput.SendKeys("Password123!");
        rememberMeCheckbox.Click();

        System.Threading.Thread.Sleep(2000);

        IWebElement signInButton = _driver.FindElement(By.CssSelector(".sign-in-input[type='submit']"));

        emailInput.Clear();
        System.Threading.Thread.Sleep(1000);
        passwordInput.Clear();
        System.Threading.Thread.Sleep(1000);
        rememberMeCheckbox.Click();

        System.Threading.Thread.Sleep(3000);

        emailInput.SendKeys("test@example.com");
        System.Threading.Thread.Sleep(1000);
        passwordInput.SendKeys("Password123!");
        System.Threading.Thread.Sleep(1000);
        rememberMeCheckbox.Click();

        System.Threading.Thread.Sleep(3000);

        signInButton.Click();
    }

    [Fact]
    public void TestCookiesFunctionality()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account");

        var predefinedCookies = new List<Cookie>
    {
        new Cookie("rememberMe", "false", "/", DateTime.Now.AddHours(1)), 
        new Cookie("email", "test@example.com", "/", DateTime.Now.AddHours(1)), 
        new Cookie("password", "Password123!", "/", DateTime.Now.AddHours(1)) 
    };

        foreach (var cookie in predefinedCookies)
        {
            _driver.Manage().Cookies.AddCookie(cookie);
        }

        IWebElement emailInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='email'][name='Email']"));
        IWebElement passwordInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));
        IWebElement rememberMeCheckbox = _driver.FindElement(By.CssSelector(".sign-in-input-checkbox"));

        IWebElement emailInputField = _driver.FindElement(By.CssSelector("[data-val='true'][type='email'][name='Email']"));
        emailInputField.SendKeys(predefinedCookies.Find(c => c.Name == "email")!.Value);

        IWebElement emailValidationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='Email']"));
        Assert.True(string.IsNullOrEmpty(emailValidationMessage.Text) || !emailValidationMessage.Displayed);

        IWebElement passwordInputField = _driver.FindElement(By.CssSelector("[data-val='true'][type='password'][name='Password']"));
        passwordInputField.SendKeys(predefinedCookies.Find(c => c.Name == "password")!.Value);

        IWebElement passwordValidationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='Password']"));
        Assert.True(string.IsNullOrEmpty(passwordValidationMessage.Text) || !passwordValidationMessage.Displayed);

        Assert.False(bool.Parse(predefinedCookies.Find(c => c.Name == "rememberMe")!.Value));

        IWebElement signInButton = _driver.FindElement(By.CssSelector(".sign-in-input[type='submit']"));
        signInButton.Click();

        System.Threading.Thread.Sleep(3000);
    }


}