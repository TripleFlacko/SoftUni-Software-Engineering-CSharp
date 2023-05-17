using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = num1; i <= num2; i++)
            {
                sumOdd = 0; sumEven = 0;
                string converted = i.ToString();

                for (int i2 = 0; i2 < converted.Length; i2++)
                {
                    int checkNum = int.Parse(converted[i2].ToString());

                    if (i2 % 2 == 0)
                    {
                        sumOdd += checkNum;
                    }
                    else
                    {
                        sumEven += checkNum;
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.Write(converted + " ");
                }
            }
        }
    }
}