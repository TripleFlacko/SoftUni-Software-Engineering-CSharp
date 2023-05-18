using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());

            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;

            for (int i = 0; i < fans; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A': a++; break;
                    case 'B': b++; break;
                    case 'V': v++; break;
                    case 'G': g++; break;
                }
            }

            Console.WriteLine($"{a / fans:p2}");
            Console.WriteLine($"{b / fans:p2}");
            Console.WriteLine($"{v / fans:p2}");
            Console.WriteLine($"{g / fans:p2}");
            Console.WriteLine($"{fans / capacity:p2}");
        }
    }
}