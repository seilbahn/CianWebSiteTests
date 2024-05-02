using OpenQA.Selenium;

namespace CianWebSiteTests.Locators
{
    internal static class MainMenuLocators
    {
        public static readonly By _signInButton = By.CssSelector("#header-frontend > div > div:nth-child(1) > div > a > span");
        public static readonly By _avatarBtn = By.XPath("//a[@data-name='UserAvatar']");
        public static readonly By _IDLabel = By.XPath("//a[@class='_25d45facb5--full-name--K5jY5']");
        public static readonly By _cityChoosingMenu = By.XPath("//button[@class='_025a50318d--button--eBKAY']");
        public static readonly By _cityGeoLocationName = By.XPath("//span[@class='_025a50318d--text--SCFDt']");
        public static readonly By _leaseBtn = By.XPath("//a[text()='Аренда']");
        public static readonly By _sellBtn = By.XPath("//a[text()='Продажа']");
        public static readonly By _newBuildingsBtn = By.XPath("//a[text()='Новостройки']");
        public static readonly By _commercialRealtyBtn = By.XPath("(//a[text()='Коммерческая'])[1]");
        public static readonly By _mortgageBtn = By.XPath("(//a[text()='Ипотека'])[1]");
        public static readonly By _myHomeBtn = By.XPath("//span[text()='Мой дом']");
        public static readonly By _pikBtn = By.XPath("//span[@class='_25d45facb5--icon--IBQt2 _25d45facb5--icon-pik--b1At6']");
    }
}