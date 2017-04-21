using System;
using System.Linq;

class DancingMoves
{
    static void Main()
    {
        int[] scores = Console.ReadLine().Split().Select(b => int.Parse(b)).ToArray();
        double sum = 0;
        int counter = -1;
        int skip = 0;
        string comand = string.Empty;
        do
        {
            counter++;
            comand = Console.ReadLine();
            if (comand == "stop")
            {
                break;
            }

            var commands = comand.Split(' ');
            int steps = int.Parse(commands[2]);
            string direction = commands[1];
            int times = int.Parse(commands[0]);
            if (direction == "right")
            {
                for (int j = 0; j < times; j++)
                {
                    skip = (skip + steps) % scores.Length;
                    sum += scores[skip];
                }
            }
            else
            {
                for (int x = 0; x < times; x++)
                {
                    skip = (skip + (-steps)) % scores.Length;
                    if (skip < 0)
                    {
                        skip = skip + scores.Length;
                    }

                    sum += scores[skip];
                }
            }
        }
        while (comand != "stop");

        Console.WriteLine("{0:F1}", (double)sum / counter);
    }
}