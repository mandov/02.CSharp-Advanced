using System;
using System.Text;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(IsCorrect(input));
    }

    static string IsCorrect(string input)
    {
        var check = new StringBuilder(input);
        int a = 0;
        int b = 0;
        string result = string.Empty;
        for (int i = 0; i < check.Length; i++)
        {
            if (check[i] == '(')
            {
                a++;
            }
            else if (check[i] == ')')
            {
                b++;
            }
        }

        if (a == b)
        {
            result = "Correct";
        }
        else
        {
            result = "Incorrect";
        }

        return result;
    }
}