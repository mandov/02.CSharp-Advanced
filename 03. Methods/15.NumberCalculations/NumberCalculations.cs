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
        Console.WriteLine("{0:F2}", AverageValue(sequence));
        Console.WriteLine(Sum(sequence));
        Console.WriteLine(Product(sequence));
    }

    static T MinValue<T>(params T[] array)
    {      
        dynamic minimum = array[0];
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (minimum > array[i])
            {
                minimum = array[i];
            }
        }

        return minimum ;
    }
    static T MaxValue<T>(params T[] array)
    {
        dynamic maximum = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (maximum < array[i])
            {
                maximum = array[i];
            }
        }

        return maximum;
    }

    static T AverageValue<T>(T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            sum += array[i];
        }

        dynamic result = sum / array.Length;
        return result;
    }

    static T Sum<T>(T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static T Product<T>(T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            product *= array[i];
        }

        return product;
    }
}