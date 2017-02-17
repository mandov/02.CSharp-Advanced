using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(FirstLargerIndex(numbers));
    }

    public static int FirstLargerIndex(int[] array)
    {
        int index = -1;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i] && array[i] > array[i - 1])
            {
                return index = i;
            }
        }
        return index;
    }
}