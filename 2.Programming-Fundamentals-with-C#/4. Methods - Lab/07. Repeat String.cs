using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string stringInput = Console.ReadLine();
        int repeatXTimes = int.Parse(Console.ReadLine());
        Console.WriteLine(RepeatString(stringInput, repeatXTimes));
    }
    static string RepeatString(string stringInput, int repeatXTimes)
    {
        string repeatedString = "";
        for (int i = 0; i < repeatXTimes; i++)
        {
            repeatedString += stringInput;
        }
        return repeatedString;
    }
}