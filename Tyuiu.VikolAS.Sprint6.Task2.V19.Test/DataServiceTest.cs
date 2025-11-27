using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint6.Task2.V19.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint6.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            double[] result = service.GetMassFunction(-5, 5);

            // Проверяем длину массива
            Assert.AreEqual(11, result.Length);

            // Проверяем, что ни одно значение не NaN
            foreach (var val in result)
            {
                Assert.IsFalse(double.IsNaN(val));
            }

            // Пример проверки конкретного значения (x = 0)
            double fx0 = Math.Round(Math.Sin(0) / (0 + 1.7) - Math.Cos(0) * 4 * 0 - 6, 2);
            Assert.AreEqual(fx0, result[5]);
        }
    }
}
