using System;

namespace _04._Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num; i <= num2; i++)
            {
                for (int i2 = num; i2 <= num2; i2++)
                {
                    for (int i3 = num; i3 <= num2; i3++)
                    {
                        for (int i4 = num; i4 <= num2; i4++)
                        {
                            if (((i % 2 == 0 && i4 % 2 != 0) || (i % 2 != 0 && i4 % 2 == 0)) && i > i4 && (i2 + i3) % 2 == 0)
                            {
                                Console.Write($"{i}{i2}{i3}{i4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}