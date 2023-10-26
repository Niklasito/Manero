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
}
