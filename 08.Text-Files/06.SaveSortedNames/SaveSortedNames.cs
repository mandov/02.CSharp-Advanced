using System;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        var sr = new StreamReader(@"../../Names.txt");
        var sw = new StreamWriter(@"../../Output.txt");
        using (sr)
        {
            string[] names = sr.ReadToEnd().Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(names);
            using (sw)
            {
                for (int i = 0; i <= names.Length - 1; i++)
                {
                    sw.WriteLine(names[i]);
                }
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}