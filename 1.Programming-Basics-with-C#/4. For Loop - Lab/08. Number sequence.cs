using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int numberMin = int.MaxValue;
            int numberMax = int.MinValue;

            for (int i = 1; i <= numberCount; i++)
            {
                int num1 = int.Parse(Console.ReadLine());

                if (num1 <= numberMin)
                {
                    numberMin = num1;
                }
                if (num1 >= numberMax)
                {
                    numberMax = num1;
                }
            }
            Console.WriteLine($"Max number: {numberMax}");
            Console.WriteLine($"Min number: {numberMin}");
        }
    }
}