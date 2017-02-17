using System;
using System.Text;
using System.Text.RegularExpressions;

class LettersCount
{
    static void Main()
    {
        string text = Console.ReadLine();
        string textWithoutWhiteSpaces = Regex.Replace(text, @"\s+", "");
        char[] letter = textWithoutWhiteSpaces.ToCharArray();
        Array.Sort(letter);
        int counter = 1;
        char currentLetter = ' ';
        int index = 0;
        int stopindex = 0;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i <= letter.Length - 1; i++)
        {
            currentLetter = letter[i];
            index = letter.Length - 1;
            stopindex = i + 1;
            if (char.IsLetter(letter[i]))
            {
                if (stopindex > index)
                {
                    break;
                }
                else if (currentLetter == letter[i + 1])
                {
                    counter++;
                }
                else if (currentLetter != letter[i + 1])
                {
                    result.Append(currentLetter.ToString() + " = " + counter + "  ");

                    counter = 1;
                }
            }
        }

        Console.WriteLine(result);
    }
}