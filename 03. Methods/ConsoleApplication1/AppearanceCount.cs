using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberToFind = int.Parse(Console.ReadLine());

        int result = NumberCount(numbers, numberToFind);

        Console.WriteLine(result);

    }

    private static int NumberCount(int[] arr, int number)
    {
        int frequent = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == number)
            {
                frequent += 1;
            }
        }

        return frequent;
    }
}