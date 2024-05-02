using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class CommercialRealtyPageObject
    {
        IWebDriver _webDriver;

        public CommercialRealtyPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}