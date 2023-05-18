using System;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int i2 = 1; i2 <= num - i; i2++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i3 = 1; i3 <= i - 1; i3++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = num - 1; i >= 1; i--)
            {
                for (int i2 = 1; i2 <= num - i; i2++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i3 = 1; i3 <= i - 1; i3++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}