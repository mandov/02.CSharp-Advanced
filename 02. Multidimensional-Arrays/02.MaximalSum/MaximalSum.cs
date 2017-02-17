using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[,] numbers = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                numbers[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int bestSum = int.MinValue;

        for (int row = 0; row < numbers.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < numbers.GetLength(1) - 2 ; col++)
            {

                
                int sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    sum += numbers[row, col + i];
                    sum += numbers[row + 1, col + i];
                    sum += numbers[row + 2, col + i];


                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }

        Console.WriteLine(bestSum);
    }
}