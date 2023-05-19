using System;

namespace _05.Special_Numbers

{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int total = 0;
                bool isSpecial = false;
                int checkNumber = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                isSpecial = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", checkNumber, isSpecial);
                total = 0;
                i = checkNumber;
            }

        }
    }
}