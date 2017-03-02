using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("text.txt"))
        {
            while (sr.ReadLine() != null)
            {
                int lines = 1;

                if (lines % 2 == 1)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                lines++;
            }
        }
    }
}