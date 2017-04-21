using System;
using System.Linq;
using System.Numerics;

class DecodeAndDecrypt
{
    static string[] arr = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

    static void Main()
    {
        BigInteger a = DecryptFrom21(Console.ReadLine());
        string op = Console.ReadLine();
        BigInteger b = DecryptFrom7(Console.ReadLine());
        string result = EncryptToBase9(a, b, op);

        Console.WriteLine(result);
    }

    private static string EncryptToBase9(BigInteger a, BigInteger b, string op)
    {
        BigInteger sum = op == "+" ? a + b : a - b; 
        BigInteger remainder = 0;
        string result = string.Empty;
        while (sum != 0)
        {
            remainder = sum % 9;
            result = remainder.ToString() + result;
            sum = sum / 9;
        }

        return result;
    }

    private static BigInteger DecryptFrom7(string secondNum)
    {
        BigInteger result = 0;
        BigInteger power = 1;
        for (int i = secondNum.Length - 1; i >= 0; i--)
        {
            result += (secondNum[i] - 48) * power;
            power *= 7;
        }

        return result;
    }

    private static BigInteger DecryptFrom21(string firstNum)
    {
        char[] chars = firstNum.ToCharArray();
        var alphabet = chars.Select(c => c.ToString()).ToArray();
        for (int i = 0; i < alphabet.Length; i++)
        {
            for (int j = 0; j <= arr.Length - 1; j++)
            {
                alphabet[i] = alphabet[i].ToString().Replace(arr[j], j.ToString());
            }
        }

        BigInteger result = 0;
        BigInteger power = 1;
        for (int i = alphabet.Length - 1; i >= 0; i--)
        {
            result += Convert.ToInt32(alphabet[i]) * power;
            power *= 26;
        }

        return result;
    }
}