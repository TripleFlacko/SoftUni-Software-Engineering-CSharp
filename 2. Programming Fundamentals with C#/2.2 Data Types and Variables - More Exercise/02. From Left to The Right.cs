using System;
using System.Numerics;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine();
            string[] theSplit = input.Split(' ', 2);

            long num1 = long.Parse(theSplit[0]);
            long num2 = long.Parse(theSplit[1]);
            long sum = 0;

            if (num1 > num2)
            {
                for (int i2 = 0; i2 < num1.ToString().Length; i2++)
                {
                    num1 = Math.Abs(num1);
                    sum += num1.ToString()[i2] - '0';
                }
            }
            else
            {
                for (int i2 = 0; i2 < num2.ToString().Length; i2++)
                {
                    num2 = Math.Abs(num2);
                    sum += num2.ToString()[i2] - '0';
                }
            }
            Console.WriteLine($"{sum}");
            sum = 0;
        }
    }
}