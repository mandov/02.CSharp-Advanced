using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string word = Console.ReadLine();

        Console.WriteLine(Reverse(word));
    }

    static string Reverse(string word)
    {
        var reversed = new StringBuilder();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed.Append(word[i]);
        }

        return reversed.ToString();
    }
}