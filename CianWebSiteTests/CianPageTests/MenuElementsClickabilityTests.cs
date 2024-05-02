using CianWebSiteTests.Locators;
using CianWebSiteTests.PageObjects;
using CianWebSiteTests.TestData;
using CianWebSiteTests.Urls;
using CianWebSiteTests.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CianWebSiteTests.CianPageTests
{
    public class MenuElementsClickabilityTests
    {
        private IWebDriver webDriver;
        private Driver driver;
        private Reporter excelReport;
        private List<(string, int, string, string, string)> units;

        [OneTimeSetUp]
        public void Prepare()
        {
            units = new List<(string, int, string, string, string)>();
            excelReport = new Reporter(Path.Combine(Options.ExcelReportsDirectoryPath,
                TestContext.CurrentContext.Test.Name + " " + Helper.GenerateFileName(Reports.Excel)));
        }

        [SetUp]
        public void Setup()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");
            chromeOptions.AddArgument("--lang=ru");
            webDriver = new ChromeDriver(chromeOptions);

            string iteration = $"Iteration {TestContext.CurrentContext.CurrentRepeatCount} ";
            string logFileName = Helper.GenerateFileName(Reports.Txt, iteration + TestContext.CurrentContext.Test.Name.ToString());
            string logDirectoryName = TestContext.CurrentContext.Test.ClassName!.ToString();
            string logMethodDirectoryName = TestContext.CurrentContext.Test.MethodName!.ToString();
            string pathToLogFile = Path.Combine(Options.LogsDirectoryPath, logDirectoryName, logMethodDirectoryName, logFileName);
            Beaver logger = new Beaver(pathToLogFile);

            driver = new Driver(webDriver, logger);
            driver.Log.Logger.Information($"Start. Method name: {TestContext.CurrentContext.Test.FullName}");
            driver.Manage().Window.Maximize();
        }

        [Test, Repeat(10)]
        public void ChooseCity()
        {
            int i = TestContext.CurrentContext.CurrentRepeatCount % CityChoiceTestData.Cities.Length;
            string choosingCity = CityChoiceTestData.Cities[i];

            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.CityChoiceMenuClick().ChooseCity(choosingCity);
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();

            string currentCity = driver.FindElement(MainMenuLocators._cityGeoLocationName, true).Text;
            Assert.That(currentCity, Is.EqualTo(choosingCity), "Expected (chosen) and actual (current) cities are not equal.");
        }

        [Test, Repeat(10)]
        public void LeaseBtnClick()
        {
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.LeaseBtnClick();
            string url = driver.Url;
            string[] values = { "snyat" };
            Assert.IsTrue(values.Any(url.Contains), "The opened page is not the target page.");
        }

        [Test, Repeat(10)]
        public void SellBtnClick()
        {
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.SellBtnClick();
            string url = driver.Url;
            string[] values = { "kupit" };
            Assert.IsTrue(values.Any(url.Contains), "The opened page is not the target page.");
        }

        [Test, Repeat(10)]
        public void NewBuildingsBtnClick()
        {
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.NewBuildingsBtnClick();
            string url = driver.Url;
            string[] values = { "novostrojki" };
            Assert.IsTrue(values.Any(url.Contains), "The opened page is not the target page.");
        }

        [Test, Repeat(10)]
        public void CommercialRealtyBtnClick()
        {
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.CommercialRealtyBtnClick();
            string url = driver.Url;
            string[] values = { "commercial" };
            Assert.IsTrue(values.Any(url.Contains), "The opened page is not the target page.");
        }

        [Test, Repeat(10)]
        public void MortgageBtnClick()
        {
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.MortgageBtnClick();
            string url = driver.Url;
            string[] values = { "ipoteka" };
            Assert.IsTrue(values.Any(url.Contains), "The opened page is not the target page.");
        }

        [Test, Repeat(10)]
        public void MyHomeBtnClick()
        {
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.MyHomeBtnClick();
            string url = driver.Url;
            string[] values = { "my-home" };
            Assert.IsTrue(values.Any(url.Contains), "The opened page is not the target page.");
        }

        [Test, Repeat(10)]
        public void PikBtnClick()
        {
            string choosingCity = CityChoiceTestData.Cities[0];
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.CityChoiceMenuClick().ChooseCity(choosingCity);
            driver.Navigate().GoToUrl(CianWebSiteUrls.MainPageUrl);
            driver.WaitDocumentReadyState();
            mainMenu.PikBtnClick();
            string url = driver.Url;
            string[] values = { "pik" };
            Assert.IsTrue(values.Any(url.Contains), "The opened page is not the target page.");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Log.Logger.Information($"Final. Method name: {TestContext.CurrentContext.Test.FullName}");
            webDriver.Dispose();
            driver.Dispose();

            units.Add((TestContext.CurrentContext.Test.Name,
                      TestContext.CurrentContext.CurrentRepeatCount,
                      TestContext.CurrentContext.Test.Name,
                      TestContext.CurrentContext.Result.Outcome.ToString()!,
                      driver.Log.Path));
        }

        [OneTimeTearDown]
        public void Finalizing()
        {
            excelReport.Create(units);
        }
    }
}