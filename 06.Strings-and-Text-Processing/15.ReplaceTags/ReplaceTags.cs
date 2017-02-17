using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string htmlDocument = Console.ReadLine();

        string[] result = Regex.Split(htmlDocument, "< a href = \".* \" </ a >");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        
    }
}