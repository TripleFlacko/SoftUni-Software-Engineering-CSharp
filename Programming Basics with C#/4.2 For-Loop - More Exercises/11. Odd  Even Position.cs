using System;

internal class Program
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());
        double oddSum = 0, evenSum = 0;
        double oddMin = double.MaxValue, evenMin = double.MaxValue;
        double oddMax = double.MinValue, evenMax = double.MinValue;

        for (int i = 0; i < numbers; i++)
        {
            double num = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                if (oddMin > num)
                {
                    oddMin = num;
                }
                if (oddMax < num)
                {
                    oddMax = num;
                }
                oddSum += num;
            }
            else
            {
                if (evenMin > num)
                {
                    evenMin = num;
                }
                if (evenMax < num)
                {
                    evenMax = num;
                }
                evenSum += num;
            }
        }

        Console.WriteLine($"OddSum={oddSum:f2},");

        if (oddMin == double.MaxValue && oddMax == double.MinValue)
        {
            Console.WriteLine($"OddMin=No,");
            Console.WriteLine($"OddMax=No,");
        }
        else
        {
            Console.WriteLine($"OddMin={oddMin:f2},");
            Console.WriteLine($"OddMax={oddMax:f2},");
        }

        Console.WriteLine($"EvenSum={evenSum:f2},");

        if (evenMin == double.MaxValue && evenMax == double.MinValue)
        {
            Console.WriteLine($"EvenMin=No,");
            Console.WriteLine($"EvenMax=No");
        }
        else
        {
            Console.WriteLine($"EvenMin={evenMin:f2},");
            Console.WriteLine($"EvenMax={evenMax:f2}");
        }
    }
}
