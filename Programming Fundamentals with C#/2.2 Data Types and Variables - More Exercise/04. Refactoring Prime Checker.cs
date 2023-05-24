using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 2; i <= input; i++)
        {
            bool isPrime = true;
            for (int i2 = 2; i2 < i; i2++)
            {
                if (i % i2 == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
        }
    }
}