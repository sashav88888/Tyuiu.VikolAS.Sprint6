using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint6.Task4.V3.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TabulateFunction_TestValues()
        {
            DataService ds = new DataService();
            var result = ds.TabulateFunction(-5, 5, 1);

            Assert.AreEqual(11, result.Count);

            foreach (var item in result)
            {
                double denominator = Math.Sin(item.x) - 3 + item.x;
                double expected;
                if (Math.Abs(denominator) < 1e-10)
                    expected = 0;
                else
                    expected = Math.Round((3 * item.x - 1.5) / denominator + 2, 2);

                Assert.AreEqual(expected, item.fx);
            }
        }
    }
}
