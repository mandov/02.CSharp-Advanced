using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());

        int[] numbers = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int currentSequence = 1;
        int bestSequence = 1;

        for (int i = 1; i < numbers.Length ; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentSequence++;
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                }
                else
                {
                    currentSequence = 1;
                }
            }
        }

        Console.WriteLine(bestSequence);
    }
}