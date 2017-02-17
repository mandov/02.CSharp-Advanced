using System;

class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int sum = 0;

        for (int i = array.Length - 1, j = k; i >= 0; i--, j--)
        {
            if (j > 0)
            {
                sum += array[i];

            }
            else
            {
                break;
            }
        }

        Console.WriteLine(sum);
    }
}