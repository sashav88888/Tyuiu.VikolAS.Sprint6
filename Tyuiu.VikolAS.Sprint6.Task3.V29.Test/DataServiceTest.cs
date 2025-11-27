using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint6.Task3.V29.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SortMatrix_CorrectSorting()
        {
            int[,] matrix =
            {
                { -2, -13, -15, -9, -17 },
                { 13, -20, -15, 27, 18 },
                { -12, -1, -20, 13, 0 },
                { 15, 32, 18, -12, -18 },
                { 16, 5, 3, -5, -8 }
            };

            int[,] expected =
            {
                { -2, -13, -15, -9, -17 },
                { 15, 32, 18, -12, -18 },
                { 16, 5, 3, -5, -8 },
                { -12, -1, -20, 13, 0 },
                { 13, -20, -15, 27, 18 }
            };

            DataService ds = new DataService();
            int[,] result = ds.SortMatrix(matrix);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
