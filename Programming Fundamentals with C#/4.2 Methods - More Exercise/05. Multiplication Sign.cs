using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 == 0 || num2 == 0 || num3 == 0) Console.WriteLine("zero");
        else if (num1 < 0 || num2 < 0 || num3 < 0) Console.WriteLine("negative");
        else Console.WriteLine("positive");
    }
}