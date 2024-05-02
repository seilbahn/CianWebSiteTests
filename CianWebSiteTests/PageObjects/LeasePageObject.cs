using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class LeasePageObject
    {
        private IWebDriver _webDriver;

        public LeasePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}