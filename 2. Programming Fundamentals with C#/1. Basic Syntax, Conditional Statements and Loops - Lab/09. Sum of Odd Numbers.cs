using System;

namespace _09.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; n != 0; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    n--;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
