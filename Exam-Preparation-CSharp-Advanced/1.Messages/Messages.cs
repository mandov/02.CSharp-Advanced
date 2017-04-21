using System;
using System.Numerics;

class Messages
{
    private static string[] arr = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan", };

    static void Main()
    {
        string firstNum = Console.ReadLine();
        string op = Console.ReadLine();
        string secondNum = Console.ReadLine();

        BigInteger numOne = Decrypt(firstNum);
        BigInteger numTwo = Decrypt(secondNum);
        BigInteger result = 0;
        if (op == "+")
        {
            result = numOne + numTwo;
        }
        else
        {
            result = numOne - numTwo;
        }

        Console.WriteLine(Encrypt(result));
    }

    private static string Encrypt(BigInteger result)
    {
        string resultt = string.Empty;
        string number = Convert.ToString(result);
        for (int i = 0; i < number.Length; i++)
        {
            resultt = resultt + arr[number[i] - 48];
        }

        return resultt;
    }

    private static BigInteger Decrypt(string firstNum)
    {
        string result = string.Empty;
        for (int i = 0; i < firstNum.Length; i += 3)
        {
            string sub = firstNum.Substring(i, 3);
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                if (string.Equals(sub, arr[j]))
                {
                    result = result + j;
                    break;
                }
            }
        }

        return BigInteger.Parse(result);
    }
}