using OpenQA.Selenium;

namespace CianWebSiteTests.Locators
{
    internal static class AuthorizationPageLocators
    {
        public static readonly By _anotherWayLogInBtn = By.XPath("//button[@data-name='SwitchToEmailAuthBtn']");
        public static readonly By _emailOrIdInput = By.XPath("//input[@name='username']");
        public static readonly By _continueBtn = By.XPath("(//span[@class='_25d45facb5--text--V2xLI'])[4]");
        public static readonly By _passwordInput = By.XPath("//input[@name='password']");
        public static readonly By _signInBtn = By.XPath("//button[@data-name='ContinueAuthBtn']");
        public static readonly By _errorOccuredMsg = By.XPath("//span[@class='_25d45facb5--error-message--NCPjP']");
    }
}