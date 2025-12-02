using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint6.Task6.V6.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile()
        {
            // создаём временный файл
            string tempFile = Path.GetTempFileName();

            File.WriteAllText(tempFile,
                "ab cd EfB gHk\n" +
                "BBc test wordB");

            DataService ds = new DataService();

            string result = ds.CollectTextFromFile(tempFile);

            // ожидаем слова, содержащие b или B
            string expected = "ab EfB BBc wordB";

            Assert.AreEqual(expected, result);

            File.Delete(tempFile);
        }
    }
}
