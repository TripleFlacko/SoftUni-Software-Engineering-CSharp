using System;

namespace Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = floors; i <= floors && i >= 1; i--)
            {
                for (int i2 = 0; i2 < rooms; i2++)
                {
                    if (counter == 0)
                    {
                        Console.Write($"L{i}{i2} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{i2} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{i2} ");
                    }
                }
                counter++;
                Console.WriteLine();
            }
        }
    }
}