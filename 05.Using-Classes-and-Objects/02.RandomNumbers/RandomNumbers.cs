using System;

class RandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(randomGenerator.Next(100, 200));
        }
    }
}