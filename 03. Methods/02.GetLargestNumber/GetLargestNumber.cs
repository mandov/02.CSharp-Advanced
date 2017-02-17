using System;

class GetLargestNumber
{

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int findMax = GetMax(a, b);
        int maxNumber = GetMax(c, findMax);

        Console.WriteLine(maxNumber);
    }

    public static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

}

