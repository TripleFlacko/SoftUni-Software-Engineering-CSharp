using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            char[] reversed = ReverseTheString(input);
            isPalindromeOrNot(input, reversed);
        }
    }

    private static void isPalindromeOrNot(string input, char[] reversed)
    {
        if (input == string.Join("", reversed))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    private static char[] ReverseTheString(string input)
    {
        char[] reversed = input.ToCharArray();
        Array.Reverse(reversed);
        return reversed;
    }
}