using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:d} <---Decimal", a);
        Console.WriteLine("{0,15:X} <---Hexadecimal", a);
        Console.WriteLine("{0,15:P} <---Percentage", a);
        Console.WriteLine("{0,15:E} <---Scientific notation", a);
    }
}