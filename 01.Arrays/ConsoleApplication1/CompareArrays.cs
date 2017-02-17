using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        int ouput = Math.Min(firstWord.Length, secondWord.Length);

        for (int i = 0; i < ouput; i++)
        {
            if (firstWord[i] > secondWord[i] || i == ouput - 1 && firstWord.Length > secondWord.Length)
            {
                Console.WriteLine(">");
                return;
            }
            else if (firstWord[i] < secondWord[i] || i == ouput - 1 && firstWord.Length < secondWord.Length)
            {
                Console.WriteLine("<");
                return;
            }
            else if (i == ouput - 1 && firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("=");
                break;
            }
        }
    }
}