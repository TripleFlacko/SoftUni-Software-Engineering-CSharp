using System;

class Program
{
    static void Main()
    {
        double input1 = double.Parse(Console.ReadLine());
        double input2 = double.Parse(Console.ReadLine());

        bool isEqual = true;

        double difference = Math.Abs(input1 - input2);
        if (difference > 0.000001)
        {
            isEqual = false;
        }
        Console.WriteLine(isEqual);
    }
}