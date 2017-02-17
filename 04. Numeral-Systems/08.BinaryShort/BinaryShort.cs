using System;

class BinaryShort
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(ShortBinaryRepres(number));

    }

    static string ShortBinaryRepres(short number)
    {
        char[] binary = new char[16];
        int position = 15;
        int i = 0;

        while (position > 0)
        {
            if ((number & (1 << i)) != 0)
            {
                binary[position] = '1';
            }
            else
            {
                binary[position] = '0';
            }

            position--;
            i++;
        }


        return new string(binary);
    }
}
