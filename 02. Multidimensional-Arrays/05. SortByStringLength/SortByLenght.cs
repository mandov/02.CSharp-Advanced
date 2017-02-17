using System;

class SortByLenght
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        string[] words = new string[size];

        for (int i = 0; i < size; i++)
        {
            words[i] = Console.ReadLine();
        }

        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}