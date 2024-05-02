using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class MyHomePageObject
    {
        IWebDriver _webDriver;

        public MyHomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}