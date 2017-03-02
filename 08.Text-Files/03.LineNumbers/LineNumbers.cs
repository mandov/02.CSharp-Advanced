using System;
using System.IO;
using System.Linq;

class LineNumbers
{
    static void Main()
    {
        var reader = new StreamReader(@"../../Barcelona.txt");
        var writer = new StreamWriter(@"../../Result.txt");

        using (reader)
        {
            using (writer)
            {
                var countlines = File.ReadLines(@"../../Barcelona.txt").Count();
                for (int i = 1; i <= countlines; i++)
                {
                    writer.Write("{0}.", i);
                    writer.WriteLine(reader.ReadLine());                
                }
            }
        }
    }
}