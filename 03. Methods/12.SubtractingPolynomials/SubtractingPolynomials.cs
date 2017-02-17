using System;

class SubtractingPolynomials
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[] firstCoefficients = AddValue(size);
        int[] secondCoefficients = AddValue(size);

        int[] result = Polynimial(firstCoefficients, secondCoefficients);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }

    public static int[] AddValue(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i <= array.Length - 1; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    public static int[] Polynimial(int[] array, int[] arrayTwo)
    {
        int[] result = new int[array.Length];

        for (int i = 0; i <= array.Length - 1; i++)
        {
            result[i] = array[i] - arrayTwo[i];

        }

        return result;
    }

}