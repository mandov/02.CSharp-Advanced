using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string url = Console.ReadLine();
        string[] arr = Regex.Split(url, "://");
        int index = arr[1].IndexOf('/');
        string resource = arr[1].Substring(index);
        string protocol = arr[1].Substring(0, index);

        Console.WriteLine("[protocol] = {0}", arr[0]);
        Console.WriteLine("[server] = {0}", protocol);
        Console.WriteLine("[resource] = {0}", resource);
    }
}