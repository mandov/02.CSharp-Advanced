using System;
using System.Linq;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date:");
        string firstDateTime = Console.ReadLine();
        Console.Write("Enter the second date:");
        string secondDateTime = Console.ReadLine();
        
        DateTime firstDT = Convert.ToDateTime(firstDateTime);
        DateTime secondDT = Convert.ToDateTime(secondDateTime);
        Console.WriteLine("Distance:{0}", Math.Abs((firstDT - secondDT).TotalDays));
    }
}