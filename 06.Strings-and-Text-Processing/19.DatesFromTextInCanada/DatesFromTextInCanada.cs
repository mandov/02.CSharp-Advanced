using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main()
    {
        string text = "I am born was born 01.08.1996.";
        string[] word = text.Split(' ');

        for (int i = 0; i < word.Length; i++)
        {
            if (Regex.IsMatch(word[i], @"\b\d{1,2}\.\d{1,2}.\d{1,4}"))
            {

                word[i] = word[i].Remove(word[i].Length - 1);

                DateTime dt = DateTime.ParseExact(word[i], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(dt.ToShortDateString().ToString(new CultureInfo("en-CA")));
            }
        }
    }
}
