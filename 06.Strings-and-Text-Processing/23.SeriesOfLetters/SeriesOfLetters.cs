using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        char[] letter = text.ToCharArray();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < letter.Length - 1; i++)
        {
            if (letter[i] != letter[i + 1])
            {
                result.Append(letter[i]);
            }
        }

        Console.WriteLine(result.Append(letter[letter.Length - 1]));
    }
}