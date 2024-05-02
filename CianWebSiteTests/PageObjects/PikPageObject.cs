using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class PikPageObject
    {
        IWebDriver _webDriver;

        public PikPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}