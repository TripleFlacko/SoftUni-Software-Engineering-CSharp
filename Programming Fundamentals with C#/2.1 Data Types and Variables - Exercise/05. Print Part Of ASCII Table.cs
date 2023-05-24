using System;

class Program
{
    static void Main()
    {
        int startChar = int.Parse(Console.ReadLine());
        int endChar = int.Parse(Console.ReadLine());

        for (int i = startChar; i <= endChar; i++)
        {
            char character = (char)i;
            Console.Write(character + " ");
        }
    }
}