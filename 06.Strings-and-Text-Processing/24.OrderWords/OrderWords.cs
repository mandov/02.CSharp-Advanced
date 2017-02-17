using System;
using System.Text;

class OrderWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', '.' });
        Array.Sort(words);
        StringBuilder result = new StringBuilder();
        foreach (var item in words)
        {
            result.Append(" " + item);
        }

        Console.WriteLine(result.Append(".").ToString().Trim());
    }
}