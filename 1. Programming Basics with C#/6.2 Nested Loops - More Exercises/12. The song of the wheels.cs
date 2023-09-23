using System;

namespace _12.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int num = int.Parse(Console.ReadLine());
            string numHolder = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d && a * b + c * d == num)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    numHolder = $"{a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }
            if (counter >= 4)
            {
                Console.WriteLine($"\nPassword: {numHolder}");
            }
            else
            {
                Console.WriteLine("\nNo!");
            }
        }
    }
}