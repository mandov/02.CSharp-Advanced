using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        string text = Console.ReadLine();
        MatchCollection words = Regex.Matches(text, @"\b\w+\b");
        Dictionary<string, int> counting = new Dictionary<string, int>();
        
        foreach (var item in words)
        {
            if (!counting.ContainsKey(item.ToString()))
            {
                counting.Add(item.ToString(), 1);
            }
            else
            {
                counting[item.ToString()]++;
            }
        }

        foreach (var item in counting)
        {
            Console.WriteLine("{0} --> {1} times", item.Key, item.Value);
        }
    }
}