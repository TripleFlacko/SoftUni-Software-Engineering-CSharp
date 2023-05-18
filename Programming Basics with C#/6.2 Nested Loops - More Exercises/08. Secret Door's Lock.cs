using System;

namespace _08._Secret_Doors_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    for (int i2 = 1; i2 <= num2; i2++)
                    {
                        if (i2 == 2 || i2 == 3 || i2 == 5 || i2 == 7)
                        {
                            for (int i3 = 1; i3 <= num3; i3++)
                            {
                                if (i3 % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {i2} {i3}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}