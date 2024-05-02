using CianWebSiteTests.Locators;
using CianWebSiteTests.Utility;
using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class CityChoicePageObject
    {
        private IWebDriver _webDriver;

        public CityChoicePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject ChooseCity(string name)
        {
            _webDriver.FindElement(CityChoiceMenuLocators._cityInput, true).Click();
            _webDriver.FindElement(CityChoiceMenuLocators._cityInput, true).SendKeys(Keys.Control + "A");
            _webDriver.FindElement(CityChoiceMenuLocators._cityInput, true).SendKeys(Keys.Backspace);
            _webDriver.FindElement(CityChoiceMenuLocators._cityInput, true).SendKeys(name);

            try
            {
                _webDriver.FindElement(By.XPath($"//span[text()='{name}']"), true).Click();
            }
            catch
            {
                _webDriver.FindElement(By.XPath($"//button[text()='{name}']")).Click();
            }

            return new MainMenuPageObject(_webDriver);
        }
    }
}