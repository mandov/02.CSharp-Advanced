using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        string number = (Console.ReadLine());
        int numberType = int.Parse(Console.ReadLine());
        int numberToConvert = int.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBase(BaseToDecimal(number,numberType),numberToConvert));

    }

    static int BaseToDecimal(string Number, int SystemType)
    {
        int digit = 0;
        int result = 0;
        int position = 0;
        for (int i = 0; i < Number.Length; i++)
        {
            position = Number.Length - 1 - i;
            if (Number[i] >= '0' && Number[i] <= '9')
            {
                digit = Number[i] - '0';
            }
            else if (Number[i] >= 'A' && Number[i] <= 'F')
            {
                digit = Number[i] - 'A' + 10;
            }
            result += digit * ((int)Math.Pow(SystemType, position));
        }

        return result;
    }

    static string DecimalToBase(int decimalNumber, int SystemToConvert)
    {
        long digit = 0;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            digit = decimalNumber % SystemToConvert;

            if (digit >= 0 && digit <= 9)
            {
                result += (char)(digit + '0') + result;
            }
            else
            {
                result += (char)(digit - 10 + 'A') + result;
            }

            decimalNumber /= SystemToConvert;
        }

        return result;
    }
}
