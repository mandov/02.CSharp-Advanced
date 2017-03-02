using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubString
{
    static void Main()
    {
        var reader = new StreamReader(@"../../input.txt");
        var writer = new StreamWriter(@"../../output.txt");

        using (reader)
        {
            string input = reader.ReadToEnd();
            string result = Regex.Replace(input, "start", "finish");

            using (writer)
            {
                writer.WriteLine(result);
            }
        }
    }
}