using System;

namespace _01.Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[3];
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());

            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }

        }
    }
}