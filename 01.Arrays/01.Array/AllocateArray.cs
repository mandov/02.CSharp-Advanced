using System;

class AllocateArray
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int counter = 5;
        int[] array = new int[size];
        for (int index = 1; index <= array.Length - 1; index++)
        {
            array[index] = +counter;
            counter += 5;

        }
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

    }
}