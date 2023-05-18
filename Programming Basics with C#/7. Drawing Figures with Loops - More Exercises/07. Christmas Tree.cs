using System;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i <= num; i++)
            {
                for (int i2 = 0; i2 < num - i; i2++)
                {
                    Console.Write(" ");
                }
                for (int i3 = 0; i3 < i; i3++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int i5 = 0; i5 < i; i5++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
