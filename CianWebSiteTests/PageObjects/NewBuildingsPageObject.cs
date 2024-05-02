using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class NewBuildingsPageObject
    {
        IWebDriver _webDriver;

        public NewBuildingsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}