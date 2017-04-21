using System;
using System.Numerics;

class FunctionalNumeralSystem
{ 
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        var product = new BigInteger(1);

        foreach (var item in numbers)
        {
            var hexadecimal = item
                                .Replace("commonlisp", "D")
                                .Replace("standardml", "9")
                                .Replace("haskell", "1")
                                .Replace("mercury", "C")
                                .Replace("clojure", "7")
                                .Replace("erlang", "8")
                                .Replace("scheme", "E")
                                .Replace("racket", "A")
                                .Replace("curry", "F")
                                .Replace("ocaml", "0")
                                .Replace("scala", "2")
                                .Replace("lisp", "4")
                                .Replace("rust", "5")
                                .Replace("elm", "B")
                                .Replace("ml", "6")
                                .Replace("f#", "3");
            product *= new BigInteger(Convert.ToInt64(hexadecimal, 16));
        }

        Console.WriteLine(product);
    }
}