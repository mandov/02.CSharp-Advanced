using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] sequence = new int[size];

        for (int i = 0; i <= sequence.Length - 1; i++)
        {
            sequence[i] = i + 1;
        }

        Console.WriteLine(Factorial(sequence));
    }

    public static BigInteger Factorial(int[] array)
    {
        BigInteger result = 1;

        for (int i = 0; i <= array.Length - 1; i++)
        {
            result *= array[i];
        }

        return result;
    }
}