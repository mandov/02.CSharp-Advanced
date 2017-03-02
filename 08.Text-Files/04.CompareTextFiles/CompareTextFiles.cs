using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CompareTextFiles
{
    static void Main()
    {
        var file1Lines = File.ReadLines(@"../../text1.txt");
        var file2Lines = File.ReadLines(@"../../text2.txt");
        IEnumerable<String> inFirstNotInSecond = file1Lines.Except(file2Lines);
        IEnumerable<String> inSecondNotInFirst = file2Lines.Except(file1Lines);

        Console.WriteLine("Different lines are: {0}", inSecondNotInFirst.Count());
        Console.WriteLine("Same lines are: {0}", file1Lines.Count() - inSecondNotInFirst.Count());
    }
}