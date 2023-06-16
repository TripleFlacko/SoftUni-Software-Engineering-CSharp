using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double baseNum = double.Parse(Console.ReadLine());
        double powerNum = double.Parse(Console.ReadLine());
        Console.WriteLine(MathPower(baseNum, powerNum));
    }
    static double MathPower(double baseNum, double powerNum)
    {
        return Math.Pow(baseNum, powerNum);
    }
}