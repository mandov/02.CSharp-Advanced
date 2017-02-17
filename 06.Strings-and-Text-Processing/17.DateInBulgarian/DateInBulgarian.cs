using System;
using System.Globalization;
class DateInBulgarian
{
    static void Main()
    {
        Console.Write("Enter date and time:");
        string input = Console.ReadLine();

        var culture = new CultureInfo("bg-BG");
        var dateAndTime = DateTime.ParseExact(input, "d.MM.yyyy HH:mm:ss", culture).AddHours(+6).AddMinutes(+30);

        Console.WriteLine("New date and time is:{0}",dateAndTime);
        Console.WriteLine("Today is:{0}",culture.DateTimeFormat.GetDayName(dateAndTime.DayOfWeek));

    }
}