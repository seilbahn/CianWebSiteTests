using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class SellPageObject
    {
        private IWebDriver _webDriver;

        public SellPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}