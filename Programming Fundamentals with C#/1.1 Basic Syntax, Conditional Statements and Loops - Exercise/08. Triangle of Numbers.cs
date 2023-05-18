using System;

namespace _08.Triangle_Of_Numbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int i2 = 0; i2 < i; i2++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}