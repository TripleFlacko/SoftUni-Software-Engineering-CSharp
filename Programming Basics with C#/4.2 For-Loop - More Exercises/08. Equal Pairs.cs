using System;
using System.Numerics;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCouples = int.Parse(Console.ReadLine());

            int couple = 0;
            int maxNum = int.MinValue;
            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < numberCouples; i++)
            {

                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                if (couple != 0 || maxNum != int.MinValue)
                {
                    if (couple != num1 + num2)
                    {
                        if (maxNum < Math.Abs(couple - (num1 + num2)))
                        {
                            maxNum = Math.Abs(couple - (num1 + num2));
                        }
                    }
                }

                couple = num1 + num2;
            }
            if (maxNum != int.MinValue)
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(maxNum)}");
            }
            else
            {
                Console.WriteLine($"Yes, value={couple}");
            }
        }
    }
}