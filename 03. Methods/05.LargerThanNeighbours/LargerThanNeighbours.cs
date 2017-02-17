using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(LargerNeighbours(numbers));

    }

    public static int LargerNeighbours(int[] array)
    {
        int counter = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i - 1] < array[i] && array[i + 1] < array[i])
            {
                counter++;
            }
        }

        return counter;
    }
}