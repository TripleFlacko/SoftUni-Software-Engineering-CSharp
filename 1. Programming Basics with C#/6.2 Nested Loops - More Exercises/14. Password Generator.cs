using System;

namespace _14.Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (char i3 = 'a'; i3 < 97 + l; i3++)
                    {
                        for (char i4 = 'a'; i4 < 97 + l; i4++)
                        {
                            for (int i5 = 1; i5 <= n; i5++)
                            {
                                if (i5 > i && i5 > i2)
                                {
                                    Console.Write($"{i}{i2}{i3}{i4}{i5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
