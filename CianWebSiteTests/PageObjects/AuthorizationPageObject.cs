using CianWebSiteTests.Locators;
using CianWebSiteTests.Utility;
using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class AuthorizationPageObject
    {
        private IWebDriver _webDriver;

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainMenuPageObject LogInEmailPassword(string email, string password)
        {
            _webDriver.FindElement(AuthorizationPageLocators._anotherWayLogInBtn, true).Click();
            _webDriver.FindElement(AuthorizationPageLocators._emailOrIdInput, true).Click();
            _webDriver.FindElement(AuthorizationPageLocators._emailOrIdInput, true).SendKeys(email);

            try
            {
                _webDriver.FindElement(AuthorizationPageLocators._continueBtn, true).Click();
                IWebElement error = _webDriver.FindElement(AuthorizationPageLocators._errorOccuredMsg);
            }
            catch
            {
                _webDriver.FindElement(AuthorizationPageLocators._continueBtn, true).Click();
            }

            _webDriver.FindElement(AuthorizationPageLocators._passwordInput, true).Click();
            _webDriver.FindElement(AuthorizationPageLocators._passwordInput, true).SendKeys(password);
            _webDriver.FindElement(AuthorizationPageLocators._signInBtn, true).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}