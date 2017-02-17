using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binNumber = Console.ReadLine();
        Console.WriteLine(BinToDecimal(binNumber));
    }

    static int BinToDecimal(string binaryNumber)
    {
        int currentNumber;
        int position = 0;
        int result = 0;
        for (int i = 0; i <= binaryNumber.Length - 1; i++)
        {
            position = binaryNumber.Length - 1 - i;
            currentNumber = binaryNumber[i] - 48;
            result += currentNumber * (int)Math.Pow(2, position);
        }

        return result;
    }

}