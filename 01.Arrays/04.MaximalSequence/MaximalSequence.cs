using System;

class MaximalSequence
{
    static void Main()
    {
        int elementsInArray = int.Parse(Console.ReadLine());

        int[] array = new int[elementsInArray];
        for (int i = 0; i < elementsInArray; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int bestSequence = 1;
        int currentSequence = 1;
        int bestNumber = 0;

        for (int i = 0; i < array.Length ; i++)
        {

            if (array[i] == array[i + 1])
            {
                currentSequence++;
                if (currentSequence > bestSequence)
                {
                    bestSequence = currentSequence;
                    bestNumber = array[i];
                }
                else
                {
                    currentSequence = 1;
                }

            }

            Console.WriteLine(bestSequence);
        }
    }
}