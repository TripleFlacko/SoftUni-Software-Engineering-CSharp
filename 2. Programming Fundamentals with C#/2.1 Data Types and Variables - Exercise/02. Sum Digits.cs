using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < input.ToString().Length; i++)
        {
            int digit = (int)Char.GetNumericValue(input.ToString()[i]);
            sum += digit;
        }
        Console.WriteLine(sum);
    }
}