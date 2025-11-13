using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VikolAS.Sprint6.Task1.V4.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            // Проверяем длину массива
            Assert.AreEqual(11, res.Length);

            // Проверка вычислений
            double x1 = -5;
            double expected1 = Math.Round((Math.Sin(x1) / (x1 + 1.2)) - (Math.Sin(x1) * 2) - (2 * x1), 2);
            Assert.AreEqual(expected1, res[0]);

            double x2 = 0;
            double expected2 = Math.Round((Math.Sin(x2) / (x2 + 1.2)) - (Math.Sin(x2) * 2) - (2 * x2), 2);
            Assert.AreEqual(expected2, res[5]);

            double x3 = 5;
            double expected3 = Math.Round((Math.Sin(x3) / (x3 + 1.2)) - (Math.Sin(x3) * 2) - (2 * x3), 2);
            Assert.AreEqual(expected3, res[10]);
        }
    }
}
