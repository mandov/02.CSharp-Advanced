
        using System;

class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];
            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;
            int currentSum = 0;
           
            for (int i = 0; i < sequence.Length; i++)
            {
                currentSum += sequence[i];
                if (currentSum < sequence[i])
                {
                    currentSum = sequence[i];
                   
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    
                }
            }

            Console.WriteLine(maxSum);
        }
    }

    