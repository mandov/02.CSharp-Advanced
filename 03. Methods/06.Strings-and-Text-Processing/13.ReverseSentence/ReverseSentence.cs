using System;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        string sentence = Console.ReadLine();
        char lastSign = sentence[sentence.Length - 1];
        string[] splliting = sentence.Split(new Char[] { ' ', '!' });
        StringBuilder result = new StringBuilder();

        for (int i = splliting.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                splliting[i] = splliting[i] + lastSign;
            }
            result.Append(splliting[i] + " ");
        }
        
        Console.WriteLine(result.ToString().Trim());
    }
}