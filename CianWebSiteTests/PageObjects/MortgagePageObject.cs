using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class MortgagePageObject
    {
        IWebDriver _webDriver;

        public MortgagePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}