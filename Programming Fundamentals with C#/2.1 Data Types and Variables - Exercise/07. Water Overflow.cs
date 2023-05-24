using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int waterTank = 255;
        int sum = 0;
        for (int i = 0; i < num; i++)
        {
            int liters = int.Parse(Console.ReadLine());
            if (liters <= waterTank - sum) sum += liters;
            else Console.WriteLine("Insufficient capacity!");
        }
        Console.WriteLine(sum);
    }
}