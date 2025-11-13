using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint6.Task0.V24.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 4096; // (3 - 1)^(3*3+1) = 2^10 = 1024
            Assert.AreEqual(1024, res);
        }
    }
}
