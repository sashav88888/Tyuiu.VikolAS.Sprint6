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
            string temp = Path.GetTempFileName();

            File.WriteAllText(temp,
                "lG YebQ BV ypiUHHFJ eAezSXF aPIjKf\n" +
                "HbJcPW wUdVEuNB");

            DataService ds = new DataService();

            string result = ds.CollectTextFromFile(temp);

            string expected = "YebQ BV HbJcPW wUdVEuNB";

            Assert.AreEqual(expected, result);

            File.Delete(temp);
        }
    }
}
