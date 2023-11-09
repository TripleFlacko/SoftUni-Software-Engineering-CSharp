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
        var coordinates1 = new List<double> { };
        var coordinates2 = new List<double> { };

        List<double> coordinatesResult = GetResult(coordinates1, coordinates2);
        coordinatesResult = PlaceClosestFirst(coordinatesResult);

        Console.WriteLine($"({coordinatesResult[0]}, {coordinatesResult[1]})({coordinatesResult[2]}, {coordinatesResult[3]})");
    }

    private static List<double> PlaceClosestFirst(List<double> coordinatesResult)
    {
        var x1 = coordinatesResult[0];
        var y1 = coordinatesResult[1];
        var x2 = coordinatesResult[2];
        var y2 = coordinatesResult[3];

        if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
        {
            coordinatesResult.RemoveRange(0, 2);
            coordinatesResult.Add(x1);
            coordinatesResult.Add(y1);
        }

        return coordinatesResult;
    }

    private static List<double> GetResult(List<double> coordinates1, List<double> coordinates2)
    {
        for (int i2 = 0; i2 < 4; i2++)
        {
            double input = double.Parse(Console.ReadLine());
            coordinates1.Add(input);
        }

        for (int i = 0; i < 4; i++)
        {
            double input = double.Parse(Console.ReadLine());
            coordinates2.Add(input);
        }

        var length = coordinates1.Select(x => Math.Abs(x)).ToList().Sum();
        var length2 = coordinates2.Select(x => Math.Abs(x)).ToList().Sum();

        return length > length2 ? coordinates1 : coordinates2;
    }
}