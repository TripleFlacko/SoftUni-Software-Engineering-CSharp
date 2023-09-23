using System;

    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = num1 + int.Parse(Console.ReadLine());
            int num3 = num2 / int.Parse(Console.ReadLine());
            int num4 = num3 * int.Parse(Console.ReadLine());
            Console.WriteLine(num4);
        }
    }