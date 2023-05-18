using System;

namespace _05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("| ");
                for (int i2 = 0; i2 < num - 2; i2++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }
            Console.Write("+ ");
            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+ ");
        }
    }
}