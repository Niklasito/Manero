using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Manero.Test.Tests.Peter.javascript
{
    public class EmailValidationTests : IClassFixture<ChromeDriverFixture>
    {
        private readonly IWebDriver _driver;

        public EmailValidationTests(ChromeDriverFixture fixture)
        {
            _driver = fixture.Driver;
        }

        [Fact]
        public void TestEmailValidationInvalidEmail()
        {
            _driver.Navigate().GoToUrl("https://localhost:7003/account/register");

            IWebElement emailInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='email'][name='Email']"));
            emailInput.SendKeys("ogiltig-email");

            System.Threading.Thread.Sleep(3000);

            IWebElement validationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='Email']"));
            Assert.Equal("Email is invalid", validationMessage.Text);
        }

        [Fact]
        public void TestValidEmail()
        {
            _driver.Navigate().GoToUrl("https://localhost:7003/account/register");

            IWebElement emailInput = _driver.FindElement(By.CssSelector("[data-val='true'][type='email'][name='Email']"));
            emailInput.SendKeys("korrekt-email@example.com");

            System.Threading.Thread.Sleep(3000);

            IWebElement validationMessage = _driver.FindElement(By.CssSelector("[data-valmsg-for='Email']"));

            Assert.True(string.IsNullOrEmpty(validationMessage.Text) || !validationMessage.Displayed);
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
