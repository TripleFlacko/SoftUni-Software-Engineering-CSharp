using System;

namespace _03.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int i2 = 0; i2 < num; i2++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
