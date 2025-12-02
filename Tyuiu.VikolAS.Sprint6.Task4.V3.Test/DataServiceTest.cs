using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint6.Task4.V3.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] res = ds.GetMassFunction(start, stop);

            Assert.AreEqual(11, res.Length);

            // Проверка значения при x = 0
            // F(0) = ((0 - 1.5) / (sin(0) - 3 + 0)) + 2 = (-1.5 / -3) + 2 = 2.5
            Assert.AreEqual(2.5, res[5]);
        }
    }
}
