using System;

    class FrequentNumber
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());         
        }
        Array.Sort(numbers);
        int currentSequence = 1;
        int bestNumber = 0;
        int bestSequence = 0;
       
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentSequence++;
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestNumber = numbers[i];
                }
            }
            else
            {
                currentSequence = 1;
            }
        }
        Console.WriteLine("{0}({1} times)", bestNumber, bestSequence);
        }
    }