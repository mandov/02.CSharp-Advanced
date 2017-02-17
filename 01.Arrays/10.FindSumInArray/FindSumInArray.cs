using System;
using System.Linq;
class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter senquence of numbers:");
        int[] sequence = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        Console.Write("Enter Sum:");
        int sum = int.Parse(Console.ReadLine());

        int currentSequence = 0;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            for (int j = i; j < sequence.Length - 1; j++)
            {
                currentSequence += sequence[j];
                if (currentSequence == sum)
                {
                    Console.Write("Numbers with sum {0}:",sum);
                    for (int print = i; print <= j; print++)
                    {
                        if (print < j)
                        {
                            Console.Write("{0},", sequence[print]);
                        }
                        else
                        {
                            Console.WriteLine(sequence[print]);
                        }
                    }
                }
                else
                {
                    continue;
                }
                currentSequence = 0;
            }
        }
    }
}
