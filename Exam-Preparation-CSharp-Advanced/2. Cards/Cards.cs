using System;

class Cards
{
    static string[] card = { "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac", "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad", "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah", "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As" };
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] arr = new long[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }

        long printOrNot = 0;
        long fullDeck = 0;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            printOrNot = printOrNot ^ arr[i];
            fullDeck = fullDeck | arr[i];
        }

        string binary = Convert.ToString(printOrNot, 2).PadLeft(52, '0');
        Console.WriteLine(fullDeck == 4503599627370495 ? "Full deck" : "Wa wa!");
        for (int i = binary.Length - 1, j = 0; i >= 0; i--, j++)
        {

            if (binary[i] == '0')
            {
                Console.Write(card[j] + " ");
            }
        }
    }
}