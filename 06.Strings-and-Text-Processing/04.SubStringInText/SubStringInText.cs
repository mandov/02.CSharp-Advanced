using System;
using System.Text;

class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        Console.WriteLine(FrequentSubString(text, pattern));

    }

    static int FrequentSubString(string text, string pattern)
    {
        int counter = 0;
        for (int i = 0; i < text.Length - pattern.Length  + 1; i++)
        {
            if (text.Substring(i, pattern.Length) == pattern)
            {
                counter++;
            }
        }
        return counter;
    }
}