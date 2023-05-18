using System;

namespace _04.Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int i2 = 0; i2 <= i; i2++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
