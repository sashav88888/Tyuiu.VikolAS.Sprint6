using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint6.Task5.V27.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = "TestInput.txt";

            File.WriteAllText(path, "-17 0 12 -14,32 5 -7,84 12,89 -1,57 -3,64 -13,26 -8,91 -17,77 35 -9 13,83 12,76 8,86 0 -1,49 -7");

            double[] expected =
            {
                -17, 12, -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91,
                -17.77, -9, 13.83, 12.76, 8.86, -1.49, -7
            };

            double[] actual = ds.LoadFromDataFile(path);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
