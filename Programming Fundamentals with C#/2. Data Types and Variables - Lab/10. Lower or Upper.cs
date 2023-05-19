using System;

namespace _10.Lower_or_Upper

{
    class Program
    {
        static void Main()
        {
            char input = char.Parse(Console.ReadLine());
            bool result = Char.IsUpper(input);
            if (result) Console.WriteLine("upper-case");
            else Console.WriteLine("lower-case");
        }
    }
}