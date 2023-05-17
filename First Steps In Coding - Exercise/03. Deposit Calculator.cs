using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double term = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;
            double sum = deposit + term * ((deposit * percentage) / 12);
            Console.WriteLine(sum);
        }
    }
}