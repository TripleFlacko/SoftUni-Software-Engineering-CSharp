using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numArray = Console.ReadLine().Split().Select(double.Parse).ToArray();

        for (int i = 0; i < numArray.Length; i++)
        {
            int rounded = (int)Math.Round(numArray[i], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{numArray[i]} => {rounded}");
        }
    }
}