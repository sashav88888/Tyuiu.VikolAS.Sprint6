using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.VikolAS.Sprint6.Task7.V27.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestModifyRow()
        {
            string temp = "test.csv";
            File.WriteAllText(temp,
                "-1;2;3\n" +
                "4;5;-6\n" +
                "7;8;9\n" +
                "1;2;3\n" +
                "-3;5;-7\n" +  // <-- строка №5 (индекс 4)
                "9;9;9");

            DataService ds = new DataService();
            int[,] matrix = ds.GetMatrix(temp);

            Assert.AreEqual(-1, matrix[4, 0]); // отрицательное → -1
            Assert.AreEqual(5, matrix[4, 1]);
            Assert.AreEqual(-1, matrix[4, 2]); // отрицательное → -1

            File.Delete(temp);
        }
    }
}
