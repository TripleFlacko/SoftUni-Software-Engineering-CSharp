using System;

namespace _04.Reverse_String
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = new string(input.Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}