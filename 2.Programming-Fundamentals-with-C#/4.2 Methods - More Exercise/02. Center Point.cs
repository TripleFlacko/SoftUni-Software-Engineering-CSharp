using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        var coordinates = new List<double> { 0, 0 };
        Console.WriteLine($"({string.Join(", ", GetResult(coordinates))})");
    }

    private static List<double> GetResult(List<double> coordinates)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double result1 = Math.Abs(x1) + Math.Abs(y1);

        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double result2 = Math.Abs(x2) + Math.Abs(y2);

        if (result1 < result2)
        {
            coordinates[0] = x1;
            coordinates[1] = y1;
        }
        else
        {
            coordinates[0] = x2;
            coordinates[1] = y2;
        }

        return coordinates;
    }
}