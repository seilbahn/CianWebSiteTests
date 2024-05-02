using CianWebSiteTests.Utility;

namespace CianWebSiteTests.TestData
{
    internal class CityChoiceTestData
    {
        public static string[] Cities { get; }

        static CityChoiceTestData()
        {
            Cities = getCities();
        }

        private static string[] getCities()
        {
            List<string> list = new List<string>();

            Excel excel = new Excel(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), MainTestData.ExcelFile));

            int row = 2;
            int column = 2;

            while (true)
            {
                string? city = excel.ReadCell("Cities", row, column);
                if (city == null)
                {
                    break;
                }
                else
                {
                    list.Add(city);
                }
                row++;
            }

            if (!list.Any())
            {
                list.Add("Москва");
                list.Add("Самара");
                list.Add("Владивосток");
            }

            return list.ToArray();
        }
    }
}