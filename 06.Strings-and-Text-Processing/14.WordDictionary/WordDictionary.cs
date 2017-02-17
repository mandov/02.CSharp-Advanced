using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        string keyWord = Console.ReadLine();
        Dictionary<string, string> words = new Dictionary<string, string>();
        words.Add(".NET", "platform for applications from Microsoft");
        words.Add("CLR", "managed execution environment for .NET");
        words.Add("namespace", "hierarchical organization of classes");

        if (words.ContainsKey(keyWord) == true)
        {
            Console.WriteLine(words[keyWord].ToString());
        }
        else
        {
            Console.WriteLine("This word doesn't exist");
        }
    }
}