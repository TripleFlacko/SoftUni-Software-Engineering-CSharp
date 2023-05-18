using System;

namespace SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int compSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                int num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    compSum += num;
                }

            }
            Console.WriteLine("Sum of all prime numbers is: " + primeSum);
            Console.WriteLine("Sum of all non prime numbers is: " + compSum);
        }
    }
}