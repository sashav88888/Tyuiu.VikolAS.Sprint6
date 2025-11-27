using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            throw new NotImplementedException();
        }

        public int[,] SortMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var order = new (int index, int value)[rows];

            for (int i = 0; i < rows; i++)
                order[i] = (i, matrix[i, 4]);

            Array.Sort(order, (a, b) => a.value.CompareTo(b.value));

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int rowIndex = order[i].index;

                for (int j = 0; j < cols; j++)
                    result[i, j] = matrix[rowIndex, j];
            }

            return result;
        }
    }
}
