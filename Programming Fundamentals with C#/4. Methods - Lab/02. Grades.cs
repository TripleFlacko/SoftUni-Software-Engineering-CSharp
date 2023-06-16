using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        Console.WriteLine($"{GradeChecker(input)}");
    }

    static string GradeChecker(double input)
    {
        if (2.00 <= input && input <= 2.99) return "Fail";
        else if (3.00 <= input && input <= 3.49) return "Poor";
        else if (3.50 <= input && input <= 4.49) return "Good";
        else if (4.49 <= input && input <= 5.49) return "Very good";
        else if (5.50 <= input && input <= 6.00) return "Excellent";
        else return "";
    }
}