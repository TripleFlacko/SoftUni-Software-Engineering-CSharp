using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double sideWallWindow = 1.5 * 1.5;
            double totalSides = sideWall * 2 - sideWallWindow * 2;
            double backWall = x * x;
            double entrance = 1.2 * 2;
            double frontBack = backWall * 2 - entrance;
            double total = totalSides + frontBack;
            double greenPaint = total / 3.4;

            double ceiling = 2 * (x * y);
            double triangle = 2 * (x * h / 2);
            double total2 = ceiling + triangle;
            double redPaint = total2 / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}