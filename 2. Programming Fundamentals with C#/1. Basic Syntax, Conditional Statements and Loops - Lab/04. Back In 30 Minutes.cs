using System;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var input2 = int.Parse(Console.ReadLine()) + 30;

            if (input2 >= 60)
            {
                input++;
                input2 -= 60;
            }

            if (input >= 24)
            {
                input -= 24;
            }

            Console.WriteLine($"{input}:{input2:d2}");

        }
    }
}
