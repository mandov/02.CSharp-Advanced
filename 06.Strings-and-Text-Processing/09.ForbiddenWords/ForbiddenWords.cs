using System;
using System.Linq;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string[] forbiddenWords = Console.ReadLine().Split(' ').ToArray();
        string text = Console.ReadLine();
        string numberOfChars = string.Empty;
        StringBuilder result = new StringBuilder(text);

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            string number = numberOfChars.PadRight(forbiddenWords[i].Length, '*');
            result.Replace(forbiddenWords[i], number);
        }

        Console.WriteLine(result);
    }
}