using System;

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBin(decimalNumber));
    }

    static string DecimalToBin(long decimalNumber)
    {
       
        long digit = 0;
        string result = " ";
       
        while (decimalNumber > 0 )
        {
            digit = decimalNumber % 2;
            result = digit + result;
            decimalNumber = decimalNumber / 2;
        }
     
        return result;
    }
}
