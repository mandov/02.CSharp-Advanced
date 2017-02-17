using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        Console.WriteLine(HexaNumToDecimalNum(hexNumber));

    }

    static int HexaNumToDecimalNum(string hexNumber)
    {
        int position = 0;
        int digit = 0;
        int result = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
            {
                digit = hexNumber[i] - '0';
            }
            else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
            {
                digit = hexNumber[i] - 'A' + 10;
            }

            position = hexNumber.Length - 1 - i;
            result += digit * ((int)Math.Pow(16, position));
        }

        return result;
    }
}