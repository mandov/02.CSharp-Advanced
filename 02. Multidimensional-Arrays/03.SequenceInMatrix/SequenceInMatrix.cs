using System;

class SequenceInMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        int counter = 0;
        int sortArraySize = n * m;
        int[] sortArray = new int[sortArraySize];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int number = int.Parse(Console.ReadLine());
                matrix[i, j] = number;
                sortArray[counter] = number;
                counter += 1;
            }
        }

        Array.Sort(sortArray);

        int frequent = 1;
        int currentNumber = 0;
        int bestfrequent = 0;
        int nextNumber = 0;
        for (int i = 0; i < sortArray.Length - 1; i++)
        {
            currentNumber = sortArray[i];
            nextNumber = sortArray[i + 1];

            if (currentNumber == nextNumber)
            {
                frequent += 1;
            }
            else if (frequent > bestfrequent)
            {
                bestfrequent = frequent;
            }
            else
            {
                frequent = 1;
            }
        }
        Console.WriteLine(bestfrequent);
    }
}