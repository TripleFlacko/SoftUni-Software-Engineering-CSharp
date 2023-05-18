using System;


namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double sum = 0;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                count++;
            }
            Console.WriteLine($"{sum / (double)count:f2}");
        }
    }
}