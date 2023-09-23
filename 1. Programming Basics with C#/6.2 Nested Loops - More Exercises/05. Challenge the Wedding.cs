using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int maxTables = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int i2 = 1; i2 <= women; i2++)
                {
                    Console.Write($"({i} <-> {i2}) ");
                    counter++;

                    if (counter == maxTables)
                    {
                        i *= 999999;
                        break;
                    }
                }
            }
        }
    }
}