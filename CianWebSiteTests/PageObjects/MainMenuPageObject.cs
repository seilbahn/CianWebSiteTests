using CianWebSiteTests.Locators;
using CianWebSiteTests.Utility;
using OpenQA.Selenium;

namespace CianWebSiteTests.PageObjects
{
    internal class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AuthorizationPageObject LogIn()
        {
            _webDriver.FindElement(MainMenuLocators._signInButton, true).Click();
            return new AuthorizationPageObject(_webDriver);
        }

        public CityChoicePageObject CityChoiceMenuClick()
        {
            _webDriver.FindElement(MainMenuLocators._cityChoosingMenu, true).Click();
            return new CityChoicePageObject(_webDriver);
        }

        public LeasePageObject LeaseBtnClick()
        {
            _webDriver.FindElement(MainMenuLocators._leaseBtn, true).Click();
            return new LeasePageObject(_webDriver);
        }

        public SellPageObject SellBtnClick()
        {
            _webDriver.FindElement(MainMenuLocators._sellBtn, true).Click();
            return new SellPageObject(_webDriver);
        }

        public NewBuildingsPageObject NewBuildingsBtnClick()
        {
            _webDriver.FindElement(MainMenuLocators._newBuildingsBtn, true).Click();
            return new NewBuildingsPageObject(_webDriver);
        }

        public CommercialRealtyPageObject CommercialRealtyBtnClick()
        {
            _webDriver.FindElement(MainMenuLocators._commercialRealtyBtn, true).Click();
            return new CommercialRealtyPageObject(_webDriver);
        }

        public MortgagePageObject MortgageBtnClick()
        {
            _webDriver.FindElement(MainMenuLocators._mortgageBtn, true).Click();
            return new MortgagePageObject(_webDriver);
        }

        public MyHomePageObject MyHomeBtnClick()
        {
            _webDriver.FindElement(MainMenuLocators._myHomeBtn, true).Click();
            return new MyHomePageObject(_webDriver);
        }

        public PikPageObject PikBtnClick()
        {
            _webDriver.FindElement(MainMenuLocators._pikBtn, true).Click(); 
            return new PikPageObject(_webDriver);
        }
    }
}