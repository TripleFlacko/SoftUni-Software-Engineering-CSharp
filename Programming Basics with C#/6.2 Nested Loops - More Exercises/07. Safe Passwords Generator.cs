using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());
            int counter = 0;
            char A = '#';
            char B = '@';

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    Console.Write($"{A}{B}{x}{y}{B}{A}|");
                    A++; B++;

                    if (A > 55) A = '#';
                    if (B > 96) B = '@';

                    counter++;

                    if (counter == quantity)
                    {
                        return;
                    }

                }
            }
        }
    }
}