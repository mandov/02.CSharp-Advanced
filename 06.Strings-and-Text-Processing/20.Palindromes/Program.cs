using System;
using System.Text;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();

        string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();
        for (int i = 0; i <= words.Length - 1; i++)
        {
            if (words[i].Length <= 3 && CompaereStrings(words[i], ReverseString(words[i])))
            {
                result.Append(words[i] + " ");
            }
        }

        Console.WriteLine(result);
    }

    static string ReverseString(string text)
    {
        string result = string.Empty;

        for (int i = text.Length - 1; i >= 0; i--)
        {
            result += text[i];
        }

        return result;
    }

    static bool CompaereStrings(string text, string textTwo)
    {
        bool length = true;
        bool isTrue = false;
        if (text.Length > textTwo.Length || textTwo.Length > text.Length)
        {
            length = false;
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == textTwo[i] && length)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
                break;
            }
        }

        return isTrue;
    }
}