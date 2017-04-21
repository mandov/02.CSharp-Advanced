using System;
using System.Linq;

class CalculationProblem
{
    static void Main()
    {
        var sum = Console.ReadLine().Split(' ').Select(MeowToDec).Sum();
        var meow = DecToMeow(sum) + " = " + sum;
        Console.WriteLine(meow);
    }

    private static int MeowToDec(string arg)
    {
        int result = 0;

        foreach (char digit in arg)
        {
            result = (digit - 'a') + result * 23;
        }

        return result;
    }

    private static string DecToMeow(int arg)
    {
        string result = string.Empty;
        
        do
        {
           char remainder = (char)('a' + (arg % 23));
            result = remainder + result;
            arg /= 23;
        } while (arg != 0);

        return result;
    }
}