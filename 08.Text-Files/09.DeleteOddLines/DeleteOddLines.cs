using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string tempFile = Path.GetTempFileName();
        using (var reader = new StreamReader(@"../../lines.txt"))
        using (var sw = new StreamWriter(tempFile))
        {
            int lines = 1;
            string textLine = string.Empty;
            while ((textLine = reader.ReadLine()) != null)
            {
                if (lines % 2 == 0)
                {
                    sw.WriteLine(textLine);
                }

                lines++;
            }
        }

        File.Delete(@"../../lines.txt");
        File.Move(tempFile, @"../../lines.txt");
    }
}