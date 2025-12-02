using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(parts[j]);
                }
            }

            // 5-я строка → индекс 4
            for (int j = 0; j < cols; j++)
            {
                if (matrix[4, j] < 0)
                    matrix[4, j] = -1;
            }

            return matrix;
        }
    }
}
