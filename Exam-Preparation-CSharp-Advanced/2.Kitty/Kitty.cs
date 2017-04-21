using System;
using System.Collections.Generic;
using System.Linq;

class Kitty
{
    static void Main()
    {
        char[] path = Console.ReadLine().ToCharArray();
        List<int> kittysPath = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToList();
        kittysPath.Insert(0, 0);
        int coderSouls = 0;
        int food = 0;
        int deadlocks = 0;
        int previousPosition = 0;
        int jumps = -1;
        bool deadlocked = false;
        for (int i = 0; i < kittysPath.Count; i++)
        {
            if (kittysPath[i] > 0)
            {
                previousPosition = ((previousPosition + kittysPath[i]) % path.Length);
            }
            else
            {
                previousPosition = (previousPosition + kittysPath[i]) % path.Length;
                if (previousPosition < 0)
                {
                    previousPosition += path.Length;
                }
            }

            switch (path[previousPosition])
            {
                case '@': coderSouls++; break;
                case '*': food++; break;
                case 'x':
                    deadlocks++;
                    if (previousPosition % 2 == 0)
                    {
                        coderSouls -= 1;
                        if (coderSouls < 0)
                        {
                            jumps = i;
                            kittysPath.Clear();
                            deadlocked = true;
                        }
                    }
                    else
                    {
                        food -= 1;
                        if (food < 0)
                        {
                            jumps = i;
                            kittysPath.Clear();
                            deadlocked = true;
                        }
                    }

                    break;
            }

            if (path[previousPosition] == 'x')
            {
                path[previousPosition] = previousPosition % 2 == 0 ? '@' : '*';
            }
            else
            {
                path[previousPosition] = ' ';
            }
        }

        if (deadlocked)
        {
            Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", jumps);
        }
        else
        {
            Console.WriteLine("Coder souls collected: {0} \nFood collected: {1} \nDeadlocks: {2}", coderSouls, food, deadlocks);
        }
    }
}