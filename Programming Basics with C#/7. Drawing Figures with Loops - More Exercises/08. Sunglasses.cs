using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");

                for (int i2 = 0; i2 < 2 * n - 2; i2++)
                {
                    Console.Write("/");
                }

                Console.Write("*");

                for (int i3 = 0; i3 < n; i3++)
                {
                    if (i == (n - 1) / 2 - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("*");

                for (int i4 = 0; i4 < 2 * n - 2; i4++)
                {
                    Console.Write("/");
                }

                Console.Write("*");

                Console.WriteLine();
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
        }
    }
}