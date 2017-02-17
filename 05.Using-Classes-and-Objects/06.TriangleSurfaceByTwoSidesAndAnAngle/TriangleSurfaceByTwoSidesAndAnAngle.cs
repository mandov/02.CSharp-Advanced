using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double result = (a * b * Math.Sin(c * Math.PI / 180)) / 2;

        Console.WriteLine("{0}:F2", result);
    }
}