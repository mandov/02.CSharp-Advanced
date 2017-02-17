using System;
using System.Linq;


class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Which task you want to solve ?");
        Console.WriteLine("1.Reverse Number");
        Console.WriteLine("2.Averge of sequence");
        Console.WriteLine("3.Linear equation");
        Console.Write("Your choice ?:");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter number for reverse:");
                string number = (Console.ReadLine());
                while (number[0] == '-')
                {
                    Console.Write("Enter positive value:");
                    number = Console.ReadLine();
                }
                string result = ReverseNumber(number);
                Console.WriteLine("The reversed number is: {0}", result);
                break;

            case "2":
                Console.Write("Enter the size of sequence:");
                int size = int.Parse(Console.ReadLine());
                Console.Write("Enter the sequence of numbers:");
                int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                while (size == 0)
                {
                    Console.WriteLine("ERROR sequence is empty");
                    size = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(Average(sequence));
                break;

            case "3":
                Console.Write("Enter value of a:");
                int a = int.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("ERROR Enter another value different from '0'");
                    a = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter value of b:");
                int b = int.Parse(Console.ReadLine()); Console.WriteLine("The result is:{0}", LinearEquation(a, b));
                break;

            default:
                Console.WriteLine("Wrong choice ERROR!!!"); break;
        }
    }

    static string ReverseNumber(string number)
    {
        string reverse = string.Empty;

        for (var i = number.Length - 1; i >= 0; i--)
        {
            reverse += number[i];
        }

        return reverse;
    }

    static decimal Average(int[] array)
    {
        decimal sum = 0;

        for (int i = 0; i <= array.Length - 1; i++)
        {
            sum += array[i];
        }

        decimal average = sum / array.Length;
        return average;
    }

    static decimal LinearEquation(int number, int numberTwo)
    {
        int result = 0;


        numberTwo = numberTwo * -1;
        result = numberTwo / number;

        return result;
    }
}