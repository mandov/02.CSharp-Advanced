using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        AscendingSortArray(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        DescendingSortArray(numbers);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }

    public static int AscendingSortArray(int[] array)
    {
        int temp = 0;
        int iMin = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            iMin = i;
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[i] > array[j])
                {
                    iMin = j;
                }
            }

            if (iMin != i)
            {
                temp = array[iMin];
                array[iMin] = array[i];
                array[i] = temp;
            }
        }
        return array[array.Length - 1];
    }

    public static int DescendingSortArray(int[] array)
    {
        int temp = 0;
        int iMax = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            iMax = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    iMax = j;
                }
            }

            if (iMax != i)
            {
                temp = array[iMax];
                array[iMax] = array[i];
                array[i] = temp;
            }
        }
        return array[array.Length - 1];
    }
}