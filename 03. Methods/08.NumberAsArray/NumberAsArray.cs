using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        string arraySize = Console.ReadLine().Split(' ').Select(int.Parse).ToString();

        ArraySize(arraySize[0], arraySize[1]);
    }

    public static int ArraySize(int number, int numberTwo)
    {
        int[,] array = new int[number, numberTwo];

        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[number, numberTwo] = int.Parse(Console.ReadLine());
        }

        return array[number, numberTwo];
    }
}