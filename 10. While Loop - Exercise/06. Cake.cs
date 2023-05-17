using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeSize = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeSize} pieces are left."); break;
                }

                cakeSize -= int.Parse(input);

                if (cakeSize <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more."); break;
                }
            }
        }
    }
}