using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{

    static void Main()
    {
        string result = string.Empty;
        var reader = new StreamReader(@"../../input.txt");
        using (reader)

        {
            string removeTags = reader.ReadToEnd();
            result = Regex.Replace(removeTags, "<.*?>", " ");
        }
        File.WriteAllText(@"../../input.txt", string.Empty);
        var writer = new StreamWriter(@"../../input.txt");
        using (writer)
        {
            writer.WriteLine(result);
        }
    }
}