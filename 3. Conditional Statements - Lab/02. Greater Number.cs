using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine(num1);
            }

            else if (num2 >= num1)
            {
                Console.WriteLine(num2);
            }
        }
    }
}