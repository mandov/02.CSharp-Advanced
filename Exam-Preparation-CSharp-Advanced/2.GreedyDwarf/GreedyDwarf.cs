using System;
using System.Linq;

class GreedyDwarf
{
    static void Main()
    {
        int[] valley = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToArray();
        int numberOfPatterns = int.Parse(Console.ReadLine());
        int coins = 0;
        int bestPattern = int.MinValue;
        int index = 0;
        int counter = 0;
        for (int i = 0; i < numberOfPatterns; i++)
        {
            int[] pattern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToArray();
            int[] copyValley = valley.Clone() as int[];
            while (index <= valley.Length - 1)
            {
                coins += copyValley[index];
                copyValley[index] = 0;
                index += pattern[counter];
                if (index < 0 || index > valley.Length - 1)
                {
                    break;
                }

                if (copyValley[index] == 0)
                {
                    break;
                }

                counter++;

                if (counter > pattern.Length - 1)
                {
                    counter = 0;
                }
            }

            if (coins > bestPattern)
            {
                bestPattern = coins;
            }

            index = 0;
            counter = 0;
            coins = 0;
        }

        Console.WriteLine(bestPattern);
    }
}