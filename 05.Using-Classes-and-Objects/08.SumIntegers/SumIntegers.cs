using System;
using System.Text.RegularExpressions;

class SumIntegers
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        Console.WriteLine(SumString(sequence));
    }

    static int SumString(string sequence)
    {
        string[] input = Regex.Split(sequence, @"\D+");
        int result = 0;
        foreach (var value in input)
        {
            if (!string.IsNullOrEmpty(value))
            {
                int number = int.Parse(value);
                result += number;
            }
        }

        return result;
    }
}