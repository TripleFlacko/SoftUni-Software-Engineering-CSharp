using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double sum = 0;
            int age = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    sum += 12000;
                }
                else
                {
                    sum += 12000 + 50 * age;
                }
                age++;
            }
            if (money >= sum)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money - sum:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {sum - money:f2} dollars to survive.");
            }
        }
    }
}