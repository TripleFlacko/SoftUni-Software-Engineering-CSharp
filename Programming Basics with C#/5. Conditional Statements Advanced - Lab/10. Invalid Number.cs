using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number < 100 || 200 < number) && 0 != number)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}