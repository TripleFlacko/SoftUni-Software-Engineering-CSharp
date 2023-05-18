using System;

namespace _09._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numEnd = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool done = true;

            for (int i = numStart; i <= numEnd; i++)
            {
                for (int i2 = numStart; i2 <= numEnd; i2++)
                {
                    counter++;
                    if (i + i2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {i2} = {magicNum})");
                        done = false;
                        return;
                    }
                }
            }
            if (done)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}