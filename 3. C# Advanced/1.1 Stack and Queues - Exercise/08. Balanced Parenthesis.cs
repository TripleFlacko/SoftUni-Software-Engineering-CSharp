using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var brackets = Console.ReadLine();
        var stack = new Stack<char>();

        foreach (var bracket in brackets)
        {
            if (IsOpeningBracket(bracket))
            {
                stack.Push(bracket);
            }
            else
            {
                if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), bracket))
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
        }
        Console.WriteLine(stack.Count == 0 ? "YES" : "NO");
    }

    static bool IsMatchingPair(char openingBracket, char closingBracket)
    {
        return (openingBracket == '(' && closingBracket == ')') || (openingBracket == '[' && closingBracket == ']') || (openingBracket == '{' && closingBracket == '}');
    }

    static bool IsOpeningBracket(char bracket)
    {
        return bracket == '(' || bracket == '[' || bracket == '{';
    }
}