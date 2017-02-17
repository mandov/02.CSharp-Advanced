using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(IsLeapYear(year));
    }

   public static string IsLeapYear(int year)
    {
        string result = string.Empty;
        bool isLeap = DateTime.IsLeapYear(year);
        if (isLeap == true)
        {
            result = "Leap";
        }
        else
        {
            result = "Common";
        }

        return result;
    }
}