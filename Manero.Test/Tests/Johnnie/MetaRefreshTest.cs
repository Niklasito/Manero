using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manero.Test.Tests.Johnnie
{

    public class MetaRefreshTest
    {
        [Fact]
        public void MetaRefreshRedirects()
        {
           
            using (var driver = new ChromeDriver())
            {          
                driver.Navigate().GoToUrl("https://localhost:7003"); 
                Thread.Sleep(TimeSpan.FromSeconds(5));
                var redirectedUrl = driver.Url;
                Assert.Equal("https://localhost:7003/Onboarding/Index", redirectedUrl);
            }
        }
    }
}