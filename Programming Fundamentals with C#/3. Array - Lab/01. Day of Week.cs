using System;

class Program
{
    static void Main()
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        var input = int.Parse(Console.ReadLine());
        if (input <= 7 && input >= 1)
        {
            Console.WriteLine(days[input - 1]);
        }
        else
        {
            Console.WriteLine("Invalid day!");
        }
    }
}