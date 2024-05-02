using CianWebSiteTests.Utility;

namespace CianWebSiteTests.TestData
{
    internal static class LogInTestData
    {
        public static string Email { get; }

        public static string Password { get; }

        public static string ExpectedUserID { get; }

        static LogInTestData()
        {
            Excel excel = new Excel(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), MainTestData.ExcelFile));
            Email = excel.ReadCell("CianAuthViaEmailPassword", 2, 2) ?? "test.user.24@inbox.ru";
            Password = excel.ReadCell("CianAuthViaEmailPassword", 2, 3) ?? "USgb?BNz.R+cFK$Jqy5t'h";
            ExpectedUserID = excel.ReadCell("CianAuthViaEmailPassword", 2, 8) ?? "ID 115568116";
        }
    }
}