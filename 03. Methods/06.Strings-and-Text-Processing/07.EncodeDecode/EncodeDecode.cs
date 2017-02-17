using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        string text = Console.ReadLine();
        string key = Console.ReadLine();
        string encode = Encrypting(text, key);
        string decode = Encrypting(encode,key);

        Console.WriteLine(encode);
        Console.WriteLine(decode);
    }

    static string Encrypting(string text, string key)
    {
       var result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            result.Append((char)(text[i] ^ key[(i % key.Length)]));
        }

        return result.ToString();
    }
}
