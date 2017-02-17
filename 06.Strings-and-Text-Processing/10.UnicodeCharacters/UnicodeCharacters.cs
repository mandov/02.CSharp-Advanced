using System;

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();

        foreach (var symbol in text)
        {
            Console.Write("\\u{0:X4}", Convert.ToInt32(symbol));
        }

        Console.WriteLine();
    }
}
