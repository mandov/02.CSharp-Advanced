using System;

class ReverseNumber
{
    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(RevNumber(number));
    }

    public static string RevNumber(string number)
    {

        string reverseString = string.Empty;

        for (var i = number.Length - 1; i >= 0; i--)
        {
            reverseString += number[i];
        }

        return reverseString;
    }
}