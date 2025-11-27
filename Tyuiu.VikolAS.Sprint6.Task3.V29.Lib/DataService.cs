using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            // Сбор 5-го столбца
            int[] fifthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fifthColumn[i] = matrix[i, 4];
            }

            // Сортировка по возрастанию
            Array.Sort(fifthColumn);

            // Замена 5-го столбца на отсортированный
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = fifthColumn[i];
            }

            return matrix;
        }
    }
}
