using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.ReadLine();
        int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(MinValue(sequence));
        Console.WriteLine(MaxValue(sequence));
        Console.WriteLine("{0:F2}",AverageValue(sequence));
        Console.WriteLine(Sum(sequence));
        Console.WriteLine(Product(sequence));
    }

    static int MinValue(int[] array)
    {
        int minimum = int.MaxValue;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (minimum > array[i])
            {
                minimum = array[i];
            }
        }

        return minimum;
    }

    static int MaxValue(int[] array)
    {
        int maximum = int.MinValue;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (maximum < array[i])
            {
                maximum = array[i];
            }
        }

        return maximum;
    }

    static decimal AverageValue(int[] array)
    {
        decimal sum = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            sum += array[i];
        }

        decimal result = sum / array.Length;
        return result;
    }

    static int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static int Product(int[] array)
    {
        int product = 1;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            product *= array[i];
        }

        return product;
    }
}