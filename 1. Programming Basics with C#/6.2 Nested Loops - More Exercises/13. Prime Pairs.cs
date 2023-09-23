using System;

namespace _13.Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int couple1 = int.Parse(Console.ReadLine());
            int couple2 = int.Parse(Console.ReadLine());
            int limit1 = int.Parse(Console.ReadLine());
            int limit2 = int.Parse(Console.ReadLine());

            int num1 = 0;
            int num2 = 0;


            for (int i = couple1; i <= couple1 + limit1; i++)
            {
                bool isPrime = true;

                for (int check1 = 2; check1 <= Math.Sqrt(i); check1++)
                {
                    if (i % check1 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && i != 1)
                {
                    for (int i2 = couple2; i2 <= couple2 + limit2; i2++)
                    {
                        bool isPrime2 = true;

                        for (int check2 = 2; check2 <= Math.Sqrt(i2); check2++)
                        {
                            if (i2 % check2 == 0)
                            {
                                isPrime2 = false;
                                break;
                            }
                        }
                        if (isPrime2 && i2 != 1)
                        {
                            Console.WriteLine($"{i}{i2}");
                        }
                    }
                }
            }
        }
    }
}
