using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letterExcluded = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = letter1; i <= letter2; i++)
            {
                if (i != letterExcluded)
                {
                    for (char i2 = letter1; i2 <= letter2; i2++)
                    {
                        if (i2 != letterExcluded)
                        {
                            for (char i3 = letter1; i3 <= letter2; i3++)
                            {
                                if (i3 != letterExcluded)
                                {
                                    Console.Write($"{i}{i2}{i3} ");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            Console.Write($"{counter}");

        }
    }
}