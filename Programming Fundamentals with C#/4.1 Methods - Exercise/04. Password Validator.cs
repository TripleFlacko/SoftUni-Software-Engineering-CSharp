using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string pass = Console.ReadLine();
        CheckIfMeetsRequirements(pass);
    }
    static void CheckIfMeetsRequirements(string pass)
    {
        int checkLength = CheckLength(pass);
        int checkIfContainsSymbols = CheckIfContainsSymbols(pass);
        int checkIfContains2Digits = CheckIfContains2Digits(pass);

        if (checkLength == 0 || checkIfContainsSymbols > 0 || checkIfContains2Digits < 2)
        {
            if (checkLength == 0)
                Console.WriteLine("Password must be between 6 and 10 characters");

            if (checkIfContainsSymbols > 0)
                Console.WriteLine("Password must consist only of letters and digits");

            if (checkIfContains2Digits < 2)
                Console.WriteLine("Password must have at least 2 digits");
        }
        else
            Console.WriteLine("Password is valid");
    }
    static int CheckLength(string pass)
    {
        return 6 <= pass.Length && pass.Length <= 10 ? 1 : 0;
    }
    static int CheckIfContainsSymbols(string pass)
    {
        int containsOrNot = 0;
        for (int i = 0; i < pass.Length; i++)
        {
            if (pass[i] > 47 && pass[i] < 58 || pass[i] > 64 && pass[i] < 91 || pass[i] > 96 && pass[i] < 123) continue;
            else containsOrNot++;
        }
        return containsOrNot;
    }
    static int CheckIfContains2Digits(string pass)
    {
        int digitsCounter = 0;

        for (int i = 0; i < pass.Length; i++)
        {
            digitsCounter += char.IsDigit(pass[i]) ? 1 : 0;
        }
        return digitsCounter;
    }
}