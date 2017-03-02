using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        var firstFile = new StreamReader(@"../../JavaScript.txt");
        var secondFile = new StreamReader(@"../../CSharp.txt");
        var write = new StreamWriter(@"../../ProgrammingLanguages");

        using (write)
        {
            using (firstFile)
            {
                write.WriteLine(firstFile.ReadToEnd());
            }

            using (secondFile)
            {
                write.WriteLine(secondFile.ReadToEnd());
            }
        }
    }
}
