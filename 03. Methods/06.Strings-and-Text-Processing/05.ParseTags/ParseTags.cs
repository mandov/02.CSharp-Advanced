using System;
using System.Text.RegularExpressions;

class ParseTags
{
    static void Main()
    {
        string text = Console.ReadLine();
        string result = Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper());
        Console.WriteLine(result);
    }
}