using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"{Division(FirstNumFactorial(num1), SecondNumFactorial(num2)):f2}");
    }
    static double FirstNumFactorial(double num1)
    {
        double factorial1 = 1;

        for (double i = 1; i <= num1; i++)
        {
            factorial1 *= i;
        }
        return factorial1;
    }
    static double SecondNumFactorial(double num2)
    {
        double factorial2 = 1;

        for (double i = 1; i <= num2; i++)
        {
            factorial2 *= i;
        }
        return factorial2;
    }
    static double Division(double factorial1, double factorial2)
    {
        return factorial1 / factorial2;
    }
}