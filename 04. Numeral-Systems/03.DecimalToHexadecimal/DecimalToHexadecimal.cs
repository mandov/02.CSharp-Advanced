using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHexa(decimalNumber));
    }

    static string DecimalToHexa(int decimalNumber)
    {
        string result = "";
        int digit = 0;
        while (decimalNumber > 0)
        {
            digit = decimalNumber % 16;
            switch (digit)
            {
                case 10: result = "A" + result ; break;
                case 11: result = "B" + result ; break;
                case 12: result = "C" + result ; break;
                case 13: result = "D" + result ; break;
                case 14: result = "E" + result ; break;
                case 15: result = "F" + result ; break;
                default:
                    result = digit + result;
                    break;
            }
            decimalNumber = decimalNumber / 16;
        }

        return result;
    }
}