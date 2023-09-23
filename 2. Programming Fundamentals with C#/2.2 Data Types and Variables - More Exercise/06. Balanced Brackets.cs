using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        bool isBalanced = true;
        bool openBracket = false;

        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();
            if (input == "(")
            {
                if (openBracket) isBalanced = false;
                else openBracket = true;
            }
            else if (input == ")")
            {
                if (openBracket) openBracket = false;
                else isBalanced = false;
            }
        }
        if (openBracket) isBalanced = false;
        Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");

    }
}