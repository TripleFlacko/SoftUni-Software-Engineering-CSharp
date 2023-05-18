using System;

namespace _10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLeva = int.Parse(Console.ReadLine());
            int twoLeva = int.Parse(Console.ReadLine());
            int fiveLeva = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLeva; i++)
            {
                for (int i2 = 0; i2 <= twoLeva; i2++)
                {
                    for (int i3 = 0; i3 <= fiveLeva; i3++)
                    {
                        if (i * 1 + i2 * 2 + i3 * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {i2} * 2 lv. + {i3} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}