using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;

            for (int i = 0; i < groups; i++)
            {
                int numberOfPersons = int.Parse(Console.ReadLine());

                if (numberOfPersons <= 5)
                {
                    group1 += numberOfPersons;
                }
                else if (numberOfPersons <= 12)
                {
                    group2 += numberOfPersons;
                }
                else if (numberOfPersons <= 25)
                {
                    group3 += numberOfPersons;
                }
                else if (numberOfPersons <= 40)
                {
                    group4 += numberOfPersons;
                }
                else
                {
                    group5 += numberOfPersons;
                }
            }

            double total = group1 + group2 + group3 + group4 + group5;

            Console.WriteLine($"{group1 / total:p2}");
            Console.WriteLine($"{group2 / total:p2}");
            Console.WriteLine($"{group3 / total:p2}");
            Console.WriteLine($"{group4 / total:p2}");
            Console.WriteLine($"{group5 / total:p2}");
        }
    }
}