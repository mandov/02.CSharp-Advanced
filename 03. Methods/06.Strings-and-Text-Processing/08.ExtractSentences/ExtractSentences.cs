using System;
using System.Linq;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string[] sentence = text.Split('.');
        char[] symbols = text.Where(x => !char.IsLetter(x)).Distinct().ToArray();

        StringBuilder result = new StringBuilder();

        foreach (var item in sentence)
        {
            var oneword = item.Split(symbols).ToArray();
            if (oneword.Contains(word))
            {
                result.Append(item);
                result.Append('.');
            }
        }
        Console.WriteLine(result);
    }
}