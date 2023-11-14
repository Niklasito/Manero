using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Manero.Test.Tests.Joakim.javascript;

public class CardDetailsFormattingTest : IClassFixture<ChromeDriverFixture>
{
    private readonly IWebDriver _driver;
    public CardDetailsFormattingTest(ChromeDriverFixture fixture)
    {
        _driver = fixture.Driver;
    }

    [Fact]
    public void TestCardNumberFormatting()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account/addPaymentMethod");
        string currentURL = _driver.Url;
        if (currentURL == "https://localhost:7003/Account/Login?ReturnUrl=%2Faccount%2FaddPaymentMethod")
        {
            IWebElement emailInput = _driver.FindElement(By.Id("Email"));
            IWebElement passwordInput = _driver.FindElement(By.Id("Password"));
            IWebElement signInButton = _driver.FindElement(By.ClassName("sign-in-input"));
            emailInput.SendKeys("jocke@mail.se");
            passwordInput.SendKeys("Bytmig123!");
            signInButton.SendKeys(Keys.Enter);
        }
        _driver.Navigate().GoToUrl("https://localhost:7003/account/addPaymentMethod");
        IWebElement cardNumberInput = _driver.FindElement(By.Id("payment-method-card-number"));
        IWebElement cardNumberText = _driver.FindElement(By.Id("card-number"));
        cardNumberInput.SendKeys("1 2fs345fs 678123456  78fsdf");
        Assert.Equal("1234 5678 1234 5678", cardNumberText.Text);
    }
    [Fact]
    public void TestCardNameFormatting()
    {
        _driver.Navigate().GoToUrl("https://localhost:7003/account/addPaymentMethod");
        string currentURL = _driver.Url;
        if (currentURL == "https://localhost:7003/Account/Login?ReturnUrl=%2Faccount%2FaddPaymentMethod")
        {
            IWebElement emailInput = _driver.FindElement(By.Id("Email"));
            IWebElement passwordInput = _driver.FindElement(By.Id("Password"));
            IWebElement signInButton = _driver.FindElement(By.ClassName("sign-in-input"));
            emailInput.SendKeys("jocke@mail.se");
            passwordInput.SendKeys("Bytmig123!");
            signInButton.SendKeys(Keys.Enter);
        }
        _driver.Navigate().GoToUrl("https://localhost:7003/account/addPaymentMethod");
        IWebElement cardNameInput = _driver.FindElement(By.Id("payment-method-card-name"));
        IWebElement cardFirstName = _driver.FindElement(By.Id("card-name"));
        IWebElement cardLastName = _driver.FindElement(By.Id("card-last-name"));
        cardNameInput.SendKeys("Joakim Gustaf Larsson");
        Assert.Equal("Joakim", cardFirstName.Text);
        Assert.Equal("Gustaf Larsson", cardLastName.Text);
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
