using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double result = 0.00;
            string evenOdd = "";

            if (action == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (action == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (action == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (action == "/" || action == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (action == "/")
                {
                    result = Convert.ToDouble(num1) / num2;
                    Console.WriteLine($"{num1} {action} {num2} = {result:f2}");
                }
                else if (action == "%")
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} {action} {num2} = {result}");
                }
            }
            if (action == "+" || action == "-" || action == "*")
            {
                Console.WriteLine($"{num1} {action} {num2} = {result} - {evenOdd}");
            }
        }
    }
}