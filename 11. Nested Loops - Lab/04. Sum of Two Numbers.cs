using System;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int check = 0;

            for (int i = start; i <= end; i++)
            {
                if (check == 1)
                {
                    break;
                }

                for (int i2 = start; i2 <= end; i2++)
                {
                    counter++;

                    if (i + i2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {i2} = {i + i2})"); check++; break;
                    }
                }
            }
            if (check != 1)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}