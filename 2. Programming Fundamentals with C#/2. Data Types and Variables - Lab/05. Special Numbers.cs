using System;

namespace _05.Special_Numbers

{
    class Program
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                var toString = i.ToString();

                if (toString.Length >= 2)
                {
                    if ((int)Char.GetNumericValue(toString[0]) + (int)Char.GetNumericValue(toString[1]) == 5 || (int)Char.GetNumericValue(toString[0]) + (int)Char.GetNumericValue(toString[1]) == 7 || (int)Char.GetNumericValue(toString[0]) + (int)Char.GetNumericValue(toString[1]) == 11)
                    {
                        Console.WriteLine($"{i} -> True"); continue;
                    }
                }
                if (i == 5 || i == 7)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}