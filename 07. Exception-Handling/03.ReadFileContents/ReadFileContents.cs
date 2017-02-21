using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        string path = Console.ReadLine();

        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (ArgumentNullException s)
        {
            Console.WriteLine(s.StackTrace);
        }
    }
}