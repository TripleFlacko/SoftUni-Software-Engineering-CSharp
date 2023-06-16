using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char char1 = char.Parse(Console.ReadLine());
        char char2 = char.Parse(Console.ReadLine());
        if (char1 < char2) Console.WriteLine(GetAllCharsInRange(char1, char2));
        else Console.WriteLine(GetAllCharsInRange(char2, char1));
    }
    static string GetAllCharsInRange(char char1, char char2)
    {
        string allChars = "";

        for (char i = (char)(char1 + 1); i < char2; i++)
        {
            allChars += i + " ";
        }
        return allChars;
    }
}