using System;

namespace _11.HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            int counter1 = 0;
            int counter125 = 0;
            int counter250 = 0;

            double sumTotal = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int i2 = 1; i2 <= hours; i2++)
                {
                    if (i % 2 == 0 && i2 % 2 != 0)
                    {
                        counter250++;
                    }
                    else if (i % 2 != 0 && i2 % 2 == 0)
                    {
                        counter125++;
                    }
                    else
                    {
                        counter1++;
                    }
                }

                double sum = counter1 * 1.00 + counter125 * 1.25 + counter250 * 2.50;
                sumTotal += sum;
                counter1 = 0;
                counter125 = 0;
                counter250 = 0;

                Console.WriteLine($"Day: {i} - {sum:f2} leva");
            }
            Console.WriteLine($"Total: {sumTotal:f2} leva");
        }
    }
}