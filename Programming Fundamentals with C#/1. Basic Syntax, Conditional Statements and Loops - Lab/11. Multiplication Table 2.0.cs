using System;

namespace _11.Multiplication_Table_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            for (int i = input2; ; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
                if (i >= 10) { break; }
            }
        }
    }
}
