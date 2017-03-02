using System;
using System.IO;
using System.Linq;

class MaximalAreaSum
{
    static void Main()
    {
        var sr = new StreamReader(@"../../matrix.txt");
        using (sr)
        {
            int matrixSize = Convert.ToInt32(sr.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

                for (int i = 0; i < matrixSize; i++)
            {
                string[] currentRow = sr.ReadLine().Split(' ' );
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = Convert.ToInt32(currentRow[j]);
                }
            }
            int bestSum = int.MinValue;
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                }
            }
            if (sum > bestSum)
            {
                bestSum = sum;
            }
            Console.WriteLine(bestSum);
        }
    }
}