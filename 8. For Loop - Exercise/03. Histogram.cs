using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < input; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine($"{p1 / input:p2}");
            Console.WriteLine($"{p2 / input:p2}");
            Console.WriteLine($"{p3 / input:p2}");
            Console.WriteLine($"{p4 / input:p2}");
            Console.WriteLine($"{p5 / input:p2}");
        }
    }
}