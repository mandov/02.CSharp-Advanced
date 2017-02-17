using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string [] arr = Regex.Split(input,"\b([A-z0-9]+)@([A-Z0-9]*).([A-z{2,6}]+)\b");

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

       
    }
}